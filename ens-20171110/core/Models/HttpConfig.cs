// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class HttpConfig : TeaModel {
        [NameInMap("Cookie")]
        [Validation(Required=false)]
        public string Cookie { get; set; }

        [NameInMap("CookieTimeout")]
        [Validation(Required=false)]
        public int? CookieTimeout { get; set; }

        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        [NameInMap("ServerCertificateId")]
        [Validation(Required=false)]
        public string ServerCertificateId { get; set; }

        [NameInMap("StickySession")]
        [Validation(Required=false)]
        public string StickySession { get; set; }

        [NameInMap("StickySessionType")]
        [Validation(Required=false)]
        public string StickySessionType { get; set; }

        [NameInMap("XForwardedFor")]
        [Validation(Required=false)]
        public string XForwardedFor { get; set; }

    }

}
