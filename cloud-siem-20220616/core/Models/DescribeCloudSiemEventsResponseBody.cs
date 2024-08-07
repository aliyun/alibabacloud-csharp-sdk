// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeCloudSiemEventsResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCloudSiemEventsResponseBodyData Data { get; set; }
        public class DescribeCloudSiemEventsResponseBodyData : TeaModel {
            /// <summary>
            /// The pagination information.
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public DescribeCloudSiemEventsResponseBodyDataPageInfo PageInfo { get; set; }
            public class DescribeCloudSiemEventsResponseBodyDataPageInfo : TeaModel {
                /// <summary>
                /// The current page number.
                /// </summary>
                [NameInMap("CurrentPage")]
                [Validation(Required=false)]
                public int? CurrentPage { get; set; }

                /// <summary>
                /// The number of entries per page.
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                /// <summary>
                /// The total number of entries returned.
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// The detailed data.
            /// </summary>
            [NameInMap("ResponseData")]
            [Validation(Required=false)]
            public List<DescribeCloudSiemEventsResponseBodyDataResponseData> ResponseData { get; set; }
            public class DescribeCloudSiemEventsResponseBodyDataResponseData : TeaModel {
                /// <summary>
                /// The number of alerts that are associated with the event.
                /// </summary>
                [NameInMap("AlertNum")]
                [Validation(Required=false)]
                public int? AlertNum { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account to which the event belongs.
                /// </summary>
                [NameInMap("Aliuid")]
                [Validation(Required=false)]
                public long? Aliuid { get; set; }

                /// <summary>
                /// The number of assets that are associated with the event.
                /// </summary>
                [NameInMap("AssetNum")]
                [Validation(Required=false)]
                public int? AssetNum { get; set; }

                /// <summary>
                /// The tags of the ATT\\&CK techniques.
                /// </summary>
                [NameInMap("AttCkLabels")]
                [Validation(Required=false)]
                public List<string> AttCkLabels { get; set; }

                /// <summary>
                /// The sources of the alert.
                /// </summary>
                [NameInMap("DataSources")]
                [Validation(Required=false)]
                public List<string> DataSources { get; set; }

                /// <summary>
                /// The description of the event.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The event description in English.
                /// </summary>
                [NameInMap("DescriptionEn")]
                [Validation(Required=false)]
                public string DescriptionEn { get; set; }

                /// <summary>
                /// The extended event information in the JSON format.
                /// </summary>
                [NameInMap("ExtContent")]
                [Validation(Required=false)]
                public string ExtContent { get; set; }

                /// <summary>
                /// The time when the event occurred.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The time when the event was last updated.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The name of the event.
                /// </summary>
                [NameInMap("IncidentName")]
                [Validation(Required=false)]
                public string IncidentName { get; set; }

                /// <summary>
                /// The event name in English.
                /// </summary>
                [NameInMap("IncidentNameEn")]
                [Validation(Required=false)]
                public string IncidentNameEn { get; set; }

                /// <summary>
                /// The UUID of the event.
                /// </summary>
                [NameInMap("IncidentUuid")]
                [Validation(Required=false)]
                public string IncidentUuid { get; set; }

                /// <summary>
                /// the refer account info.
                /// </summary>
                [NameInMap("ReferAccount")]
                [Validation(Required=false)]
                public string ReferAccount { get; set; }

                /// <summary>
                /// The remarks of the event.
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// The status of the event. Valid values:
                /// 
                /// *   0: unhandled.
                /// *   1: handling.
                /// *   5: handling failed.
                /// *   10: handled.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The risk level. Valid values:
                /// 
                /// *   serious: high.
                /// *   suspicious: medium.
                /// *   remind: low.
                /// </summary>
                [NameInMap("ThreatLevel")]
                [Validation(Required=false)]
                public string ThreatLevel { get; set; }

                /// <summary>
                /// The risk score of the event. Valid values: 0 to 100. A higher value indicates a higher risk level.
                /// </summary>
                [NameInMap("ThreatScore")]
                [Validation(Required=false)]
                public float? ThreatScore { get; set; }

            }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
