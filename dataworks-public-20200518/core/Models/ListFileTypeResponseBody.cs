// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListFileTypeResponseBody : TeaModel {
        [NameInMap("NodeTypeInfoList")]
        [Validation(Required=false)]
        public ListFileTypeResponseBodyNodeTypeInfoList NodeTypeInfoList { get; set; }
        public class ListFileTypeResponseBodyNodeTypeInfoList : TeaModel {
            [NameInMap("NodeTypeInfo")]
            [Validation(Required=false)]
            public List<ListFileTypeResponseBodyNodeTypeInfoListNodeTypeInfo> NodeTypeInfo { get; set; }
            public class ListFileTypeResponseBodyNodeTypeInfoListNodeTypeInfo : TeaModel {
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public int? NodeType { get; set; }

                [NameInMap("NodeTypeName")]
                [Validation(Required=false)]
                public string NodeTypeName { get; set; }

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

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
