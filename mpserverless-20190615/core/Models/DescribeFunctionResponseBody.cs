// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class DescribeFunctionResponseBody : TeaModel {
        [NameInMap("Function")]
        [Validation(Required=false)]
        public DescribeFunctionResponseBodyFunction Function { get; set; }
        public class DescribeFunctionResponseBodyFunction : TeaModel {
            [NameInMap("TimingTriggerConfig")]
            [Validation(Required=false)]
            public string TimingTriggerConfig { get; set; }
            [NameInMap("Spec")]
            [Validation(Required=false)]
            public DescribeFunctionResponseBodyFunctionSpec Spec { get; set; }
            public class DescribeFunctionResponseBodyFunctionSpec : TeaModel {
                [NameInMap("Timeout")]
                [Validation(Required=false)]
                public string Timeout { get; set; }

                [NameInMap("Runtime")]
                [Validation(Required=false)]
                public string Runtime { get; set; }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

            }
            [NameInMap("HttpTriggerPath")]
            [Validation(Required=false)]
            public string HttpTriggerPath { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("ModifiedAt")]
            [Validation(Required=false)]
            public string ModifiedAt { get; set; }
            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Deployment")]
        [Validation(Required=false)]
        public DescribeFunctionResponseBodyDeployment Deployment { get; set; }
        public class DescribeFunctionResponseBodyDeployment : TeaModel {
            [NameInMap("DeploymentId")]
            [Validation(Required=false)]
            public string DeploymentId { get; set; }
            [NameInMap("CreatedAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }
            [NameInMap("DownloadSignedUrl")]
            [Validation(Required=false)]
            public string DownloadSignedUrl { get; set; }
            [NameInMap("VersionNo")]
            [Validation(Required=false)]
            public string VersionNo { get; set; }
            [NameInMap("ModifiedAt")]
            [Validation(Required=false)]
            public string ModifiedAt { get; set; }
        };

    }

}
