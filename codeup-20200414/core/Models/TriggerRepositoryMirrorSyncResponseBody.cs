// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Codeup20200414.Models
{
    public class TriggerRepositoryMirrorSyncResponseBody : TeaModel {
        /// <summary>
        /// 错误信息
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 请求结果
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 响应结果
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public TriggerRepositoryMirrorSyncResponseBodyResult Result { get; set; }
        public class TriggerRepositoryMirrorSyncResponseBodyResult : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public bool? Result { get; set; }
        };

    }

}
