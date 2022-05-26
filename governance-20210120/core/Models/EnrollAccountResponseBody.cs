// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class EnrollAccountResponseBody : TeaModel {
        /// <summary>
        /// 注册账号ID
        /// </summary>
        [NameInMap("AccountUid")]
        [Validation(Required=false)]
        public long? AccountUid { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
