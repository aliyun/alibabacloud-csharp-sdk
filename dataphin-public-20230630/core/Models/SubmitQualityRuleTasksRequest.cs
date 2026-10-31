// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class SubmitQualityRuleTasksRequest : TeaModel {
        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>The ID of the operator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpUserId")]
        [Validation(Required=false)]
        public string OpUserId { get; set; }

        /// <summary>
        /// <para>The submit command.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SubmitCommand")]
        [Validation(Required=false)]
        public SubmitQualityRuleTasksRequestSubmitCommand SubmitCommand { get; set; }
        public class SubmitQualityRuleTasksRequestSubmitCommand : TeaModel {
            /// <summary>
            /// <para>The business date. Format: yyyy-MM-dd.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30</para>
            /// </summary>
            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public string BizDate { get; set; }

            /// <summary>
            /// <para>Specifies whether to perform a test run. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: performs a test run.</description></item>
            /// <item><description>false: performs a formal run.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("IsTestRun")]
            [Validation(Required=false)]
            public bool? IsTestRun { get; set; }

            /// <summary>
            /// <para>The custom partition expression.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds=${yyyyMMdd}</para>
            /// </summary>
            [NameInMap("PartitionExpression")]
            [Validation(Required=false)]
            public string PartitionExpression { get; set; }

            /// <summary>
            /// <para>The source of the partition expression for the test run. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SCHEDULE: existing schedule.</description></item>
            /// <item><description>CUSTOM: custom expression.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOM</para>
            /// </summary>
            [NameInMap("PartitionExpressionFrom")]
            [Validation(Required=false)]
            public string PartitionExpressionFrom { get; set; }

            /// <summary>
            /// <para>The ID of the existing schedule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScheduleId")]
            [Validation(Required=false)]
            public long? ScheduleId { get; set; }

            /// <summary>
            /// <para>The monitored object and rule IDs.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("WatchRuleIdList")]
            [Validation(Required=false)]
            public List<SubmitQualityRuleTasksRequestSubmitCommandWatchRuleIdList> WatchRuleIdList { get; set; }
            public class SubmitQualityRuleTasksRequestSubmitCommandWatchRuleIdList : TeaModel {
                /// <summary>
                /// <para>The rule ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                /// <summary>
                /// <para>The monitored object ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("WatchId")]
                [Validation(Required=false)]
                public long? WatchId { get; set; }

            }

        }

    }

}
