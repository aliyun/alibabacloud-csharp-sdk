// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListServiceSharedAccountsResponseBody : TeaModel {
        /// <summary>
        /// The number of entries per page. Valid values: 1 to 100. Default value: 20.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ShareAccount")]
        [Validation(Required=false)]
        public List<ListServiceSharedAccountsResponseBodyShareAccount> ShareAccount { get; set; }
        public class ListServiceSharedAccountsResponseBodyShareAccount : TeaModel {
            /// <summary>
            /// The time when the service was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// Service logo.
            /// </summary>
            [NameInMap("Logo")]
            [Validation(Required=false)]
            public string Logo { get; set; }

            /// <summary>
            /// The name of the service instance. The value must meet the following requirements:
            /// 
            /// *   The name cannot exceed 64 characters in length.
            /// *   It can contain digits, letters, hyphens (-), and underscores (_). It must start with a digit or a letter.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The permissions on the service. Valid values:
            /// 
            /// *   Deployable: Permissions to deploy the service.
            /// *   Accessible: Permissions to access the service.
            /// </summary>
            [NameInMap("Permission")]
            [Validation(Required=false)]
            public string Permission { get; set; }

            /// <summary>
            /// The service ID.
            /// </summary>
            [NameInMap("ServiceId")]
            [Validation(Required=false)]
            public string ServiceId { get; set; }

            /// <summary>
            /// The time when the service was updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("UserAliUid")]
            [Validation(Required=false)]
            public string UserAliUid { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
