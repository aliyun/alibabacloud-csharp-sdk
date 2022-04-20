// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class DeleteSensitiveWordResponseBody : TeaModel {
        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 调用发送直播间弹幕的返回结果。
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DeleteSensitiveWordResponseBodyResult Result { get; set; }
        public class DeleteSensitiveWordResponseBodyResult : TeaModel {
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }
        };

    }

}
