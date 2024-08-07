// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAlertsResponseBody : TeaModel {
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
        public DescribeAlertsResponseBodyData Data { get; set; }
        public class DescribeAlertsResponseBodyData : TeaModel {
            /// <summary>
            /// The pagination information.
            /// </summary>
            [NameInMap("PageInfo")]
            [Validation(Required=false)]
            public DescribeAlertsResponseBodyDataPageInfo PageInfo { get; set; }
            public class DescribeAlertsResponseBodyDataPageInfo : TeaModel {
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
            public List<DescribeAlertsResponseBodyDataResponseData> ResponseData { get; set; }
            public class DescribeAlertsResponseBodyDataResponseData : TeaModel {
                /// <summary>
                /// The description of the alert.
                /// </summary>
                [NameInMap("AlertDesc")]
                [Validation(Required=false)]
                public string AlertDesc { get; set; }

                /// <summary>
                /// The internal code of the alert description.
                /// </summary>
                [NameInMap("AlertDescCode")]
                [Validation(Required=false)]
                public string AlertDescCode { get; set; }

                /// <summary>
                /// The description of the alert in English.
                /// </summary>
                [NameInMap("AlertDescEn")]
                [Validation(Required=false)]
                public string AlertDescEn { get; set; }

                /// <summary>
                /// The details of the alert.
                /// </summary>
                [NameInMap("AlertDetail")]
                [Validation(Required=false)]
                public string AlertDetail { get; set; }

                /// <summary>
                /// The displayed details of the alert.
                /// </summary>
                [NameInMap("AlertInfoList")]
                [Validation(Required=false)]
                public List<DescribeAlertsResponseBodyDataResponseDataAlertInfoList> AlertInfoList { get; set; }
                public class DescribeAlertsResponseBodyDataResponseDataAlertInfoList : TeaModel {
                    /// <summary>
                    /// The attribute key.
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// The name of the key.
                    /// </summary>
                    [NameInMap("KeyName")]
                    [Validation(Required=false)]
                    public string KeyName { get; set; }

                    /// <summary>
                    /// The value of the key.
                    /// </summary>
                    [NameInMap("Values")]
                    [Validation(Required=false)]
                    public string Values { get; set; }

                }

                /// <summary>
                /// The threat level. Valid values:
                /// 
                /// *   serious: high
                /// *   suspicious: medium
                /// *   remind: low
                /// </summary>
                [NameInMap("AlertLevel")]
                [Validation(Required=false)]
                public string AlertLevel { get; set; }

                /// <summary>
                /// The name of the alert.
                /// </summary>
                [NameInMap("AlertName")]
                [Validation(Required=false)]
                public string AlertName { get; set; }

                /// <summary>
                /// The internal code of the alert name.
                /// </summary>
                [NameInMap("AlertNameCode")]
                [Validation(Required=false)]
                public string AlertNameCode { get; set; }

                /// <summary>
                /// The name of the alert in English.
                /// </summary>
                [NameInMap("AlertNameEn")]
                [Validation(Required=false)]
                public string AlertNameEn { get; set; }

                /// <summary>
                /// The service for which the alert associated with the event is generated.
                /// </summary>
                [NameInMap("AlertSrcProd")]
                [Validation(Required=false)]
                public string AlertSrcProd { get; set; }

                /// <summary>
                /// The sub-module of ther alert source.
                /// </summary>
                [NameInMap("AlertSrcProdModule")]
                [Validation(Required=false)]
                public string AlertSrcProdModule { get; set; }

                /// <summary>
                /// The title of the alert.
                /// </summary>
                [NameInMap("AlertTitle")]
                [Validation(Required=false)]
                public string AlertTitle { get; set; }

                /// <summary>
                /// The title of the alert in English.
                /// </summary>
                [NameInMap("AlertTitleEn")]
                [Validation(Required=false)]
                public string AlertTitleEn { get; set; }

                /// <summary>
                /// The alert type.
                /// </summary>
                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public string AlertType { get; set; }

                /// <summary>
                /// The internal code of the alert type.
                /// </summary>
                [NameInMap("AlertTypeCode")]
                [Validation(Required=false)]
                public string AlertTypeCode { get; set; }

                /// <summary>
                /// The type of the alert in English.
                /// </summary>
                [NameInMap("AlertTypeEn")]
                [Validation(Required=false)]
                public string AlertTypeEn { get; set; }

                /// <summary>
                /// The UUID of the alert.
                /// </summary>
                [NameInMap("AlertUuid")]
                [Validation(Required=false)]
                public string AlertUuid { get; set; }

                /// <summary>
                /// The details of the asset.
                /// </summary>
                [NameInMap("AssetList")]
                [Validation(Required=false)]
                public string AssetList { get; set; }

                /// <summary>
                /// The tag of the ATT\\&CK attack.
                /// </summary>
                [NameInMap("AttCk")]
                [Validation(Required=false)]
                public string AttCk { get; set; }

                /// <summary>
                /// The cloud code. Valid values:
                /// 
                /// *   aliyun: Alibaba Cloud
                /// *   qcloud: Tencent Cloud
                /// *   hcloud: Huawei Cloud
                /// </summary>
                [NameInMap("CloudCode")]
                [Validation(Required=false)]
                public string CloudCode { get; set; }

                /// <summary>
                /// The time when the alert was closed.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The time when the alert was received.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The time when the alert was last updated.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The unique ID of the alert.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The UUID of the event.
                /// </summary>
                [NameInMap("IncidentUuid")]
                [Validation(Required=false)]
                public string IncidentUuid { get; set; }

                /// <summary>
                /// Indicates whether an attack is defended. Valid values:
                /// 
                /// *   0: detected.
                /// *   1: blocked.
                /// </summary>
                [NameInMap("IsDefend")]
                [Validation(Required=false)]
                public string IsDefend { get; set; }

                /// <summary>
                /// The time when the alert was recorded.
                /// </summary>
                [NameInMap("LogTime")]
                [Validation(Required=false)]
                public string LogTime { get; set; }

                /// <summary>
                /// The UUID of the alert log.
                /// </summary>
                [NameInMap("LogUuid")]
                [Validation(Required=false)]
                public string LogUuid { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account that is associated with the alert in SIEM.
                /// </summary>
                [NameInMap("MainUserId")]
                [Validation(Required=false)]
                public long? MainUserId { get; set; }

                /// <summary>
                /// The time when the alert is triggered.
                /// </summary>
                [NameInMap("OccurTime")]
                [Validation(Required=false)]
                public string OccurTime { get; set; }

                /// <summary>
                /// The time at which the alert was first generated.
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account within which the alert is generated.
                /// </summary>
                [NameInMap("SubUserId")]
                [Validation(Required=false)]
                public long? SubUserId { get; set; }

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
