// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class EnableAccessForCloudSiemRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically add alert logs from Security Center, Web Application Firewall (WAF), and Cloud Firewall. By default, alert logs are automatically added.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoSubmit")]
        [Validation(Required=false)]
        public int? AutoSubmit { get; set; }

        /// <summary>
        /// <para>The region of the Data Management center for Threat Analysis. Select the region based on where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Your assets are in the Chinese mainland or Hong Kong (China).</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Your assets are in regions outside China.</para>
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
        /// <para>The user ID of a member. An administrator can use this parameter to switch to the perspective of the specified member.</para>
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
        /// <item><description><para>1: The view of all member accounts.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

    }

}
