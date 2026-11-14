// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetRuntimeChannelRequest : TeaModel {
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
        /// <para>Specifies whether to include risk information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeRiskInfo")]
        [Validation(Required=false)]
        public bool? IncludeRiskInfo { get; set; }

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
        /// <para>jvs-xxxx</para>
        /// </summary>
        [NameInMap("RuntimeId")]
        [Validation(Required=false)]
        public string RuntimeId { get; set; }

        /// <summary>
        /// <para>The agent runtime type.</para>
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
