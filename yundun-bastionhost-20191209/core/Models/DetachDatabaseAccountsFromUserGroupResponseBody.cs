// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class DetachDatabaseAccountsFromUserGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AC528ED1-C302-56E5-9CB5-ADA625D64FF9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result of the call.</para>
        /// </summary>
        [NameInMap("Results")]
        [Validation(Required=false)]
        public List<DetachDatabaseAccountsFromUserGroupResponseBodyResults> Results { get; set; }
        public class DetachDatabaseAccountsFromUserGroupResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The error code that is returned. If OK is returned, the operation was successful. If other error codes are returned, the operation failed.</para>
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
            public List<DetachDatabaseAccountsFromUserGroupResponseBodyResultsDatabaseAccounts> DatabaseAccounts { get; set; }
            public class DetachDatabaseAccountsFromUserGroupResponseBodyResultsDatabaseAccounts : TeaModel {
                /// <summary>
                /// <para>The error code that is returned. If OK is returned, the operation was successful. If other error codes are returned, the operation failed.</para>
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
                /// <para>5</para>
                /// </summary>
                [NameInMap("DatabaseAccountId")]
                [Validation(Required=false)]
                public string DatabaseAccountId { get; set; }

                /// <summary>
                /// <para>The error message that is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>N/A</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The ID of the database on which the permissions are revoked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

            /// <summary>
            /// <para>The error message that is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>N/A</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The user group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("UserGroupId")]
            [Validation(Required=false)]
            public string UserGroupId { get; set; }

        }

    }

}
