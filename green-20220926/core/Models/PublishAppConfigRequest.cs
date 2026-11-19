// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class PublishAppConfigRequest : TeaModel {
        /// <summary>
        /// <para>The agent ID. This parameter must be the AgentId returned by the AddAppAgent operation after the agent is added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ag.abcxxx</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The agent name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Agent 1</para>
        /// </summary>
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <para>The application ID. This parameter must be the AppId returned by the AddAppConfig operation after the application is created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>txt_check_agent_01</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The configuration details. The value is a JSON string. The outer object contains the agentItemConfigs field, and its value is a re-serialized JSON array string (a double-nested structure) represented as a sequence of characters. Each array element in agentItemConfigs is an agent configuration object. Supported fields include agentId (string, the agent ID. Use the actual value returned by AddAppAgent or a clear placeholder such as <your-agent-id>), name (string, the agent name), and enable (boolean, specifies whether to enable the agent). Differences and connections with the Config parameter of ModifyAppAgent: The Config parameter of ModifyAppAgent describes the runtime configuration of a single agent (model, scene, or labelConfig), and you must first configure the agent by calling ModifyAppAgent. The Config parameter of this operation aggregates all agent entries (agentItemConfigs) under the application for overall publishing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;agentItemConfigs&quot;: &quot;[{\&quot;agentId\&quot;:\&quot;ag.abcxxx\&quot;,\&quot;enable\&quot;:true,\&quot;name\&quot;:\&quot;Agent 1\&quot;}]&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the agent. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent_text</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
