// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class RemoveRuntimeChannelRequest : TeaModel {
        /// <summary>
        /// <para>The agent platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("AgentPlatform")]
        [Validation(Required=false)]
        public string AgentPlatform { get; set; }

        /// <summary>
        /// <para>The agent provider.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenClaw</para>
        /// </summary>
        [NameInMap("AgentProvider")]
        [Validation(Required=false)]
        public string AgentProvider { get; set; }

        /// <summary>
        /// <para>The channel code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dingtalk-connector</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of agent runtime IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RuntimeIds")]
        [Validation(Required=false)]
        public List<string> RuntimeIds { get; set; }

        /// <summary>
        /// <para>The runtime type.</para>
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
