// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeControlPlaneLogAlertRulesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeControlPlaneLogAlertRulesResponseBodyData> Data { get; set; }
        public class DescribeControlPlaneLogAlertRulesResponseBodyData : TeaModel {
            [NameInMap("ActionPolicyId")]
            [Validation(Required=false)]
            public string ActionPolicyId { get; set; }

            [NameInMap("Enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            [NameInMap("Info")]
            [Validation(Required=false)]
            public DescribeControlPlaneLogAlertRulesResponseBodyDataInfo Info { get; set; }
            public class DescribeControlPlaneLogAlertRulesResponseBodyDataInfo : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }
            };

            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
