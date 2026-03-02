// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateOfficeSiteAcceleratorRequest : TeaModel {
        /// <summary>
        /// <para>The regions to include in global acceleration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AccelerateRegion")]
        [Validation(Required=false)]
        public List<CreateOfficeSiteAcceleratorRequestAccelerateRegion> AccelerateRegion { get; set; }
        public class CreateOfficeSiteAcceleratorRequestAccelerateRegion : TeaModel {
            /// <summary>
            /// <para>The ID of the region to include in global acceleration.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-southeast-1</para>
            /// </summary>
            [NameInMap("AccelerateRegionId")]
            [Validation(Required=false)]
            public string AccelerateRegionId { get; set; }

            /// <summary>
            /// <para>The bandwidth that you want to allocate to the acceleration region. Unit: Mbit/s.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The IP version used to connect to the GA instance.</para>
            /// <remarks>
            /// <para> Only pay-as-you-go standard GA instances support <c>DUAL_STACK</c>.</para>
            /// </remarks>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DUAL_STACK: IPv4 and IPv6.</description></item>
            /// <item><description>IPv6: IPv6.</description></item>
            /// <item><description>IPv4 (default): IPv4.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// <para>The line type of the elastic IP address (EIP) in the acceleration region.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter is required only if the bandwidth metering method of the GA instance is <b>pay-by-data transfer</b>.</para>
            /// </description></item>
            /// <item><description><para>Different acceleration regions support different line types of EIPs.</para>
            /// </description></item>
            /// </list>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>BGP: BGP (Multi-ISP) lines.</description></item>
            /// <item><description>BGP_PRO: BGP (Multi-ISP) Pro.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BGP</para>
            /// </summary>
            [NameInMap("IspType")]
            [Validation(Required=false)]
            public string IspType { get; set; }

        }

        /// <summary>
        /// <para>The name of the GA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testGA</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The office network ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai+dir-259382****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-3mtuc28rx95lx****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
