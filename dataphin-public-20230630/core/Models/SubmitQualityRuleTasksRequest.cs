// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class SubmitQualityRuleTasksRequest : TeaModel {
        /// <summary>
        /// <para>Tenant ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>Submit command</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SubmitCommand")]
        [Validation(Required=false)]
        public SubmitQualityRuleTasksRequestSubmitCommand SubmitCommand { get; set; }
        public class SubmitQualityRuleTasksRequestSubmitCommand : TeaModel {
            /// <summary>
            /// <para>Business date, format: yyyy-MM-dd</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30</para>
            /// </summary>
            [NameInMap("BizDate")]
            [Validation(Required=false)]
            public string BizDate { get; set; }

            /// <summary>
            /// <para>Whether it is a test run: true for test run, false for formal run.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("IsTestRun")]
            [Validation(Required=false)]
            public bool? IsTestRun { get; set; }

            /// <summary>
            /// <para>Partition expression - custom expression</para>
            /// 
            /// <b>Example:</b>
            /// <para>ds=${yyyyMMdd}</para>
            /// </summary>
            [NameInMap("PartitionExpression")]
            [Validation(Required=false)]
            public string PartitionExpression { get; set; }

            /// <summary>
            /// <para>Source of the test run partition expression: SCHEDULE for existing schedule, CUSTOM for custom.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CUSTOM</para>
            /// </summary>
            [NameInMap("PartitionExpressionFrom")]
            [Validation(Required=false)]
            public string PartitionExpressionFrom { get; set; }

            /// <summary>
            /// <para>Existing schedule ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ScheduleId")]
            [Validation(Required=false)]
            public long? ScheduleId { get; set; }

            /// <summary>
            /// <para>Monitoring object and rule IDs</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("WatchRuleIdList")]
            [Validation(Required=false)]
            public List<SubmitQualityRuleTasksRequestSubmitCommandWatchRuleIdList> WatchRuleIdList { get; set; }
            public class SubmitQualityRuleTasksRequestSubmitCommandWatchRuleIdList : TeaModel {
                /// <summary>
                /// <para>Rule ID</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RuleId")]
                [Validation(Required=false)]
                public long? RuleId { get; set; }

                /// <summary>
                /// <para>Monitoring object ID</para>
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
