// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class BatchModifyEntitlementRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the cloud computers for which you want to modify authorized users.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>The user IDs (usernames).</para>
        /// </summary>
        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public List<string> EndUserId { get; set; }

        /// <summary>
        /// <para>The number of cloud computers to assign to each user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxDesktopPerUser")]
        [Validation(Required=false)]
        public int? MaxDesktopPerUser { get; set; }

        /// <summary>
        /// <para>The number of users to assign to each cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxUserPerDesktop")]
        [Validation(Required=false)]
        public int? MaxUserPerDesktop { get; set; }

        /// <summary>
        /// <para>Specifies whether to preview the assignment. If set to true, the assignment is not actually performed.</para>
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
        /// <para>The policy used when the ratio of cloud computers to users cannot be evenly matched. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AVERAGE: prioritizes assigning a cloud computer to each user. When the number of selected cloud computers and users cannot be evenly matched, the system prioritizes assigning a cloud computer to each user.</para>
        /// </description></item>
        /// <item><description><para>CENTRAL: prioritizes assigning the specified number of cloud computers to users. When the number of selected cloud computers and users cannot be evenly matched, the system prioritizes assigning the specified number of cloud computers to users.</para>
        /// </description></item>
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
