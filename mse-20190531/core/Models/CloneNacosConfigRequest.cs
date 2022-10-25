// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CloneNacosConfigRequest : TeaModel {
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OriginNamespaceId")]
        [Validation(Required=false)]
        public string OriginNamespaceId { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        [NameInMap("TargetNamespaceId")]
        [Validation(Required=false)]
        public string TargetNamespaceId { get; set; }

    }

}
