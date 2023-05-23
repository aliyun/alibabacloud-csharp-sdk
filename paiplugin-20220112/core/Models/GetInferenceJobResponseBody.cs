// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiPlugin20220112.Models
{
    public class GetInferenceJobResponseBody : TeaModel {
        /// <summary>
        /// 返回数据。
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInferenceJobResponseBodyData Data { get; set; }
        public class GetInferenceJobResponseBodyData : TeaModel {
            /// <summary>
            /// 关联算法。
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// 关联运营活动Id。
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
            /// 预测数据路径。
            /// </summary>
            [NameInMap("DataPath")]
            [Validation(Required=false)]
            public string DataPath { get; set; }

            /// <summary>
            /// 关联人群Id，如果任务失败则人群无效。
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
            /// 预测任务Id。
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
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// 输出数据路径，需要为空目录。
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
