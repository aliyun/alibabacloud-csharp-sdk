// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryIncidentVertexExtendInfoResponseBody : TeaModel {
        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public string Count { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The returned extended information about the node.
        /// </summary>
        [NameInMap("VertexExtendInfo")]
        [Validation(Required=false)]
        public List<QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfo> VertexExtendInfo { get; set; }
        public class QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfo : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account.
            /// </summary>
            [NameInMap("Aliuid")]
            [Validation(Required=false)]
            public string Aliuid { get; set; }

            /// <summary>
            /// The display information.
            /// </summary>
            [NameInMap("DisplayInfo")]
            [Validation(Required=false)]
            public List<QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfoDisplayInfo> DisplayInfo { get; set; }
            public class QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfoDisplayInfo : TeaModel {
                /// <summary>
                /// The display name of the property.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The display value of the property.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The node ID.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The language of the content within the response. Valid values:
            /// 
            /// *   **zh**: Chinese
            /// *   **en**: English
            /// </summary>
            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            /// <summary>
            /// The node name.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The neighboring nodes.
            /// </summary>
            [NameInMap("NeighborList")]
            [Validation(Required=false)]
            public List<QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfoNeighborList> NeighborList { get; set; }
            public class QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfoNeighborList : TeaModel {
                /// <summary>
                /// The number of nodes.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// Indicates whether more neighboring nodes exist. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("HasMore")]
                [Validation(Required=false)]
                public bool? HasMore { get; set; }

                /// <summary>
                /// The node type. Valid values include but are not limited to:
                /// 
                /// *   **process**
                /// *   **file**
                /// *   **alert**
                /// *   **ip**
                /// *   **domain**
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The node properties. The value is in the text format.
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }

            /// <summary>
            /// The node property.
            /// </summary>
            [NameInMap("Property")]
            [Validation(Required=false)]
            public QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfoProperty Property { get; set; }
            public class QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfoProperty : TeaModel {
                /// <summary>
                /// The alert description.
                /// </summary>
                [NameInMap("AlertDesc")]
                [Validation(Required=false)]
                public string AlertDesc { get; set; }

                /// <summary>
                /// The details of the alert.
                /// </summary>
                [NameInMap("AlertDetail")]
                [Validation(Required=false)]
                public string AlertDetail { get; set; }

                /// <summary>
                /// The alert level. Valid values:
                /// 
                /// *   **serious**
                /// *   **suspicious**
                /// *   **remind**
                /// </summary>
                [NameInMap("AlertLevel")]
                [Validation(Required=false)]
                public string AlertLevel { get; set; }

                /// <summary>
                /// The alert name.
                /// </summary>
                [NameInMap("AlertName")]
                [Validation(Required=false)]
                public string AlertName { get; set; }

                /// <summary>
                /// The code of the alert name.
                /// </summary>
                [NameInMap("AlertNameCode")]
                [Validation(Required=false)]
                public string AlertNameCode { get; set; }

                /// <summary>
                /// The alert name. The value is in English.
                /// </summary>
                [NameInMap("AlertNameEn")]
                [Validation(Required=false)]
                public string AlertNameEn { get; set; }

                /// <summary>
                /// The service that generates the alert.
                /// </summary>
                [NameInMap("AlertSrcProd")]
                [Validation(Required=false)]
                public string AlertSrcProd { get; set; }

                /// <summary>
                /// The module of the service that generates the alert.
                /// </summary>
                [NameInMap("AlertSrcProdModule")]
                [Validation(Required=false)]
                public string AlertSrcProdModule { get; set; }

                /// <summary>
                /// The alert title.
                /// </summary>
                [NameInMap("AlertTitle")]
                [Validation(Required=false)]
                public string AlertTitle { get; set; }

                /// <summary>
                /// The alert type.
                /// </summary>
                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public string AlertType { get; set; }

                /// <summary>
                /// The code of the alert type.
                /// </summary>
                [NameInMap("AlertTypeCode")]
                [Validation(Required=false)]
                public string AlertTypeCode { get; set; }

                /// <summary>
                /// The alert type. The value is in English.
                /// </summary>
                [NameInMap("AlertTypeEn")]
                [Validation(Required=false)]
                public string AlertTypeEn { get; set; }

                /// <summary>
                /// The alert ID.
                /// </summary>
                [NameInMap("AlertUuid")]
                [Validation(Required=false)]
                public string AlertUuid { get; set; }

                /// <summary>
                /// The assets.
                /// </summary>
                [NameInMap("AssetList")]
                [Validation(Required=false)]
                public string AssetList { get; set; }

                /// <summary>
                /// ATT\\&CK
                /// </summary>
                [NameInMap("AttCk")]
                [Validation(Required=false)]
                public string AttCk { get; set; }

                /// <summary>
                /// The code of the cloud service provider.
                /// </summary>
                [NameInMap("CloudCode")]
                [Validation(Required=false)]
                public string CloudCode { get; set; }

                /// <summary>
                /// The instance.
                /// </summary>
                [NameInMap("EntityList")]
                [Validation(Required=false)]
                public string EntityList { get; set; }

                /// <summary>
                /// The creation time.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The modification time.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The time when the log was generated.
                /// </summary>
                [NameInMap("LogTime")]
                [Validation(Required=false)]
                public string LogTime { get; set; }

                /// <summary>
                /// The log ID.
                /// </summary>
                [NameInMap("LogUuid")]
                [Validation(Required=false)]
                public string LogUuid { get; set; }

                /// <summary>
                /// The ID of the master account.
                /// </summary>
                [NameInMap("MainUserId")]
                [Validation(Required=false)]
                public string MainUserId { get; set; }

                /// <summary>
                /// The time when the alert was generated.
                /// </summary>
                [NameInMap("OccurTime")]
                [Validation(Required=false)]
                public string OccurTime { get; set; }

                /// <summary>
                /// The ID of the sub-account.
                /// </summary>
                [NameInMap("SubUserId")]
                [Validation(Required=false)]
                public string SubUserId { get; set; }

            }

            /// <summary>
            /// The ID of the rule for which the node was created.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// The time when the node was created.
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// The UNIX timestamp when the node was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            /// <summary>
            /// The node type. Valid values include but are not limited to:
            /// 
            /// *   **process**
            /// *   **file**
            /// *   **alert**
            /// *   **ip**
            /// *   **domain**
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The node UUID.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
