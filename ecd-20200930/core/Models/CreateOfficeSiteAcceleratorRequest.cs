// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateOfficeSiteAcceleratorRequest : TeaModel {
        /// <summary>
        /// <para>The list of acceleration region information for the access points.</para>
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
            /// <para>The IP address protocol used to connect to the GA service.</para>
            /// <remarks>
            /// <para>The <c>DUAL_STACK</c> type is supported only by standard pay-as-you-go GA instances.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>IPv4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public string IpVersion { get; set; }

            /// <summary>
            /// <para>The public network line type of the acceleration region.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Configure this parameter for GA instances that use the <b>pay-by-data-transfer</b> billing method.</description></item>
            /// <item><description>The supported public network line types vary by acceleration region.</description></item>
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
