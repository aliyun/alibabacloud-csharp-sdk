/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class AccessTokenRequest : TeaModel {
        /// <summary>
        /// 应用的appKey
        /// </summary>
        [NameInMap("app_key")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// 应用的appSecret
        /// </summary>
        [NameInMap("app_secret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

    }

}
