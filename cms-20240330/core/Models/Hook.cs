// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class Hook : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable debug mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("debug")]
        [Validation(Required=false)]
        public bool? Debug { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>检查工具调用中的命令是否安全。</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether the Hook is enabled. It is executed only when this parameter is set to true. If not configured, the Hook is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The event. Each Hook processes only one event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ToolStart</para>
        /// </summary>
        [NameInMap("event")]
        [Validation(Required=false)]
        public string Event { get; set; }

        /// <summary>
        /// <para>The execution configuration. Configures the synchronous execution, total timeout, number of retries, and invalid return value handling policy for the Hook.</para>
        /// </summary>
        [NameInMap("execution")]
        [Validation(Required=false)]
        public HookExecution Execution { get; set; }
        public class HookExecution : TeaModel {
            /// <summary>
            /// <para>The invalid return value handling policy. If the handler return value is still invalid after retries, it is processed as allow or reject.</para>
            /// 
            /// <b>Example:</b>
            /// <para>allow</para>
            /// </summary>
            [NameInMap("failResult")]
            [Validation(Required=false)]
            public string FailResult { get; set; }

            /// <summary>
            /// <para>The execution instruction. For the prompt type, it is a prompt. For the bash type, it is a Bash script. For the python3 type, it is a Python 3 script. For the hint type, it is contextual text directly appended. Non-empty UTF-8 text must be provided for all four types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>检查当前工具调用是否安全。</para>
            /// </summary>
            [NameInMap("instruction")]
            [Validation(Required=false)]
            public string Instruction { get; set; }

            /// <summary>
            /// <para>The maximum number of retries. Specifies the number of additional attempts after a failure. Valid values: 0 to 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("maxRetry")]
            [Validation(Required=false)]
            public long? MaxRetry { get; set; }

            /// <summary>
            /// <para>The timeout period in seconds. Valid values: 1 to 30. All attempts and waits for this Hook share this timeout period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("timeoutSeconds")]
            [Validation(Required=false)]
            public long? TimeoutSeconds { get; set; }

            /// <summary>
            /// <para>The handler type. Only prompt, bash, python3, and hint are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prompt</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to hide Hook invocation events. When set to true, Hook invocation events are not sent to the frontend, regardless of whether debug mode is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("invisible")]
        [Validation(Required=false)]
        public bool? Invisible { get; set; }

        /// <summary>
        /// <para>The list of tool names. Only ToolStart and ToolEnd perform an exact match based on the actual tool name. Tool names such as Read, Write, Bash, and Edit are supported. Wildcards are not supported. An empty array does not restrict tools. This field is ignored for other events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Read&quot;,&quot;Write&quot;,&quot;Bash&quot;,&quot;Edit&quot;]</para>
        /// </summary>
        [NameInMap("match")]
        [Validation(Required=false)]
        public List<string> Match { get; set; }

        /// <summary>
        /// <para>The Hook name. Only digits, letters, underscores, and hyphens are allowed, and it cannot be empty. Hooks with the same name are executed independently in the order of the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>command-guard</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The configuration protocol version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("schemaVersion")]
        [Validation(Required=false)]
        public string SchemaVersion { get; set; }

        /// <summary>
        /// <para>The effective scope. A value of all indicates Chat and Mission. A value of chat or mission indicates that the Hook takes effect only in the corresponding scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
