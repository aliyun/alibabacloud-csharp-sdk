// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetNodeTypeListInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of node types.</para>
        /// </summary>
        [NameInMap("NodeTypeInfoList")]
        [Validation(Required=false)]
        public GetNodeTypeListInfoResponseBodyNodeTypeInfoList NodeTypeInfoList { get; set; }
        public class GetNodeTypeListInfoResponseBodyNodeTypeInfoList : TeaModel {
            /// <summary>
            /// <para>The information about a node type.</para>
            /// </summary>
            [NameInMap("NodeTypeInfo")]
            [Validation(Required=false)]
            public List<GetNodeTypeListInfoResponseBodyNodeTypeInfoListNodeTypeInfo> NodeTypeInfo { get; set; }
            public class GetNodeTypeListInfoResponseBodyNodeTypeInfoListNodeTypeInfo : TeaModel {
                /// <summary>
                /// <para>The type of the node, which is specified by a number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public int? NodeType { get; set; }

                /// <summary>
                /// <para>The name of the node type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ODPS SQL</para>
                /// </summary>
                [NameInMap("NodeTypeName")]
                [Validation(Required=false)]
                public string NodeTypeName { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
