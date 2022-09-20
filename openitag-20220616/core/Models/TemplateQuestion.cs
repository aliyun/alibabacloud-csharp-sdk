// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class TemplateQuestion : TeaModel {
        [NameInMap("Children")]
        [Validation(Required=false)]
        public List<TemplateQuestion> Children { get; set; }

        [NameInMap("Exif")]
        [Validation(Required=false)]
        public Dictionary<string, object> Exif { get; set; }

        [NameInMap("MarkTitle")]
        [Validation(Required=false)]
        public string MarkTitle { get; set; }

        [NameInMap("Options")]
        [Validation(Required=false)]
        public List<QuestionOption> Options { get; set; }

        [NameInMap("PreOptions")]
        [Validation(Required=false)]
        public List<string> PreOptions { get; set; }

        [NameInMap("QuestionId")]
        [Validation(Required=false)]
        public long? QuestionId { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
