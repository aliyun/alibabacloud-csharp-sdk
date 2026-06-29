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
        /// <item><description>The name must start with a letter or a Chinese character.</description></item>
        /// <item><description>The name can contain digits, colons (:), underscores (_), or hyphens (-). It cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>Default value: empty.</description></item>
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
        /// <para>Valid values: extreme (Extreme NAS).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>extreme</para>
        /// </summary>
        [NameInMap("FileSystemType")]
        [Validation(Required=false)]
        public string FileSystemType { get; set; }

        /// <summary>
        /// <para>The days of the week on which automatic snapshots are created.</para>
        /// <para>Cycle: week.</para>
        /// <para>Valid values: 1 to 7, which represent Monday through Sunday.</para>
        /// <para>To create automatic snapshots on multiple days in a week, specify multiple values separated by commas (,). You can specify a maximum of 7 values.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("RepeatWeekdays")]
        [Validation(Required=false)]
        public string RepeatWeekdays { get; set; }

        /// <summary>
        /// <para>The retention period of automatic snapshots.</para>
        /// <para>Unit: days.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>-1 (default): Automatic snapshots are permanently retained. When the snapshot quota is reached, the earliest automatic snapshots are automatically deleted.</description></item>
        /// <item><description>1 to 65536: Automatic snapshots are retained for the specified number of days. Snapshots are subject to automatic release after the retention period expires.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("RetentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// <para>The time points at which automatic snapshots are created.</para>
        /// <para>Unit: hours.</para>
        /// <para>Valid values: 0 to 23, which represent the 24 time points from 00:00 to 23:00. For example, 1 indicates 01:00.</para>
        /// <para>To create multiple automatic snapshots within a day, specify multiple time points separated by commas (,). You can specify a maximum of 24 time points.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0,1,…,23</para>
        /// </summary>
        [NameInMap("TimePoints")]
        [Validation(Required=false)]
        public string TimePoints { get; set; }

    }

}
