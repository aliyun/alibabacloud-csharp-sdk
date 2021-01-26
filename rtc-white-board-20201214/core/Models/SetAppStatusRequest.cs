// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc_white_board20201214.Models
{
    public class SetAppStatusRequest : TeaModel {
        [NameInMap("AppID")]
        [Validation(Required=false)]
        public string AppID { get; set; }

        [NameInMap("AppStatus")]
        [Validation(Required=false)]
        public long? AppStatus { get; set; }

    }

}
