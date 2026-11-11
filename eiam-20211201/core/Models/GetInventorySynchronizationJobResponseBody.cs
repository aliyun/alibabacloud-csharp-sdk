// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetInventorySynchronizationJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The inventory synchronization job.</para>
        /// </summary>
        [NameInMap("InventorySynchronizationJob")]
        [Validation(Required=false)]
        public GetInventorySynchronizationJobResponseBodyInventorySynchronizationJob InventorySynchronizationJob { get; set; }
        public class GetInventorySynchronizationJobResponseBodyInventorySynchronizationJob : TeaModel {
            /// <summary>
            /// <para>The synchronization job description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>No Description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The synchronization end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1761531556</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The synchronization target ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>src_xxxxxx</para>
            /// </summary>
            [NameInMap("InventorySourceId")]
            [Validation(Required=false)]
            public string InventorySourceId { get; set; }

            /// <summary>
            /// <para>The ID of the synchronization task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sync_xxxxxxxxx</para>
            /// </summary>
            [NameInMap("InventorySynchronizationJobId")]
            [Validation(Required=false)]
            public string InventorySynchronizationJobId { get; set; }

            /// <summary>
            /// <para>The synchronization node task result.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public GetInventorySynchronizationJobResponseBodyInventorySynchronizationJobResult Result { get; set; }
            public class GetInventorySynchronizationJobResponseBodyInventorySynchronizationJobResult : TeaModel {
                /// <summary>
                /// <para>The agent synchronization result statistics.</para>
                /// </summary>
                [NameInMap("AgentStatistics")]
                [Validation(Required=false)]
                public GetInventorySynchronizationJobResponseBodyInventorySynchronizationJobResultAgentStatistics AgentStatistics { get; set; }
                public class GetInventorySynchronizationJobResponseBodyInventorySynchronizationJobResultAgentStatistics : TeaModel {
                    /// <summary>
                    /// <para>The creation result statistics.</para>
                    /// </summary>
                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public GetInventorySynchronizationJobResponseBodyInventorySynchronizationJobResultAgentStatisticsCreated Created { get; set; }
                    public class GetInventorySynchronizationJobResponseBodyInventorySynchronizationJobResultAgentStatisticsCreated : TeaModel {
                        /// <summary>
                        /// <para>The failure count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The skipped count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The success count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The deletion result statistics.</para>
                    /// </summary>
                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public GetInventorySynchronizationJobResponseBodyInventorySynchronizationJobResultAgentStatisticsDeleted Deleted { get; set; }
                    public class GetInventorySynchronizationJobResponseBodyInventorySynchronizationJobResultAgentStatisticsDeleted : TeaModel {
                        /// <summary>
                        /// <para>The failure count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The skipped count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The success count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The unchanged result statistics.</para>
                    /// </summary>
                    [NameInMap("Same")]
                    [Validation(Required=false)]
                    public GetInventorySynchronizationJobResponseBodyInventorySynchronizationJobResultAgentStatisticsSame Same { get; set; }
                    public class GetInventorySynchronizationJobResponseBodyInventorySynchronizationJobResultAgentStatisticsSame : TeaModel {
                        /// <summary>
                        /// <para>The failure count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The skipped count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The success count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The update result statistics.</para>
                    /// </summary>
                    [NameInMap("Updated")]
                    [Validation(Required=false)]
                    public GetInventorySynchronizationJobResponseBodyInventorySynchronizationJobResultAgentStatisticsUpdated Updated { get; set; }
                    public class GetInventorySynchronizationJobResponseBodyInventorySynchronizationJobResultAgentStatisticsUpdated : TeaModel {
                        /// <summary>
                        /// <para>The failure count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The skipped count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The success count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
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
                /// <para>The asset synchronization result statistics.</para>
                /// </summary>
                [NameInMap("AssetStatistics")]
                [Validation(Required=false)]
                public GetInventorySynchronizationJobResponseBodyInventorySynchronizationJobResultAssetStatistics AssetStatistics { get; set; }
                public class GetInventorySynchronizationJobResponseBodyInventorySynchronizationJobResultAssetStatistics : TeaModel {
                    /// <summary>
                    /// <para>The creation result statistics.</para>
                    /// </summary>
                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public GetInventorySynchronizationJobResponseBodyInventorySynchronizationJobResultAssetStatisticsCreated Created { get; set; }
                    public class GetInventorySynchronizationJobResponseBodyInventorySynchronizationJobResultAssetStatisticsCreated : TeaModel {
                        /// <summary>
                        /// <para>The failure count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The skipped count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The success count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The deletion result statistics.</para>
                    /// </summary>
                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public GetInventorySynchronizationJobResponseBodyInventorySynchronizationJobResultAssetStatisticsDeleted Deleted { get; set; }
                    public class GetInventorySynchronizationJobResponseBodyInventorySynchronizationJobResultAssetStatisticsDeleted : TeaModel {
                        /// <summary>
                        /// <para>The failure count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The skipped count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The success count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The unchanged result statistics.</para>
                    /// </summary>
                    [NameInMap("Same")]
                    [Validation(Required=false)]
                    public GetInventorySynchronizationJobResponseBodyInventorySynchronizationJobResultAssetStatisticsSame Same { get; set; }
                    public class GetInventorySynchronizationJobResponseBodyInventorySynchronizationJobResultAssetStatisticsSame : TeaModel {
                        /// <summary>
                        /// <para>The failure count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The skipped count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The success count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// <para>The update result statistics.</para>
                    /// </summary>
                    [NameInMap("Updated")]
                    [Validation(Required=false)]
                    public GetInventorySynchronizationJobResponseBodyInventorySynchronizationJobResultAssetStatisticsUpdated Updated { get; set; }
                    public class GetInventorySynchronizationJobResponseBodyInventorySynchronizationJobResultAssetStatisticsUpdated : TeaModel {
                        /// <summary>
                        /// <para>The failure count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// <para>The skipped count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// <para>The success count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// <para>The total count.</para>
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
                /// <para>The error code of the synchronization result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>No ErrorCode</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message description of the synchronization result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>No Error Message</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

            }

            /// <summary>
            /// <para>The synchronization start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1761531256</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The synchronization job status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The synchronization trigger type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>manual</para>
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
