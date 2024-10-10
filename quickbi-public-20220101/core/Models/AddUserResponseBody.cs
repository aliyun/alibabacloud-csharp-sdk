// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class AddUserResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public AddUserResponseBodyResult Result { get; set; }
        public class AddUserResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:xxxxxx@163.com">xxxxxx@163.com</a></para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AdminUser")]
            [Validation(Required=false)]
            public bool? AdminUser { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AuthAdminUser")]
            [Validation(Required=false)]
            public bool? AuthAdminUser { get; set; }

            [NameInMap("NickName")]
            [Validation(Required=false)]
            public string NickName { get; set; }

            [NameInMap("RoleIdList")]
            [Validation(Required=false)]
            public List<long?> RoleIdList { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>b5d8fd9348cc4327****afb604</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserType")]
            [Validation(Required=false)]
            public int? UserType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
