// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ConfigRuntimeChannelRequest : TeaModel {
        /// <summary>
        /// <para>The Agent platform (such as ENTERPRISE or JVS).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("AgentPlatform")]
        [Validation(Required=false)]
        public string AgentPlatform { get; set; }

        /// <summary>
        /// <para>The Agent provider.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenClaw</para>
        /// </summary>
        [NameInMap("AgentProvider")]
        [Validation(Required=false)]
        public string AgentProvider { get; set; }

        /// <summary>
        /// <para>The third-party channel code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingtalk-connector</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The channel configuration JSON string.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;appKey&quot;: &quot;abc&quot;,
        ///     &quot;appSecret&quot;: &quot;efg&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The configuration mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Simple</para>
        /// </summary>
        [NameInMap("ConfigMode")]
        [Validation(Required=false)]
        public string ConfigMode { get; set; }

        /// <summary>
        /// <para>The channel name.</para>
        /// <para>If you leave this parameter empty, the system automatically uses the value of Code as the name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>钉钉</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The list of runtime IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RuntimeIds")]
        [Validation(Required=false)]
        public List<string> RuntimeIds { get; set; }

        /// <summary>
        /// <para>The Agent runtime type.</para>
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
