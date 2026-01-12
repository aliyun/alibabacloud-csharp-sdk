// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RdsAi20250507.Models
{
    public class ModifyInstanceIpWhitelistRequest : TeaModel {
        /// <summary>
        /// <para>The method that is used to modify the IP address whitelist. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Cover</b> (default): Uses the IP addresses and CIDR blocks that are specified in the <b>IpWhitelist</b> parameter to <b>overwrite</b> the existing ones in the current whitelist.</description></item>
        /// <item><description><b>Append</b>: <b>Appends</b> the IP addresses and CIDR blocks that are specified in the <b>IpWhitelist</b> parameter to the current whitelist.</description></item>
        /// <item><description><b>Delete</b>: <b>Deletes</b> the IP addresses and CIDR blocks that are specified in the <b>IpWhitelist</b> parameter from the current whitelist. You must retain at least one IP address or CIDR block.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The idempotency token. The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ra-supabase-8moov5lxba****</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The ID of the RDS Supabase instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.23.XXX.XXX</para>
        /// </summary>
        [NameInMap("IpWhitelist")]
        [Validation(Required=false)]
        public string IpWhitelist { get; set; }

        /// <summary>
        /// <para>The IP address whitelist. Before you modify the IP address whitelist, call the DescribeInstanceIpWhitelist operation to query the existing IP address whitelist of the instance.</para>
        /// <para><b>Configuration rules</b></para>
        /// <list type="bullet">
        /// <item><description>You can configure IP addresses (such as 10.23.XXX.XXX) or CIDR blocks (such as 10.23.XXX.XXX/24).</description></item>
        /// <item><description>Separate multiple IP addresses or CIDR blocks with commas (,) and do not add spaces preceding or following the commas.</description></item>
        /// <item><description>You can configure up to 1,000 IP addresses and CIDR blocks in total for each instance. If you want to add a large number of IP addresses, we recommend that you merge the IP addresses into CIDR blocks, such as 10.23.XXX.XXX/24.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Cover</para>
        /// </summary>
        [NameInMap("ModifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform. Set the value to <b>ModifyInstanceIpWhitelist</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
