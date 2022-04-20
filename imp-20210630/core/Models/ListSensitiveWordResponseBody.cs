// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class ListSensitiveWordResponseBody : TeaModel {
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
        public ListSensitiveWordResponseBodyResult Result { get; set; }
        public class ListSensitiveWordResponseBodyResult : TeaModel {
            [NameInMap("WordList")]
            [Validation(Required=false)]
            public List<string> WordList { get; set; }
        };

    }

}
