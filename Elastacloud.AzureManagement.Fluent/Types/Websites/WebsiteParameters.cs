﻿/************************************************************************************************************
 * This software is distributed under a GNU Lesser License by Elastacloud Limited and it is free to         *
 * modify and distribute providing the terms of the license are followed. From the root of the source the   *
 * license can be found in /Resources/license.txt                                                           * 
 *                                                                                                          *
 * Web at: www.elastacloud.com                                                                              *
 * Email: info@elastacloud.com                                                                              *
 ************************************************************************************************************/
using System.Collections.Generic;

namespace Elastacloud.AzureManagement.Fluent.Types.Websites
{
    /// <summary>
    /// The website structure containing details oof the underlying website
    /// </summary>
    public class WebsiteParameters
    {
        public int CurrentNumberOfWorkers { get; set; }
        public int NumberOfWorkers { get; set; }
        public WebsiteState CurrentWorkerState { get; set; }
        public WorkerSize CurrentWorkerSize { get; set; }
        public WebsiteAvailabilityState AvailabilityState { get; set; }
    }

}