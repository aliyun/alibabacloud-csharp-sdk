// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class UpdateEvaluatorRequest : TeaModel {
        /// <summary>
        /// <para>The list of annotation tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;__en&quot;]</para>
        /// </summary>
        [NameInMap("annotations")]
        [Validation(Required=false)]
        public List<string> Annotations { get; set; }

        /// <summary>
        /// <para>The configuration of the new version. This parameter is typically required when <c>version</c> is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;prompt&quot;:&quot;Evaluate task completion more strictly&quot;}</para>
        /// </summary>
        [NameInMap("config")]
        [Validation(Required=false)]
        public Dictionary<string, object> Config { get; set; }

        /// <summary>
        /// <para>The evaluator description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Determines whether the agent completes the user task</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Task completion of the chain</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

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
        /// <para>The new version number. A new version is created when this parameter is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.1.0</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The version description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Optimized scoring instructions</para>
        /// </summary>
        [NameInMap("versionDescription")]
        [Validation(Required=false)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// <para>The idempotency token. CloudSpec declares this query parameter, but the backend does not currently perform idempotency comparison.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a1b2c3d4-1234-5678-90ab-cdef12345678</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
