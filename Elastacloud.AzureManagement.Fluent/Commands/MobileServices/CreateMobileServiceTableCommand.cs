﻿/************************************************************************************************************
 * This software is distributed under a GNU Lesser License by Elastacloud Limited and it is free to         *
 * modify and distribute providing the terms of the license are followed. From the root of the source the   *
 * license can be found in /Resources/license.txt                                                           * 
 *                                                                                                          *
 * Web at: www.elastacloud.com                                                                              *
 * Email: info@elastacloud.com                                                                              *
 ************************************************************************************************************/

using System.Xml.Linq;
using Elastacloud.AzureManagement.Fluent.Helpers;

namespace Elastacloud.AzureManagement.Fluent.Commands.MobileServices
{
    /// <summary>
    /// Used to create a mobile services application
    /// </summary>
    internal class CreateMobileServiceTableCommand : MobileServiceCommand
    {
        /// <summary>
        /// Constructs a command to create a mobile service
        /// </summary>
        internal CreateMobileServiceTableCommand(string serviceName, string tableName, string config)
        {
            OperationId = "mobileservices";
            ServiceType = "services";
            Name = serviceName;
            TableName = tableName;
            Config = config;
            HttpVerb = HttpVerbPost;
            ContentType = "application/json";
            HttpCommand = "mobileservices/" + serviceName.ToLower() + "/tables";
        }

        /// <summary>
        /// The name of the WAMS table
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// Returns a JSON payload to setup the table
        /// </summary>
        protected override string CreatePayload()
        {
            return Config;
        }

        /// <summary>
        /// Returns the string name of the command
        /// </summary>
        public override string ToString()
        {
            return "CreateMobileServiceTableCommand";
        }
    }
}