// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class UpsertQualityScheduleRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30001011</para>
        /// </summary>
        [NameInMap("OpTenantId")]
        [Validation(Required=false)]
        public long? OpTenantId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("UpsertCommand")]
        [Validation(Required=false)]
        public UpsertQualityScheduleRequestUpsertCommand UpsertCommand { get; set; }
        public class UpsertQualityScheduleRequestUpsertCommand : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description><list type="bullet">
            /// <item><description>1/* * * *</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("CronExpression")]
            [Validation(Required=false)]
            public string CronExpression { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ds=${yyyyMMdd}</para>
            /// </summary>
            [NameInMap("PartitionExpression")]
            [Validation(Required=false)]
            public string PartitionExpression { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>CUSTOM</para>
            /// </summary>
            [NameInMap("PartitionType")]
            [Validation(Required=false)]
            public string PartitionType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DAILY</para>
            /// </summary>
            [NameInMap("PeriodScheduleIntervalType")]
            [Validation(Required=false)]
            public string PeriodScheduleIntervalType { get; set; }

            [NameInMap("PeriodScheduleParamList")]
            [Validation(Required=false)]
            public List<string> PeriodScheduleParamList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ONE_TASKS_FINISHED</para>
            /// </summary>
            [NameInMap("StaticTaskTriggerType")]
            [Validation(Required=false)]
            public string StaticTaskTriggerType { get; set; }

            [NameInMap("TriggerNodeList")]
            [Validation(Required=false)]
            public List<string> TriggerNodeList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>STATIC_TASK_TRIGGER</para>
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PERIOD_SCHEDULE</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TASK_REFERRED_PARTITION</para>
            /// </summary>
            [NameInMap("ValidatePartitionType")]
            [Validation(Required=false)]
            public string ValidatePartitionType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("WatchId")]
            [Validation(Required=false)]
            public long? WatchId { get; set; }

        }

    }

}
