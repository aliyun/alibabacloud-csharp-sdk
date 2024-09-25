// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class AllocateEipSegmentAddressRequest : TeaModel {
        /// <summary>
        /// <para>The maximum bandwidth of the contiguous EIP group. Unit: Mbit/s.</para>
        /// <list type="bullet">
        /// <item><description>Valid values when <b>InstanceChargeType</b> is set to <b>PostPaid</b> and <b>InternetChargeType</b> is set to <b>PayByBandwidth</b>: <b>1</b> to <b>500</b>.****</description></item>
        /// <item><description>Valid values when <b>InstanceChargeType</b> is set to <b>PostPaid</b> and <b>InternetChargeType</b> is set to <b>PayByTraffic</b>: <b>1</b> to <b>200</b>.****</description></item>
        /// <item><description>Valid values when <b>InstanceChargeType</b> is set to <b>PrePaid</b>: <b>1</b> to <b>1000</b>.****</description></item>
        /// </list>
        /// <para>Default value: <b>5</b>. Unit: Mbit/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public string Bandwidth { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate a token, but you must make sure that the token is unique among different requests. <b>ClientToken</b> can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The subnet mask of the contiguous EIP group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>28</b>: applies for 16 contiguous EIPs in each call.</description></item>
        /// <item><description><b>27</b>: applies for 32 contiguous EIPs in each call.</description></item>
        /// <item><description><b>26</b>: applies for 64 contiguous EIPs in each call.</description></item>
        /// <item><description><b>25</b>: applies for 128 contiguous EIPs in each call.</description></item>
        /// <item><description><b>24</b>: applies for 256 contiguous EIPs in each call.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Some IP address are reserved for specific purposes. Therefore, the actual number of the contiguous EIPs may be one, three, or four less than the expected number.</para>
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
        /// <para>The metering method of contiguous EIPs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PayByBandwidth</b> (default)</description></item>
        /// <item><description><b>PayByTraffic</b></description></item>
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
        /// <item><description><b>BGP</b> (default): BGP (Multi-ISP) line The BGP (Multi-ISP) line is supported in all regions.</description></item>
        /// <item><description><b>BGP_PRO</b>: BGP (Multi-ISP) Pro line BGP (Multi-ISP) Pro line is supported only in the China (Hong Kong), Singapore, Japan (Tokyo), Malaysia (Kuala Lumpur), Philippines (Manila), Indonesia (Jakarta), and Thailand (Bangkok) regions.</description></item>
        /// </list>
        /// <para>For more information about the BGP (Multi-ISP) line and BGP (Multi-ISP) Pro line, see <a href="https://help.aliyun.com/document_detail/32321.html">EIP line types</a>.</para>
        /// <para>If you are allowed to use single-ISP bandwidth, you can also use one of the following values:</para>
        /// <list type="bullet">
        /// <item><description><b>ChinaTelecom</b></description></item>
        /// <item><description><b>ChinaUnicom</b></description></item>
        /// <item><description><b>ChinaMobile</b></description></item>
        /// <item><description><b>ChinaTelecom_L2</b></description></item>
        /// <item><description><b>ChinaUnicom_L2</b></description></item>
        /// <item><description><b>ChinaMobile_L2</b></description></item>
        /// </list>
        /// <para>If your services are deployed in China East 1 Finance, this parameter is required and you must set the parameter to <b>BGP_FinanceCloud</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BGP</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>The network type. Set the value to <b>public</b>, which specifies the public network type.</para>
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
        /// <para>The ID of the region in which the contiguous EIP group resides.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
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
