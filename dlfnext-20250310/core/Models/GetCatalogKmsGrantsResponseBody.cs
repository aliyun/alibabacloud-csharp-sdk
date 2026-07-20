// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class GetCatalogKmsGrantsResponseBody : TeaModel {
        [NameInMap("dataAccessRoleArn")]
        [Validation(Required=false)]
        public string DataAccessRoleArn { get; set; }

        [NameInMap("keyPolicyStatement")]
        [Validation(Required=false)]
        public string KeyPolicyStatement { get; set; }

        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("workflowRoleArn")]
        [Validation(Required=false)]
        public string WorkflowRoleArn { get; set; }

    }

}
