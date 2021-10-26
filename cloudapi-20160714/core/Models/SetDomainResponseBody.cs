// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class SetDomainResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainLegalStatus")]
        [Validation(Required=false)]
        public string DomainLegalStatus { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("SubDomain")]
        [Validation(Required=false)]
        public string SubDomain { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("DomainBindingStatus")]
        [Validation(Required=false)]
        public string DomainBindingStatus { get; set; }

        [NameInMap("DomainRemark")]
        [Validation(Required=false)]
        public string DomainRemark { get; set; }

        [NameInMap("DomainWebSocketStatus")]
        [Validation(Required=false)]
        public string DomainWebSocketStatus { get; set; }

    }

}
