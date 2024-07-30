// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetSynchronizationJobResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SynchronizationJob")]
        [Validation(Required=false)]
        public GetSynchronizationJobResponseBodySynchronizationJob SynchronizationJob { get; set; }
        public class GetSynchronizationJobResponseBodySynchronizationJob : TeaModel {
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
            public GetSynchronizationJobResponseBodySynchronizationJobResult Result { get; set; }
            public class GetSynchronizationJobResponseBodySynchronizationJobResult : TeaModel {
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
                public GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatistics GroupMemberStatistics { get; set; }
                public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatistics : TeaModel {
                    /// <summary>
                    /// 绑定结果统计
                    /// </summary>
                    [NameInMap("Binded")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsBinded Binded { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsBinded : TeaModel {
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
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsCreated Created { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsCreated : TeaModel {
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
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsDeleted Deleted { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsDeleted : TeaModel {
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
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsPushed Pushed { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsPushed : TeaModel {
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
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsSame Same { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsSame : TeaModel {
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
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsUpdated Updated { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupMemberStatisticsUpdated : TeaModel {
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
                public GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatistics GroupStatistics { get; set; }
                public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatistics : TeaModel {
                    /// <summary>
                    /// 绑定结果统计
                    /// </summary>
                    [NameInMap("Binded")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsBinded Binded { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsBinded : TeaModel {
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
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsCreated Created { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsCreated : TeaModel {
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
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsDeleted Deleted { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsDeleted : TeaModel {
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
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsPushed Pushed { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsPushed : TeaModel {
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
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsSame Same { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsSame : TeaModel {
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
                    public GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsUpdated Updated { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultGroupStatisticsUpdated : TeaModel {
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
                public GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatistics OrganizationalUnitStatistics { get; set; }
                public class GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatistics : TeaModel {
                    /// <summary>
                    /// 绑定结果统计
                    /// </summary>
                    [NameInMap("Binded")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsBinded Binded { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsBinded : TeaModel {
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
                    public GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsCreated Created { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsCreated : TeaModel {
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
                    public GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsDeleted Deleted { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsDeleted : TeaModel {
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
                    public GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsPushed Pushed { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsPushed : TeaModel {
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
                    public GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsSame Same { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsSame : TeaModel {
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
                    public GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsUpdated Updated { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultOrganizationalUnitStatisticsUpdated : TeaModel {
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
                public GetSynchronizationJobResponseBodySynchronizationJobResultUserStatistics UserStatistics { get; set; }
                public class GetSynchronizationJobResponseBodySynchronizationJobResultUserStatistics : TeaModel {
                    /// <summary>
                    /// 绑定结果统计
                    /// </summary>
                    [NameInMap("Binded")]
                    [Validation(Required=false)]
                    public GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsBinded Binded { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsBinded : TeaModel {
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
                    public GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsCreated Created { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsCreated : TeaModel {
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
                    public GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsDeleted Deleted { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsDeleted : TeaModel {
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
                    public GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsPushed Pushed { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsPushed : TeaModel {
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
                    public GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsSame Same { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsSame : TeaModel {
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
                    public GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsUpdated Updated { get; set; }
                    public class GetSynchronizationJobResponseBodySynchronizationJobResultUserStatisticsUpdated : TeaModel {
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

    }

}
