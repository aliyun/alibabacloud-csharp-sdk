// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddAuthResourceRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("AuthId")]
        [Validation(Required=false)]
        public long? AuthId { get; set; }

        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public long? DomainId { get; set; }

        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

        [NameInMap("MseSessionId")]
        [Validation(Required=false)]
        public string MseSessionId { get; set; }

        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

    }

}
