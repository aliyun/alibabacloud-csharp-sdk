// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class AttachDatabaseAccountsToUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23120B8E-8737-50BD-A3A3-902A7821F04D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the call.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<AttachDatabaseAccountsToUserResponseBodyResults> Results { get; set; }
        public class AttachDatabaseAccountsToUserResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The error code that is returned. If <b>OK</b> is returned, the authorization was successful. If another error code is returned, the authorization failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>A list that shows the authorization results of the database accounts.</para>
            /// </summary>
            [NameInMap("DatabaseAccounts")]
            [Validation(Required=false)]
            public List<AttachDatabaseAccountsToUserResponseBodyResultsDatabaseAccounts> DatabaseAccounts { get; set; }
            public class AttachDatabaseAccountsToUserResponseBodyResultsDatabaseAccounts : TeaModel {
                /// <summary>
                /// <para>The error code that is returned. If OK is returned, the authorization was successful. If another error code is returned, the authorization failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The database account ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("DatabaseAccountId")]
                [Validation(Required=false)]
                public string DatabaseAccountId { get; set; }

                /// <summary>
                /// <para>The error message that is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The database ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
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
