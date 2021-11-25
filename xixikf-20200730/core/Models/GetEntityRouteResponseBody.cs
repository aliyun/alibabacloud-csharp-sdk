// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xixikf20200730.Models
{
    public class GetEntityRouteResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetEntityRouteResponseBodyData Data { get; set; }
        public class GetEntityRouteResponseBodyData : TeaModel {
            [NameInMap("DepartmentId")]
            [Validation(Required=false)]
            public string DepartmentId { get; set; }
            [NameInMap("EntityBizCode")]
            [Validation(Required=false)]
            public string EntityBizCode { get; set; }
            [NameInMap("EntityBizCodeType")]
            [Validation(Required=false)]
            public string EntityBizCodeType { get; set; }
            [NameInMap("EntityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }
            [NameInMap("EntityName")]
            [Validation(Required=false)]
            public string EntityName { get; set; }
            [NameInMap("EntityRelationNumber")]
            [Validation(Required=false)]
            public string EntityRelationNumber { get; set; }
            [NameInMap("ExtInfo")]
            [Validation(Required=false)]
            public string ExtInfo { get; set; }
            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public long? ServiceId { get; set; }
            [NameInMap("UniqueId")]
            [Validation(Required=false)]
            public long? UniqueId { get; set; }
        };

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
