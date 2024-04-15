// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeAclEntriesResponseBody : TeaModel {
        /// <summary>
        /// The ACL entries.
        /// </summary>
        [NameInMap("AclEntries")]
        [Validation(Required=false)]
        public List<DescribeAclEntriesResponseBodyAclEntries> AclEntries { get; set; }
        public class DescribeAclEntriesResponseBodyAclEntries : TeaModel {
            /// <summary>
            /// The ACL type.
            /// 
            /// Valid values:
            /// 
            /// *   allow: whitelist
            /// *   disable: blacklist
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// The ID of the instance to which the ACL applies, such as an office network ID or a cloud computer ID.
            /// </summary>
            [NameInMap("SourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            /// <summary>
            /// The granularity of the ACL.
            /// 
            /// Valid values:
            /// 
            /// *   desktop: cloud computer
            /// *   vpc: office network
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

        }

        /// <summary>
        /// The token that is used to start the next query. If the value of this parameter is empty, all results are returned.
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

    }

}
