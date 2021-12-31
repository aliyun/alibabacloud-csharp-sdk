// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListDeployedAlgorithmModelsRequest : TeaModel {
        [NameInMap("algorithmType")]
        [Validation(Required=false)]
        public string AlgorithmType { get; set; }

        [NameInMap("inServiceOnly")]
        [Validation(Required=false)]
        public bool? InServiceOnly { get; set; }

    }

}
