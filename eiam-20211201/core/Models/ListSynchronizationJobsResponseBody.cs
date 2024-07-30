// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListSynchronizationJobsResponseBody : TeaModel {
        /// <summary>
        /// 本次调用返回的查询凭证（Token）值，用于下一次翻页查询。
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SynchronizationJobs")]
        [Validation(Required=false)]
        public List<ListSynchronizationJobsResponseBodySynchronizationJobs> SynchronizationJobs { get; set; }
        public class ListSynchronizationJobsResponseBodySynchronizationJobs : TeaModel {
            /// <summary>
            /// 同步任务方向
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// 同步结束时间
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// 同步任务结果
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public ListSynchronizationJobsResponseBodySynchronizationJobsResult Result { get; set; }
            public class ListSynchronizationJobsResponseBodySynchronizationJobsResult : TeaModel {
                /// <summary>
                /// 同步结果错误码
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// 同步结果错误信息描述
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// 组成员同步结果统计
                /// </summary>
                [NameInMap("GroupMemberStatistics")]
                [Validation(Required=false)]
                public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatistics GroupMemberStatistics { get; set; }
                public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatistics : TeaModel {
                    /// <summary>
                    /// 绑定结果统计
                    /// </summary>
                    [NameInMap("Binded")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsBinded Binded { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsBinded : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// 创建结果统计
                    /// </summary>
                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsCreated Created { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsCreated : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// 删除结果统计
                    /// </summary>
                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsDeleted Deleted { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsDeleted : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// 推送结果统计
                    /// </summary>
                    [NameInMap("Pushed")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsPushed Pushed { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsPushed : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// 相同结果统计
                    /// </summary>
                    [NameInMap("Same")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsSame Same { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsSame : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// 更新结果统计
                    /// </summary>
                    [NameInMap("Updated")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsUpdated Updated { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupMemberStatisticsUpdated : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                }

                /// <summary>
                /// 组同步结果统计
                /// </summary>
                [NameInMap("GroupStatistics")]
                [Validation(Required=false)]
                public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatistics GroupStatistics { get; set; }
                public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatistics : TeaModel {
                    /// <summary>
                    /// 绑定结果统计
                    /// </summary>
                    [NameInMap("Binded")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsBinded Binded { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsBinded : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// 创建结果统计
                    /// </summary>
                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsCreated Created { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsCreated : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// 删除结果统计
                    /// </summary>
                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsDeleted Deleted { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsDeleted : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// 推送结果统计
                    /// </summary>
                    [NameInMap("Pushed")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsPushed Pushed { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsPushed : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// 相同结果统计
                    /// </summary>
                    [NameInMap("Same")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsSame Same { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsSame : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// 更新结果统计
                    /// </summary>
                    [NameInMap("Updated")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsUpdated Updated { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultGroupStatisticsUpdated : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                }

                /// <summary>
                /// 组织同步结果统计
                /// </summary>
                [NameInMap("OrganizationalUnitStatistics")]
                [Validation(Required=false)]
                public ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatistics OrganizationalUnitStatistics { get; set; }
                public class ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatistics : TeaModel {
                    /// <summary>
                    /// 绑定结果统计
                    /// </summary>
                    [NameInMap("Binded")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsBinded Binded { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsBinded : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// 创建结果统计
                    /// </summary>
                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsCreated Created { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsCreated : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// 删除结果统计
                    /// </summary>
                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsDeleted Deleted { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsDeleted : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// 推送结果统计
                    /// </summary>
                    [NameInMap("Pushed")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsPushed Pushed { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsPushed : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// 相同结果统计
                    /// </summary>
                    [NameInMap("Same")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsSame Same { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsSame : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// 更新结果统计
                    /// </summary>
                    [NameInMap("Updated")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsUpdated Updated { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultOrganizationalUnitStatisticsUpdated : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                }

                /// <summary>
                /// 用户同步结果统计
                /// </summary>
                [NameInMap("UserStatistics")]
                [Validation(Required=false)]
                public ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatistics UserStatistics { get; set; }
                public class ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatistics : TeaModel {
                    /// <summary>
                    /// 绑定结果统计
                    /// </summary>
                    [NameInMap("Binded")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsBinded Binded { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsBinded : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// 创建结果统计
                    /// </summary>
                    [NameInMap("Created")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsCreated Created { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsCreated : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// 删除结果统计
                    /// </summary>
                    [NameInMap("Deleted")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsDeleted Deleted { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsDeleted : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// 推送结果统计
                    /// </summary>
                    [NameInMap("Pushed")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsPushed Pushed { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsPushed : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// 相同结果统计
                    /// </summary>
                    [NameInMap("Same")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsSame Same { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsSame : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                    /// <summary>
                    /// 更新结果统计
                    /// </summary>
                    [NameInMap("Updated")]
                    [Validation(Required=false)]
                    public ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsUpdated Updated { get; set; }
                    public class ListSynchronizationJobsResponseBodySynchronizationJobsResultUserStatisticsUpdated : TeaModel {
                        /// <summary>
                        /// 失败数目
                        /// </summary>
                        [NameInMap("Failed")]
                        [Validation(Required=false)]
                        public long? Failed { get; set; }

                        /// <summary>
                        /// 跳过数目
                        /// </summary>
                        [NameInMap("Skipped")]
                        [Validation(Required=false)]
                        public long? Skipped { get; set; }

                        /// <summary>
                        /// 成功数目
                        /// </summary>
                        [NameInMap("Success")]
                        [Validation(Required=false)]
                        public long? Success { get; set; }

                        /// <summary>
                        /// 总共数目
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                    }

                }

            }

            /// <summary>
            /// 同步开始时间
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// 同步任务状态
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 同步任务ID
            /// </summary>
            [NameInMap("SynchronizationJobId")]
            [Validation(Required=false)]
            public string SynchronizationJobId { get; set; }

            /// <summary>
            /// 同步目标ID
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// 同步目标类型
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// 同步触发类型
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
