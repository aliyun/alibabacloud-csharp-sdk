// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetParameterSetResponseBody : TeaModel {
        /// <summary>
        /// <para>The parameter set details.</para>
        /// </summary>
        [NameInMap("parameterSet")]
        [Validation(Required=false)]
        public GetParameterSetResponseBodyParameterSet ParameterSet { get; set; }
        public class GetParameterSetResponseBodyParameterSet : TeaModel {
            /// <summary>
            /// <para>The creation time in UTC, in the ISO 8601 format of YYYY-MM-DDTHH:mm:ssZ.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-30T02:14:16Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the parameter set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is parameterSet</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the parameter set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The parameter set ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pts-3b6cb9fa4751afff9c5e4e01624b9</para>
            /// </summary>
            [NameInMap("parameterSetId")]
            [Validation(Required=false)]
            public string ParameterSetId { get; set; }

            /// <summary>
            /// <para>The parameters in the parameter set.</para>
            /// </summary>
            [NameInMap("parameters")]
            [Validation(Required=false)]
            public List<GetParameterSetResponseBodyParameterSetParameters> Parameters { get; set; }
            public class GetParameterSetResponseBodyParameterSetParameters : TeaModel {
                /// <summary>
                /// <para>The name of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>region</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Specifies whether the parameter is secret. Secret parameters are hidden in API responses and console displays, and are stored with encryption.</para>
                /// </summary>
                [NameInMap("secret")]
                [Validation(Required=false)]
                public bool? Secret { get; set; }

                /// <summary>
                /// <para>The parameter set status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>HAS_VALUE (default): A specific value is defined.</description></item>
                /// <item><description>EXPLICIT_NULL: Explicitly set to null.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HAS_VALUE</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the parameter (string/number/bool/map(string)/list(string)).</para>
                /// 
                /// <b>Example:</b>
                /// <para>string</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The value of the parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public object Value { get; set; }

            }

            /// <summary>
            /// <para>The association relationships.</para>
            /// </summary>
            [NameInMap("relationList")]
            [Validation(Required=false)]
            public List<GetParameterSetResponseBodyParameterSetRelationList> RelationList { get; set; }
            public class GetParameterSetResponseBodyParameterSetRelationList : TeaModel {
                /// <summary>
                /// <para>The creation time in UTC, in the ISO 8601 format of YYYY-MM-DDTHH:mm:ssZ.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-04-24T22:58:50Z</para>
                /// </summary>
                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The resource ID. When the resource type is ModuleVersion, the ID is composed of <moduleId>-<moduleversion>, such as mod-34535345df123fr-v3.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mod-433aead756057101546eb5d50c1</para>
                /// </summary>
                [NameInMap("resourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                /// <summary>
                /// <para>The resource type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Module: template.</description></item>
                /// <item><description>ModuleVersion: template version.</description></item>
                /// <item><description>Task: task.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Module</para>
                /// </summary>
                [NameInMap("resourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99905C7C-1320-5E7F-A798-3071482EB08E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
