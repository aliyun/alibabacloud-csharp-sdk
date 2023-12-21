// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeEnabledPrivilegesResponseBody : TeaModel {
        /// <summary>
        /// The queried permission level and permissions.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeEnabledPrivilegesResponseBodyData> Data { get; set; }
        public class DescribeEnabledPrivilegesResponseBodyData : TeaModel {
            /// <summary>
            /// The description of the permission level.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The queried permissions.
            /// </summary>
            [NameInMap("Privileges")]
            [Validation(Required=false)]
            public List<DescribeEnabledPrivilegesResponseBodyDataPrivileges> Privileges { get; set; }
            public class DescribeEnabledPrivilegesResponseBodyDataPrivileges : TeaModel {
                /// <summary>
                /// The description of the permission.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The name of the permission.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

            /// <summary>
            /// The permission level.
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
