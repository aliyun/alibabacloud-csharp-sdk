// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeExternalAgentRequest : TeaModel {
        /// <summary>
        /// The agent mode.
        /// </summary>
        [NameInMap("AgentMode")]
        [Validation(Required=false)]
        public string AgentMode { get; set; }

        /// <summary>
        /// Specifies whether to obtain the credentials that are used to access the cluster over the internal network.
        /// 
        /// *   `true`: obtains the credentials that are used to access the cluster over the internal network.
        /// *   `false`: obtains the credentials that are used to access the cluster over the Internet.
        /// 
        /// Default value: `false`.
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

    }

}
