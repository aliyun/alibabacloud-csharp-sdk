// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeExternalAgentRequest : TeaModel {
        /// <summary>
        /// <para>The permission mode of the agent. Valid values:</para>
        /// <para>admin: the admin mode, which provides full permissions. restricted: the restricted mode, which provides partial permissions. Default value: admin.</para>
        /// 
        /// <b>Example:</b>
        /// <para>admin</para>
        /// </summary>
        [NameInMap("AgentMode")]
        [Validation(Required=false)]
        public string AgentMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to obtain the credentials that are used to access the cluster over the internal network.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: obtains the credentials that are used to access the cluster over the internal network.</description></item>
        /// <item><description><c>false</c>: obtains the credentials that are used to access the cluster over the Internet.</description></item>
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
