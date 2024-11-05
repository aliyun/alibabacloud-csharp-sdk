// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class AttachDatabaseAccountsToUserGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5D0EB759-CB0A-537D-A2CC-13A9854FA08D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the call.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<AttachDatabaseAccountsToUserGroupResponseBodyResults> Results { get; set; }
        public class AttachDatabaseAccountsToUserGroupResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The error code returned. If OK is returned, the authorization was successful. If another error code is returned, the authorization failed.</para>
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
            public List<AttachDatabaseAccountsToUserGroupResponseBodyResultsDatabaseAccounts> DatabaseAccounts { get; set; }
            public class AttachDatabaseAccountsToUserGroupResponseBodyResultsDatabaseAccounts : TeaModel {
                /// <summary>
                /// <para>The error code returned. If OK is returned, the authorization was successful. If another error code is returned, the authorization failed.</para>
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
                /// <para>8</para>
                /// </summary>
                [NameInMap("DatabaseAccountId")]
                [Validation(Required=false)]
                public string DatabaseAccountId { get; set; }

                /// <summary>
                /// <para>The error message returned.</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The database ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

            /// <summary>
            /// <para>The error message returned.</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The user group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }

        }

    }

}
