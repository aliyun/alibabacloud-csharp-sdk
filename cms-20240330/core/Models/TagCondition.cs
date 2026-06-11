// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class TagCondition : TeaModel {
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("op")]
        [Validation(Required=false)]
        public string Op { get; set; }

        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
