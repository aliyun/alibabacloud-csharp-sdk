// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeDtsJobConfigResponseBody : TeaModel {
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<DescribeDtsJobConfigResponseBodyParameters> Parameters { get; set; }
        public class DescribeDtsJobConfigResponseBodyParameters : TeaModel {
            [NameInMap("CheckingCode")]
            [Validation(Required=false)]
            public string CheckingCode { get; set; }

            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("ForceRestart")]
            [Validation(Required=false)]
            public string ForceRestart { get; set; }

            [NameInMap("Modifiable")]
            [Validation(Required=false)]
            public string Modifiable { get; set; }

            [NameInMap("Module")]
            [Validation(Required=false)]
            public string Module { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RecommendValue")]
            [Validation(Required=false)]
            public string RecommendValue { get; set; }

            [NameInMap("RunningValue")]
            [Validation(Required=false)]
            public string RunningValue { get; set; }

            [NameInMap("ValueType")]
            [Validation(Required=false)]
            public int? ValueType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
