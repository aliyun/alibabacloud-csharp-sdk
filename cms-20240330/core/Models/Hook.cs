// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class Hook : TeaModel {
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
        /// <para>Specifies whether the Hook is enabled. The Hook is executed only when this parameter is set to true. If not configured, the Hook is disabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The event processed by the Hook. Each Hook processes only one event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ToolStart</para>
        /// </summary>
        [NameInMap("event")]
        [Validation(Required=false)]
        public string Event { get; set; }

        /// <summary>
        /// <para>The execution configuration that specifies the synchronous execution, total timeout, number of retries, and invalid return value handling policy for the Hook.</para>
        /// </summary>
        [NameInMap("execution")]
        [Validation(Required=false)]
        public HookExecution Execution { get; set; }
        public class HookExecution : TeaModel {
            /// <summary>
            /// <para>The handling policy for invalid return values. If the handler return value remains invalid after retries, it is processed as allow or reject.</para>
            /// 
            /// <b>Example:</b>
            /// <para>allow</para>
            /// </summary>
            [NameInMap("failResult")]
            [Validation(Required=false)]
            public string FailResult { get; set; }

            /// <summary>
            /// <para>The execution instruction. The prompt type indicates a prompt, the bash type indicates a Bash script, the python3 type indicates a Python 3 script, and the hint type indicates contextual text directly appended. A non-empty UTF-8 text must be provided for all four types.</para>
            /// 
            /// <b>Example:</b>
            /// <para>检查当前工具调用是否安全。</para>
            /// </summary>
            [NameInMap("instruction")]
            [Validation(Required=false)]
            public string Instruction { get; set; }

            /// <summary>
            /// <para>The maximum number of additional attempts after a failure. Valid values: 0 to 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("maxRetry")]
            [Validation(Required=false)]
            public long? MaxRetry { get; set; }

            /// <summary>
            /// <para>The timeout period in seconds. Valid values: 1 to 30. All attempts and waits for the Hook share this timeout period.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("timeoutSeconds")]
            [Validation(Required=false)]
            public long? TimeoutSeconds { get; set; }

            /// <summary>
            /// <para>The handler type. Valid values: prompt, bash, python3, and hint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prompt</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The list of tool names. Only ToolStart and ToolEnd events perform exact matching based on the actual tool name. Tool names such as Read, Write, Bash, and Edit are supported, but wildcards are not supported. An empty array does not restrict tools. This field is ignored for other events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Read&quot;,&quot;Write&quot;,&quot;Bash&quot;,&quot;Edit&quot;]</para>
        /// </summary>
        [NameInMap("match")]
        [Validation(Required=false)]
        public List<string> Match { get; set; }

        /// <summary>
        /// <para>The Hook name. Only digits, letters, underscores, and hyphens are allowed. The name cannot be empty. Hooks with the same name are still executed independently in the order of the list.</para>
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
        /// <para>The effective scope. Valid values: all, chat, and mission. A value of all indicates that the scope includes Chat and Mission. A value of chat or mission indicates that the scope applies only to the corresponding scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
