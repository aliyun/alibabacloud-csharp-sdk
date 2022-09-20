// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class QuestionOption : TeaModel {
        [NameInMap("Children")]
        [Validation(Required=false)]
        public List<QuestionOption> Children { get; set; }

        [NameInMap("Color")]
        [Validation(Required=false)]
        public string Color { get; set; }

        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        [NameInMap("Shortcut")]
        [Validation(Required=false)]
        public string Shortcut { get; set; }

    }

}
