// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class HTTPTrigger : TeaModel {
        [NameInMap("urlInternet")]
        [Validation(Required=false)]
        public string UrlInternet { get; set; }

        [NameInMap("urlIntranet")]
        [Validation(Required=false)]
        public string UrlIntranet { get; set; }

    }

}
