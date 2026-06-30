// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ModifyWhitelistIpsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_copilot***_public_cn-*********6</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The IP whitelist. Before you modify the IP whitelist, call the DescribeInstanceIpWhitelist operation to query the existing IP whitelist of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1,192.168.1.0/24</para>
        /// </summary>
        [NameInMap("IpWhitelist")]
        [Validation(Required=false)]
        public string IpWhitelist { get; set; }

    }

}
