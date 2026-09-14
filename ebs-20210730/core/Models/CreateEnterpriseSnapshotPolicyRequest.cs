// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class CreateEnterpriseSnapshotPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Ensures the idempotence of the request. Generate a parameter value from your client that is unique across different requests. ClientToken supports only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The snapshot replication information.</para>
        /// </summary>
        [NameInMap("CrossRegionCopyInfo")]
        [Validation(Required=false)]
        public CreateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfo CrossRegionCopyInfo { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfo : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable cross-region replication. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The destination region information.</para>
            /// </summary>
            [NameInMap("Regions")]
            [Validation(Required=false)]
            public List<CreateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfoRegions> Regions { get; set; }
            public class CreateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfoRegions : TeaModel {
                /// <summary>
                /// <para>The ID of the destination region for snapshot replication. You can invoke <a href="https://help.aliyun.com/document_detail/354206.html">DescribeDiskReplicaPairs</a> to query the region information of existing asynchronous replication relationships.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The number of days to retain snapshots in the destination region. The value must be greater than 1.</para>
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
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// <para>The Policy Name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The region ID. You can call DescribeRegions to query the regions that support asynchronous replication.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The retention rule.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("RetainRule")]
        [Validation(Required=false)]
        public CreateEnterpriseSnapshotPolicyRequestRetainRule RetainRule { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestRetainRule : TeaModel {
            /// <summary>
            /// <para>The number of snapshots to retain. Valid values: 1 to 256.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("Number")]
            [Validation(Required=false)]
            public int? Number { get; set; }

            /// <summary>
            /// <para>The time interval of the retention rule. The unit is specified by the TimeUnit parameter. The value must be greater than 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>14</para>
            /// </summary>
            [NameInMap("TimeInterval")]
            [Validation(Required=false)]
            public int? TimeInterval { get; set; }

            /// <summary>
            /// <para>The unit of the retention time. Valid values:</para>
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
        /// <para>The schedule rule.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public CreateEnterpriseSnapshotPolicyRequestSchedule Schedule { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestSchedule : TeaModel {
            /// <summary>
            /// <para>The cycle and time at which the policy is executed. Specify the value in a cron expression.</para>
            /// <para>For example, <c>0 0 4 1/1 * ?</c> specifies that the snapshot operation is performed at 4:00 AM every day, starting from the first day of each month.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

        }

        /// <summary>
        /// <para>The special retention rules.</para>
        /// </summary>
        [NameInMap("SpecialRetainRules")]
        [Validation(Required=false)]
        public CreateEnterpriseSnapshotPolicyRequestSpecialRetainRules SpecialRetainRules { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestSpecialRetainRules : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable special retention. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The list of special retention rules.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<CreateEnterpriseSnapshotPolicyRequestSpecialRetainRulesRules> Rules { get; set; }
            public class CreateEnterpriseSnapshotPolicyRequestSpecialRetainRulesRules : TeaModel {
                /// <summary>
                /// <para>The period unit for specially retained snapshots. For example, if this parameter is set to WEEKS, the first snapshot of each week is specially retained. The retention duration is determined by TimeUnit and TimeInterval. Valid values:</para>
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
                /// <para>The time interval of the retention rule. The unit is specified by the TimeUnit parameter. The value must be greater than 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14</para>
                /// </summary>
                [NameInMap("TimeInterval")]
                [Validation(Required=false)]
                public int? TimeInterval { get; set; }

                /// <summary>
                /// <para>The unit of the retention time for special snapshots. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>DAYS</description></item>
                /// <item><description>WEEKS</description></item>
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
        /// <para>The status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DISABLED</description></item>
        /// <item><description>ENABLED</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ENABLED</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The advanced snapshot feature.</para>
        /// </summary>
        [NameInMap("StorageRule")]
        [Validation(Required=false)]
        public CreateEnterpriseSnapshotPolicyRequestStorageRule StorageRule { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestStorageRule : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable instant access for snapshots. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
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
        /// <para>The tag key-value pairs. Valid values of n: 1 to 20.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateEnterpriseSnapshotPolicyRequestTag> Tag { get; set; }
        public class CreateEnterpriseSnapshotPolicyRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
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
        /// <para>The type. Valid values:</para>
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
