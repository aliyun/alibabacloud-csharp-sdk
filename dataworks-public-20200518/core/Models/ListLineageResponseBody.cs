// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListLineageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListLineageResponseBodyData Data { get; set; }
        public class ListLineageResponseBodyData : TeaModel {
            [NameInMap("DataEntityList")]
            [Validation(Required=false)]
            public List<ListLineageResponseBodyDataDataEntityList> DataEntityList { get; set; }
            public class ListLineageResponseBodyDataDataEntityList : TeaModel {
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                [NameInMap("Entity")]
                [Validation(Required=false)]
                public Entity Entity { get; set; }

                [NameInMap("RelationList")]
                [Validation(Required=false)]
                public List<ListLineageResponseBodyDataDataEntityListRelationList> RelationList { get; set; }
                public class ListLineageResponseBodyDataDataEntityListRelationList : TeaModel {
                    [NameInMap("Channel")]
                    [Validation(Required=false)]
                    public string Channel { get; set; }

                    [NameInMap("Datasource")]
                    [Validation(Required=false)]
                    public string Datasource { get; set; }

                    [NameInMap("Guid")]
                    [Validation(Required=false)]
                    public string Guid { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
