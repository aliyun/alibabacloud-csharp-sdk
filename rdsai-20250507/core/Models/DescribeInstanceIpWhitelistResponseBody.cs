// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class DescribeInstanceIpWhitelistResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the RDS Supabase instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ra-supabase-8moov5lxba****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The IP address whitelists.</para>
        /// </summary>
        [NameInMap("IpWhiteListGroups")]
        [Validation(Required=false)]
        public List<DescribeInstanceIpWhitelistResponseBodyIpWhiteListGroups> IpWhiteListGroups { get; set; }
        public class DescribeInstanceIpWhitelistResponseBodyIpWhiteListGroups : TeaModel {
            /// <summary>
            /// <para>The IP address whitelist name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The IP addresses or CIDR blocks in the whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XXX.XXX/24,10.0.XXX.XXX/24</para>
            /// </summary>
            [NameInMap("IpWhitelist")]
            [Validation(Required=false)]
            public string IpWhitelist { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32DEFB4A-861F-5D1D-ADD5-918E4FD7AB8C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
