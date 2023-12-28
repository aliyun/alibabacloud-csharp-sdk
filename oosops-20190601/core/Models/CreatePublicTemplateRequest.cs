// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oosops20190601.Models
{
    public class CreatePublicTemplateRequest : TeaModel {
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("Popularity")]
        [Validation(Required=false)]
        public int? Popularity { get; set; }

        [NameInMap("Publisher")]
        [Validation(Required=false)]
        public string Publisher { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

    }

}
