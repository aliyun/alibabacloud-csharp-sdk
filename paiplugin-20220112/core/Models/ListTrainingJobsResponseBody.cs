// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class ListTrainingJobsResponseBody : TeaModel {
        /// <summary>
        /// 返回数据。
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListTrainingJobsResponseBodyData Data { get; set; }
        public class ListTrainingJobsResponseBodyData : TeaModel {
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
            /// 总训练任务数量。
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// 训练任务列表。
            /// </summary>
            [NameInMap("TrainingJobs")]
            [Validation(Required=false)]
            public List<ListTrainingJobsResponseBodyDataTrainingJobs> TrainingJobs { get; set; }
            public class ListTrainingJobsResponseBodyDataTrainingJobs : TeaModel {
                /// <summary>
                /// 关联算法ID。
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
                /// 训练数据路径，指定路径前需确保已在控制台完成一键授权。
                /// </summary>
                [NameInMap("DataPath")]
                [Validation(Required=false)]
                public string DataPath { get; set; }

                [NameInMap("HasModelInfo")]
                [Validation(Required=false)]
                public bool? HasModelInfo { get; set; }

                /// <summary>
                /// 训练任务日志。
                /// </summary>
                [NameInMap("History")]
                [Validation(Required=false)]
                public string History { get; set; }

                /// <summary>
                /// 训练任务ID。
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// 训练任务名称。
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
                /// 训练任务状态。
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
                /// 关联训练计划ID。
                /// </summary>
                [NameInMap("TrainingScheduleId")]
                [Validation(Required=false)]
                public string TrainingScheduleId { get; set; }

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
