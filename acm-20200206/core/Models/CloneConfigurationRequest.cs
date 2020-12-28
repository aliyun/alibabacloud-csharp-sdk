// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Acm20200206.Models
{
    public class CloneConfigurationRequest : TeaModel {
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        [NameInMap("NamespaceFrom")]
        [Validation(Required=false)]
        public string NamespaceFrom { get; set; }

        [NameInMap("NamespaceTo")]
        [Validation(Required=false)]
        public string NamespaceTo { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

    }

}
