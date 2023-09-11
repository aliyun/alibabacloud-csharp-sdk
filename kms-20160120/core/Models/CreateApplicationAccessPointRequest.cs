// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class CreateApplicationAccessPointRequest : TeaModel {
        [NameInMap("AuthenticationMethod")]
        [Validation(Required=false)]
        public string AuthenticationMethod { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Policies")]
        [Validation(Required=false)]
        public string Policies { get; set; }

    }

}
