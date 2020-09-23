// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetNodeTypeListInfoResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("NodeTypeInfoList")]
        [Validation(Required=true)]
        public GetNodeTypeListInfoResponseNodeTypeInfoList NodeTypeInfoList { get; set; }
        public class GetNodeTypeListInfoResponseNodeTypeInfoList : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=true)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=true)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=true)]
            public int? TotalCount { get; set; }
            [NameInMap("NodeTypeInfo")]
            [Validation(Required=true)]
            public List<GetNodeTypeListInfoResponseNodeTypeInfoListNodeTypeInfo> NodeTypeInfo { get; set; }
            public class GetNodeTypeListInfoResponseNodeTypeInfoListNodeTypeInfo : TeaModel {
                public int? NodeType { get; set; }
                public string NodeTypeName { get; set; }
            }
        };

    }

}
