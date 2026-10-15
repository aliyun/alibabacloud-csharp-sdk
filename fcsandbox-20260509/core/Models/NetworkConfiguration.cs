// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class NetworkConfiguration : TeaModel {
        /// <summary>
        /// <para>The network mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("networkMode")]
        [Validation(Required=false)]
        public string NetworkMode { get; set; }

        /// <summary>
        /// <para>The security group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-bp1gx7yj8ud5mabcde</para>
        /// </summary>
        [NameInMap("securityGroupID")]
        [Validation(Required=false)]
        public string SecurityGroupID { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp1mwrqm3wkq7abcde</para>
        /// </summary>
        [NameInMap("vpcID")]
        [Validation(Required=false)]
        public string VpcID { get; set; }

        /// <summary>
        /// <para>The list of vSwitch IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;vsw-bp1s5fnlk4jl2abcde&quot;]</para>
        /// </summary>
        [NameInMap("vswitchIDs")]
        [Validation(Required=false)]
        public List<string> VswitchIDs { get; set; }

    }

}
