// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetVariableGroupResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASSDS-ASSASX-XSAXSA-XSAXSAXS</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("variableGroup")]
        [Validation(Required=false)]
        public GetVariableGroupResponseBodyVariableGroup VariableGroup { get; set; }
        public class GetVariableGroupResponseBodyVariableGroup : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>13232343434343</para>
            /// </summary>
            [NameInMap("ccreatorAccountId")]
            [Validation(Required=false)]
            public string CcreatorAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1586863220000</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>变量组</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12234</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>13232343434343</para>
            /// </summary>
            [NameInMap("modifierAccountId")]
            [Validation(Required=false)]
            public string ModifierAccountId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>变量组</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("relatedPipelines")]
            [Validation(Required=false)]
            public List<GetVariableGroupResponseBodyVariableGroupRelatedPipelines> RelatedPipelines { get; set; }
            public class GetVariableGroupResponseBodyVariableGroupRelatedPipelines : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>流水线</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1586863220000</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            [NameInMap("variables")]
            [Validation(Required=false)]
            public List<GetVariableGroupResponseBodyVariableGroupVariables> Variables { get; set; }
            public class GetVariableGroupResponseBodyVariableGroupVariables : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("isEncrypted")]
                [Validation(Required=false)]
                public bool? IsEncrypted { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>name1</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
