// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class GetModelOssPolicyRequest : TeaModel {
        [NameInMap("ApiProduct")]
        [Validation(Required=false)]
        public string ApiProduct { get; set; }

        [NameInMap("ApiRevision")]
        [Validation(Required=false)]
        public string ApiRevision { get; set; }

        [NameInMap("AlgorithmId")]
        [Validation(Required=false)]
        public long? AlgorithmId { get; set; }

        [NameInMap("Hardware")]
        [Validation(Required=false)]
        public string Hardware { get; set; }

        [NameInMap("ModelPackageStandard")]
        [Validation(Required=false)]
        public string ModelPackageStandard { get; set; }

    }

}
