// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc_white_board20201214.Models
{
    public class RefreshUsersPermissionsRequest : TeaModel {
        [NameInMap("UserIds")]
        [Validation(Required=false)]
        public string UserIds { get; set; }

        [NameInMap("DocKey")]
        [Validation(Required=false)]
        public string DocKey { get; set; }

        [NameInMap("AppID")]
        [Validation(Required=false)]
        public string AppID { get; set; }

    }

}
