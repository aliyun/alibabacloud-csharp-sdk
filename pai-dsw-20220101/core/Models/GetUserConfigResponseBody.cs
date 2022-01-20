// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class GetUserConfigResponseBody : TeaModel {
        /// <summary>
        /// 用户账号金额是否充足
        /// </summary>
        [NameInMap("AccountSufficient")]
        [Validation(Required=false)]
        public bool? AccountSufficient { get; set; }

        /// <summary>
        /// 请求Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
