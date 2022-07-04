// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class CreateCardSmsTemplateRequest : TeaModel {
        [NameInMap("Factorys")]
        [Validation(Required=false)]
        public string Factorys { get; set; }

        [NameInMap("Memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        [NameInMap("Template")]
        [Validation(Required=false)]
        public Dictionary<string, object> Template { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
