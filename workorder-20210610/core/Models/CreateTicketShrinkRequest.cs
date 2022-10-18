// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Workorder20210610.Models
{
    public class CreateTicketShrinkRequest : TeaModel {
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        [NameInMap("CreatorId")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Email")]
        [Validation(Required=false)]
        public string Email { get; set; }

        [NameInMap("FileNameList")]
        [Validation(Required=false)]
        public string FileNameListShrink { get; set; }

        [NameInMap("SecretInfo")]
        [Validation(Required=false)]
        public string SecretInfoShrink { get; set; }

        [NameInMap("Severity")]
        [Validation(Required=false)]
        public int? Severity { get; set; }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
