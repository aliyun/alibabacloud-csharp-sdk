// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class RecallHonorResponseBody : TeaModel {
        [NameInMap("content")]
        [Validation(Required=false)]
        public RecallHonorResponseBodyContent Content { get; set; }
        public class RecallHonorResponseBodyContent : TeaModel {
            [NameInMap("data")]
            [Validation(Required=false)]
            public object Data { get; set; }

        }

        [NameInMap("errorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("errorCtx")]
        [Validation(Required=false)]
        public Dictionary<string, object> ErrorCtx { get; set; }

        [NameInMap("errorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
