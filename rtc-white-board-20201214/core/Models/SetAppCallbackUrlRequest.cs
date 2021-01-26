// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc_white_board20201214.Models
{
    public class SetAppCallbackUrlRequest : TeaModel {
        [NameInMap("AppID")]
        [Validation(Required=false)]
        public string AppID { get; set; }

        [NameInMap("AppCallbackUrl")]
        [Validation(Required=false)]
        public string AppCallbackUrl { get; set; }

        [NameInMap("AppCallbackAuthKey")]
        [Validation(Required=false)]
        public string AppCallbackAuthKey { get; set; }

    }

}
