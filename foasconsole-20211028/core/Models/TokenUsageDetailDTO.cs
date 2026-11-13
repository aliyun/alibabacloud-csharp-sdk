// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class TokenUsageDetailDTO : TeaModel {
        /// <summary>
        /// <para>The associated items of the intelligent assistant, such as jobs and deployments.</para>
        /// </summary>
        [NameInMap("BizObjects")]
        [Validation(Required=false)]
        public List<TokenUsageDetailDTOBizObjects> BizObjects { get; set; }
        public class TokenUsageDetailDTOBizObjects : TeaModel {
            /// <summary>
            /// <para>The ID of the associated item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4c9102f7-51d2-4494-9ea2-468e3c407ad8</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The type of the associated item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deployment</para>
            /// </summary>
            [NameInMap("Kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <para>The name of the associated item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deployemnt-draft</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>namespace</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-default</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The time when the request is initiated, in epoch milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1790651783392</para>
        /// </summary>
        [NameInMap("OccurredAt")]
        [Validation(Required=false)]
        public long? OccurredAt { get; set; }

        /// <summary>
        /// <para>The inspection configuration.</para>
        /// </summary>
        [NameInMap("ScopeConfig")]
        [Validation(Required=false)]
        public TokenUsageDetailDTOScopeConfig ScopeConfig { get; set; }
        public class TokenUsageDetailDTOScopeConfig : TeaModel {
            /// <summary>
            /// <para>The list of deployments selected for inspection.</para>
            /// </summary>
            [NameInMap("DeploymentIds")]
            [Validation(Required=false)]
            public List<string> DeploymentIds { get; set; }

            /// <summary>
            /// <para>The tag configuration selected for inspection.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, List<string>> Tags { get; set; }

        }

        /// <summary>
        /// <para>The inspection type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TAG</para>
        /// </summary>
        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

        /// <summary>
        /// <para>The session ID shared across multiple requests in the same session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>conv_1790651642778_azcvjyh</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>The request status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The number of jobs covered by the inspection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalJobs")]
        [Validation(Required=false)]
        public int? TotalJobs { get; set; }

        /// <summary>
        /// <para>The number of tokens consumed by this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1287</para>
        /// </summary>
        [NameInMap("TotalTokens")]
        [Validation(Required=false)]
        public long? TotalTokens { get; set; }

        /// <summary>
        /// <para>The request trigger type, such as cron or manual.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CRON</para>
        /// </summary>
        [NameInMap("TriggerSource")]
        [Validation(Required=false)]
        public string TriggerSource { get; set; }

        /// <summary>
        /// <para>The token consumption scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ai_assistant</para>
        /// </summary>
        [NameInMap("UsageType")]
        [Validation(Required=false)]
        public string UsageType { get; set; }

        /// <summary>
        /// <para>workspace</para>
        /// 
        /// <b>Example:</b>
        /// <para>c278e83dff5b41</para>
        /// </summary>
        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
