// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiStatisticsConfig : TeaModel {
        /// <summary>
        /// <para><b>[Deprecated]</b> Specifies whether to record the request content (controls whether question-related attributes are generated). This field is deprecated in new versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("logRequestContent")]
        [Validation(Required=false)]
        public bool? LogRequestContent { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> Specifies whether to record the response content (controls whether answer-related attributes are generated). This field is deprecated in new versions.</para>
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
            /// <para>The AI request log field configuration groups corresponding to the API path, passed as a map. The valid keys for the map are fixed to basic and custom, and the values are arrays of log field configurations for the corresponding groups. basic indicates basic log fields, and custom indicates custom log fields. For the current API path, fieldPaths represents the complete desired state of the field configuration. Incremental appending or diff merging is not supported.</para>
            /// <para>If pathFieldConfigs is not passed, is passed as null, or is passed as an empty array, the existing log field configurations are not updated. If a non-empty array is passed, a desired state replacement is performed based on the complete set of paths in the request, and historical path configurations not included in the request are deleted.</para>
            /// <para>For example, to add a custom field named test to the /v1/chat/completions API path based on the existing configuration, the caller must use the read-merge-full write-back approach:</para>
            /// <ol>
            /// <item><description>Read all current path configurations.</description></item>
            /// <item><description>Retain the current complete basic and custom arrays for the target API path /v1/chat/completions.</description></item>
            /// <item><description>Append test to the current custom array.</description></item>
            /// <item><description>Retain the configurations for other API paths as they are.</description></item>
            /// <item><description>Submit the merged and complete pathFieldConfigs.</description></item>
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
