// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryLinkeBahamutQualitylogRequest : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("Branch")]
        [Validation(Required=false)]
        public string Branch { get; set; }

        [NameInMap("CommitId")]
        [Validation(Required=false)]
        public string CommitId { get; set; }

        [NameInMap("QualityItem")]
        [Validation(Required=false)]
        public string QualityItem { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
