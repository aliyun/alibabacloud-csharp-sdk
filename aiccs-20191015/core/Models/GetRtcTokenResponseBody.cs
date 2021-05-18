// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetRtcTokenResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 是否成功
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

        /// <summary>
        /// data
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetRtcTokenResponseBodyData Data { get; set; }
        public class GetRtcTokenResponseBodyData : TeaModel {
            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }
            [NameInMap("RtcId")]
            [Validation(Required=false)]
            public string RtcId { get; set; }
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }
        };

    }

}
