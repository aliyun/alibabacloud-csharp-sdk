// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryRmsUsersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Response")]
        [Validation(Required=false)]
        public QueryRmsUsersResponseBodyResponse Response { get; set; }
        public class QueryRmsUsersResponseBodyResponse : TeaModel {
            [NameInMap("Entities")]
            [Validation(Required=false)]
            public List<QueryRmsUsersResponseBodyResponseEntities> Entities { get; set; }
            public class QueryRmsUsersResponseBodyResponseEntities : TeaModel {
                public string Layer { get; set; }
                public QueryRmsUsersResponseBodyResponseEntitiesEntity Entity { get; set; }
                public class QueryRmsUsersResponseBodyResponseEntitiesEntity : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    [NameInMap("LoginName")]
                    [Validation(Required=false)]
                    public string LoginName { get; set; }

                    [NameInMap("MsgType")]
                    [Validation(Required=false)]
                    public string MsgType { get; set; }

                    [NameInMap("NickName")]
                    [Validation(Required=false)]
                    public string NickName { get; set; }

                    [NameInMap("RealName")]
                    [Validation(Required=false)]
                    public string RealName { get; set; }

                    [NameInMap("UserNumber")]
                    [Validation(Required=false)]
                    public string UserNumber { get; set; }

                }
            }
            [NameInMap("EntitieTests")]
            [Validation(Required=false)]
            public List<QueryRmsUsersResponseBodyResponseEntitieTests> EntitieTests { get; set; }
            public class QueryRmsUsersResponseBodyResponseEntitieTests : TeaModel {
                public string Id { get; set; }
                public string LoginName { get; set; }
                public string MsgType { get; set; }
                public string NickName { get; set; }
                public string RealName { get; set; }
                public string UserNumber { get; set; }
            }
            [NameInMap("Meta")]
            [Validation(Required=false)]
            public List<QueryRmsUsersResponseBodyResponseMeta> Meta { get; set; }
            public class QueryRmsUsersResponseBodyResponseMeta : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
        };

    }

}
