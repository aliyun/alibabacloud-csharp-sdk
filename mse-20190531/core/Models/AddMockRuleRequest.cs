/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
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

        [NameInMap("ScMockItems")]
        [Validation(Required=false)]
        public string ScMockItems { get; set; }

        [NameInMap("DubboMockItems")]
        [Validation(Required=false)]
        public string DubboMockItems { get; set; }

        [NameInMap("ConsumerAppIds")]
        [Validation(Required=false)]
        public string ConsumerAppIds { get; set; }

        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

    }

}
