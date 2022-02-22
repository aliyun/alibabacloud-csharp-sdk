// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailcloud20180313.Models
{
    public class DescribePodLogResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("ErrMsg")]
        [Validation(Required=false)]
        public string ErrMsg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribePodLogResponseBodyResult Result { get; set; }
        public class DescribePodLogResponseBodyResult : TeaModel {
            [NameInMap("DeployOrderName")]
            [Validation(Required=false)]
            public string DeployOrderName { get; set; }
            [NameInMap("DeployStepList")]
            [Validation(Required=false)]
            public List<DescribePodLogResponseBodyResultDeployStepList> DeployStepList { get; set; }
            public class DescribePodLogResponseBodyResultDeployStepList : TeaModel {
                public string Status { get; set; }
                public string StepCode { get; set; }
                public string StepLog { get; set; }
                public string StepName { get; set; }
            }
            [NameInMap("EnvTypeName")]
            [Validation(Required=false)]
            public string EnvTypeName { get; set; }
        };

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
