// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class GetEvaluatorResponseBody : TeaModel {
        /// <summary>
        /// <para>The evaluator details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;trace_task_completion&quot;,&quot;type&quot;:&quot;AGENT&quot;,&quot;currentVersion&quot;:&quot;1.0.0&quot;}</para>
        /// </summary>
        [NameInMap("evaluator")]
        [Validation(Required=false)]
        public GetEvaluatorResponseBodyEvaluator Evaluator { get; set; }
        public class GetEvaluatorResponseBodyEvaluator : TeaModel {
            /// <summary>
            /// <para>The AgentSpace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod-agentspace</para>
            /// </summary>
            [NameInMap("agentSpace")]
            [Validation(Required=false)]
            public string AgentSpace { get; set; }

            /// <summary>
            /// <para>The list of annotations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;__en&quot;]</para>
            /// </summary>
            [NameInMap("annotations")]
            [Validation(Required=false)]
            public List<string> Annotations { get; set; }

            /// <summary>
            /// <para>The configuration of the current version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;prompt&quot;:&quot;请评估任务完成度&quot;}</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public Dictionary<string, object> Config { get; set; }

            /// <summary>
            /// <para>The time when the evaluator was created. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1782816000</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public long? CreatedAt { get; set; }

            /// <summary>
            /// <para>The version number returned in the current response.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("currentVersion")]
            [Validation(Required=false)]
            public string CurrentVersion { get; set; }

            /// <summary>
            /// <para>The evaluator description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>判断 Agent 是否完成用户任务</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>链路任务完成度</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The latest version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("latestVersion")]
            [Validation(Required=false)]
            public string LatestVersion { get; set; }

            /// <summary>
            /// <para>The evaluation metric name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent_task_completion</para>
            /// </summary>
            [NameInMap("metricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>The evaluator name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>trace_task_completion</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The evaluator properties.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;agentEvaluatorMode&quot;:&quot;raw_prompt&quot;}</para>
            /// </summary>
            [NameInMap("properties")]
            [Validation(Required=false)]
            public Dictionary<string, object> Properties { get; set; }

            /// <summary>
            /// <para>The evaluator type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AGENT</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The time when the evaluator was last updated. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1782816600</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public long? UpdatedAt { get; set; }

            /// <summary>
            /// <para>The list of versions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;version&quot;:&quot;1.0.0&quot;}]</para>
            /// </summary>
            [NameInMap("versions")]
            [Validation(Required=false)]
            public List<GetEvaluatorResponseBodyEvaluatorVersions> Versions { get; set; }
            public class GetEvaluatorResponseBodyEvaluatorVersions : TeaModel {
                /// <summary>
                /// <para>The time when the version was created. The value is a UNIX timestamp in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1782816000</para>
                /// </summary>
                [NameInMap("createdAt")]
                [Validation(Required=false)]
                public long? CreatedAt { get; set; }

                /// <summary>
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.0.0</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                /// <summary>
                /// <para>The version description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>初始版本</para>
                /// </summary>
                [NameInMap("versionDescription")]
                [Validation(Required=false)]
                public string VersionDescription { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3FE4CD1E-FF41-56BE-B590-7A021D9C1524</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
