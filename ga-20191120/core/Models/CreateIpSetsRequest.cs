// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateIpSetsRequest : TeaModel {
        /// <summary>
        /// <para>The information about the acceleration regions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AccelerateRegion")]
        [Validation(Required=false)]
        public List<CreateIpSetsRequestAccelerateRegion> AccelerateRegion { get; set; }
        public class CreateIpSetsRequestAccelerateRegion : TeaModel {
            /// <summary>
            /// <para>The ID of the acceleration region.</para>
            /// <para>The number of regions that you can add varies based on the specification of the GA instance. For more information, see <a href="https://help.aliyun.com/document_detail/153127.html">Overview</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-huhehaote</para>
            /// </summary>
            [NameInMap("AccelerateRegionId")]
            [Validation(Required=false)]
            public string AccelerateRegionId { get; set; }

            /// <summary>
            /// <para>The bandwidth that you want to allocate to the acceleration region. Unit: <b>Mbit/s</b>.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is required.</description></item>
            /// <item><description>You must allocate at least 2 Mbit/s of bandwidth to each acceleration region.</description></item>
            /// <item><description>The total bandwidth of all acceleration regions cannot exceed the bandwidth limit of your basic bandwidth plan.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The IP version used to connect to the GA instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>IPv4</b> (default)</description></item>
            /// <item><description><b>IPv6</b></description></item>
            /// <item><description><b>DUAL_STACK</b>: IPv4 and IPv6</description></item>
            /// </list>
            /// <remarks>
            /// <para>Only pay-as-you-go standard GA instances support DUAL_STACK.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>IPv6</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// <para>The line type of the elastic IP address (EIP) in the acceleration region. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>BGP</b>: BGP (Multi-ISP) lines.</description></item>
            /// <item><description><b>BGP_PRO</b>: BGP (Multi-ISP) Pro lines</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is required only if the bandwidth metering method of the GA instance is <b>pay-by-data transfer</b>.</description></item>
            /// <item><description>Different acceleration regions support different line types of EIPs.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>BGP</para>
            /// </summary>
            [NameInMap("IspType")]
            [Validation(Required=false)]
            public string IspType { get; set; }

        }

        /// <summary>
        /// <para>The GA instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp1yeeq8yfoyszmqy****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1F4B6A4A-C89E-489E-BAF1-52777EE148EF</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The region ID of the GA instance. Set the value to <b>cn-hangzhou</b>.</para>
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
