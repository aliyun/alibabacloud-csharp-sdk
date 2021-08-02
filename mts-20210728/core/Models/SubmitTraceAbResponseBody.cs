// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20210728.Models
{
    public class SubmitTraceAbResponseBody : TeaModel {
        /// <summary>
        /// 返回数据
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public SubmitTraceAbResponseBodyData Data { get; set; }
        public class SubmitTraceAbResponseBodyData : TeaModel {
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }
        };

        /// <summary>
        /// 返回信息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// 请求Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        [NameInMap("StatusCode")]
        [Validation(Required=false)]
        public long? StatusCode { get; set; }

    }

}
