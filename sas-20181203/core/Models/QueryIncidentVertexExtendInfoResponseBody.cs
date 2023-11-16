// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryIncidentVertexExtendInfoResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public string Count { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("VertexExtendInfo")]
        [Validation(Required=false)]
        public List<QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfo> VertexExtendInfo { get; set; }
        public class QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfo : TeaModel {
            /// <summary>
            /// AliUid
            /// </summary>
            [NameInMap("Aliuid")]
            [Validation(Required=false)]
            public string Aliuid { get; set; }

            [NameInMap("DisplayInfo")]
            [Validation(Required=false)]
            public List<QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfoDisplayInfo> DisplayInfo { get; set; }
            public class QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfoDisplayInfo : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Lang")]
            [Validation(Required=false)]
            public string Lang { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NeighborList")]
            [Validation(Required=false)]
            public List<QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfoNeighborList> NeighborList { get; set; }
            public class QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfoNeighborList : TeaModel {
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                [NameInMap("HasMore")]
                [Validation(Required=false)]
                public bool? HasMore { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Properties")]
            [Validation(Required=false)]
            public string Properties { get; set; }

            [NameInMap("Property")]
            [Validation(Required=false)]
            public QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfoProperty Property { get; set; }
            public class QueryIncidentVertexExtendInfoResponseBodyVertexExtendInfoProperty : TeaModel {
                [NameInMap("AlertDesc")]
                [Validation(Required=false)]
                public string AlertDesc { get; set; }

                [NameInMap("AlertDetail")]
                [Validation(Required=false)]
                public string AlertDetail { get; set; }

                [NameInMap("AlertLevel")]
                [Validation(Required=false)]
                public string AlertLevel { get; set; }

                [NameInMap("AlertName")]
                [Validation(Required=false)]
                public string AlertName { get; set; }

                [NameInMap("AlertNameCode")]
                [Validation(Required=false)]
                public string AlertNameCode { get; set; }

                [NameInMap("AlertNameEn")]
                [Validation(Required=false)]
                public string AlertNameEn { get; set; }

                [NameInMap("AlertSrcProd")]
                [Validation(Required=false)]
                public string AlertSrcProd { get; set; }

                [NameInMap("AlertSrcProdModule")]
                [Validation(Required=false)]
                public string AlertSrcProdModule { get; set; }

                [NameInMap("AlertTitle")]
                [Validation(Required=false)]
                public string AlertTitle { get; set; }

                [NameInMap("AlertType")]
                [Validation(Required=false)]
                public string AlertType { get; set; }

                [NameInMap("AlertTypeCode")]
                [Validation(Required=false)]
                public string AlertTypeCode { get; set; }

                [NameInMap("AlertTypeEn")]
                [Validation(Required=false)]
                public string AlertTypeEn { get; set; }

                [NameInMap("AlertUuid")]
                [Validation(Required=false)]
                public string AlertUuid { get; set; }

                [NameInMap("AssetList")]
                [Validation(Required=false)]
                public string AssetList { get; set; }

                [NameInMap("AttCk")]
                [Validation(Required=false)]
                public string AttCk { get; set; }

                [NameInMap("CloudCode")]
                [Validation(Required=false)]
                public string CloudCode { get; set; }

                [NameInMap("EntityList")]
                [Validation(Required=false)]
                public string EntityList { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("LogTime")]
                [Validation(Required=false)]
                public string LogTime { get; set; }

                [NameInMap("LogUuid")]
                [Validation(Required=false)]
                public string LogUuid { get; set; }

                [NameInMap("MainUserId")]
                [Validation(Required=false)]
                public string MainUserId { get; set; }

                [NameInMap("OccurTime")]
                [Validation(Required=false)]
                public string OccurTime { get; set; }

                [NameInMap("SubUserId")]
                [Validation(Required=false)]
                public string SubUserId { get; set; }

            }

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// UUID
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

    }

}
