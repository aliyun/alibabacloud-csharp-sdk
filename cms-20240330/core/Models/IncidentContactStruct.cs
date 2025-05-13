// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentContactStruct : TeaModel {
        [NameInMap("channel")]
        [Validation(Required=false)]
        public List<string> Channel { get; set; }

        [NameInMap("contactId")]
        [Validation(Required=false)]
        public string ContactId { get; set; }

        [NameInMap("contactType")]
        [Validation(Required=false)]
        public string ContactType { get; set; }

    }

}
