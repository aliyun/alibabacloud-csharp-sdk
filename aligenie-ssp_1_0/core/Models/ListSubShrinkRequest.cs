// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListSubShrinkRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public string DeviceInfoShrink { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public string PageShrink { get; set; }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public string UserInfoShrink { get; set; }

    }

}
