// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateEventRequest : TeaModel {
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("createType")]
        [Validation(Required=false)]
        public string CreateType { get; set; }

        [NameInMap("eventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        [NameInMap("inputFieldsStr")]
        [Validation(Required=false)]
        public string InputFieldsStr { get; set; }

        [NameInMap("memo")]
        [Validation(Required=false)]
        public string Memo { get; set; }

        [NameInMap("regId")]
        [Validation(Required=false)]
        public string RegId { get; set; }

        [NameInMap("templateCode")]
        [Validation(Required=false)]
        public string TemplateCode { get; set; }

        [NameInMap("templateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("templateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
