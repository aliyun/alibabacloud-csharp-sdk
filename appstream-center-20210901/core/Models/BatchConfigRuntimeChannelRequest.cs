// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class BatchConfigRuntimeChannelRequest : TeaModel {
        /// <summary>
        /// <para>The agent platform, such as ENTERPRISE. If the value is invalid, the error code InvalidParameter.AgentPlatform is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("AgentPlatform")]
        [Validation(Required=false)]
        public string AgentPlatform { get; set; }

        /// <summary>
        /// <para>The agent provider.</para>
        /// <list type="bullet">
        /// <item><description>JVS Computer: Enter OpenClaw.</description></item>
        /// <item><description>OpenClaw: Enter OpenClaw.</description></item>
        /// <item><description>Hermes Agent: Enter HermesAgent.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenClaw</para>
        /// </summary>
        [NameInMap("AgentProvider")]
        [Validation(Required=false)]
        public string AgentProvider { get; set; }

        /// <summary>
        /// <para>The list of channel configurations. A maximum of 200 configurations are supported. Each configuration item specifies an agent runtime and the third-party channel to be configured for it. Different channel configurations can be delivered to different runtimes. Multiple configuration items for the same runtime are processed sequentially.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ChannelConfigs")]
        [Validation(Required=false)]
        public List<BatchConfigRuntimeChannelRequestChannelConfigs> ChannelConfigs { get; set; }
        public class BatchConfigRuntimeChannelRequestChannelConfigs : TeaModel {
            /// <summary>
            /// <para>The third-party channel code, such as dingtalk-connector (DingTalk), feishu (Lark), and wecom (WeCom). System channel codes are not case-sensitive. Configuring wechat and jvsclaw is not supported. If these values are passed, the entire request fails and the error code ChannelConfig.NotSupported is returned.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dingtalk-connector</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The JSON string for the channel configuration.</para>
            /// <list type="bullet">
            /// <item><description>Simple mode: only appKey and appSecret are allowed.</description></item>
            /// <item><description>Custom mode: all configuration items required for the channel under the current agent provider must be included.</description></item>
            /// </list>
            /// <para>If the string is not valid JSON, the error code InvalidParameter.ValueInvalid is returned.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;appKey&quot;:&quot;testKey&quot;,&quot;appSecret&quot;:&quot;testSecret&quot;}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The configuration mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Simple: the simple configuration mode.</description></item>
            /// <item><description>Custom: the custom configuration mode.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Simple</para>
            /// </summary>
            [NameInMap("ConfigMode")]
            [Validation(Required=false)]
            public string ConfigMode { get; set; }

            /// <summary>
            /// <para>The channel name.</para>
            /// <para>If this parameter is not specified, the system automatically uses the code as the name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DingTalk</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The agent runtime ID. The ID mappings are as follows:</para>
            /// <list type="bullet">
            /// <item><description>JVS Computer: the JVS Computer ID, in the format of jvs-xxxx.</description></item>
            /// <item><description>OpenClaw: the cloud desktop ID, in the format of ecd-xxxx.</description></item>
            /// <item><description>Hermes Agent: the Hermes Agent ID, in the format of jvs-xxxx.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-xgads</para>
            /// </summary>
            [NameInMap("RuntimeId")]
            [Validation(Required=false)]
            public string RuntimeId { get; set; }

        }

        /// <summary>
        /// <para>The agent runtime type, such as CloudDesktop (cloud desktop).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudDesktop</para>
        /// </summary>
        [NameInMap("RuntimeType")]
        [Validation(Required=false)]
        public string RuntimeType { get; set; }

    }

}
