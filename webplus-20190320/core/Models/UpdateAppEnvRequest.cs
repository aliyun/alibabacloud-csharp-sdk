// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class UpdateAppEnvRequest : TeaModel {
        [NameInMap("EnvDescription")]
        [Validation(Required=false)]
        public string EnvDescription { get; set; }

        [NameInMap("EnvId")]
        [Validation(Required=false)]
        public string EnvId { get; set; }

        [NameInMap("PkgVersionId")]
        [Validation(Required=false)]
        public string PkgVersionId { get; set; }

        [NameInMap("OptionSettings")]
        [Validation(Required=false)]
        public string OptionSettings { get; set; }

        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        [NameInMap("ExtraProperties")]
        [Validation(Required=false)]
        public string ExtraProperties { get; set; }

        [NameInMap("BatchSize")]
        [Validation(Required=false)]
        public string BatchSize { get; set; }

        [NameInMap("BatchPercent")]
        [Validation(Required=false)]
        public string BatchPercent { get; set; }

        [NameInMap("BatchInterval")]
        [Validation(Required=false)]
        public string BatchInterval { get; set; }

        [NameInMap("PauseBetweenBatches")]
        [Validation(Required=false)]
        public bool? PauseBetweenBatches { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
