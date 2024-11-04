// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class FilterSetting : TeaModel {
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<FilterSettingConditions> Conditions { get; set; }
        public class FilterSettingConditions : TeaModel {
            [NameInMap("field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        [NameInMap("relation")]
        [Validation(Required=false)]
        public string Relation { get; set; }

    }

}
