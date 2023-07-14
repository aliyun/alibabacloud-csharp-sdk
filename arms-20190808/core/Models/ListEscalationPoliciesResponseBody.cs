// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListEscalationPoliciesResponseBody : TeaModel {
        /// <summary>
        /// The returned objects.
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public ListEscalationPoliciesResponseBodyPageBean PageBean { get; set; }
        public class ListEscalationPoliciesResponseBodyPageBean : TeaModel {
            /// <summary>
            /// The list of escalation policies.
            /// </summary>
            [NameInMap("EscalationPolicies")]
            [Validation(Required=false)]
            public List<ListEscalationPoliciesResponseBodyPageBeanEscalationPolicies> EscalationPolicies { get; set; }
            public class ListEscalationPoliciesResponseBodyPageBeanEscalationPolicies : TeaModel {
                /// <summary>
                /// The ID of the escalation policy.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The name of the escalation policy.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// The total number of returned entries.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
