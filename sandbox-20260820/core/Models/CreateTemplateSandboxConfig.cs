// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CreateTemplateSandboxConfig : TeaModel {
        [NameInMap("acrInstanceId")]
        [Validation(Required=false)]
        public string AcrInstanceId { get; set; }

        [NameInMap("generation")]
        [Validation(Required=false)]
        public int? Generation { get; set; }

        [NameInMap("image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        [NameInMap("osType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        [NameInMap("readyCommand")]
        [Validation(Required=false)]
        public string ReadyCommand { get; set; }

        [NameInMap("registryConfig")]
        [Validation(Required=false)]
        public CreateTemplateRegistryConfig RegistryConfig { get; set; }

        [NameInMap("registryType")]
        [Validation(Required=false)]
        public string RegistryType { get; set; }

        [NameInMap("startCommand")]
        [Validation(Required=false)]
        public string StartCommand { get; set; }

        [NameInMap("steps")]
        [Validation(Required=false)]
        public List<CreateTemplateStep> Steps { get; set; }

    }

}
