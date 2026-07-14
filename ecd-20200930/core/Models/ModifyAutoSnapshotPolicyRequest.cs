// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyAutoSnapshotPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The cron expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 20 16 ? * 1,2,3,4,5,6,7</para>
        /// </summary>
        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <para>The type of cloud disk for which the automatic snapshot policy creates snapshots.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>The ID of the automatic snapshot policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-itcmrhqt01tdo****</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The name of the automatic snapshot policy. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. The name can contain digits, colons (:), underscores (_), or hyphens (-). Default value: empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>系统自动快照</para>
        /// </summary>
        [NameInMap("PolicyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The retention period of automatic snapshots. Unit: days. Valid values: 1 to 180.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RetentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

    }

}
