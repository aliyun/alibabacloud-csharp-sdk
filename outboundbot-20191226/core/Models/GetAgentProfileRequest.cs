// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class GetAgentProfileRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the agent configuration.</para>
        /// <remarks>
        /// <para>The agent configuration ID for a created scenario is available in the ChatbotId parameter returned by the DescribeScript operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d31794e2a51f47d2901b4094d88311d7</para>
        /// </summary>
        [NameInMap("AgentProfileId")]
        [Validation(Required=false)]
        public string AgentProfileId { get; set; }

        /// <summary>
        /// <para>The IP address of the application. This is a system field and is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("AppIp")]
        [Validation(Required=false)]
        public string AppIp { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ec0c897-b92c-40e4-9ad7-e6e4f5ce13bb</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
