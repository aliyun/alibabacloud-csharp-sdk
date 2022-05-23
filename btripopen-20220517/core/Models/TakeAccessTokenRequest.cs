/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220517.Models
{
    public class TakeAccessTokenRequest : TeaModel {
        [NameInMap("app_key")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("app_secret")]
        [Validation(Required=false)]
        public string AppSecret { get; set; }

    }

}
