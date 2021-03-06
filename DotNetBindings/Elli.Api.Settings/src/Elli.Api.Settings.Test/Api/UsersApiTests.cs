/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/

/* 
 * Settings
 *
 * Represents settings operations on Company, Loan, Contact etc.
 *
 * OpenAPI spec version: 1.3.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Elli.Api.Settings.Client;
using Elli.Api.Settings.Api;
using Elli.Api.Settings.Model;

namespace Elli.Api.Settings.Test
{
    /// <summary>
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UsersApiTests
    {
        private UsersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UsersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UsersApi
            //Assert.IsInstanceOfType(typeof(UsersApi), instance, "instance is a UsersApi");
        }

        
        /// <summary>
        /// Test GetAssignedPermissionRights
        /// </summary>
        [Test]
        public void GetAssignedPermissionRightsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //string category = null;
            //var response = instance.GetAssignedPermissionRights(userId, category);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test GetEffectivePermissionRights
        /// </summary>
        [Test]
        public void GetEffectivePermissionRightsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //string category = null;
            //var response = instance.GetEffectivePermissionRights(userId, category);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
        
        /// <summary>
        /// Test GetLicenseInfo
        /// </summary>
        [Test]
        public void GetLicenseInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //string state = null;
            //var response = instance.GetLicenseInfo(userId, state);
            //Assert.IsInstanceOf<List<LicenseContract>> (response, "response is List<LicenseContract>");
        }
        
        /// <summary>
        /// Test GetUserCompPlans
        /// </summary>
        [Test]
        public void GetUserCompPlansTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userId = null;
            //var response = instance.GetUserCompPlans(userId);
            //Assert.IsInstanceOf<List<UserCompensationPlanContract>> (response, "response is List<UserCompensationPlanContract>");
        }
        
        /// <summary>
        /// Test GetUserGroups
        /// </summary>
        [Test]
        public void GetUserGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetUserGroups(id);
            //Assert.IsInstanceOf<List<EntityRefContract>> (response, "response is List<EntityRefContract>");
        }
        
        /// <summary>
        /// Test GetUserProfile
        /// </summary>
        [Test]
        public void GetUserProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //string viewEmailSignature = null;
            //var response = instance.GetUserProfile(id, viewEmailSignature);
            //Assert.IsInstanceOf<UserContract> (response, "response is UserContract");
        }
        
        /// <summary>
        /// Test GetUserProfiles
        /// </summary>
        [Test]
        public void GetUserProfilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string viewEmailSignature = null;
            //string groupId = null;
            //string roleId = null;
            //string personaId = null;
            //string featureId = null;
            //string organizationId = null;
            //string userName = null;
            //string start = null;
            //string limit = null;
            //var response = instance.GetUserProfiles(viewEmailSignature, groupId, roleId, personaId, featureId, organizationId, userName, start, limit);
            //Assert.IsInstanceOf<List<UserContract>> (response, "response is List<UserContract>");
        }
        
    }

}
