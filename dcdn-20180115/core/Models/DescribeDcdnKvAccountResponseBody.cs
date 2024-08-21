// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnKvAccountResponseBody : TeaModel {
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public long? Capacity { get; set; }

        /// <summary>
        /// The available capacity of all namespaces.
        /// </summary>
        [NameInMap("CapacityString")]
        [Validation(Required=false)]
        public string CapacityString { get; set; }

        [NameInMap("CapacityUsed")]
        [Validation(Required=false)]
        public long? CapacityUsed { get; set; }

        /// <summary>
        /// All namespaces have used capacity.
        /// </summary>
        [NameInMap("CapacityUsedString")]
        [Validation(Required=false)]
        public string CapacityUsedString { get; set; }

        /// <summary>
        /// Details about the namespaces.
        /// </summary>
        [NameInMap("NamespaceList")]
        [Validation(Required=false)]
        public List<DescribeDcdnKvAccountResponseBodyNamespaceList> NamespaceList { get; set; }
        public class DescribeDcdnKvAccountResponseBodyNamespaceList : TeaModel {
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public long? Capacity { get; set; }

            /// <summary>
            /// The available capacity of the namespace.
            /// </summary>
            [NameInMap("CapacityString")]
            [Validation(Required=false)]
            public string CapacityString { get; set; }

            [NameInMap("CapacityUsed")]
            [Validation(Required=false)]
            public long? CapacityUsed { get; set; }

            /// <summary>
            /// The namespace has used capacity.
            /// </summary>
            [NameInMap("CapacityUsedString")]
            [Validation(Required=false)]
            public string CapacityUsedString { get; set; }

            /// <summary>
            /// The description of the namespace.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The name of the namespace.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// The ID of the namespace.
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// The status of the namespace. Valid values:
            /// 
            /// *   **online**: normal
            /// *   **delete**: pending delete
            /// *   **deleting**: being deleted
            /// *   **deleted**: deleted
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The maximum number of namespaces that you can apply for by using your account.
        /// </summary>
        [NameInMap("NamespaceQuota")]
        [Validation(Required=false)]
        public int? NamespaceQuota { get; set; }

        /// <summary>
        /// The number of namespaces that you applied for by using your account.
        /// </summary>
        [NameInMap("NamespaceUsed")]
        [Validation(Required=false)]
        public int? NamespaceUsed { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the account.
        /// 
        /// *   **online**: enabled
        /// *   **offline**: disabled
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
