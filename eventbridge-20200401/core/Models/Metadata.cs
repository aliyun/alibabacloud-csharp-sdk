// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class Metadata : TeaModel {
        [NameInMap("Attachments")]
        [Validation(Required=false)]
        public List<MetadataAttachments> Attachments { get; set; }
        public class MetadataAttachments : TeaModel {
            [NameInMap("Arn")]
            [Validation(Required=false)]
            public string Arn { get; set; }

            [NameInMap("MimeType")]
            [Validation(Required=false)]
            public string MimeType { get; set; }

        }

    }

}
