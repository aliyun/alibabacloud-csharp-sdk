// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeAutoProvisioningGroupHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>An array consisting of AutoProvisioningGroupHistory data.</para>
        /// </summary>
        [NameInMap("AutoProvisioningGroupHistories")]
        [Validation(Required=false)]
        public DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistories AutoProvisioningGroupHistories { get; set; }
        public class DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistories : TeaModel {
            [NameInMap("AutoProvisioningGroupHistory")]
            [Validation(Required=false)]
            public List<DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistory> AutoProvisioningGroupHistory { get; set; }
            public class DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistory : TeaModel {
                /// <summary>
                /// <para>An array consisting of ActivityDetail data.</para>
                /// </summary>
                [NameInMap("ActivityDetails")]
                [Validation(Required=false)]
                public DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetails ActivityDetails { get; set; }
                public class DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetails : TeaModel {
                    [NameInMap("ActivityDetail")]
                    [Validation(Required=false)]
                    public List<DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetailsActivityDetail> ActivityDetail { get; set; }
                    public class DescribeAutoProvisioningGroupHistoryResponseBodyAutoProvisioningGroupHistoriesAutoProvisioningGroupHistoryActivityDetailsActivityDetail : TeaModel {
                        /// <summary>
                        /// <para>The execution details of instance creation performed by the single scheduling task.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>New ECS instances &quot;i-bp67acfmxazb4p****, i-bp67acfmxazb5p****&quot; created.</para>
                        /// </summary>
                        [NameInMap("Detail")]
                        [Validation(Required=false)]
                        public string Detail { get; set; }

                        /// <summary>
                        /// <para>The execution status of instance creation performed by the single scheduling task. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>Successful: Instances are created.</description></item>
                        /// <item><description>Failed: Instances failed to be created.</description></item>
                        /// <item><description>InProgress: Instances are being created.</description></item>
                        /// <item><description>Warning: Some instances are created.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Successful</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                /// <summary>
                /// <para>The execution time of the last instance creation performed by the single scheduling task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-04-01T15:10:20Z</para>
                /// </summary>
                [NameInMap("LastEventTime")]
                [Validation(Required=false)]
                public string LastEventTime { get; set; }

                /// <summary>
                /// <para>The start time of executing the single scheduling task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-04-01T15:10:20Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The execution status of the single scheduling task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>prepare: The scheduling task is being executed.</description></item>
                /// <item><description>success: The scheduling task is executed.</description></item>
                /// <item><description>failed: The scheduling task failed to be executed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The ID of the scheduling task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>apg-task-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B48A12CD-1295-4A38-A8F0-0E92C937****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of queried scheduling tasks in the auto provisioning group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
