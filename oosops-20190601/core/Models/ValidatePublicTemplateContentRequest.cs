// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oosops20190601.Models
{
    public class ValidatePublicTemplateContentRequest : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
