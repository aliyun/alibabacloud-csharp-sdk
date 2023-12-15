// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class RuleMtopDTO : TeaModel {
        [NameInMap("Error")]
        [Validation(Required=false)]
        public List<string> Error { get; set; }

        [NameInMap("Strict")]
        [Validation(Required=false)]
        public bool? Strict { get; set; }

        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        [NameInMap("Warning")]
        [Validation(Required=false)]
        public List<string> Warning { get; set; }

    }

}
