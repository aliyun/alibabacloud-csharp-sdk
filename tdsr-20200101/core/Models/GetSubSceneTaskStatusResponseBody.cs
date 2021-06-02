// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class GetSubSceneTaskStatusResponseBody : TeaModel {
        /// <summary>
        /// 请求ID，与入参requestId对应
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 返回码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// 是否请求成功
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// 任务信息
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<GetSubSceneTaskStatusResponseBodyList> List { get; set; }
        public class GetSubSceneTaskStatusResponseBodyList : TeaModel {
            /// <summary>
            /// 任务ID
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// 场景ID
            /// </summary>
            [NameInMap("SceneId")]
            [Validation(Required=false)]
            public string SceneId { get; set; }

            /// <summary>
            /// 子场景ID
            /// </summary>
            [NameInMap("SubSceneId")]
            [Validation(Required=false)]
            public string SubSceneId { get; set; }

            /// <summary>
            /// 未开始  init 处理中   processing   失败     failure  完成     succeed  取消     canceled
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 墙线预测: wall_line   切图: cut_image 重建: build  直角优化：right_angle_optimization 其他：other
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// 任务失败错误码
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// 任务失败错误信息
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

        }

    }

}
