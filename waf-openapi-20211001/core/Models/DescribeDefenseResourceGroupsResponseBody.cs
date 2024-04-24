// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseResourceGroupsResponseBody : TeaModel {
        /// <summary>
        /// The list of protected object groups.
        /// </summary>
        [NameInMap("Groups")]
        [Validation(Required=false)]
        public List<DescribeDefenseResourceGroupsResponseBodyGroups> Groups { get; set; }
        public class DescribeDefenseResourceGroupsResponseBodyGroups : TeaModel {
            /// <summary>
            /// The description of the protected object group.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The time when the protected object group was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The most recent time when the protected object group was modified. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// The name of the protected object group.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// The names of the protected objects that are added to the protected object group. Separate multiple protected objects with commas (,).
            /// </summary>
            [NameInMap("ResourceList")]
            [Validation(Required=false)]
            public string ResourceList { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
