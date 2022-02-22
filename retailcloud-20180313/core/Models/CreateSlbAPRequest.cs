// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class CreateSlbAPRequest : TeaModel {
        [NameInMap("CookieTimeout")]
        [Validation(Required=false)]
        public int? CookieTimeout { get; set; }

        [NameInMap("EnvId")]
        [Validation(Required=false)]
        public long? EnvId { get; set; }

        [NameInMap("EstablishedTimeout")]
        [Validation(Required=false)]
        public int? EstablishedTimeout { get; set; }

        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        [NameInMap("RealServerPort")]
        [Validation(Required=false)]
        public int? RealServerPort { get; set; }

        [NameInMap("SlbId")]
        [Validation(Required=false)]
        public string SlbId { get; set; }

        [NameInMap("SslCertId")]
        [Validation(Required=false)]
        public string SslCertId { get; set; }

        [NameInMap("StickySession")]
        [Validation(Required=false)]
        public int? StickySession { get; set; }

    }

}
