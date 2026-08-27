// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiStatisticsConfig : TeaModel {
        /// <summary>
        /// <para><b>[Deprecated]</b> Specifies whether to record request content (controls whether question-related attributes are generated). This parameter is deprecated in the new version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("logRequestContent")]
        [Validation(Required=false)]
        public bool? LogRequestContent { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> Specifies whether to record response content (controls whether answer-related attributes are generated). This parameter is deprecated in the new version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("logResponseContent")]
        [Validation(Required=false)]
        public bool? LogResponseContent { get; set; }

        /// <summary>
        /// <para>The list of AI request log field collection configurations, configured by API path.</para>
        /// </summary>
        [NameInMap("pathFieldConfigs")]
        [Validation(Required=false)]
        public List<AiStatisticsConfigPathFieldConfigs> PathFieldConfigs { get; set; }
        public class AiStatisticsConfigPathFieldConfigs : TeaModel {
            /// <summary>
            /// <para>The AI request log field configuration groups for the API path, passed in as a Map. The Map keys are fixed to basic and custom, and the values are arrays of log field configurations for the corresponding groups. basic indicates basic log fields, and custom indicates custom log fields. For the current API path, fieldPaths represents the complete desired state of field configurations and does not support incremental appending or diff merging.</para>
            /// <para>If pathFieldConfigs is not passed, is null, or is an empty array, the existing log field configurations are not updated. If a non-empty array is passed, the system performs a desired state replacement based on the complete set of Paths in the request, and historical Path configurations not included in the request are deleted.</para>
            /// <para>For example, to add a custom field test to the /v1/chat/completions API path on top of existing configurations, the caller must use a &quot;read-merge-write back in full&quot; approach:</para>
            /// <ol>
            /// <item><description>Read all current Path configurations.</description></item>
            /// <item><description>Retain the complete basic array and custom array for the target API path /v1/chat/completions.</description></item>
            /// <item><description>Append test to the current custom array.</description></item>
            /// <item><description>Keep configurations for other API paths unchanged.</description></item>
            /// <item><description>Submit the merged complete pathFieldConfigs.</description></item>
            /// </ol>
            /// </summary>
            [NameInMap("fieldPaths")]
            [Validation(Required=false)]
            public Dictionary<string, AiStatisticsPathField> FieldPaths { get; set; }

            /// <summary>
            /// <para>The API path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/v1/chat/completions</para>
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

    }

}
