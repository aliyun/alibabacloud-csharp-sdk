// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class UpdateMCTemplateResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Template")]
        [Validation(Required=false)]
        public UpdateMCTemplateResponseBodyTemplate Template { get; set; }
        public class UpdateMCTemplateResponseBodyTemplate : TeaModel {
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }
            [NameInMap("Porn")]
            [Validation(Required=false)]
            public string Porn { get; set; }
            [NameInMap("Terrorism")]
            [Validation(Required=false)]
            public string Terrorism { get; set; }
            [NameInMap("Politics")]
            [Validation(Required=false)]
            public string Politics { get; set; }
            [NameInMap("Ad")]
            [Validation(Required=false)]
            public string Ad { get; set; }
            [NameInMap("Qrcode")]
            [Validation(Required=false)]
            public string Qrcode { get; set; }
            [NameInMap("Live")]
            [Validation(Required=false)]
            public string Live { get; set; }
            [NameInMap("Logo")]
            [Validation(Required=false)]
            public string Logo { get; set; }
            [NameInMap("Abuse")]
            [Validation(Required=false)]
            public string Abuse { get; set; }
            [NameInMap("Contraband")]
            [Validation(Required=false)]
            public string Contraband { get; set; }
            [NameInMap("Spam")]
            [Validation(Required=false)]
            public string Spam { get; set; }
        };

    }

}
