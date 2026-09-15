// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicUpdateTemplateCopyAction : TeaModel {
        [NameInMap("acrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        [NameInMap("image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        [NameInMap("registryConfig")]
        [Validation(Required=false)]
        public PublicUpdateTemplateRegistryConfig RegistryConfig { get; set; }

        [NameInMap("registryType")]
        [Validation(Required=false)]
        public string RegistryType { get; set; }

    }

}
