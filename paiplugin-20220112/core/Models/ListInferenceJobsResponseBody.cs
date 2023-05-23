// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class ListInferenceJobsResponseBody : TeaModel {
        /// <summary>
        /// 返回数据。
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListInferenceJobsResponseBodyData Data { get; set; }
        public class ListInferenceJobsResponseBodyData : TeaModel {
            /// <summary>
            /// 预测任务列表。
            /// </summary>
            [NameInMap("InferenceJobs")]
            [Validation(Required=false)]
            public List<ListInferenceJobsResponseBodyDataInferenceJobs> InferenceJobs { get; set; }
            public class ListInferenceJobsResponseBodyDataInferenceJobs : TeaModel {
                /// <summary>
                /// 关联算法。
                /// </summary>
                [NameInMap("Algorithm")]
                [Validation(Required=false)]
                public string Algorithm { get; set; }

                /// <summary>
                /// 关联运营活动ID。
                /// </summary>
                [NameInMap("CampaignId")]
                [Validation(Required=false)]
                public string CampaignId { get; set; }

                /// <summary>
                /// 创建时间 (UTC+8)。
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// 预测数据路径，当预测人群数据分布在多个csv文件时可指定目录，指定路径前需确保已在控制台完成一键授权。
                /// </summary>
                [NameInMap("DataPath")]
                [Validation(Required=false)]
                public string DataPath { get; set; }

                /// <summary>
                /// 预测人群，人群来源必须为多列csv，当同时指定DataPath与GroupId时，以GroupId为准。
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// 预测任务日志。
                /// </summary>
                [NameInMap("History")]
                [Validation(Required=false)]
                public string History { get; set; }

                /// <summary>
                /// 预测任务ID。
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// 预测任务名称。
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// 备注。
                /// </summary>
                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                /// <summary>
                /// 预测任务状态。
                /// - 0: 队列中。
                /// - 1: 已提交。
                /// - 2: 运行中。
                /// - 3: 成功。
                /// - 4: 失败。
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// 关联目标人群ID，如果任务失败则人群无效。
                /// </summary>
                [NameInMap("TargetGroupId")]
                [Validation(Required=false)]
                public string TargetGroupId { get; set; }

                /// <summary>
                /// 输出数据路径，需要为空目录，指定路径前需确保已在控制台完成一键授权。
                /// </summary>
                [NameInMap("TargetPath")]
                [Validation(Required=false)]
                public string TargetPath { get; set; }

                /// <summary>
                /// 关联训练任务。
                /// </summary>
                [NameInMap("TrainingJobId")]
                [Validation(Required=false)]
                public string TrainingJobId { get; set; }

                /// <summary>
                /// 更新时间 (UTC+8)。
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public string UpdatedTime { get; set; }

                /// <summary>
                /// 用户配置。
                /// </summary>
                [NameInMap("UserConfig")]
                [Validation(Required=false)]
                public string UserConfig { get; set; }

            }

            /// <summary>
            /// 分页数，从1开始，默认为1。
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// 分页大小，默认为10。
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// 总预测任务数量。
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// 错误码。
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
