// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetParameterSetResponseBody : TeaModel {
        [NameInMap("parameterSet")]
        [Validation(Required=false)]
        public GetParameterSetResponseBodyParameterSet ParameterSet { get; set; }
        public class GetParameterSetResponseBodyParameterSet : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-01-30T02:14:16Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pts-3b6cb9fa4751afff9c5e4e01624b9</para>
            /// </summary>
            [NameInMap("parameterSetId")]
            [Validation(Required=false)]
            public string ParameterSetId { get; set; }

            [NameInMap("parameters")]
            [Validation(Required=false)]
            public List<GetParameterSetResponseBodyParameterSetParameters> Parameters { get; set; }
            public class GetParameterSetResponseBodyParameterSetParameters : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test1121</para>
                /// </summary>
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
                /// <para>vpc-2ze83xrka9ktxy0pnaxn5</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public object Value { get; set; }

            }

            [NameInMap("relationList")]
            [Validation(Required=false)]
            public List<GetParameterSetResponseBodyParameterSetRelationList> RelationList { get; set; }
            public class GetParameterSetResponseBodyParameterSetRelationList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2022-04-24T22:58:50Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mod-433aead756057101546eb5d50c1</para>
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
        /// <para>99905C7C-1320-5E7F-A798-3071482EB08E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
