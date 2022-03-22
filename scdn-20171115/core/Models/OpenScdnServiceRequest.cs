// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Scdn20171115.Models
{
    public class OpenScdnServiceRequest : TeaModel {
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        [NameInMap("CcProtection")]
        [Validation(Required=false)]
        public int? CcProtection { get; set; }

        [NameInMap("DDoSBasic")]
        [Validation(Required=false)]
        public int? DDoSBasic { get; set; }

        [NameInMap("DomainCount")]
        [Validation(Required=false)]
        public int? DomainCount { get; set; }

        [NameInMap("ElasticProtection")]
        [Validation(Required=false)]
        public int? ElasticProtection { get; set; }

        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ProtectType")]
        [Validation(Required=false)]
        public string ProtectType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
