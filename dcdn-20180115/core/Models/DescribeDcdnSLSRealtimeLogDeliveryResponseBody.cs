// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnSLSRealtimeLogDeliveryResponseBody : TeaModel {
        /// <summary>
        /// The configuration results of the domain name.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public DescribeDcdnSLSRealtimeLogDeliveryResponseBodyContent Content { get; set; }
        public class DescribeDcdnSLSRealtimeLogDeliveryResponseBodyContent : TeaModel {
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
            /// The region from which logs were collected.
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
            /// The name of the field. For more information about fields in real-time log entries, see [Fields in a real-time log](https://help.aliyun.com/document_detail/324199.html).
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// The name of the project.
            /// </summary>
            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            /// <summary>
            /// The name of the Logstore.
            /// </summary>
            [NameInMap("SLSLogStore")]
            [Validation(Required=false)]
            public string SLSLogStore { get; set; }

            /// <summary>
            /// The name of the log file.
            /// </summary>
            [NameInMap("SLSProject")]
            [Validation(Required=false)]
            public string SLSProject { get; set; }

            /// <summary>
            /// The region to which logs were delivered.
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

            /// <summary>
            /// The status of real-time logs.
            /// 
            /// *   **success**
            /// *   **fail**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The type of log delivery. Only **SLS_POST** is supported.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
