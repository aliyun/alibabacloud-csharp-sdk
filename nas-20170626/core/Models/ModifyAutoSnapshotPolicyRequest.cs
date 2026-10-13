// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifyAutoSnapshotPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the automatic snapshot policy.</para>
        /// <para>You can call DescribeAutoSnapshotPolicies to query available automatic snapshot policies.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sp-extreme-233e6****</para>
        /// </summary>
        [NameInMap("AutoSnapshotPolicyId")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyId { get; set; }

        /// <summary>
        /// <para>The name of the automatic snapshot policy. If this parameter is left empty, the policy name is not modified.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 128 characters in length.</description></item>
        /// <item><description>The name must start with a letter.</description></item>
        /// <item><description>The name can contain digits, colons (:), underscores (_), and hyphens (-). The name cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FinanceJoshua</para>
        /// </summary>
        [NameInMap("AutoSnapshotPolicyName")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyName { get; set; }

        /// <summary>
        /// <para>The days of the week on which automatic snapshots are created.</para>
        /// <para>Cycle: week.</para>
        /// <para>Valid values: 1 to 7. For example, 1 indicates Monday. To create multiple automatic snapshots within a week, specify multiple days and separate them with commas (,). You can specify up to 7 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,7</para>
        /// </summary>
        [NameInMap("RepeatWeekdays")]
        [Validation(Required=false)]
        public string RepeatWeekdays { get; set; }

        /// <summary>
        /// <para>The retention period of automatic snapshots.</para>
        /// <para>Unit: days.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>-1 (default): Automatic snapshots are permanently retained.</description></item>
        /// <item><description>1 to 65536: Automatic snapshots are retained for the specified number of days.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("RetentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// <para>The points in time at which automatic snapshots are created.</para>
        /// <para>Unit: hours.</para>
        /// <para>Valid values: 0 to 23, which correspond to the 24 points in time from 00:00 to 23:00. For example, 1 indicates 01:00. To create multiple automatic snapshots within a day, specify multiple points in time and separate them with commas (,). You can specify up to 24 points in time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0,1</para>
        /// </summary>
        [NameInMap("TimePoints")]
        [Validation(Required=false)]
        public string TimePoints { get; set; }

    }

}
