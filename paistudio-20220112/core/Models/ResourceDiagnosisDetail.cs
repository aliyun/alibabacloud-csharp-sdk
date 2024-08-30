// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ResourceDiagnosisDetail : TeaModel {
        [NameInMap("ExceedResources")]
        [Validation(Required=false)]
        public List<string> ExceedResources { get; set; }

        [NameInMap("Limit")]
        [Validation(Required=false)]
        public ResourceAmount Limit { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Used")]
        [Validation(Required=false)]
        public ResourceAmount Used { get; set; }

        [NameInMap("WorkloadIds")]
        [Validation(Required=false)]
        public List<string> WorkloadIds { get; set; }

    }

}
