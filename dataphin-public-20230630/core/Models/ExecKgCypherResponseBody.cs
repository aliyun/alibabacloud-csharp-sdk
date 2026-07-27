// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ExecKgCypherResponseBody : TeaModel {
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
        public ExecKgCypherResponseBodyData Data { get; set; }
        public class ExecKgCypherResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of edges.</para>
            /// </summary>
            [NameInMap("EdgeList")]
            [Validation(Required=false)]
            public List<ExecKgCypherResponseBodyDataEdgeList> EdgeList { get; set; }
            public class ExecKgCypherResponseBodyDataEdgeList : TeaModel {
                /// <summary>
                /// <para>The data ID of the relationship record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bcd-456</para>
                /// </summary>
                [NameInMap("DataId")]
                [Validation(Required=false)]
                public string DataId { get; set; }

                /// <summary>
                /// <para>The list of relationship record properties.</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public List<ExecKgCypherResponseBodyDataEdgeListProperties> Properties { get; set; }
                public class ExecKgCypherResponseBodyDataEdgeListProperties : TeaModel {
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
                /// <para>SALE</para>
                /// </summary>
                [NameInMap("RelationType")]
                [Validation(Required=false)]
                public string RelationType { get; set; }

                /// <summary>
                /// <para>The data ID of the source entity record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>source-123</para>
                /// </summary>
                [NameInMap("SourceEntityDataId")]
                [Validation(Required=false)]
                public string SourceEntityDataId { get; set; }

                /// <summary>
                /// <para>The source entity type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Product</para>
                /// </summary>
                [NameInMap("SourceEntityType")]
                [Validation(Required=false)]
                public string SourceEntityType { get; set; }

                /// <summary>
                /// <para>The data ID of the target entity record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>target-345</para>
                /// </summary>
                [NameInMap("TargetEntityDataId")]
                [Validation(Required=false)]
                public string TargetEntityDataId { get; set; }

                /// <summary>
                /// <para>The target entity type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Shop</para>
                /// </summary>
                [NameInMap("TargetEntityType")]
                [Validation(Required=false)]
                public string TargetEntityType { get; set; }

            }

            /// <summary>
            /// <para>The transformed execution statement.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MATCH p=()-[:Product]-&gt;() RETURN p, count(*) LIMIT 25</para>
            /// </summary>
            [NameInMap("ExecuteCypher")]
            [Validation(Required=false)]
            public string ExecuteCypher { get; set; }

            /// <summary>
            /// <para>The list of nodes.</para>
            /// </summary>
            [NameInMap("NodeList")]
            [Validation(Required=false)]
            public List<ExecKgCypherResponseBodyDataNodeList> NodeList { get; set; }
            public class ExecKgCypherResponseBodyDataNodeList : TeaModel {
                /// <summary>
                /// <para>The data ID of the entity record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc-123</para>
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
                public List<ExecKgCypherResponseBodyDataNodeListProperties> Properties { get; set; }
                public class ExecKgCypherResponseBodyDataNodeListProperties : TeaModel {
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
            public List<ExecKgCypherResponseBodyDataRowList> RowList { get; set; }
            public class ExecKgCypherResponseBodyDataRowList : TeaModel {
                /// <summary>
                /// <para>The list of columns in the row.</para>
                /// </summary>
                [NameInMap("Columns")]
                [Validation(Required=false)]
                public List<ExecKgCypherResponseBodyDataRowListColumns> Columns { get; set; }
                public class ExecKgCypherResponseBodyDataRowListColumns : TeaModel {
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
