// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class ModifySlbAPRequest : TeaModel {
        [NameInMap("CookieTimeout")]
        [Validation(Required=false)]
        public int? CookieTimeout { get; set; }

        [NameInMap("EstablishedTimeout")]
        [Validation(Required=false)]
        public int? EstablishedTimeout { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RealServerPort")]
        [Validation(Required=false)]
        public int? RealServerPort { get; set; }

        [NameInMap("SlbAPId")]
        [Validation(Required=false)]
        public long? SlbAPId { get; set; }

        [NameInMap("SslCertId")]
        [Validation(Required=false)]
        public string SslCertId { get; set; }

        [NameInMap("StickySession")]
        [Validation(Required=false)]
        public int? StickySession { get; set; }

    }

}
