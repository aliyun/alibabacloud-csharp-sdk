// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class CreateEnterpriseSnapshotPolicyRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotency of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
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
        public CreateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfo CrossRegionCopyInfo { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfo : TeaModel {
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
            /// <para>The list of destination regions.</para>
            /// </summary>
            [NameInMap("Regions")]
            [Validation(Required=false)]
            public List<CreateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfoRegions> Regions { get; set; }
            public class CreateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfoRegions : TeaModel {
                /// <summary>
                /// <para>The region ID of the destination. You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
        /// <para>The ID of the resource group to which to assign the snapshot policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The snapshot retention rule.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RetainRule")]
        [Validation(Required=false)]
        public CreateEnterpriseSnapshotPolicyRequestRetainRule RetainRule { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestRetainRule : TeaModel {
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
            /// <item><description><para>DAYS</para>
            /// </description></item>
            /// <item><description><para>WEEKS</para>
            /// </description></item>
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
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public CreateEnterpriseSnapshotPolicyRequestSchedule Schedule { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestSchedule : TeaModel {
            /// <summary>
            /// <para>The time when the policy will to be scheduled. Valid values: Set the parameter in a cron expression.</para>
            /// <para>For example, you can use 0 0 4 1/1 * ? to specify 04:00:00 (UTC+8) on the first day of each month.</para>
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
        public CreateEnterpriseSnapshotPolicyRequestSpecialRetainRules SpecialRetainRules { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestSpecialRetainRules : TeaModel {
            /// <summary>
            /// <para>Indicates whether the special retention is enabled.</para>
            /// <list type="bullet">
            /// <item><description>true: enable</description></item>
            /// <item><description>false: disable</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The special retention rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<CreateEnterpriseSnapshotPolicyRequestSpecialRetainRulesRules> Rules { get; set; }
            public class CreateEnterpriseSnapshotPolicyRequestSpecialRetainRulesRules : TeaModel {
                /// <summary>
                /// <para>The periodic unit for specially retained snapshots. If configured to WEEKS, it provides special retention for the first snapshot of each week. The retention period is determined by TimeUnit and TimeInterval. The range of values are:</para>
                /// <list type="bullet">
                /// <item><description>WEEKS</description></item>
                /// <item><description>MONTHS</description></item>
                /// <item><description>YEARS</description></item>
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
                /// <para>14</para>
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
        /// <item><description><para>ENABLED: Enable snapshot policy execution.</para>
        /// </description></item>
        /// <item><description><para>DISABLED: Disable snapshot policy execution.</para>
        /// </description></item>
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
        public CreateEnterpriseSnapshotPolicyRequestStorageRule StorageRule { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestStorageRule : TeaModel {
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

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateEnterpriseSnapshotPolicyRequestTag> Tag { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <para>The tag value can be 0 to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>Each tag key must have a unique tag value. You can specify at most 20 tag values in each call.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Binding target type, valid value:</para>
        /// <list type="bullet">
        /// <item><description>DISK</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DISK</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
