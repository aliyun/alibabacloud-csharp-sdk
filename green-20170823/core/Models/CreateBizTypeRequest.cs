// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class CreateBizTypeRequest : TeaModel {
        [NameInMap("BizTypeImport")]
        [Validation(Required=false)]
        public string BizTypeImport { get; set; }

        [NameInMap("BizTypeName")]
        [Validation(Required=false)]
        public string BizTypeName { get; set; }

        [NameInMap("CiteTemplate")]
        [Validation(Required=false)]
        public bool? CiteTemplate { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("IndustryInfo")]
        [Validation(Required=false)]
        public string IndustryInfo { get; set; }

    }

}
