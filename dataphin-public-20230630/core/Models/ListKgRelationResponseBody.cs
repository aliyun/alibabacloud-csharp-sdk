// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListKgRelationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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

        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListKgRelationResponseBodyPageResult PageResult { get; set; }
        public class ListKgRelationResponseBodyPageResult : TeaModel {
            [NameInMap("RelationList")]
            [Validation(Required=false)]
            public List<ListKgRelationResponseBodyPageResultRelationList> RelationList { get; set; }
            public class ListKgRelationResponseBodyPageResultRelationList : TeaModel {
                [NameInMap("PropertyList")]
                [Validation(Required=false)]
                public List<ListKgRelationResponseBodyPageResultRelationListPropertyList> PropertyList { get; set; }
                public class ListKgRelationResponseBodyPageResultRelationListPropertyList : TeaModel {
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>68</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

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
