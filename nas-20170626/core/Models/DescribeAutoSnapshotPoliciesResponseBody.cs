// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeAutoSnapshotPoliciesResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried automatic snapshot policies.</para>
        /// </summary>
        [NameInMap("AutoSnapshotPolicies")]
        [Validation(Required=false)]
        public DescribeAutoSnapshotPoliciesResponseBodyAutoSnapshotPolicies AutoSnapshotPolicies { get; set; }
        public class DescribeAutoSnapshotPoliciesResponseBodyAutoSnapshotPolicies : TeaModel {
            [NameInMap("AutoSnapshotPolicy")]
            [Validation(Required=false)]
            public List<DescribeAutoSnapshotPoliciesResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicy> AutoSnapshotPolicy { get; set; }
            public class DescribeAutoSnapshotPoliciesResponseBodyAutoSnapshotPoliciesAutoSnapshotPolicy : TeaModel {
                /// <summary>
                /// <para>The ID of the automatic snapshot policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sp-extreme-233e6****</para>
                /// </summary>
                [NameInMap("AutoSnapshotPolicyId")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyId { get; set; }

                /// <summary>
                /// <para>The name of the automatic snapshot policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FinanceJoshua</para>
                /// </summary>
                [NameInMap("AutoSnapshotPolicyName")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyName { get; set; }

                /// <summary>
                /// <para>The time when the automatic snapshot policy was created.</para>
                /// <para>The time follows the <a href="https://www.iso.org/iso-8601-date-and-time-format.html">ISO8601</a> standard in the <c>yyyy-MM-ddTHH:mm:ssZ</c> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2014-04-21T12:08:52Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The number of file systems to which the automatic snapshot policy applies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("FileSystemNums")]
                [Validation(Required=false)]
                public int? FileSystemNums { get; set; }

                /// <summary>
                /// <para>The type of the file system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>extreme</para>
                /// </summary>
                [NameInMap("FileSystemType")]
                [Validation(Required=false)]
                public string FileSystemType { get; set; }

                /// <summary>
                /// <para>The region ID of the automatic snapshot policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The days of a week on which auto snapshots are created.</para>
                /// <para>Auto snapshots are created on a weekly basis.</para>
                /// <para>Valid values: 1 to 7. The values from 1 to 7 indicate 7 days in a week from Monday to Sunday.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1,5</para>
                /// </summary>
                [NameInMap("RepeatWeekdays")]
                [Validation(Required=false)]
                public string RepeatWeekdays { get; set; }

                /// <summary>
                /// <para>The retention period of auto snapshots.</para>
                /// <para>Unit: days.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>\-1: Auto snapshots are permanently retained. After the number of auto snapshots exceeds the upper limit, the earliest auto snapshot is automatically deleted.</description></item>
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
                /// <para>The status of the automatic snapshot policy.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Creating: The automatic snapshot policy is being created.</description></item>
                /// <item><description>Available: The automatic snapshot policy is available.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The points in time at which auto snapshots are created.</para>
                /// <para>Unit: hours.</para>
                /// <para>Valid values: <c>0 to 23</c>. The values from 0 to 23 indicate a total of 24 hours from <c>00:00 to 23:00</c>. For example, 1 indicates 01:00. A maximum of 24 points in time can be returned. Multiple points in time are separated with commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>4,19</para>
                /// </summary>
                [NameInMap("TimePoints")]
                [Validation(Required=false)]
                public string TimePoints { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of automatic snapshot policies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
