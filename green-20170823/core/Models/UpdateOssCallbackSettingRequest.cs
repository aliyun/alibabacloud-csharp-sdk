// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class UpdateOssCallbackSettingRequest : TeaModel {
        [NameInMap("AuditCallback")]
        [Validation(Required=false)]
        public bool? AuditCallback { get; set; }

        [NameInMap("CallbackSeed")]
        [Validation(Required=false)]
        public string CallbackSeed { get; set; }

        [NameInMap("CallbackUrl")]
        [Validation(Required=false)]
        public string CallbackUrl { get; set; }

        [NameInMap("ScanCallback")]
        [Validation(Required=false)]
        public bool? ScanCallback { get; set; }

        [NameInMap("ScanCallbackSuggestions")]
        [Validation(Required=false)]
        public string ScanCallbackSuggestions { get; set; }

        [NameInMap("ServiceModules")]
        [Validation(Required=false)]
        public string ServiceModules { get; set; }

    }

}
