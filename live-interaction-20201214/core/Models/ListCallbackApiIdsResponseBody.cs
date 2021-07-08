// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class ListCallbackApiIdsResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 业务是否成功
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 业务错误码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 网络错误码
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// 返回结果
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListCallbackApiIdsResponseBodyResult Result { get; set; }
        public class ListCallbackApiIdsResponseBodyResult : TeaModel {
            [NameInMap("Spis")]
            [Validation(Required=false)]
            public Dictionary<string, string> Spis { get; set; }
            [NameInMap("Events")]
            [Validation(Required=false)]
            public Dictionary<string, string> Events { get; set; }
        };

    }

}
