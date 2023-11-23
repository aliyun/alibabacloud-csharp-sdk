// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class HyperParameterRange : TeaModel {
        [NameInMap("Enum")]
        [Validation(Required=false)]
        public List<string> Enum { get; set; }

        [NameInMap("ExclusiveMaximum")]
        [Validation(Required=false)]
        public bool? ExclusiveMaximum { get; set; }

        [NameInMap("ExclusiveMinimum")]
        [Validation(Required=false)]
        public bool? ExclusiveMinimum { get; set; }

        [NameInMap("MaxLength")]
        [Validation(Required=false)]
        public long? MaxLength { get; set; }

        [NameInMap("Maximum")]
        [Validation(Required=false)]
        public string Maximum { get; set; }

        [NameInMap("MinLength")]
        [Validation(Required=false)]
        public long? MinLength { get; set; }

        [NameInMap("Minimum")]
        [Validation(Required=false)]
        public string Minimum { get; set; }

        [NameInMap("Pattern")]
        [Validation(Required=false)]
        public string Pattern { get; set; }

    }

}
