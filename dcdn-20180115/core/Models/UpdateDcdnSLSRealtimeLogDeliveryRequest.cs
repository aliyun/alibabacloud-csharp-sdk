// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class UpdateDcdnSLSRealtimeLogDeliveryRequest : TeaModel {
        /// <summary>
        /// The region from which logs are collected.
        /// 
        /// *   **cn**: Chinese mainland
        /// *   **sg**: Singapore
        /// *   **in**: India
        /// *   **eu**: Europe
        /// *   **us**: United States
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

        /// <summary>
        /// The domain names from which logs were collected. You can specify one or more domain names. Separate multiple domain names with commas (,).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The name of the project.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// The name of the Logstore.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SLSLogStore")]
        [Validation(Required=false)]
        public string SLSLogStore { get; set; }

        /// <summary>
        /// The name of the log file.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SLSProject")]
        [Validation(Required=false)]
        public string SLSProject { get; set; }

        /// <summary>
        /// The region to which logs were delivered.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SLSRegion")]
        [Validation(Required=false)]
        public string SLSRegion { get; set; }

        /// <summary>
        /// The sampling rate.
        /// </summary>
        [NameInMap("SamplingRate")]
        [Validation(Required=false)]
        public string SamplingRate { get; set; }

    }

}
