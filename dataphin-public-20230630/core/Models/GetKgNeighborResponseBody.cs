// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetKgNeighborResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetKgNeighborResponseBodyData Data { get; set; }
        public class GetKgNeighborResponseBodyData : TeaModel {
            [NameInMap("EdgeList")]
            [Validation(Required=false)]
            public List<GetKgNeighborResponseBodyDataEdgeList> EdgeList { get; set; }
            public class GetKgNeighborResponseBodyDataEdgeList : TeaModel {
                [NameInMap("PropertyList")]
                [Validation(Required=false)]
                public List<GetKgNeighborResponseBodyDataEdgeListPropertyList> PropertyList { get; set; }
                public class GetKgNeighborResponseBodyDataEdgeListPropertyList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>company_name</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>STRING</para>
                    /// </summary>
                    [NameInMap("DataType")]
                    [Validation(Required=false)]
                    public string DataType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Alibaba</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>abc-xxx</para>
                /// </summary>
                [NameInMap("RelationId")]
                [Validation(Required=false)]
                public string RelationId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>BELONG_TO</para>
                /// </summary>
                [NameInMap("RelationType")]
                [Validation(Required=false)]
                public string RelationType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>abc-xxx</para>
                /// </summary>
                [NameInMap("SourceEntityId")]
                [Validation(Required=false)]
                public string SourceEntityId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>abd-xxx</para>
                /// </summary>
                [NameInMap("TargetEntityId")]
                [Validation(Required=false)]
                public string TargetEntityId { get; set; }

            }

            [NameInMap("NodeList")]
            [Validation(Required=false)]
            public List<GetKgNeighborResponseBodyDataNodeList> NodeList { get; set; }
            public class GetKgNeighborResponseBodyDataNodeList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>abc-xxx</para>
                /// </summary>
                [NameInMap("EntityId")]
                [Validation(Required=false)]
                public string EntityId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Company</para>
                /// </summary>
                [NameInMap("EntityType")]
                [Validation(Required=false)]
                public string EntityType { get; set; }

                [NameInMap("PropertyList")]
                [Validation(Required=false)]
                public List<GetKgNeighborResponseBodyDataNodeListPropertyList> PropertyList { get; set; }
                public class GetKgNeighborResponseBodyDataNodeListPropertyList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>company_name</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>STRING</para>
                    /// </summary>
                    [NameInMap("DataType")]
                    [Validation(Required=false)]
                    public string DataType { get; set; }

                    /// <summary>
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
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
