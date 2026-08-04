// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class UserVpc : TeaModel {
        /// <summary>
        /// <para>The default public gateway information.</para>
        /// </summary>
        [NameInMap("DefaultForwardInfo")]
        [Validation(Required=false)]
        public ForwardInfo DefaultForwardInfo { get; set; }

        /// <summary>
        /// <para>The default routing. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>eth0: uses the default network interface controller (NIC) to access external networks through the public gateway.</description></item>
        /// <item><description>eth1: uses the user\&quot;s elastic network interfaces (ENIs) to access external networks through the private gateway.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>eth0</para>
        /// </summary>
        [NameInMap("DefaultRoute")]
        [Validation(Required=false)]
        public string DefaultRoute { get; set; }

        /// <summary>
        /// <para>The secondary CIDR blocks.</para>
        /// </summary>
        [NameInMap("ExtendedCIDRs")]
        [Validation(Required=false)]
        public List<string> ExtendedCIDRs { get; set; }

        /// <summary>
        /// <para>The OSS access authorization information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::25xxxx:role/AliyunPAIDLCDefaultRole</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The security group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-abcdef****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vs-abcdef****</para>
        /// </summary>
        [NameInMap("SwitchId")]
        [Validation(Required=false)]
        public string SwitchId { get; set; }

        /// <summary>
        /// <para>VPC ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-abcdef****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
