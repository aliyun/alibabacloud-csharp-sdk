// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class ListParameterSetsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("parameterSets")]
        [Validation(Required=false)]
        public List<ListParameterSetsResponseBodyParameterSets> ParameterSets { get; set; }
        public class ListParameterSetsResponseBodyParameterSets : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-14T10:05:19Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("deletionProtection")]
            [Validation(Required=false)]
            public bool? DeletionProtection { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pts-433aead756057ea135b21e89c</para>
            /// </summary>
            [NameInMap("parameterSetId")]
            [Validation(Required=false)]
            public string ParameterSetId { get; set; }

            [NameInMap("parameters")]
            [Validation(Required=false)]
            public List<ListParameterSetsResponseBodyParameterSetsParameters> Parameters { get; set; }
            public class ListParameterSetsResponseBodyParameterSetsParameters : TeaModel {
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public object Value { get; set; }

            }

            [NameInMap("relationList")]
            [Validation(Required=false)]
            public List<ListParameterSetsResponseBodyParameterSetsRelationList> RelationList { get; set; }
            public class ListParameterSetsResponseBodyParameterSetsRelationList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-06-09T03:46:18Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>task-433aead756057ffdf5326bf1e12ed</para>
                /// </summary>
                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Module</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4E188A8C-D77A-53F2-9578-E9AD8ABF2FA9</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
