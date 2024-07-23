// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeUsersPasswordResponseBody : TeaModel {
        /// <summary>
        /// <para>The authorized users of the cloud computer.</para>
        /// </summary>
        [NameInMap("DesktopUsers")]
        [Validation(Required=false)]
        public List<DescribeUsersPasswordResponseBodyDesktopUsers> DesktopUsers { get; set; }
        public class DescribeUsersPasswordResponseBodyDesktopUsers : TeaModel {
            /// <summary>
            /// <para>The display name of the end user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice_1365*****</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The ID of the end user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alice</para>
            /// </summary>
            [NameInMap("EndUserId")]
            [Validation(Required=false)]
            public string EndUserId { get; set; }

            /// <summary>
            /// <para>The password of the end user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tes123</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F7B4B17B-5C8A-514C-AA4D-F8090E3A63E9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
