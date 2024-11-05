// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DetachDatabaseAccountsFromUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>79D7E114-CB52-5695-AB15-12776C308387</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the call.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<DetachDatabaseAccountsFromUserResponseBodyResults> Results { get; set; }
        public class DetachDatabaseAccountsFromUserResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The error code that is returned. If <b>OK</b> is returned, the operation was successful. If another error code is returned, the operation failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>A list that shows the operation results of the database accounts.</para>
            /// </summary>
            [NameInMap("DatabaseAccounts")]
            [Validation(Required=false)]
            public List<DetachDatabaseAccountsFromUserResponseBodyResultsDatabaseAccounts> DatabaseAccounts { get; set; }
            public class DetachDatabaseAccountsFromUserResponseBodyResultsDatabaseAccounts : TeaModel {
                /// <summary>
                /// <para>The error code that is returned. If OK is returned, the operation was successful. If another error code is returned, the operation failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The ID of the database account on which the permissions are revoked.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("DatabaseAccountId")]
                [Validation(Required=false)]
                public string DatabaseAccountId { get; set; }

                /// <summary>
                /// <para>The error message that is returned.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The ID of the database on which the permissions are revoked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

            /// <summary>
            /// <para>The error message that is returned.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

    }

}
