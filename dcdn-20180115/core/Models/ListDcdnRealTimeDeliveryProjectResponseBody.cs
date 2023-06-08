// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class ListDcdnRealTimeDeliveryProjectResponseBody : TeaModel {
        /// <summary>
        /// The configuration results of the domain name.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListDcdnRealTimeDeliveryProjectResponseBodyContent Content { get; set; }
        public class ListDcdnRealTimeDeliveryProjectResponseBodyContent : TeaModel {
            [NameInMap("Projects")]
            [Validation(Required=false)]
            public List<ListDcdnRealTimeDeliveryProjectResponseBodyContentProjects> Projects { get; set; }
            public class ListDcdnRealTimeDeliveryProjectResponseBodyContentProjects : TeaModel {
                /// <summary>
                /// The type of the collected logs. Default value: cdn_log_access_l1. Valid values:
                /// 
                /// *   **cdn_log_access_l1**: access logs of DCDN POPs
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
                /// The name of the field. For more information about fields in real-time log entries, see [Fields in a real-time log](~~324199~~).
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
                public float? SamplingRate { get; set; }

                /// <summary>
                /// The type of log delivery. Only **SLS_POST** is supported.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
