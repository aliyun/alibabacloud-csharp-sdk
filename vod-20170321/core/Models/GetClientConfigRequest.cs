// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetClientConfigRequest : TeaModel {
        [NameInMap("Brand")]
        [Validation(Required=false)]
        public string Brand { get; set; }

        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("OsName")]
        [Validation(Required=false)]
        public string OsName { get; set; }

    }

}
