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
            /// <para>The edge list.</para>
            /// </summary>
            [NameInMap("EdgeList")]
            [Validation(Required=false)]
            public List<GetKgNeighborResponseBodyDataEdgeList> EdgeList { get; set; }
            public class GetKgNeighborResponseBodyDataEdgeList : TeaModel {
                /// <summary>
                /// <para>The relation record property list.</para>
                /// </summary>
                [NameInMap("PropertyList")]
                [Validation(Required=false)]
                public List<GetKgNeighborResponseBodyDataEdgeListPropertyList> PropertyList { get; set; }
                public class GetKgNeighborResponseBodyDataEdgeListPropertyList : TeaModel {
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
                    /// <para>The property data type. Valid values: STRING (string), INTEGER (integer), FLOAT (float), BOOLEAN (Boolean), DATE (date), LIST (list), and others.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>STRING</para>
                    /// </summary>
                    [NameInMap("DataType")]
                    [Validation(Required=false)]
                    public string DataType { get; set; }

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
                /// <para>The relation record ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc-xxx</para>
                /// </summary>
                [NameInMap("RelationId")]
                [Validation(Required=false)]
                public string RelationId { get; set; }

                /// <summary>
                /// <para>The relation type code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BELONG_TO</para>
                /// </summary>
                [NameInMap("RelationType")]
                [Validation(Required=false)]
                public string RelationType { get; set; }

                /// <summary>
                /// <para>The source entity ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc-xxx</para>
                /// </summary>
                [NameInMap("SourceEntityId")]
                [Validation(Required=false)]
                public string SourceEntityId { get; set; }

                /// <summary>
                /// <para>The target entity ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abd-xxx</para>
                /// </summary>
                [NameInMap("TargetEntityId")]
                [Validation(Required=false)]
                public string TargetEntityId { get; set; }

            }

            /// <summary>
            /// <para>The node list.</para>
            /// </summary>
            [NameInMap("NodeList")]
            [Validation(Required=false)]
            public List<GetKgNeighborResponseBodyDataNodeList> NodeList { get; set; }
            public class GetKgNeighborResponseBodyDataNodeList : TeaModel {
                /// <summary>
                /// <para>The entity record ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc-xxx</para>
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <para>The entity type code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Company</para>
                /// </summary>
                [NameInMap("EntityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                /// <summary>
                /// <para>The entity record property list.</para>
                /// </summary>
                [NameInMap("PropertyList")]
                [Validation(Required=false)]
                public List<GetKgNeighborResponseBodyDataNodeListPropertyList> PropertyList { get; set; }
                public class GetKgNeighborResponseBodyDataNodeListPropertyList : TeaModel {
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
                    /// <para>The property data type. Valid values: STRING (string), INTEGER (integer), FLOAT (float), BOOLEAN (Boolean), DATE (date), LIST (list), and others.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>STRING</para>
                    /// </summary>
                    [NameInMap("DataType")]
                    [Validation(Required=false)]
                    public string DataType { get; set; }

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
