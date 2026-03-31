// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateYikeUserResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>63E8B7C7-4812-46AD-0FA56029AC86</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public CreateYikeUserResponseBodyUserInfo UserInfo { get; set; }
        public class CreateYikeUserResponseBodyUserInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>nick</para>
            /// </summary>
            [NameInMap("Nickname")]
            [Validation(Required=false)]
            public string Nickname { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>name</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>spaceId</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

    }

}
