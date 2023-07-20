// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeServiceInstanceDiagnosisResponseBody : TeaModel {
        [NameInMap("Diagnosis")]
        [Validation(Required=false)]
        public DescribeServiceInstanceDiagnosisResponseBodyDiagnosis Diagnosis { get; set; }
        public class DescribeServiceInstanceDiagnosisResponseBodyDiagnosis : TeaModel {
            [NameInMap("Advices")]
            [Validation(Required=false)]
            public List<string> Advices { get; set; }

            [NameInMap("Causes")]
            [Validation(Required=false)]
            public List<string> Causes { get; set; }

            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
