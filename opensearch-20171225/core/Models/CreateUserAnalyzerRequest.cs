// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class CreateUserAnalyzerRequest : TeaModel {
        [NameInMap("business")]
        [Validation(Required=false)]
        public string Business { get; set; }

        [NameInMap("businessAppGroupId")]
        [Validation(Required=false)]
        public string BusinessAppGroupId { get; set; }

        [NameInMap("businessType")]
        [Validation(Required=false)]
        public string BusinessType { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("dryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

    }

}
