// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetKgNeighborResponseBody : TeaModel {
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
        public GetKgNeighborResponseBodyData Data { get; set; }
        public class GetKgNeighborResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of edges.</para>
            /// </summary>
            [NameInMap("EdgeList")]
            [Validation(Required=false)]
            public List<GetKgNeighborResponseBodyDataEdgeList> EdgeList { get; set; }
            public class GetKgNeighborResponseBodyDataEdgeList : TeaModel {
                /// <summary>
                /// <para>The list of properties for the relation record.</para>
                /// </summary>
                [NameInMap("PropertyList")]
                [Validation(Required=false)]
                public List<GetKgNeighborResponseBodyDataEdgeListPropertyList> PropertyList { get; set; }
                public class GetKgNeighborResponseBodyDataEdgeListPropertyList : TeaModel {
                    /// <summary>
                    /// <para>The code of the property.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>company_name</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The data type of the property. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>STRING: String.</description></item>
                    /// <item><description>INTEGER: Integer.</description></item>
                    /// <item><description>FLOAT: Floating-point number.</description></item>
                    /// <item><description>BOOLEAN: Boolean.</description></item>
                    /// <item><description>DATE: Date.</description></item>
                    /// <item><description>LIST: List.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>STRING</para>
                    /// </summary>
                    [NameInMap("DataType")]
                    [Validation(Required=false)]
                    public string DataType { get; set; }

                    /// <summary>
                    /// <para>The value of the property.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Alibaba</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>The ID of the relation record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc-xxx</para>
                /// </summary>
                [NameInMap("RelationId")]
                [Validation(Required=false)]
                public string RelationId { get; set; }

                /// <summary>
                /// <para>The code of the relation type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BELONG_TO</para>
                /// </summary>
                [NameInMap("RelationType")]
                [Validation(Required=false)]
                public string RelationType { get; set; }

                /// <summary>
                /// <para>The ID of the source entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc-xxx</para>
                /// </summary>
                [NameInMap("SourceEntityId")]
                [Validation(Required=false)]
                public string SourceEntityId { get; set; }

                /// <summary>
                /// <para>The ID of the target entity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abd-xxx</para>
                /// </summary>
                [NameInMap("TargetEntityId")]
                [Validation(Required=false)]
                public string TargetEntityId { get; set; }

            }

            /// <summary>
            /// <para>The list of nodes.</para>
            /// </summary>
            [NameInMap("NodeList")]
            [Validation(Required=false)]
            public List<GetKgNeighborResponseBodyDataNodeList> NodeList { get; set; }
            public class GetKgNeighborResponseBodyDataNodeList : TeaModel {
                /// <summary>
                /// <para>The ID of the entity record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc-xxx</para>
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>The code of the entity type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Company</para>
                /// </summary>
                [NameInMap("EntityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                /// <summary>
                /// <para>The list of properties for the entity record.</para>
                /// </summary>
                [NameInMap("PropertyList")]
                [Validation(Required=false)]
                public List<GetKgNeighborResponseBodyDataNodeListPropertyList> PropertyList { get; set; }
                public class GetKgNeighborResponseBodyDataNodeListPropertyList : TeaModel {
                    /// <summary>
                    /// <para>The code of the property.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>company_name</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The data type of the property. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>STRING: String.</description></item>
                    /// <item><description>INTEGER: Integer.</description></item>
                    /// <item><description>FLOAT: Floating-point number.</description></item>
                    /// <item><description>BOOLEAN: Boolean.</description></item>
                    /// <item><description>DATE: Date.</description></item>
                    /// <item><description>LIST: List.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>STRING</para>
                    /// </summary>
                    [NameInMap("DataType")]
                    [Validation(Required=false)]
                    public string DataType { get; set; }

                    /// <summary>
                    /// <para>The value of the property.</para>
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
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
