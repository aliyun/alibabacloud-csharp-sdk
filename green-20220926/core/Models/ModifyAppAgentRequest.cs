// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class ModifyAppAgentRequest : TeaModel {
        /// <summary>
        /// <para>The agent ID, which is the unique identifier of the agent and is returned in the response of the AddAppAgent operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ag.abcxxx</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>The name of the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Agent 1</para>
        /// </summary>
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <para>The app ID, which is the unique identifier of the application and is returned in the response of the AddAppConfig operation. Note: This parameter is actually required. If it is not provided, the API returns a 400 error with the message &quot;appId may not be empty&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>txt_check_agent_01</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The configuration details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;model&quot;:&quot;default&quot;,&quot;scene&quot;:&quot;0swLgojx&quot;,&quot;labelConfig&quot;:[{&quot;label&quot;:&quot;Abuse&quot;,&quot;labelDefinition&quot;:&quot;The moderated text contains abusive content.&quot;}]}</para>
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
        /// <para>The resource type. Note: This parameter is actually required. If it is not provided, the API returns a 400 error with the message &quot;resourceType may not be empty&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent_text</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
