// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseResourceGroupResponseBody : TeaModel {
        /// <summary>
        /// The information about the protected object group.
        /// </summary>
        [NameInMap("Group")]
        [Validation(Required=false)]
        public DescribeDefenseResourceGroupResponseBodyGroup Group { get; set; }
        public class DescribeDefenseResourceGroupResponseBodyGroup : TeaModel {
            /// <summary>
            /// The description of the protected object group.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The time when the protected object group was created.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The most recent time when the protected object group was modified.
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
            /// The protected objects in the protected object group. The protected objects are separated with commas (,).
            /// </summary>
            [NameInMap("ResourceList")]
            [Validation(Required=false)]
            public string ResourceList { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
