// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListChatappTemplateRequest : TeaModel {
        [NameInMap("AuditStatus")]
        [Validation(Required=false)]
        public string AuditStatus { get; set; }

        [NameInMap("CustWabaId")]
        [Validation(Required=false)]
        public string CustWabaId { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public ListChatappTemplateRequestPage Page { get; set; }
        public class ListChatappTemplateRequestPage : TeaModel {
            [NameInMap("Index")]
            [Validation(Required=false)]
            public int? Index { get; set; }
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }
        };

    }

}
