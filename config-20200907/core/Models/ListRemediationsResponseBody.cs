// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListRemediationsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Remediations")]
        [Validation(Required=false)]
        public List<ListRemediationsResponseBodyRemediations> Remediations { get; set; }
        public class ListRemediationsResponseBodyRemediations : TeaModel {
            [NameInMap("LastSuccessfulInvocationType")]
            [Validation(Required=false)]
            public string LastSuccessfulInvocationType { get; set; }

            [NameInMap("RemediationTemplateId")]
            [Validation(Required=false)]
            public string RemediationTemplateId { get; set; }

            [NameInMap("RemediationDynamicParams")]
            [Validation(Required=false)]
            public string RemediationDynamicParams { get; set; }

            [NameInMap("RemediationId")]
            [Validation(Required=false)]
            public string RemediationId { get; set; }

            [NameInMap("RemediationSourceType")]
            [Validation(Required=false)]
            public string RemediationSourceType { get; set; }

            [NameInMap("RemediationType")]
            [Validation(Required=false)]
            public string RemediationType { get; set; }

            [NameInMap("LastSuccessfulInvocationId")]
            [Validation(Required=false)]
            public string LastSuccessfulInvocationId { get; set; }

            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public long? AccountId { get; set; }

            [NameInMap("InvokeType")]
            [Validation(Required=false)]
            public string InvokeType { get; set; }

            [NameInMap("ConfigRuleId")]
            [Validation(Required=false)]
            public string ConfigRuleId { get; set; }

            [NameInMap("LastSuccessfulInvocationTime")]
            [Validation(Required=false)]
            public long? LastSuccessfulInvocationTime { get; set; }

        }

    }

}
