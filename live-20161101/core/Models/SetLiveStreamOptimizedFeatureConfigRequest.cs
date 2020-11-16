// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetLiveStreamOptimizedFeatureConfigRequest : TeaModel {
        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("ConfigName")]
        [Validation(Required=true)]
        public string ConfigName { get; set; }

        [NameInMap("ConfigStatus")]
        [Validation(Required=true)]
        public string ConfigStatus { get; set; }

        [NameInMap("ConfigValue")]
        [Validation(Required=false)]
        public string ConfigValue { get; set; }

    }

}
