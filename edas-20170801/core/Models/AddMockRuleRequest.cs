// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class AddMockRuleRequest : TeaModel {
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("ProviderAppId")]
        [Validation(Required=false)]
        public string ProviderAppId { get; set; }

        [NameInMap("ProviderAppName")]
        [Validation(Required=false)]
        public string ProviderAppName { get; set; }

        [NameInMap("ExtraJson")]
        [Validation(Required=false)]
        public string ExtraJson { get; set; }

        [NameInMap("ScMockItemJson")]
        [Validation(Required=false)]
        public string ScMockItemJson { get; set; }

        [NameInMap("DubboMockItemJson")]
        [Validation(Required=false)]
        public string DubboMockItemJson { get; set; }

        [NameInMap("ConsumerAppsJson")]
        [Validation(Required=false)]
        public string ConsumerAppsJson { get; set; }

        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

    }

}
