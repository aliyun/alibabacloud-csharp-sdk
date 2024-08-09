// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Property : TeaModel {
        [NameInMap("defaultValue")]
        [Validation(Required=false)]
        public string DefaultValue { get; set; }

        [NameInMap("definesFormat")]
        [Validation(Required=false)]
        public bool? DefinesFormat { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("required")]
        [Validation(Required=false)]
        public bool? Required { get; set; }

        [NameInMap("sensitive")]
        [Validation(Required=false)]
        public bool? Sensitive { get; set; }

    }

}
