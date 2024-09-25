// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyNatGatewayAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The description of the NAT gateway.</para>
        /// <para>The description must be 1 to 128 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The mode in which the NAT gateway is associated with an elastic IP address (EIP). You can leave this parameter empty. If you want to specify a value for this parameter, set the value to <b>NAT</b>, which indicates that the NAT gateway is associated with the EIP in NAT mode.</para>
        /// <para>**</para>
        /// <para><b>Description</b></para>
        /// <list type="bullet">
        /// <item><description><para>If EipBindMode is set to MULTI_BINDED when the NAT gateway is created, you can change the value of this parameter from <b>MULTI_BINDED</b> to <b>NAT</b>. If EipBindMode is set to NAT when the NAT gateway is created, you cannot change the value of this parameter from <b>NAT</b> to <b>MULTI_BINDED</b>. For more information about <b>MULTI_BINDED</b>, see <a href="https://help.aliyun.com/document_detail/120219.html">CreateNatGateway</a>.</para>
        /// </description></item>
        /// <item><description><para>When the mode in which the NAT gateway is associated with an EIP is being changed, a transient connection that lasts a few seconds may occur. If the number of EIPs with which the NAT gateway is associated increases, the transient connection lasts longer. You can change the mode only for a NAT gateway that is associated with up to five EIPs. We recommend that you change the mode during off-peak hours.</para>
        /// </description></item>
        /// <item><description><para>After the mode is changed to <b>NAT</b>, the Internet NAT gateway is compatible with the IPv4 gateway. However, if you associate an EIP with the NAT gateway, the EIP occupies one private IP address on the vSwitch of the NAT gateway. Make sure that the vSwitch has sufficient private IP addresses. Otherwise, the EIP fails to be associated with the NAT gateway.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NAT</para>
        /// </summary>
        [NameInMap("EipBindMode")]
        [Validation(Required=false)]
        public string EipBindMode { get; set; }

        [NameInMap("EnableSessionLog")]
        [Validation(Required=false)]
        public bool? EnableSessionLog { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Internet Control Message Protocol (ICMP) non-retrieval feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default)</description></item>
        /// <item><description><b>true</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IcmpReplyEnabled")]
        [Validation(Required=false)]
        public bool? IcmpReplyEnabled { get; set; }

        [NameInMap("LogDelivery")]
        [Validation(Required=false)]
        public ModifyNatGatewayAttributeRequestLogDelivery LogDelivery { get; set; }
        public class ModifyNatGatewayAttributeRequestLogDelivery : TeaModel {
            [NameInMap("LogDeliveryType")]
            [Validation(Required=false)]
            public string LogDeliveryType { get; set; }

            [NameInMap("LogDestination")]
            [Validation(Required=false)]
            public string LogDestination { get; set; }

        }

        /// <summary>
        /// <para>The name of the NAT gateway.</para>
        /// <para>The name must be 1 to 128 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nat123</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the NAT gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-2ze0dcn4mq31qx2jc****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the NAT gateway.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
