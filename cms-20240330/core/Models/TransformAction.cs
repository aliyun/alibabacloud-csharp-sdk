// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class TransformAction : TeaModel {
        [NameInMap("filterSetting")]
        [Validation(Required=false)]
        public FilterSetting FilterSetting { get; set; }

        [NameInMap("labelKey")]
        [Validation(Required=false)]
        public string LabelKey { get; set; }

        [NameInMap("mapping")]
        [Validation(Required=false)]
        public Dictionary<string, string> Mapping { get; set; }

        [NameInMap("regExp")]
        [Validation(Required=false)]
        public string RegExp { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        [NameInMap("variable")]
        [Validation(Required=false)]
        public string Variable { get; set; }

    }

}
