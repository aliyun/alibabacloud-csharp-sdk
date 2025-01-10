// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class CreateVccRequest : TeaModel {
        /// <summary>
        /// <para>Enabled access to cloud services. Optional values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enable access to cloud services</description></item>
        /// <item><description><b>false</b>: Do not enable access to cloud services</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AccessCouldService")]
        [Validation(Required=false)]
        public bool? AccessCouldService { get; set; }

        /// <summary>
        /// <para>The bandwidth. Unit: Mbit /s. The minimum value is 1000, representing 1Gbps bandwidth; the maximum value is 400000, representing 400Gbps bandwidth.</para>
        /// <remarks>
        /// <para> 1Gbps = 1000Mbps</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>bgp as number</para>
        /// 
        /// <b>Example:</b>
        /// <para>bgpAsn</para>
        /// </summary>
        [NameInMap("BgpAsn")]
        [Validation(Required=false)]
        public long? BgpAsn { get; set; }

        /// <summary>
        /// <para>Internet segment, on-premises input, off-premises default</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.0.0.0/24</para>
        /// </summary>
        [NameInMap("BgpCidr")]
        [Validation(Required=false)]
        public string BgpCidr { get; set; }

        /// <summary>
        /// <para>CEN Instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-bkiw0x1347roekr7f2</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>Account to which cen belongs</para>
        /// 
        /// <b>Example:</b>
        /// <para>1511928242963727</para>
        /// </summary>
        [NameInMap("CenOwnerId")]
        [Validation(Required=false)]
        public string CenOwnerId { get; set; }

        /// <summary>
        /// <para>The connection mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b></description></item>
        /// <item><description><b>CEN (CENTR)</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CENTR</para>
        /// </summary>
        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// <para>The description of the document.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
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
        /// <para>rg-aeky5f3qx6ceapq</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tag information.</para>
        /// <para>You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateVccRequestTag> Tag { get; set; }
        public class CreateVccRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the VPN attachment.</para>
            /// <para>You cannot specify an empty string as a tag key. It can be up to 64 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// <para>You can specify at most 20 tag keys in each call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-vcc</para>
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
            /// <para>vcc-group-1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the vSwitch. <a href="https://help.aliyun.com/document_detail/100380.html">Virtual Private Cloud VSwitch</a>.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/35748.html">DescribeVSwitches</a> operation to query created vSwitches.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-t4nahb0pxckgktx1kot8q</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the Lingjun connection instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vcc-cn-zvp2w222001</para>
        /// </summary>
        [NameInMap("VccId")]
        [Validation(Required=false)]
        public string VccId { get; set; }

        /// <summary>
        /// <para>Lingjun Connection Name</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("VccName")]
        [Validation(Required=false)]
        public string VccName { get; set; }

        /// <summary>
        /// <para>Virtual Private Cloud IDs; <a href="https://help.aliyun.com/document_detail/34217.html">What is Virtual Private Cloud</a></para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/35739.html#demo-0">DescribeVpcs</a> operation to query the specified VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-uf6aa4ddo97frj22tgp52</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>Lingjun CIDR block instance ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpd-t2jseldp</para>
        /// </summary>
        [NameInMap("VpdId")]
        [Validation(Required=false)]
        public string VpdId { get; set; }

        /// <summary>
        /// <para>The zone ID of the disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-wulanchabu-a</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
