// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class GetTokenRequest : TeaModel {
        /// <summary>
        /// appKey
        /// </summary>
        [NameInMap("app_key")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// appSecret
        /// </summary>
        [NameInMap("app_secret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

    }

}
