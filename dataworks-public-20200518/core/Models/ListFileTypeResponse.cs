// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListFileTypeResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("NodeTypeInfoList")]
        [Validation(Required=true)]
        public ListFileTypeResponseNodeTypeInfoList NodeTypeInfoList { get; set; }
        public class ListFileTypeResponseNodeTypeInfoList : TeaModel {
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
            public List<ListFileTypeResponseNodeTypeInfoListNodeTypeInfo> NodeTypeInfo { get; set; }
            public class ListFileTypeResponseNodeTypeInfoListNodeTypeInfo : TeaModel {
                public int? NodeType { get; set; }
                public string NodeTypeName { get; set; }
            }
        };

    }

}
