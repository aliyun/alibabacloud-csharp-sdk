// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AllocateEipSegmentAddressRequest : TeaModel {
        /// <summary>
        /// <para>The peak bandwidth of the EIP. Unit: Mbit/s.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>InternetChargeType</b> is set to <b>PayByBandwidth</b>, the valid values for <b>Bandwidth</b> are <b>1</b> to <b>500</b>.</para>
        /// </description></item>
        /// <item><description><para>If <b>InternetChargeType</b> is set to <b>PayByTraffic</b>, the valid values for <b>Bandwidth</b> are <b>1</b> to <b>200</b>.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>5</b> Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate a parameter value from your client to ensure that the value is unique among different requests. <b>ClientToken</b> only supports ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The subnet mask of the contiguous EIPs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>28</b>: The system allocates 16 contiguous EIPs per call.</para>
        /// </description></item>
        /// <item><description><para><b>27</b>: The system allocates 32 contiguous EIPs per call.</para>
        /// </description></item>
        /// <item><description><para><b>26</b>: The system allocates 64 contiguous EIPs per call.</para>
        /// </description></item>
        /// <item><description><para><b>25</b>: The system allocates 128 contiguous EIPs per call.</para>
        /// </description></item>
        /// <item><description><para><b>24</b>: The system allocates 256 contiguous EIPs per call.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Due to IP address reservation, the actual number of contiguous EIPs allocated may be 1, 3, or 4 fewer than expected.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28</para>
        /// </summary>
        [NameInMap("EipMask")]
        [Validation(Required=false)]
        public string EipMask { get; set; }

        /// <summary>
        /// <para>The billing method of the contiguous EIPs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PayByBandwidth</b> (default): pay-by-bandwidth.</para>
        /// </description></item>
        /// <item><description><para><b>PayByTraffic</b>: pay-by-data-transfer.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PayByBandwidth</para>
        /// </summary>
        [NameInMap("InternetChargeType")]
        [Validation(Required=false)]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// <para>The line type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BGP</b> (default): BGP (Multi-ISP) line. BGP (Multi-ISP) EIPs are supported in all regions.</description></item>
        /// <item><description><b>BGP_PRO</b>: BGP (Multi-ISP) Pro line. BGP (Multi-ISP) Pro EIPs are supported only in the Hong Kong (China), Singapore, Japan (Tokyo), Malaysia (Kuala Lumpur), Philippines (Manila), Indonesia (Jakarta), and Thailand (Bangkok) regions.</description></item>
        /// </list>
        /// <para>For more information about BGP (Multi-ISP) and BGP (Multi-ISP) Pro lines, see <a href="https://help.aliyun.com/document_detail/32321.html">EIP line types</a>.</para>
        /// <para>If you are a single-ISP bandwidth whitelist user, you can also select the following types:</para>
        /// <list type="bullet">
        /// <item><description><b>ChinaTelecom</b>: China Telecom</description></item>
        /// <item><description><b>ChinaUnicom</b>: China Unicom</description></item>
        /// <item><description><b>ChinaMobile</b>: China Mobile</description></item>
        /// <item><description><b>ChinaTelecom_L2</b>: China Telecom L2</description></item>
        /// <item><description><b>ChinaUnicom_L2</b>: China Unicom L2</description></item>
        /// <item><description><b>ChinaMobile_L2</b>: China Mobile L2</description></item>
        /// </list>
        /// <para>If you are an Alibaba Finance Cloud user in the China (Hangzhou) region, this parameter is required. Set the value to <b>BGP_FinanceCloud</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BGP</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The network type. Set the value to <b>public</b>, which indicates the Internet.</para>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("Netmode")]
        [Validation(Required=false)]
        public string Netmode { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the contiguous EIPs.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4ph****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The zone of the contiguous EIP group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-a</para>
        /// </summary>
        [NameInMap("Zone")]
        [Validation(Required=false)]
        public string Zone { get; set; }

    }

}
