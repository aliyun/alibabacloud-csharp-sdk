// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class DefaultBuilderConfig : TeaModel {
        [NameInMap("cache")]
        [Validation(Required=false)]
        public BuildCacheConfig Cache { get; set; }

        [NameInMap("languages")]
        [Validation(Required=false)]
        public List<string> Languages { get; set; }

        [NameInMap("steps")]
        [Validation(Required=false)]
        public List<object> Steps { get; set; }

    }

}
