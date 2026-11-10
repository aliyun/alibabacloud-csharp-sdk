// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListInventorySynchronizationJobsResponseBody : TeaModel {
        [NameInMap("InventorySynchronizationJobs")]
        [Validation(Required=false)]
        public List<ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobs> InventorySynchronizationJobs { get; set; }
        public class ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobs : TeaModel {
            /// <summary>
            /// <para>同步任务描述</para>
            /// 
            /// <b>Example:</b>
            /// <para>No Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>同步结束时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>1761533214</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>同步目标ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>src_xxxxx</para>
            /// </summary>
            [NameInMap("InventorySourceId")]
            [Validation(Required=false)]
            public string InventorySourceId { get; set; }

            /// <summary>
            /// <para>同步任务ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>sync_xxxxxxx</para>
            /// </summary>
            [NameInMap("InventorySynchronizationJobId")]
            [Validation(Required=false)]
            public string InventorySynchronizationJobId { get; set; }

            /// <summary>
            /// <para>同步任务结果</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobsResult Result { get; set; }
            public class ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobsResult : TeaModel {
                [NameInMap("AgentStatistics")]
                [Validation(Required=false)]
                public ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobsResultAgentStatistics AgentStatistics { get; set; }
                public class ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobsResultAgentStatistics : TeaModel {
                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobsResultAgentStatisticsCreated Created { get; set; }
                    public class ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobsResultAgentStatisticsCreated : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobsResultAgentStatisticsDeleted Deleted { get; set; }
                    public class ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobsResultAgentStatisticsDeleted : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    [NameInMap("Same")]
                    [Validation(Required=false)]
                    public ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobsResultAgentStatisticsSame Same { get; set; }
                    public class ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobsResultAgentStatisticsSame : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    [NameInMap("Updated")]
                    [Validation(Required=false)]
                    public ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobsResultAgentStatisticsUpdated Updated { get; set; }
                    public class ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobsResultAgentStatisticsUpdated : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                }

                /// <summary>
                /// <para>资产同步结果统计</para>
                /// </summary>
                [NameInMap("AssetStatistics")]
                [Validation(Required=false)]
                public ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobsResultAssetStatistics AssetStatistics { get; set; }
                public class ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobsResultAssetStatistics : TeaModel {
                    /// <summary>
                    /// <para>创建结果统计</para>
                    /// </summary>
                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobsResultAssetStatisticsCreated Created { get; set; }
                    public class ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobsResultAssetStatisticsCreated : TeaModel {
                        /// <summary>
                        /// <para>失败数目</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>跳过数目</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>成功数目</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>总共数目</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>删除结果统计</para>
                    /// </summary>
                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobsResultAssetStatisticsDeleted Deleted { get; set; }
                    public class ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobsResultAssetStatisticsDeleted : TeaModel {
                        /// <summary>
                        /// <para>失败数目</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>跳过数目</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>成功数目</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>总共数目</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>相同结果统计</para>
                    /// </summary>
                    [NameInMap("Same")]
                    [Validation(Required=false)]
                    public ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobsResultAssetStatisticsSame Same { get; set; }
                    public class ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobsResultAssetStatisticsSame : TeaModel {
                        /// <summary>
                        /// <para>失败数目</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>跳过数目</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>成功数目</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>总共数目</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>更新结果统计</para>
                    /// </summary>
                    [NameInMap("Updated")]
                    [Validation(Required=false)]
                    public ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobsResultAssetStatisticsUpdated Updated { get; set; }
                    public class ListInventorySynchronizationJobsResponseBodyInventorySynchronizationJobsResultAssetStatisticsUpdated : TeaModel {
                        /// <summary>
                        /// <para>失败数目</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>跳过数目</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>成功数目</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>总共数目</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                }

                /// <summary>
                /// <para>同步结果错误码</para>
                /// 
                /// <b>Example:</b>
                /// <para>No ErrorCode</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>同步结果错误信息描述</para>
                /// 
                /// <b>Example:</b>
                /// <para>No Error Message</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

            }

            /// <summary>
            /// <para>同步开始时间</para>
            /// 
            /// <b>Example:</b>
            /// <para>1761531256</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>同步任务状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>同步触发类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>manual</para>
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>本次调用返回的查询凭证（Token）值，用于下一次翻页查询。</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
