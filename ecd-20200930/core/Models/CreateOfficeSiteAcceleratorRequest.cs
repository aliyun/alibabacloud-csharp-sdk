// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateOfficeSiteAcceleratorRequest : TeaModel {
        /// <summary>
        /// <para>The list of acceleration regions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AccelerateRegion")]
        [Validation(Required=false)]
        public List<CreateOfficeSiteAcceleratorRequestAccelerateRegion> AccelerateRegion { get; set; }
        public class CreateOfficeSiteAcceleratorRequestAccelerateRegion : TeaModel {
            /// <summary>
            /// <para>The ID of the acceleration region.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ap-southeast-1</para>
            /// </summary>
            [NameInMap("AccelerateRegionId")]
            [Validation(Required=false)]
            public string AccelerateRegionId { get; set; }

            /// <summary>
            /// <para>The bandwidth allocated to the acceleration region. Unit: Mbit/s.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// <para>The IP address protocol used to access the Global Accelerator (GA) service.</para>
            /// <remarks>
            /// <para>The <c>DUAL_STACK</c> type is supported only by standard Alibaba Cloud Global Accelerator (GA) instances that use the pay-as-you-go billing method.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// <para>The Internet line type of the acceleration region.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is required for Alibaba Cloud Global Accelerator (GA) instances that use the <b>pay-by-traffic</b> Billable methods.</description></item>
            /// <item><description>The supported Internet line types vary based on the acceleration region.</description></item>
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
        /// <para>The name of the Alibaba Cloud Global Accelerator (GA) instance.</para>
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
