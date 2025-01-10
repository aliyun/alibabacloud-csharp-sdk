// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class CreateVpdRequest : TeaModel {
        /// <summary>
        /// <para>The CIDR block of the VPD.</para>
        /// <list type="bullet">
        /// <item><description>We recommend that you use an RFC private endpoint as the Lingjun CIDR block, such as 10.0.0.0/8,172.16.0.0/12,192.168.0.0/16. In scenarios where the Doringjun CIDR block is connected to each other or where the Lingjun CIDR block is connected to a VPC, make sure that the addresses do not conflict with each other.</description></item>
        /// <item><description>You can also use a custom CIDR block other than 100.64.0.0/10, 224.0.0.0/4, 127.0.0.0/8, or 169.254.0.0/16 and their subnets as the primary IPv4 CIDR block of the VPD.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/8</para>
        /// </summary>
        [NameInMap("Cidr")]
        [Validation(Required=false)]
        public string Cidr { get; set; }

        /// <summary>
        /// <para>The region ID of the disk.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// <para>For more information about resource groups, see <a href="https://help.aliyun.com/document_detail/94475.htm?spm=a2c4g.11186623.0.0.29e15d7akXhpuu">Resource groups</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2l4sq6l7unhi</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Lingjun subnet information list</para>
        /// </summary>
        [NameInMap("Subnets")]
        [Validation(Required=false)]
        public List<CreateVpdRequestSubnets> Subnets { get; set; }
        public class CreateVpdRequestSubnets : TeaModel {
            /// <summary>
            /// <para>The CIDR block of the Subnet.</para>
            /// <list type="bullet">
            /// <item><description>The network segment of the subnet must be a proper subset of the network segment of Lingjun to which it belongs, and the mask must be between 16 bits and 29 bits, which can provide 8 to 65536 addresses. For example, the CIDR block of the Lingjun CIDR block is 192.168.0.0/16, and the CIDR blocks of the subnets under the Lingjun CIDR block are 192.168.0.0/17 to 192.168.0.0/29.</description></item>
            /// <item><description>The first and last three IP addresses of each subnet segment are reserved by the system. For example, the CIDR blocks of the subnet are 192.168.1.0/24,192.168.1.0, 192.168.1.253, 192.168.1.254, and 192.168.1.255.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>10.1.0.0/16</para>
            /// </summary>
            [NameInMap("Cidr")]
            [Validation(Required=false)]
            public string Cidr { get; set; }

            /// <summary>
            /// <para>The region in which the instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-wulanchabu</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>Lingjun subnet instance name</para>
            /// 
            /// <b>Example:</b>
            /// <para>subnet-1</para>
            /// </summary>
            [NameInMap("SubnetName")]
            [Validation(Required=false)]
            public string SubnetName { get; set; }

            /// <summary>
            /// <para>Lingjun Subnet Usage Type; optional; optional. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Generic type is not specified</b>.</description></item>
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
            /// <para>The zone ID of the disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-wulanchabu-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>A tag.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateVpdRequestTag> Tag { get; set; }
        public class CreateVpdRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the VPN attachment.</para>
            /// <para>You cannot specify an empty string as a tag key. It can be up to 64 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// <para>You can specify at most 20 tag keys in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpd-wulanchabu</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the VPN connection.</para>
            /// <para>The tag value can be empty or a string of up to 128 characters. It cannot start with aliyun or acs:, and cannot contain http:// or https://.</para>
            /// <para>Each tag key corresponds to a tag value. You can enter a maximum of 20 tag values at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wulanchabu-a</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Lingjun CIDR block instance name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpd-1</para>
        /// </summary>
        [NameInMap("VpdName")]
        [Validation(Required=false)]
        public string VpdName { get; set; }

    }

}
