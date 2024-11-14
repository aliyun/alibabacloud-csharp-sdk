// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class UpdateEnterpriseSnapshotPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Snapshot replication destination information.</para>
        /// </summary>
        [NameInMap("CrossRegionCopyInfo")]
        [Validation(Required=false)]
        public UpdateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfo CrossRegionCopyInfo { get; set; }
        public class UpdateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfo : TeaModel {
            /// <summary>
            /// <para>Whether cross-region replication is enabled. The range of values:</para>
            /// <list type="bullet">
            /// <item><description><para>true</para>
            /// </description></item>
            /// <item><description><para>false</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>Destination region information.</para>
            /// </summary>
            [NameInMap("Regions")]
            [Validation(Required=false)]
            public List<UpdateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfoRegions> Regions { get; set; }
            public class UpdateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfoRegions : TeaModel {
                /// <summary>
                /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/354276.html">DescribeRegions</a> operation to query the most recent list of regions in which async replication is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>Number of days to retain the destination snapshot. The range of values is greater than 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("RetainDays")]
                [Validation(Required=false)]
                public int? RetainDays { get; set; }

            }

        }

        /// <summary>
        /// <para>The description of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// <para>The name of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The id of the policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esp-xxx</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The region ID . You can call the <a href="https://help.aliyun.com/document_detail/354276.html">DescribeRegions</a> operation to query the most recent list of regions in which snapshot policy is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Snapshot retention rule.</para>
        /// </summary>
        [NameInMap("RetainRule")]
        [Validation(Required=false)]
        public UpdateEnterpriseSnapshotPolicyRequestRetainRule RetainRule { get; set; }
        public class UpdateEnterpriseSnapshotPolicyRequestRetainRule : TeaModel {
            /// <summary>
            /// <para>Maximum number of retained snapshots.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

            /// <summary>
            /// <para>The time interval , valid value greater than 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14</para>
            /// </summary>
            [NameInMap("TimeInterval")]
            [Validation(Required=false)]
            public int? TimeInterval { get; set; }

            /// <summary>
            /// <para>The unit of time, valid values:</para>
            /// <list type="bullet">
            /// <item><description>DAYS</description></item>
            /// <item><description>WEEKS</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DAYS</para>
            /// </summary>
            [NameInMap("TimeUnit")]
            [Validation(Required=false)]
            public string TimeUnit { get; set; }

        }

        /// <summary>
        /// <para>The rule for scheduling.</para>
        /// </summary>
        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public UpdateEnterpriseSnapshotPolicyRequestSchedule Schedule { get; set; }
        public class UpdateEnterpriseSnapshotPolicyRequestSchedule : TeaModel {
            /// <summary>
            /// <para>The time when the policy will to be scheduled. Valid values: Set the parameter in a cron expression.</para>
            /// <para>For example, you can use <c>0 0 4 1/1 * ?</c> to specify 04:00:00 (UTC+8) on the first day of each month.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

        }

        /// <summary>
        /// <para>The special snapshot retention rules.</para>
        /// </summary>
        [NameInMap("SpecialRetainRules")]
        [Validation(Required=false)]
        public UpdateEnterpriseSnapshotPolicyRequestSpecialRetainRules SpecialRetainRules { get; set; }
        public class UpdateEnterpriseSnapshotPolicyRequestSpecialRetainRules : TeaModel {
            /// <summary>
            /// <para>Indicates whether the special retention is enabled.</para>
            /// <list type="bullet">
            /// <item><description>true: enable</description></item>
            /// <item><description>false: disable</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The special retention rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<UpdateEnterpriseSnapshotPolicyRequestSpecialRetainRulesRules> Rules { get; set; }
            public class UpdateEnterpriseSnapshotPolicyRequestSpecialRetainRulesRules : TeaModel {
                /// <summary>
                /// <para>The periodic unit for specially retained snapshots. If configured to WEEKS, it provides special retention for the first snapshot of each week. The retention period is determined by TimeUnit and TimeInterval. The range of values are:</para>
                /// <list type="bullet">
                /// <item><description>WEEKS</description></item>
                /// <item><description>MONTHS</description></item>
                /// <item><description>YEARS&quot;</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>WEEKS</para>
                /// </summary>
                [NameInMap("SpecialPeriodUnit")]
                [Validation(Required=false)]
                public string SpecialPeriodUnit { get; set; }

                /// <summary>
                /// <para>Retention Time Value. The range of values is greater than 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("TimeInterval")]
                [Validation(Required=false)]
                public int? TimeInterval { get; set; }

                /// <summary>
                /// <para>Retention time unit for special snapshots. The range of values:</para>
                /// <list type="bullet">
                /// <item><description><para>DAYS</para>
                /// </description></item>
                /// <item><description><para>WEEKS</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>WEEKS</para>
                /// </summary>
                [NameInMap("TimeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

            }

        }

        /// <summary>
        /// <para>The status of the policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ENABLED</b>: Enable snapshot policy execution.</description></item>
        /// <item><description><b>DISABLED</b>: Disable snapshot policy execution.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLED</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>Advanced snapshot features.</para>
        /// </summary>
        [NameInMap("StorageRule")]
        [Validation(Required=false)]
        public UpdateEnterpriseSnapshotPolicyRequestStorageRule StorageRule { get; set; }
        public class UpdateEnterpriseSnapshotPolicyRequestStorageRule : TeaModel {
            /// <summary>
            /// <para>Whether to enable the rapid availability of snapshots. The range of values:</para>
            /// <list type="bullet">
            /// <item><description><para>true</para>
            /// </description></item>
            /// <item><description><para>false</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("EnableImmediateAccess")]
            [Validation(Required=false)]
            public bool? EnableImmediateAccess { get; set; }

        }

    }

}
