// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateAutoSnapshotPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The name of the automatic snapshot policy.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 2 to 128 characters in length.</description></item>
        /// <item><description>The name must start with a letter.</description></item>
        /// <item><description>The name can contain digits, colons (:), underscores (_), and hyphens (-). It cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>This parameter is empty by default.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FinanceJoshua</para>
        /// </summary>
        [NameInMap("AutoSnapshotPolicyName")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyName { get; set; }

        /// <summary>
        /// <para>The type of the file system.</para>
        /// <para>Valid value: extreme, which indicates Extreme NAS file systems.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>extreme</para>
        /// </summary>
        [NameInMap("FileSystemType")]
        [Validation(Required=false)]
        public string FileSystemType { get; set; }

        /// <summary>
        /// <para>The days of a week on which to create automatic snapshots.</para>
        /// <para>Cycle: week.</para>
        /// <para>Valid values: 1 to 7. The values from 1 to 7 indicate the seven days in a week from Monday to Sunday.</para>
        /// <para>If you want to create multiple auto snapshots within a week, you can specify multiple days from Monday to Sunday and separate the days with commas (,). You can specify a maximum of seven days.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("RepeatWeekdays")]
        [Validation(Required=false)]
        public string RepeatWeekdays { get; set; }

        /// <summary>
        /// <para>The retention period of auto snapshots.</para>
        /// <para>Unit: days.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>\-1 (default). Auto snapshots are permanently retained. After the number of auto snapshots exceeds the upper limit, the earliest auto snapshot is automatically deleted.</description></item>
        /// <item><description>1 to 65536: Auto snapshots are retained for the specified days. After the retention period of auto snapshots expires, the auto snapshots are automatically deleted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("RetentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// <para>The points in time at which auto snapshots were created.</para>
        /// <para>Unit: hours.</para>
        /// <para>Valid values: 0 to 23. The values from 0 to 23 indicate a total of 24 hours from 00:00 to 23:00. For example, the value 1 indicates 01:00.</para>
        /// <para>If you want to create multiple auto snapshots within a day, you can specify multiple points in time and separate the points in time with commas (,). You can specify a maximum of 24 points in time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0,1,…23</para>
        /// </summary>
        [NameInMap("TimePoints")]
        [Validation(Required=false)]
        public string TimePoints { get; set; }

    }

}
