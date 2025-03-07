/* 
 * API de Salas, Niveles, Dispositivos y Notificaciones
 *
 * Esta API permite gestionar las entidades:   - Salas: crear, borrar, modificar y consultar.   - Niveles: crear, borrar, modificar y consultar.   - Dispositivos: crear, borrar, modificar y consultar.   - Notificaciones: enviar notificaciones por email mediante los métodos:       • NotificarPresenciaSala       • NotificarUsuarioValido       • NotificarError 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing Nivel
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class NivelTests
    {
        // TODO uncomment below to declare an instance variable for Nivel
        //private Nivel instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Nivel
            //instance = new Nivel();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Nivel
        /// </summary>
        [Test]
        public void NivelInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Nivel
            //Assert.IsInstanceOfType<Nivel> (instance, "variable 'instance' is a Nivel");
        }


        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property '_Nivel'
        /// </summary>
        [Test]
        public void _NivelTest()
        {
            // TODO unit test for the property '_Nivel'
        }
        /// <summary>
        /// Test the property 'Descripcion'
        /// </summary>
        [Test]
        public void DescripcionTest()
        {
            // TODO unit test for the property 'Descripcion'
        }

    }

}
