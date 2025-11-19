// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class ProviderSettings : TeaModel {
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public string ApiKey { get; set; }

        [NameInMap("baseUrl")]
        [Validation(Required=false)]
        public string BaseUrl { get; set; }

        [NameInMap("modelNames")]
        [Validation(Required=false)]
        public List<string> ModelNames { get; set; }

    }

}
