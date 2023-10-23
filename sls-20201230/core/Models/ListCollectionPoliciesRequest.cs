// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ListCollectionPoliciesRequest : TeaModel {
        [NameInMap("attribute")]
        [Validation(Required=false)]
        public ListCollectionPoliciesRequestAttribute Attribute { get; set; }
        public class ListCollectionPoliciesRequestAttribute : TeaModel {
            [NameInMap("app")]
            [Validation(Required=false)]
            public string App { get; set; }

            [NameInMap("policyGroup")]
            [Validation(Required=false)]
            public string PolicyGroup { get; set; }

        }

        [NameInMap("dataCode")]
        [Validation(Required=false)]
        public string DataCode { get; set; }

        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("pageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("policyName")]
        [Validation(Required=false)]
        public string PolicyName { get; set; }

        [NameInMap("productCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

    }

}
