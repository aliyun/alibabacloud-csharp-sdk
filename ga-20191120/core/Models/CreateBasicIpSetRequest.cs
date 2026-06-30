// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateBasicIpSetRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the region to be accelerated.</para>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/261190.html">ListAvailableBusiRegions</a> operation to query the active acceleration regions for the specified Alibaba Cloud Global Accelerator (GA) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("AccelerateRegionId")]
        [Validation(Required=false)]
        public string AccelerateRegionId { get; set; }

        /// <summary>
        /// <para>The instance ID of the basic Alibaba Cloud Global Accelerator (GA) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp17frjjh0udz4qz****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>The bandwidth of the acceleration area. Unit: <b>Mbps</b>.</para>
        /// <para>The minimum bandwidth that can be allocated to an acceleration area is 2 Mbps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of a request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The ISP type of the public network in the acceleration region. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BGP</b> (default): BGP (Multi-ISP)</description></item>
        /// <item><description><b>BGP_PRO</b>: BGP (Multi-ISP) Pro</description></item>
        /// </list>
        /// <para>If you are a whitelist user of single-ISP bandwidth, you can also select the following types:</para>
        /// <list type="bullet">
        /// <item><description><b>ChinaTelecom</b>: China Telecom (single ISP)</description></item>
        /// <item><description><b>ChinaUnicom</b>: China Unicom (single ISP)</description></item>
        /// <item><description><b>ChinaMobile</b>: China Shift (single ISP)</description></item>
        /// <item><description><b>ChinaTelecom_L2</b>: China Telecom (single ISP)_L2</description></item>
        /// <item><description><b>ChinaUnicom_L2</b>: China Unicom (single ISP)_L2</description></item>
        /// <item><description><b>ChinaMobile_L2</b>: China Shift (single ISP)_L2<remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required for basic Alibaba Cloud Global Accelerator (GA) instances that use the <b>pay-by-traffic</b> billing method.</description></item>
        /// <item><description>If the acceleration region of the basic Alibaba Cloud Global Accelerator (GA) instance is Hong Kong (China) and the instance is attached with a basic bandwidth plan of the BGP (Multi-ISP) Pro type, the default value is BGP (Multi-ISP) Pro.</description></item>
        /// <item><description>The supported single-ISP line types vary by acceleration region.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BGP</para>
        /// </summary>
        [NameInMap("IspType")]
        [Validation(Required=false)]
        public string IspType { get; set; }

        /// <summary>
        /// <para>The region ID of the basic Alibaba Cloud Global Accelerator (GA) instance. Set the value to <b>ap-southeast-1</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
