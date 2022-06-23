// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class RpcStatus : TeaModel {
        /// <summary>
        /// 错误码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// 错误详情
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
