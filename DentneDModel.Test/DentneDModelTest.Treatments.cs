﻿#region License
// Copyright (c) 2015 Davide Gironi
//
// Please refer to LICENSE file for licensing information.
#endregion

using DG.DentneD.Model.Entity;
using NUnit.Framework;
using System.Linq;

namespace DG.DentneD.Model.Test
{
    [TestFixture]
    public partial class DentneDModelTest
    {
        [Test]
        public void Treatments_Test1()
        {
            string[] errors = new string[] { };
            taxes t_taxes = null;
            treatments t_treatments = null;
            treatmentstypes t_treatmentstypes = null;

            _dentnedModel.Treatments.Remove(_dentnedModel.Treatments.List(r => r.treatments_code == "XX1").ToArray());
            _dentnedModel.Treatments.Remove(_dentnedModel.Treatments.List(r => r.treatments_code == "XX2").ToArray());
            _dentnedModel.TreatmentsTypes.Remove(_dentnedModel.TreatmentsTypes.List(r => r.treatmentstypes_name == "XX1").ToArray());
            _dentnedModel.Taxes.Remove(_dentnedModel.Taxes.List(r => r.taxes_name == "XX1").ToArray());

            t_taxes = new taxes()
            {
                taxes_name = "XX1",
                taxes_rate = 20
            };
            _dentnedModel.Taxes.Add(t_taxes);

            t_treatmentstypes = new treatmentstypes()
            {
                treatmentstypes_name = "XX1"
            };
            _dentnedModel.TreatmentsTypes.Add(t_treatmentstypes);

            t_treatments = new treatments()
            {
                treatmentstypes_id = t_treatmentstypes.treatmentstypes_id,
                taxes_id = t_taxes.taxes_id,
                //treatments_code = "XX1",
                treatments_name = "XX1",
                treatments_mexpiration = 1,
                treatments_price = 10
            };
            Assert.IsFalse(_dentnedModel.Treatments.CanAdd(t_treatments));

            t_treatments = new treatments()
            {
                //treatmentstypes_id = t_treatmentstypes.treatmentstypes_id,
                taxes_id = t_taxes.taxes_id,
                treatments_code = "XX1",
                treatments_name = "XX1",
                treatments_mexpiration = 1,
                treatments_price = 10
            };
            Assert.IsFalse(_dentnedModel.Treatments.CanAdd(t_treatments));

            t_treatments = new treatments()
            {
                treatmentstypes_id = t_treatmentstypes.treatmentstypes_id,
                taxes_id = t_taxes.taxes_id,
                treatments_code = "XX1",
                //treatments_name = "XX1",
                treatments_mexpiration = 1,
                treatments_price = 10
            };
            Assert.IsFalse(_dentnedModel.Treatments.CanAdd(t_treatments));

            t_treatments = new treatments()
            {
                treatmentstypes_id = t_treatmentstypes.treatmentstypes_id,
                taxes_id = t_taxes.taxes_id,
                treatments_code = "XX1",
                treatments_name = "XX1",
                //treatments_mexpiration = 1,
                treatments_price = 10
            };
            Assert.IsTrue(_dentnedModel.Treatments.CanAdd(t_treatments));

            t_treatments = new treatments()
            {
                treatmentstypes_id = t_treatmentstypes.treatmentstypes_id,
                taxes_id = t_taxes.taxes_id,
                treatments_code = "XX1",
                treatments_name = "XX1",
                treatments_mexpiration = 0,
                treatments_price = 10
            };
            Assert.IsFalse(_dentnedModel.Treatments.CanAdd(t_treatments));

            t_treatments = new treatments()
            {
                treatmentstypes_id = t_treatmentstypes.treatmentstypes_id,
                //taxes_id = t_taxes.taxes_id,
                treatments_code = "XX1",
                treatments_name = "XX1",
                treatments_price = 10
            };
            Assert.IsTrue(_dentnedModel.Treatments.CanAdd(t_treatments));

            t_treatments = new treatments()
            {
                treatmentstypes_id = t_treatmentstypes.treatmentstypes_id,
                taxes_id = -999,
                treatments_code = "XX1",
                treatments_name = "XX1",
                treatments_price = 10
            };
            Assert.IsFalse(_dentnedModel.Treatments.CanAdd(t_treatments));

            t_treatments = new treatments()
            {
                treatmentstypes_id = t_treatmentstypes.treatmentstypes_id,
                taxes_id = t_taxes.taxes_id,
                treatments_code = "XX1",
                treatments_name = "XX1",
                treatments_price = 10
            };
            Assert.IsTrue(_dentnedModel.Treatments.CanAdd(t_treatments));
            _dentnedModel.Treatments.Add(t_treatments);

            t_treatments = new treatments()
            {
                treatmentstypes_id = t_treatmentstypes.treatmentstypes_id,
                treatments_code = "XX1",
                treatments_name = "XX1",
                treatments_price = 10
            };
            Assert.IsFalse(_dentnedModel.Treatments.CanAdd(t_treatments));

            t_treatments = new treatments()
            {
                treatmentstypes_id = t_treatmentstypes.treatmentstypes_id,
                treatments_code = "XX2",
                treatments_name = "XX2",
                treatments_price = 20
            };
            Assert.IsTrue(_dentnedModel.Treatments.CanAdd(t_treatments));
            _dentnedModel.Treatments.Add(t_treatments);

            t_treatments = new treatments()
            {
                treatmentstypes_id = t_treatmentstypes.treatmentstypes_id,
                treatments_code = "XX-",
                treatments_name = "XX-",
                treatments_price = 20
            };
            Assert.IsTrue(_dentnedModel.Treatments.CanAdd(t_treatments));

            t_treatments = _dentnedModel.Treatments.FirstOrDefault(r => r.treatments_code == "XX1");
            t_treatments.treatments_code = "XX2";
            Assert.IsFalse(_dentnedModel.Treatments.CanUpdate(t_treatments));
            t_treatments.treatments_code = "XX3";
            Assert.IsTrue(_dentnedModel.Treatments.CanUpdate(t_treatments));

            _dentnedModel.Treatments.Remove(_dentnedModel.Treatments.List(r => r.treatments_code == "XX1").ToArray());
            _dentnedModel.Treatments.Remove(_dentnedModel.Treatments.List(r => r.treatments_code == "XX2").ToArray());
            _dentnedModel.TreatmentsTypes.Remove(_dentnedModel.TreatmentsTypes.List(r => r.treatmentstypes_name == "XX1").ToArray());
            _dentnedModel.Taxes.Remove(_dentnedModel.Taxes.List(r => r.taxes_name == "XX1").ToArray());
        }
    }
}
