// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class GetSearchCodePreviewRequest : TeaModel {
        [NameInMap("docId")]
        [Validation(Required=false)]
        public string DocId { get; set; }

        [NameInMap("isDsl")]
        [Validation(Required=false)]
        public bool? IsDsl { get; set; }

        [NameInMap("keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
