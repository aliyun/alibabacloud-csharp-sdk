// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeUsersPasswordResponseBody : TeaModel {
        /// <summary>
        /// The users that are associated with cloud desktop.
        /// </summary>
        [NameInMap("DesktopUsers")]
        [Validation(Required=false)]
        public List<DescribeUsersPasswordResponseBodyDesktopUsers> DesktopUsers { get; set; }
        public class DescribeUsersPasswordResponseBodyDesktopUsers : TeaModel {
            /// <summary>
            /// The display name of the user.
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// The ID of the end user.
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// The password of the user.
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
