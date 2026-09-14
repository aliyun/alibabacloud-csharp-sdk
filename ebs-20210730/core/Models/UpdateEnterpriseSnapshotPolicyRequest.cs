// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class UpdateEnterpriseSnapshotPolicyRequest : TeaModel {
        /// <summary>
        /// <para>Ensures the idempotence of the request. Generate a parameter value from your client to ensure that the value is unique across different requests. The ClientToken value supports only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The cross-region copy destination information.</para>
        /// </summary>
        [NameInMap("CrossRegionCopyInfo")]
        [Validation(Required=false)]
        public UpdateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfo CrossRegionCopyInfo { get; set; }
        public class UpdateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfo : TeaModel {
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
            public List<UpdateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfoRegions> Regions { get; set; }
            public class UpdateEnterpriseSnapshotPolicyRequestCrossRegionCopyInfoRegions : TeaModel {
                /// <summary>
                /// <para>The destination region ID for snapshot replication. You can call <a href="https://help.aliyun.com/document_detail/354206.html">DescribeDiskReplicaPairs</a> to query the region information of existing asynchronous replication relationships.</para>
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
        /// <para>The description of the snapshot policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        /// <summary>
        /// <para>The ID of the policy to modify.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The snapshot policy ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esp-xxx</para>
        /// </summary>
        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public string PolicyId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The retention rule.</para>
        /// </summary>
        [NameInMap("RetainRule")]
        [Validation(Required=false)]
        public UpdateEnterpriseSnapshotPolicyRequestRetainRule RetainRule { get; set; }
        public class UpdateEnterpriseSnapshotPolicyRequestRetainRule : TeaModel {
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
        /// </summary>
        [NameInMap("Schedule")]
        [Validation(Required=false)]
        public UpdateEnterpriseSnapshotPolicyRequestSchedule Schedule { get; set; }
        public class UpdateEnterpriseSnapshotPolicyRequestSchedule : TeaModel {
            /// <summary>
            /// <para>The execution cycle and time of the policy. A cron expression is used.</para>
            /// <para>For example, <c>0 0 4 1/1 * ?</c> specifies that the snapshot operation is performed at 04:00 every day, starting from the first day of each month.</para>
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
        public UpdateEnterpriseSnapshotPolicyRequestSpecialRetainRules SpecialRetainRules { get; set; }
        public class UpdateEnterpriseSnapshotPolicyRequestSpecialRetainRules : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable special retention. Valid values:</para>
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
            /// <para>The list of special retention rules. Multiple rules are supported.</para>
            /// </summary>
            [NameInMap("Rules")]
            [Validation(Required=false)]
            public List<UpdateEnterpriseSnapshotPolicyRequestSpecialRetainRulesRules> Rules { get; set; }
            public class UpdateEnterpriseSnapshotPolicyRequestSpecialRetainRulesRules : TeaModel {
                /// <summary>
                /// <para>The period unit for special retention snapshots. For example, if this parameter is set to WEEKS, the first snapshot of each week is given special retention. The retention duration is determined by the TimeUnit and TimeInterval parameters. Valid values:</para>
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
                /// <para>30</para>
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
                /// <para>DAYS</para>
                /// </summary>
                [NameInMap("TimeUnit")]
                [Validation(Required=false)]
                public string TimeUnit { get; set; }

            }

        }

        /// <summary>
        /// <para>The status of the snapshot policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ENABLED</description></item>
        /// <item><description>DISABLED</description></item>
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
        public UpdateEnterpriseSnapshotPolicyRequestStorageRule StorageRule { get; set; }
        public class UpdateEnterpriseSnapshotPolicyRequestStorageRule : TeaModel {
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

    }

}
