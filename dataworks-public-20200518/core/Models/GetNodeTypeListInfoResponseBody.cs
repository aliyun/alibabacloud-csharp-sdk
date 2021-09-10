// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetNodeTypeListInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("NodeTypeInfoList")]
        [Validation(Required=false)]
        public GetNodeTypeListInfoResponseBodyNodeTypeInfoList NodeTypeInfoList { get; set; }
        public class GetNodeTypeListInfoResponseBodyNodeTypeInfoList : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("NodeTypeInfo")]
            [Validation(Required=false)]
            public List<GetNodeTypeListInfoResponseBodyNodeTypeInfoListNodeTypeInfo> NodeTypeInfo { get; set; }
            public class GetNodeTypeListInfoResponseBodyNodeTypeInfoListNodeTypeInfo : TeaModel {
                public string NodeTypeName { get; set; }
                public int? NodeType { get; set; }
            }
        };

    }

}
