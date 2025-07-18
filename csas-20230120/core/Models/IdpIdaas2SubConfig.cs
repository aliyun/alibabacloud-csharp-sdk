// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class IdpIdaas2SubConfig : TeaModel {
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        [NameInMap("ClientId")]
        [Validation(Required=false)]
        public string ClientId { get; set; }

        [NameInMap("ClientSecret")]
        [Validation(Required=false)]
        public string ClientSecret { get; set; }

        [NameInMap("EventAesKey")]
        [Validation(Required=false)]
        public string EventAesKey { get; set; }

        [NameInMap("EventLabel")]
        [Validation(Required=false)]
        public string EventLabel { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("PublicKeyEndpoint")]
        [Validation(Required=false)]
        public string PublicKeyEndpoint { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("SamlMetadata")]
        [Validation(Required=false)]
        public string SamlMetadata { get; set; }

    }

}
