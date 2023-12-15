// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20171011.Models
{
    public class PaasFunctionPluginParams : TeaModel {
        [NameInMap("Body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        [NameInMap("Header")]
        [Validation(Required=false)]
        public Dictionary<string, string> Header { get; set; }

        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        [NameInMap("Query")]
        [Validation(Required=false)]
        public Dictionary<string, string> Query { get; set; }

        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
