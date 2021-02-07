// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DeployAppEnvRequest : TeaModel {
        [NameInMap("EnvId")]
        [Validation(Required=false)]
        public string EnvId { get; set; }

        [NameInMap("BatchSize")]
        [Validation(Required=false)]
        public int? BatchSize { get; set; }

        [NameInMap("BatchPercent")]
        [Validation(Required=false)]
        public int? BatchPercent { get; set; }

        [NameInMap("BatchInterval")]
        [Validation(Required=false)]
        public int? BatchInterval { get; set; }

        [NameInMap("PauseBetweenBatches")]
        [Validation(Required=false)]
        public bool? PauseBetweenBatches { get; set; }

        [NameInMap("PkgVersionId")]
        [Validation(Required=false)]
        public string PkgVersionId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
