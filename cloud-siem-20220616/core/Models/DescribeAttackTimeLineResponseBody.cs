// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAttackTimeLineResponseBody : TeaModel {
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
        public List<DescribeAttackTimeLineResponseBodyData> Data { get; set; }
        public class DescribeAttackTimeLineResponseBodyData : TeaModel {
            /// <summary>
            /// The risk level. Valid values:
            /// 
            /// *   serious: high
            /// *   suspicious: medium
            /// *   remind: low
            /// </summary>
            [NameInMap("AlertLevel")]
            [Validation(Required=false)]
            public string AlertLevel { get; set; }

            /// <summary>
            /// The alert name in English.
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
            /// The alert name in English.
            /// </summary>
            [NameInMap("AlertNameEn")]
            [Validation(Required=false)]
            public string AlertNameEn { get; set; }

            /// <summary>
            /// The source of the alert.
            /// </summary>
            [NameInMap("AlertSrcProd")]
            [Validation(Required=false)]
            public string AlertSrcProd { get; set; }

            /// <summary>
            /// The sub-module of the alert source.
            /// </summary>
            [NameInMap("AlertSrcProdModule")]
            [Validation(Required=false)]
            public string AlertSrcProdModule { get; set; }

            /// <summary>
            /// The time when the alert was triggered.
            /// </summary>
            [NameInMap("AlertTime")]
            [Validation(Required=false)]
            public long? AlertTime { get; set; }

            /// <summary>
            /// The title of the alert.
            /// </summary>
            [NameInMap("AlertTitle")]
            [Validation(Required=false)]
            public string AlertTitle { get; set; }

            /// <summary>
            /// The alert title in English.
            /// </summary>
            [NameInMap("AlertTitleEn")]
            [Validation(Required=false)]
            public string AlertTitleEn { get; set; }

            /// <summary>
            /// The type of the alert.
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
            /// The alert type in English.
            /// </summary>
            [NameInMap("AlertTypeEn")]
            [Validation(Required=false)]
            public string AlertTypeEn { get; set; }

            /// <summary>
            /// The UUID of the alert
            /// </summary>
            [NameInMap("AlertUuid")]
            [Validation(Required=false)]
            public string AlertUuid { get; set; }

            /// <summary>
            /// The logical ID of the asset.
            /// </summary>
            [NameInMap("AssetId")]
            [Validation(Required=false)]
            public string AssetId { get; set; }

            /// <summary>
            /// The details of the asset.
            /// </summary>
            [NameInMap("AssetList")]
            [Validation(Required=false)]
            public string AssetList { get; set; }

            /// <summary>
            /// The name of the asset.
            /// </summary>
            [NameInMap("AssetName")]
            [Validation(Required=false)]
            public string AssetName { get; set; }

            /// <summary>
            /// The tag of the ATT\&CK attack.
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
            /// The UUID of the event.
            /// </summary>
            [NameInMap("IncidentUuid")]
            [Validation(Required=false)]
            public string IncidentUuid { get; set; }

            /// <summary>
            /// The time when the alert was recorded.
            /// </summary>
            [NameInMap("LogTime")]
            [Validation(Required=false)]
            public string LogTime { get; set; }

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
