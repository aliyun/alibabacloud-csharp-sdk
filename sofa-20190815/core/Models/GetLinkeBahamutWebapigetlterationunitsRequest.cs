// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutWebapigetlterationunitsRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("IsFinished")]
        [Validation(Required=false)]
        public string IsFinished { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public string Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("ShowAll")]
        [Validation(Required=false)]
        public string ShowAll { get; set; }

        [NameInMap("Stage")]
        [Validation(Required=false)]
        public string Stage { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
