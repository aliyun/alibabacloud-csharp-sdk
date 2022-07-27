// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class DeleteTemplatesRequest : TeaModel {
        [NameInMap("AutoDeleteExecutions")]
        [Validation(Required=false)]
        public bool? AutoDeleteExecutions { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TemplateNames")]
        [Validation(Required=false)]
        public string TemplateNames { get; set; }

    }

}
