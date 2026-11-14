// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class GetTenantMemoryConfigRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is not enabled. Do not specify this parameter. The current API operation queries tenant configurations by provider, business platform, and business type. The example is used to illustrate the field status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N/A (not enabled)</para>
        /// </summary>
        [NameInMap("AgentInstanceId")]
        [Validation(Required=false)]
        public string AgentInstanceId { get; set; }

        /// <summary>
        /// <para>The business platform to which the agent belongs. Specify the platform corresponding to the tenant memory configuration, such as <c>ENTERPRISE</c> for the enterprise platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("AgentPlatform")]
        [Validation(Required=false)]
        public string AgentPlatform { get; set; }

        /// <summary>
        /// <para>The agent provider. This parameter is used together with AgentPlatform and BizType to locate the memory configuration. You must use a configured business combination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenClaw</para>
        /// </summary>
        [NameInMap("AgentProvider")]
        [Validation(Required=false)]
        public string AgentProvider { get; set; }

        /// <summary>
        /// <para>The business type code. This parameter is used together with the provider and business platform. Common values include <c>1</c> for Enterprise Edition, <c>10</c> for Personal Edition, and <c>20</c> for Commercial Edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

    }

}
