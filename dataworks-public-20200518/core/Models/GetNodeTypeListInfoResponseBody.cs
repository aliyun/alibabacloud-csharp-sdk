// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetNodeTypeListInfoResponseBody : TeaModel {
        /// <summary>
        /// The list of node types.
        /// </summary>
        [NameInMap("NodeTypeInfoList")]
        [Validation(Required=false)]
        public GetNodeTypeListInfoResponseBodyNodeTypeInfoList NodeTypeInfoList { get; set; }
        public class GetNodeTypeListInfoResponseBodyNodeTypeInfoList : TeaModel {
            /// <summary>
            /// The information about a node type.
            /// </summary>
            [NameInMap("NodeTypeInfo")]
            [Validation(Required=false)]
            public List<GetNodeTypeListInfoResponseBodyNodeTypeInfoListNodeTypeInfo> NodeTypeInfo { get; set; }
            public class GetNodeTypeListInfoResponseBodyNodeTypeInfoListNodeTypeInfo : TeaModel {
                /// <summary>
                /// The type of the node, which is specified by a number.
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public int? NodeType { get; set; }

                /// <summary>
                /// The name of the node type.
                /// </summary>
                [NameInMap("NodeTypeName")]
                [Validation(Required=false)]
                public string NodeTypeName { get; set; }

            }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
