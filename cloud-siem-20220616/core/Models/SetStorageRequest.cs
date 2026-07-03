// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class SetStorageRequest : TeaModel {
        /// <summary>
        /// <para>The log storage region.</para>
        /// <para>If the Data Management center is in cn-hangzhou, the default value of Region is <b>cn-shanghai</b>. If the Data Management center is in <b>ap-southeast-1</b>, the default value of <b>Region</b> is <b>ap-southeast-1</b>.</para>
        /// <para>The log storage region cannot be changed. To change the region, contact the Threat Analysis operations team.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The region of the Data Management center for Threat Analysis. Select the region for the Data Management center based on the region of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Select this value if your assets are in the Chinese mainland or China (Hong Kong).</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Select this value if your assets are in a region outside the Chinese mainland.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID of the member. An administrator can use this parameter to switch to the view of a specific member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The type of the view.</para>
        /// <list type="bullet">
        /// <item><description><para>0: The view of the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>1: The view of all accounts in your enterprise.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// <para>The log storage duration in days. The default value is 180. The minimum value is 30 and the maximum value is 3000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180</para>
        /// </summary>
        [NameInMap("Ttl")]
        [Validation(Required=false)]
        public int? Ttl { get; set; }

    }

}
