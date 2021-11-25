// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xixikf20200730.Models
{
    public class GetEntityRouteListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetEntityRouteListResponseBodyData Data { get; set; }
        public class GetEntityRouteListResponseBodyData : TeaModel {
            [NameInMap("EntityRouteList")]
            [Validation(Required=false)]
            public List<GetEntityRouteListResponseBodyDataEntityRouteList> EntityRouteList { get; set; }
            public class GetEntityRouteListResponseBodyDataEntityRouteList : TeaModel {
                public string DepartmentId { get; set; }
                public string EntityBizCode { get; set; }
                public string EntityBizCodeType { get; set; }
                public string EntityId { get; set; }
                public string EntityName { get; set; }
                public string EntityRelationNumber { get; set; }
                public string ExtInfo { get; set; }
                public string GroupId { get; set; }
                public string ServiceId { get; set; }
                public long? UniqueId { get; set; }
            }
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
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
