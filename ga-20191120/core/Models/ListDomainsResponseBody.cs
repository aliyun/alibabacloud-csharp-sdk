// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListDomainsResponseBody : TeaModel {
        /// <summary>
        /// The list of accelerated domain names.
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<ListDomainsResponseBodyDomains> Domains { get; set; }
        public class ListDomainsResponseBodyDomains : TeaModel {
            /// <summary>
            /// The list of GA instances.
            /// </summary>
            [NameInMap("Accelerators")]
            [Validation(Required=false)]
            public List<ListDomainsResponseBodyDomainsAccelerators> Accelerators { get; set; }
            public class ListDomainsResponseBodyDomainsAccelerators : TeaModel {
                /// <summary>
                /// The ID of the GA instance.
                /// </summary>
                [NameInMap("AcceleratorId")]
                [Validation(Required=false)]
                public string AcceleratorId { get; set; }

                /// <summary>
                /// The name of the GA instance.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// The accelerated domain name.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The ICP filing status of the accelerated domain name.
            /// 
            /// *   **illegal:** The domain name is illegal.
            /// *   **inactive:** The domain name has not completed ICP filing.
            /// *   **active:** The domain name has a valid ICP filing.
            /// *   **unknown:** The ICP filing status is unknown.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
