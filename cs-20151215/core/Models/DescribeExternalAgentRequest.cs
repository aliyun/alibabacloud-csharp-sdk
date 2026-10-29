// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeExternalAgentRequest : TeaModel {
        /// <summary>
        /// <para>The agent permission mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>admin: Administrator mode. The agent has all permissions.</description></item>
        /// <item><description>restricted: Restricted mode. The agent has only partial permissions.</description></item>
        /// </list>
        /// <para>Default value: admin.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("AgentMode")]
        [Validation(Required=false)]
        public string AgentMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to obtain internal network access credentials. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: Obtains only internal network connection credentials.</description></item>
        /// <item><description><c>false</c>: Obtains only public network connection credentials.</description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

    }

}
