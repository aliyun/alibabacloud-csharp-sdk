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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Display")]
        [Validation(Required=false)]
        public bool? Display { get; set; }

        [NameInMap("Exif")]
        [Validation(Required=false)]
        public Dictionary<string, object> Exif { get; set; }

        [NameInMap("HotKeyMap")]
        [Validation(Required=false)]
        public string HotKeyMap { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MarkTitle")]
        [Validation(Required=false)]
        public string MarkTitle { get; set; }

        [NameInMap("MarkTitleAlias")]
        [Validation(Required=false)]
        public string MarkTitleAlias { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("MustFill")]
        [Validation(Required=false)]
        public bool? MustFill { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Options")]
        [Validation(Required=false)]
        public List<QuestionOption> Options { get; set; }

        [NameInMap("PreOptions")]
        [Validation(Required=false)]
        public List<string> PreOptions { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
