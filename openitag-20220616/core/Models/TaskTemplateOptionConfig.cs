// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class TaskTemplateOptionConfig : TeaModel {
        [NameInMap("DefaultResult")]
        [Validation(Required=false)]
        public string DefaultResult { get; set; }

        [NameInMap("Options")]
        [Validation(Required=false)]
        public List<QuestionOption> Options { get; set; }

        [NameInMap("PreOptions")]
        [Validation(Required=false)]
        public List<string> PreOptions { get; set; }

        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

    }

}
