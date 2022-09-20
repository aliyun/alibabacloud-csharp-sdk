// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class QuestionPlugin : TeaModel {
        [NameInMap("CanSelect")]
        [Validation(Required=false)]
        public bool? CanSelect { get; set; }

        [NameInMap("Children")]
        [Validation(Required=false)]
        public List<QuestionPlugin> Children { get; set; }

        [NameInMap("DefaultResult")]
        [Validation(Required=false)]
        public string DefaultResult { get; set; }

        [NameInMap("Display")]
        [Validation(Required=false)]
        public bool? Display { get; set; }

        [NameInMap("Exif")]
        [Validation(Required=false)]
        public Dictionary<string, object> Exif { get; set; }

        [NameInMap("HotKeyMap")]
        [Validation(Required=false)]
        public string HotKeyMap { get; set; }

        [NameInMap("MarkTitle")]
        [Validation(Required=false)]
        public string MarkTitle { get; set; }

        [NameInMap("MarkTitleAlias")]
        [Validation(Required=false)]
        public string MarkTitleAlias { get; set; }

        [NameInMap("MustFill")]
        [Validation(Required=false)]
        public bool? MustFill { get; set; }

        [NameInMap("Options")]
        [Validation(Required=false)]
        public List<QuestionOption> Options { get; set; }

        [NameInMap("PreOptions")]
        [Validation(Required=false)]
        public List<string> PreOptions { get; set; }

        [NameInMap("QuestionId")]
        [Validation(Required=false)]
        public string QuestionId { get; set; }

        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

        [NameInMap("SelectGroup")]
        [Validation(Required=false)]
        public string SelectGroup { get; set; }

        [NameInMap("Selected")]
        [Validation(Required=false)]
        public bool? Selected { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
