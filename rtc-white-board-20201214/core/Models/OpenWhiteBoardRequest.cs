// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc_white_board20201214.Models
{
    public class OpenWhiteBoardRequest : TeaModel {
        [NameInMap("AppID")]
        [Validation(Required=false)]
        public string AppID { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("DocKey")]
        [Validation(Required=false)]
        public string DocKey { get; set; }

    }

}
