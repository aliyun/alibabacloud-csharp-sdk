// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class MigrateDesktopsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of cloud computers. You can specify 1 to 100 IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The member IP address of the target node for migration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.1.10</para>
        /// </summary>
        [NameInMap("TargetMemberIp")]
        [Validation(Required=false)]
        public string TargetMemberIp { get; set; }

        /// <summary>
        /// <para>The ID of the target office network.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen+dir-388505****</para>
        /// </summary>
        [NameInMap("TargetOfficeSiteId")]
        [Validation(Required=false)]
        public string TargetOfficeSiteId { get; set; }

        /// <summary>
        /// <remarks>
        /// <para>This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1m3o4kbjxwe****</para>
        /// </summary>
        [NameInMap("TargetSubnetId")]
        [Validation(Required=false)]
        public string TargetSubnetId { get; set; }

    }

}
