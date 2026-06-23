// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class AttachDatabaseAccountsToUserGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5D0EB759-CB0A-537D-A2CC-13A9854FA08D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The results of the call.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<AttachDatabaseAccountsToUserGroupResponseBodyResults> Results { get; set; }
        public class AttachDatabaseAccountsToUserGroupResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The error code. If the value is \<c>OK\\</c>, the authorization was successful. Other values indicate that the authorization failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>A list of database account information.</para>
            /// </summary>
            [NameInMap("DatabaseAccounts")]
            [Validation(Required=false)]
            public List<AttachDatabaseAccountsToUserGroupResponseBodyResultsDatabaseAccounts> DatabaseAccounts { get; set; }
            public class AttachDatabaseAccountsToUserGroupResponseBodyResultsDatabaseAccounts : TeaModel {
                /// <summary>
                /// <para>The error code. If the value is \<c>OK\\</c>, the authorization was successful. Other values indicate that the authorization failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OK</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The ID of the database account.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("DatabaseAccountId")]
                [Validation(Required=false)]
                public string DatabaseAccountId { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NULL</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The ID of the database instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NULL</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The ID of the user group.</para>
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
