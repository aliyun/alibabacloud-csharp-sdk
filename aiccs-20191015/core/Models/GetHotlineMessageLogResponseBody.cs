// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetHotlineMessageLogResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 调用是否成功
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetHotlineMessageLogResponseBodyData> Data { get; set; }
        public class GetHotlineMessageLogResponseBodyData : TeaModel {
            /// <summary>
            /// 会话ID
            /// </summary>
            [NameInMap("Acid")]
            [Validation(Required=false)]
            public string Acid { get; set; }

            /// <summary>
            /// 发送方类型（1：会员，2：坐席）
            /// </summary>
            [NameInMap("SenderType")]
            [Validation(Required=false)]
            public int? SenderType { get; set; }

            /// <summary>
            /// 开始时间
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// 结束时间
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// 记录id
            /// </summary>
            [NameInMap("Mid")]
            [Validation(Required=false)]
            public string Mid { get; set; }

            /// <summary>
            /// 会话内容
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

        }

    }

}
