// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetRuntimeModelConfigRequest : TeaModel {
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
        /// <para>Specifies whether to include risk information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeRiskInfo")]
        [Validation(Required=false)]
        public bool? IncludeRiskInfo { get; set; }

        /// <summary>
        /// <para>The ID of the agent runtime. The ID mappings are as follows:</para>
        /// <para>JVS Computer: JVS Computer ID, in the format of jvs-xxxx.</para>
        /// <para>OpenClaw: Cloud desktop ID, in the format of ecd-xxxx.</para>
        /// <para>Hermes Agent: Hermes Agent ID, in the format of jvs-xxxx.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecd-xxxx</para>
        /// </summary>
        [NameInMap("RuntimeId")]
        [Validation(Required=false)]
        public string RuntimeId { get; set; }

        /// <summary>
        /// <para>The type of the agent runtime.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CloudDesktop</para>
        /// </summary>
        [NameInMap("RuntimeType")]
        [Validation(Required=false)]
        public string RuntimeType { get; set; }

        /// <summary>
        /// <para>The smart model filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Queries the system wuying-preset provider models based on the business type of the runtime.</description></item>
        /// <item><description>false: Excludes wuying-preset from the effective configuration.</description></item>
        /// <item><description>Empty: Returns both smart and non-smart models in the effective configuration.
        /// The business type is read by the server from runtime.biz_type, and the BizType input parameter is not required. Risk information is still independently controlled by IncludeRiskInfo.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SmartModel")]
        [Validation(Required=false)]
        public bool? SmartModel { get; set; }

    }

}
