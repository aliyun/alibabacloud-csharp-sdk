// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20210728.Models
{
    public class QueryCopyrightResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryCopyrightResponseBodyData> Data { get; set; }
        public class QueryCopyrightResponseBodyData : TeaModel {
            /// <summary>
            /// 回调url
            /// </summary>
            [NameInMap("Callback")]
            [Validation(Required=false)]
            public string Callback { get; set; }

            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("Gmt_create")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// 修改时间
            /// </summary>
            [NameInMap("Gmt_modified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// 水印视频输入
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public string Input { get; set; }

            /// <summary>
            /// 任务id
            /// </summary>
            [NameInMap("Job_id")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// 水印强度
            /// </summary>
            [NameInMap("Level")]
            [Validation(Required=false)]
            public long? Level { get; set; }

            /// <summary>
            /// 水印信息
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// 水印信息id
            /// </summary>
            [NameInMap("Message_id")]
            [Validation(Required=false)]
            public long? MessageId { get; set; }

            /// <summary>
            /// 水印视频输出
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// 状态
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 用户数据
            /// </summary>
            [NameInMap("User_data")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// 用户ID
            /// </summary>
            [NameInMap("User_id")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// 状态码
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public long? StatusCode { get; set; }

    }

}
