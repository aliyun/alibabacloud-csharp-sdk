// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryIncidentIconListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("InfoList")]
        [Validation(Required=false)]
        public QueryIncidentIconListResponseBodyInfoList InfoList { get; set; }
        public class QueryIncidentIconListResponseBodyInfoList : TeaModel {
            [NameInMap("EntityTypeList")]
            [Validation(Required=false)]
            public List<QueryIncidentIconListResponseBodyInfoListEntityTypeList> EntityTypeList { get; set; }
            public class QueryIncidentIconListResponseBodyInfoListEntityTypeList : TeaModel {
                [NameInMap("DisplayColor")]
                [Validation(Required=false)]
                public string DisplayColor { get; set; }

                [NameInMap("DisplayIcon")]
                [Validation(Required=false)]
                public string DisplayIcon { get; set; }

                [NameInMap("DisplayOrder")]
                [Validation(Required=false)]
                public string DisplayOrder { get; set; }

                [NameInMap("DisplayTemplate")]
                [Validation(Required=false)]
                public string DisplayTemplate { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("IsVirtualNode")]
                [Validation(Required=false)]
                public string IsVirtualNode { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("TraceSuccessFlag")]
                [Validation(Required=false)]
                public string TraceSuccessFlag { get; set; }

            }

            [NameInMap("RelationTypeList")]
            [Validation(Required=false)]
            public List<QueryIncidentIconListResponseBodyInfoListRelationTypeList> RelationTypeList { get; set; }
            public class QueryIncidentIconListResponseBodyInfoListRelationTypeList : TeaModel {
                [NameInMap("Directed")]
                [Validation(Required=false)]
                public string Directed { get; set; }

                [NameInMap("DisplayColor")]
                [Validation(Required=false)]
                public string DisplayColor { get; set; }

                [NameInMap("DisplayIcon")]
                [Validation(Required=false)]
                public string DisplayIcon { get; set; }

                [NameInMap("DisplayTemplate")]
                [Validation(Required=false)]
                public string DisplayTemplate { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("ShowType")]
                [Validation(Required=false)]
                public string ShowType { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TimeCost")]
        [Validation(Required=false)]
        public long? TimeCost { get; set; }

    }

}
