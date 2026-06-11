// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class UpdateContextRequest : TeaModel {
        /// <summary>
        /// <para>The updated text for the long-term memory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Users prefer to first view the SLS error logs, index configuration, and the most recent Agent execution trace.</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The experience object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;taskType&quot;: &quot;troubleshooting&quot;,
        ///     &quot;complexity&quot;: &quot;medium&quot;,
        ///     &quot;confidence&quot;: 0.95
        /// }</para>
        /// </summary>
        [NameInMap("experience")]
        [Validation(Required=false)]
        public Dictionary<string, object> Experience { get; set; }

        /// <summary>
        /// <para>A set of key-value pairs to attach to an object for storing custom information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;sessionId&quot;:&quot;test_session_001&quot;}</para>
        /// </summary>
        [NameInMap("metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// <para>The payload to update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;userId&quot;: &quot;u-10001&quot;,
        ///     &quot;agentId&quot;: &quot;sls-agent&quot;,
        ///     &quot;appId&quot;: &quot;console&quot;,
        ///     &quot;categories&quot;: [
        ///       &quot;preference&quot;
        ///     ],
        ///     &quot;source&quot;: &quot;user_confirmed&quot;,
        ///     &quot;topic&quot;: &quot;debugging_preference&quot;,
        ///     &quot;immutable&quot;: false,
        ///     &quot;createdAt&quot;: 1776319200,
        ///     &quot;updatedAt&quot;: 1776319200
        ///   }</para>
        /// </summary>
        [NameInMap("payload")]
        [Validation(Required=false)]
        public Dictionary<string, object> Payload { get; set; }

        /// <summary>
        /// <para>The trigger condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Identify and troubleshoot SLs issues</para>
        /// </summary>
        [NameInMap("triggerCondition")]
        [Validation(Required=false)]
        public string TriggerCondition { get; set; }

    }

}
