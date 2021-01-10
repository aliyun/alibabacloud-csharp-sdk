// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeBahamutQualityupdatecoverageRequest : TeaModel {
        [NameInMap("GitBranch")]
        [Validation(Required=false)]
        public string GitBranch { get; set; }

        [NameInMap("Group")]
        [Validation(Required=false)]
        public string Group { get; set; }

        [NameInMap("Host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        [NameInMap("IterationUnitId")]
        [Validation(Required=false)]
        public string IterationUnitId { get; set; }

    }

}
