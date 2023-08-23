// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class ListChainResponseBody : TeaModel {
        /// <summary>
        /// The list of delivery chains.
        /// </summary>
        [NameInMap("Chains")]
        [Validation(Required=false)]
        public List<ListChainResponseBodyChains> Chains { get; set; }
        public class ListChainResponseBodyChains : TeaModel {
            /// <summary>
            /// The ID of the delivery chain.
            /// </summary>
            [NameInMap("ChainId")]
            [Validation(Required=false)]
            public string ChainId { get; set; }

            /// <summary>
            /// The time when the delivery chain was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The description of the delivery chain.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The time when the delivery chain was last modified.
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// The name of the delivery chain.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Repositories to which the delivery chain does not apply.
            /// </summary>
            [NameInMap("ScopeExclude")]
            [Validation(Required=false)]
            public List<string> ScopeExclude { get; set; }

            /// <summary>
            /// The ID of the delivery chain scope.
            /// </summary>
            [NameInMap("ScopeId")]
            [Validation(Required=false)]
            public string ScopeId { get; set; }

            /// <summary>
            /// The type of the delivery chain scope.
            /// </summary>
            [NameInMap("ScopeType")]
            [Validation(Required=false)]
            public string ScopeType { get; set; }

        }

        /// <summary>
        /// The return value.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("IsSuccess")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

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
        /// The total number of delivery chains.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
