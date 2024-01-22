// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class CreateIngressRequest : TeaModel {
        [NameInMap("CertId")]
        [Validation(Required=false)]
        public string CertId { get; set; }

        [NameInMap("CertIds")]
        [Validation(Required=false)]
        public string CertIds { get; set; }

        [NameInMap("DefaultRule")]
        [Validation(Required=false)]
        public string DefaultRule { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        [NameInMap("LoadBalanceType")]
        [Validation(Required=false)]
        public string LoadBalanceType { get; set; }

        [NameInMap("NamespaceId")]
        [Validation(Required=false)]
        public string NamespaceId { get; set; }

        [NameInMap("Rules")]
        [Validation(Required=false)]
        public string Rules { get; set; }

        [NameInMap("SlbId")]
        [Validation(Required=false)]
        public string SlbId { get; set; }

    }

}
