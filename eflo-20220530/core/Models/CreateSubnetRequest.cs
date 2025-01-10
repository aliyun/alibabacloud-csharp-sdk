// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class CreateSubnetRequest : TeaModel {
        /// <summary>
        /// <para>The CIDR block of the Subnet.</para>
        /// <list type="bullet">
        /// <item><description>The network segment of the subnet must be a proper subset of the network segment of Lingjun to which it belongs, and the mask must be between 16 bits and 29 bits, which can provide 8 to 65536 addresses. For example, the CIDR block of the Lingjun CIDR block is 192.168.0.0/16, and the CIDR blocks of the subnets under the Lingjun CIDR block are 192.168.0.0/17 to 192.168.0.0/29.</description></item>
        /// <item><description>The first and last three IP addresses of each subnet segment are reserved by the system. For example, the CIDR blocks of the subnet are 192.168.1.0/24,192.168.1.0, 192.168.1.253, 192.168.1.254, and 192.168.1.255.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/16</para>
        /// </summary>
        [NameInMap("Cidr")]
        [Validation(Required=false)]
        public string Cidr { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Lingjun subnet instance name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>subnet-1</para>
        /// </summary>
        [NameInMap("SubnetName")]
        [Validation(Required=false)]
        public string SubnetName { get; set; }

        /// <summary>
        /// <para>The tag information.</para>
        /// <para>You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateSubnetRequestTag> Tag { get; set; }
        public class CreateSubnetRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the VPN attachment.</para>
            /// <para>You cannot specify an empty string as a tag key. It can be up to 64 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// <para>You can specify at most 20 tag keys in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-subnet</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the VPN connection.</para>
            /// <para>The tag value can be empty or a string of up to 128 characters. It cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
            /// <para>Each key-value pair must be unique. You can specify values for at most 20 tag keys in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>subnet-tag-1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Lingjun Subnet Usage Type; optional; optional. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>If you do not set this field for a common type</b></description></item>
        /// <item><description><b>OOB</b> :OOB type</description></item>
        /// <item><description><b>LB</b>: LB type</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OOB</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The ID of the Lingjun CIDR block.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpd-xcuhjyrj</para>
        /// </summary>
        [NameInMap("VpdId")]
        [Validation(Required=false)]
        public string VpdId { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
