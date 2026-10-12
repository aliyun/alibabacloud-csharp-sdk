// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class AiStatisticsConfig : TeaModel {
        /// <summary>
        /// <para><b>[Deprecated]</b> Specifies whether to log request content (controls whether question-related attributes are generated). This parameter is deprecated in the new version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("logRequestContent")]
        [Validation(Required=false)]
        public bool? LogRequestContent { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> Specifies whether to log response content (controls whether answer-related attributes are generated). This parameter is deprecated in the new version.</para>
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
            /// <para>The log field configuration groups for the AI request log corresponding to the API path. Pass this parameter as a map. The valid keys of the map are fixed as basic and custom. The values are arrays of log field configurations for the corresponding group. basic indicates basic log fields, and custom indicates custom log fields. For the current API path, fieldPaths represents the complete desired state of the field configuration and does not support incremental appending or diff merging.</para>
            /// <para>If pathFieldConfigs is not passed, is set to null, or is an empty array, the existing log field configurations are not updated. If a non-empty array is passed, the system performs a full desired state replacement based on the complete set of paths in the request. Historical path configurations that are not included are deleted.</para>
            /// <para>For example, to add a custom field test to the /v1/chat/completions API path on top of the existing configuration, the caller must use a read-merge-write-back approach:</para>
            /// <ol>
            /// <item><description>Read all current path configurations.</description></item>
            /// <item><description>Retain the complete basic array and custom array for the target API path /v1/chat/completions.</description></item>
            /// <item><description>Append test to the current custom array.</description></item>
            /// <item><description>Retain the configurations of other API paths as-is.</description></item>
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
