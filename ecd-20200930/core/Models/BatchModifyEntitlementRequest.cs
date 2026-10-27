// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class BatchModifyEntitlementRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the cloud desktops for which you want to modify the authorized users.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>The user IDs, which are the usernames.</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public List<string> EndUserId { get; set; }

        /// <summary>
        /// <para>The number of cloud desktops assigned to each user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxDesktopPerUser")]
        [Validation(Required=false)]
        public int? MaxDesktopPerUser { get; set; }

        /// <summary>
        /// <para>The number of users assigned to each cloud desktop.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxUserPerDesktop")]
        [Validation(Required=false)]
        public int? MaxUserPerDesktop { get; set; }

        /// <summary>
        /// <para>Specifies whether to preview the assignment. A preview does not perform the actual assignment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Preview")]
        [Validation(Required=false)]
        public bool? Preview { get; set; }

        /// <summary>
        /// <para>The region ID. You can call DescribeRegions to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The policy used when proportional matching is not possible. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AVERAGE: Prioritizes assigning cloud desktops to each user. When the number of selected cloud desktops and users cannot be matched proportionally, cloud desktops are assigned to each user first.</description></item>
        /// <item><description>CENTRAL: Prioritizes assigning a specified number of cloud desktops to users. When the number of selected cloud desktops and users cannot be matched proportionally, the specified number of cloud desktops are assigned to users first.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AVERAGE</para>
        /// </summary>
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public string Strategy { get; set; }

    }

}
