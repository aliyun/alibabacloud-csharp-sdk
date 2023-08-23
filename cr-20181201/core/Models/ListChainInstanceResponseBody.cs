// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListChainInstanceResponseBody : TeaModel {
        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("ChainInstances")]
        [Validation(Required=false)]
        public List<ListChainInstanceResponseBodyChainInstances> ChainInstances { get; set; }
        public class ListChainInstanceResponseBodyChainInstances : TeaModel {
            /// <summary>
            /// The name of the namespace.
            /// </summary>
            [NameInMap("Chain")]
            [Validation(Required=false)]
            public ListChainInstanceResponseBodyChainInstancesChain Chain { get; set; }
            public class ListChainInstanceResponseBodyChainInstancesChain : TeaModel {
                /// <summary>
                /// The name of the namespace.
                /// </summary>
                [NameInMap("ChainId")]
                [Validation(Required=false)]
                public string ChainId { get; set; }

                /// <summary>
                /// The number of entries returned on each page.
                /// </summary>
                [NameInMap("ChainName")]
                [Validation(Required=false)]
                public string ChainName { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public long? Version { get; set; }

            }

            /// <summary>
            /// 1
            /// </summary>
            [NameInMap("ChainInstanceId")]
            [Validation(Required=false)]
            public string ChainInstanceId { get; set; }

            /// <summary>
            /// The ID of the Container Registry instance.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// The ID of the delivery chain.
            /// </summary>
            [NameInMap("RepoName")]
            [Validation(Required=false)]
            public string RepoName { get; set; }

            /// <summary>
            /// The execution result of the delivery chain. Valid values:
            /// 
            /// *   `SUCCESS`
            /// *   `FAILED`
            /// *   `CANCELED`
            /// *   `DENIED`
            /// </summary>
            [NameInMap("RepoNamespaceName")]
            [Validation(Required=false)]
            public string RepoNamespaceName { get; set; }

            /// <summary>
            /// The list of the execution records of delivery chains.
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            /// <summary>
            /// test-repo
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The status of the delivery chain. Valid values:
            /// 
            /// *   `RUNNING`
            /// *   `COMPLETE`
            /// *   `CANCELING`
            /// *   `CANCELED`
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The version of the delivery chain.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The page number of the page to return.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The execution record of the delivery chain.
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// 30
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// Indicates whether the operation is successful.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the Container Registry instance.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The name of the repository.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
