// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ExecKgGremlinResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ExecKgGremlinResponseBodyData Data { get; set; }
        public class ExecKgGremlinResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of edges.</para>
            /// </summary>
            [NameInMap("EdgeList")]
            [Validation(Required=false)]
            public List<ExecKgGremlinResponseBodyDataEdgeList> EdgeList { get; set; }
            public class ExecKgGremlinResponseBodyDataEdgeList : TeaModel {
                /// <summary>
                /// <para>The data ID of the relationship record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcd-1235-xc</para>
                /// </summary>
                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                /// <summary>
                /// <para>The list of relationship record properties.</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public List<ExecKgGremlinResponseBodyDataEdgeListProperties> Properties { get; set; }
                public class ExecKgGremlinResponseBodyDataEdgeListProperties : TeaModel {
                    /// <summary>
                    /// <para>The property code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>company_name</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The property value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Alibaba</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The relationship type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BUY</para>
                /// </summary>
                [NameInMap("RelationType")]
                [Validation(Required=false)]
                public string RelationType { get; set; }

                /// <summary>
                /// <para>The data ID of the source entity record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcd-1234</para>
                /// </summary>
                [NameInMap("SourceEntityDataId")]
                [Validation(Required=false)]
                public string SourceEntityDataId { get; set; }

                /// <summary>
                /// <para>The source entity type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Shop</para>
                /// </summary>
                [NameInMap("SourceEntityType")]
                [Validation(Required=false)]
                public string SourceEntityType { get; set; }

                /// <summary>
                /// <para>The data ID of the target entity record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcd-2234</para>
                /// </summary>
                [NameInMap("TargetEntityDataId")]
                [Validation(Required=false)]
                public string TargetEntityDataId { get; set; }

                /// <summary>
                /// <para>The target entity type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Product</para>
                /// </summary>
                [NameInMap("TargetEntityType")]
                [Validation(Required=false)]
                public string TargetEntityType { get; set; }

            }

            /// <summary>
            /// <para>The transformed execution statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>g.v().limit(100)</para>
            /// </summary>
            [NameInMap("ExecQuery")]
            [Validation(Required=false)]
            public string ExecQuery { get; set; }

            /// <summary>
            /// <para>The list of nodes.</para>
            /// </summary>
            [NameInMap("NodeList")]
            [Validation(Required=false)]
            public List<ExecKgGremlinResponseBodyDataNodeList> NodeList { get; set; }
            public class ExecKgGremlinResponseBodyDataNodeList : TeaModel {
                /// <summary>
                /// <para>The data ID of the entity record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcd-1234-xx</para>
                /// </summary>
                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                /// <summary>
                /// <para>The entity type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Product</para>
                /// </summary>
                [NameInMap("EntityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                /// <summary>
                /// <para>The list of entity record properties.</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public List<ExecKgGremlinResponseBodyDataNodeListProperties> Properties { get; set; }
                public class ExecKgGremlinResponseBodyDataNodeListProperties : TeaModel {
                    /// <summary>
                    /// <para>The property code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>company_name</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The property value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Alibaba</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The list of rows.</para>
            /// </summary>
            [NameInMap("RowList")]
            [Validation(Required=false)]
            public List<ExecKgGremlinResponseBodyDataRowList> RowList { get; set; }
            public class ExecKgGremlinResponseBodyDataRowList : TeaModel {
                /// <summary>
                /// <para>The list of columns in the row.</para>
                /// </summary>
                [NameInMap("Columns")]
                [Validation(Required=false)]
                public List<ExecKgGremlinResponseBodyDataRowListColumns> Columns { get; set; }
                public class ExecKgGremlinResponseBodyDataRowListColumns : TeaModel {
                    /// <summary>
                    /// <para>The property code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>company_name</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The property value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Alibaba</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The backend exception details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
