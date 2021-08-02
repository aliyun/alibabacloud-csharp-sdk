// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20210728.Models
{
    public class QueryTraceMuResponseBody : TeaModel {
        /// <summary>
        /// 返回数据结构
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryTraceMuResponseBodyData> Data { get; set; }
        public class QueryTraceMuResponseBodyData : TeaModel {
            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// 最后修改时间
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// 任务id
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// 媒体id
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// 输出oss地址
            /// </summary>
            [NameInMap("Output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// 任务状态
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// 溯源水印信息
            /// </summary>
            [NameInMap("Trace")]
            [Validation(Required=false)]
            public string Trace { get; set; }

            /// <summary>
            /// 溯源水印信息id
            /// </summary>
            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public long? TraceId { get; set; }

            /// <summary>
            /// 用户自定义数据
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// uid
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

        /// <summary>
        /// 返回信息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [NameInMap("RequestID")]
        [Validation(Required=false)]
        public string RequestID { get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public long? StatusCode { get; set; }

    }

}
