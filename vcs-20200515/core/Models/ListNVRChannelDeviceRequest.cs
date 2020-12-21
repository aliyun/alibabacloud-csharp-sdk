// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListNVRChannelDeviceRequest : TeaModel {
        [NameInMap("DeviceCode")]
        [Validation(Required=false)]
        public string DeviceCode { get; set; }

        [NameInMap("IsPage")]
        [Validation(Required=false)]
        public string IsPage { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public string PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

    }

}
