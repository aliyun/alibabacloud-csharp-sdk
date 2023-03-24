// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListApplicationsForPrivateAccessPolicyResponseBody : TeaModel {
        [NameInMap("Polices")]
        [Validation(Required=false)]
        public List<ListApplicationsForPrivateAccessPolicyResponseBodyPolices> Polices { get; set; }
        public class ListApplicationsForPrivateAccessPolicyResponseBodyPolices : TeaModel {
            [NameInMap("Applications")]
            [Validation(Required=false)]
            public List<ListApplicationsForPrivateAccessPolicyResponseBodyPolicesApplications> Applications { get; set; }
            public class ListApplicationsForPrivateAccessPolicyResponseBodyPolicesApplications : TeaModel {
                [NameInMap("Addresses")]
                [Validation(Required=false)]
                public List<string> Addresses { get; set; }

                [NameInMap("ApplicationId")]
                [Validation(Required=false)]
                public string ApplicationId { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("PortRanges")]
                [Validation(Required=false)]
                public List<ListApplicationsForPrivateAccessPolicyResponseBodyPolicesApplicationsPortRanges> PortRanges { get; set; }
                public class ListApplicationsForPrivateAccessPolicyResponseBodyPolicesApplicationsPortRanges : TeaModel {
                    [NameInMap("Begin")]
                    [Validation(Required=false)]
                    public int? Begin { get; set; }

                    [NameInMap("End")]
                    [Validation(Required=false)]
                    public int? End { get; set; }

                }

                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("PolicyId")]
            [Validation(Required=false)]
            public string PolicyId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
