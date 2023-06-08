// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CreateDcdnSLSRealTimeLogDeliveryRequest : TeaModel {
        /// <summary>
        /// The type of the collected logs. Default value: cdn_log_access_l1. Valid values:
        /// 
        /// *   **cdn_log_access_l1**: access logs of Dynamic Content Delivery Network (DCDN) points of presence (POPs)
        /// *   **cdn_log_origin**: back-to-origin logs
        /// *   **cdn_log_er**: EdgeRoutine logs
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// The data center. Valid values:
        /// 
        /// *   cn: China
        /// *   sg: Singapore
        /// *   in: India
        /// *   eu: Europe
        /// *   us: United States
        /// </summary>
        [NameInMap("DataCenter")]
        [Validation(Required=false)]
        public string DataCenter { get; set; }

        /// <summary>
        /// The domain names from which logs were collected. You can specify one or more domain names. Separate multiple domain names with commas (,).
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The name of a real-time log delivery project.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// The name of the Log Service Logstore.
        /// </summary>
        [NameInMap("SLSLogStore")]
        [Validation(Required=false)]
        public string SLSLogStore { get; set; }

        /// <summary>
        /// The name of the Log Service project.
        /// </summary>
        [NameInMap("SLSProject")]
        [Validation(Required=false)]
        public string SLSProject { get; set; }

        /// <summary>
        /// The region to which real-time logs are delivered.
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
