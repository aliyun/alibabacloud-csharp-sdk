// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class QueryEntitiesResponseBody : TeaModel {
        [NameInMap("Entities")]
        [Validation(Required=false)]
        public List<QueryEntitiesResponseBodyEntities> Entities { get; set; }
        public class QueryEntitiesResponseBodyEntities : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("CreateUserId")]
            [Validation(Required=false)]
            public string CreateUserId { get; set; }

            [NameInMap("CreateUserName")]
            [Validation(Required=false)]
            public string CreateUserName { get; set; }

            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public long? EntityId { get; set; }

            [NameInMap("EntityName")]
            [Validation(Required=false)]
            public string EntityName { get; set; }

            [NameInMap("EntityType")]
            [Validation(Required=false)]
            public string EntityType { get; set; }

            [NameInMap("Members")]
            [Validation(Required=false)]
            public List<QueryEntitiesResponseBodyEntitiesMembers> Members { get; set; }
            public class QueryEntitiesResponseBodyEntitiesMembers : TeaModel {
                [NameInMap("MemberName")]
                [Validation(Required=false)]
                public string MemberName { get; set; }

                [NameInMap("Synonyms")]
                [Validation(Required=false)]
                public List<string> Synonyms { get; set; }

            }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("ModifyUserId")]
            [Validation(Required=false)]
            public string ModifyUserId { get; set; }

            [NameInMap("ModifyUserName")]
            [Validation(Required=false)]
            public string ModifyUserName { get; set; }

            [NameInMap("Regex")]
            [Validation(Required=false)]
            public string Regex { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
