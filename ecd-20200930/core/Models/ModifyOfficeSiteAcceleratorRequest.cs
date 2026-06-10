// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyOfficeSiteAcceleratorRequest : TeaModel {
        /// <summary>
        /// <para>The information about the regions to accelerate.</para>
        /// </summary>
        [NameInMap("AccelerateRegion")]
        [Validation(Required=false)]
        public List<ModifyOfficeSiteAcceleratorRequestAccelerateRegion> AccelerateRegion { get; set; }
        public class ModifyOfficeSiteAcceleratorRequestAccelerateRegion : TeaModel {
            /// <summary>
            /// <para>The ID of the region to accelerate.</para>
            /// <para>The number of regions that you can add is limited by the total bandwidth and the instance type of the GA instance. For more information about the number of access regions supported by each instance type, see <a href="t1855472.xdita#">Overview of GA instances</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("AccelerateRegionId")]
            [Validation(Required=false)]
            public string AccelerateRegionId { get; set; }

            /// <summary>
            /// <para>The peak public bandwidth. Unit: Mbps.</para>
            /// <remarks>
            /// <para>For the pay-by-bandwidth metering method, the value ranges from 10 to 1000.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The IP protocol version used to access GA instances. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>IPv4</b> (default)</para>
            /// </description></item>
            /// <item><description><para><b>IPv6</b></para>
            /// </description></item>
            /// <item><description><para><b>DUAL_STACK</b>: IPv4 and IPv6</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Only standard pay-as-you-go GA instances support the DUAL_STACK option.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// <para>The Internet line type in the acceleration region. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>BGP</b>: BGP (Multi-ISP) lines.</para>
            /// </description></item>
            /// <item><description><para><b>BGP_PRO</b>: BGP (Multi-ISP) Pro lines.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter is required for GA instances that use the pay-by-data-transfer metering method.</para>
            /// </description></item>
            /// <item><description><para>The supported line types vary based on the acceleration region.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
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
        /// <para>The office network ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-363353****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
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
