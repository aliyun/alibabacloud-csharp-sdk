// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class ListDSEntityResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDSEntityResponseBodyData Data { get; set; }
        public class ListDSEntityResponseBodyData : TeaModel {
            [NameInMap("Entities")]
            [Validation(Required=false)]
            public List<ListDSEntityResponseBodyDataEntities> Entities { get; set; }
            public class ListDSEntityResponseBodyDataEntities : TeaModel {
                public string Action { get; set; }
                public string AppKey { get; set; }
                public string CallerBid { get; set; }
                public string CallerBidLoginEmail { get; set; }
                public long? CallerUid { get; set; }
                public string CallerUidLoginEmail { get; set; }
                public string Channel { get; set; }
                public string ClientIP { get; set; }
                public string CreateTime { get; set; }
                public string CreateUserId { get; set; }
                public string CreateUserName { get; set; }
                public bool? Enable { get; set; }
                public long? EntityId { get; set; }
                public string EntityName { get; set; }
                public string EntityType { get; set; }
                public string ModifyTime { get; set; }
                public string ModifyUserId { get; set; }
                public string ModifyUserName { get; set; }
                public string Operator { get; set; }
                public string OwnerAccount { get; set; }
                public long? OwnerId { get; set; }
                public string OwnerIdLoginEmail { get; set; }
                public string ProxyId { get; set; }
                public string RequestContent { get; set; }
                public string RequestId { get; set; }
                public string ResourceOwnerAccount { get; set; }
                public long? ResourceOwnerId { get; set; }
                public long? TenantId { get; set; }
                public string Token { get; set; }
                public long? UserId { get; set; }
                public string UserNick { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
        };

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
