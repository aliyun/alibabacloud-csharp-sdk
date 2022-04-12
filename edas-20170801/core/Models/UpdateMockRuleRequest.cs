// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class UpdateMockRuleRequest : TeaModel {
        [NameInMap("DubboMockItemJson")]
        [Validation(Required=false)]
        public string DubboMockItemJson { get; set; }

        [NameInMap("ExtraJson")]
        [Validation(Required=false)]
        public string ExtraJson { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("ScMockItemJson")]
        [Validation(Required=false)]
        public string ScMockItemJson { get; set; }

    }

}
