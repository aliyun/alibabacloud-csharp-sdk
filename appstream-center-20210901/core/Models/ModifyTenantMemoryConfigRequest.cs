// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyTenantMemoryConfigRequest : TeaModel {
        /// <summary>
        /// <para>The business platform to which the agent belongs. Specify the platform that corresponds to the tenant memory configuration, such as the enterprise platform <c>ENTERPRISE</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("AgentPlatform")]
        [Validation(Required=false)]
        public string AgentPlatform { get; set; }

        /// <summary>
        /// <para>The agent provider. Used together with AgentPlatform and BizType to locate the memory configuration. A configured business combination must be used.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenClaw</para>
        /// </summary>
        [NameInMap("AgentProvider")]
        [Validation(Required=false)]
        public string AgentProvider { get; set; }

        /// <summary>
        /// <para>The business type code. Used together with the provider and business platform. Common values include <c>1</c> (Enterprise Edition), <c>10</c> (Personal Edition), and <c>20</c> (Commercial Edition).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the memory feature for the business combination. A value of <c>true</c> enables the feature, and <c>false</c> disables it. If this parameter is omitted, the current status is retained.</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

    }

}
