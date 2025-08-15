// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OssMfd20231017.Models
{
    public class DescribeServiceLinkedRoleStatusResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>E99D386F-5546-5BCD-BADD-F4EF4B******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RoleStatus")]
        [Validation(Required=false)]
        public DescribeServiceLinkedRoleStatusResponseBodyRoleStatus RoleStatus { get; set; }
        public class DescribeServiceLinkedRoleStatusResponseBodyRoleStatus : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

        }

    }

}
