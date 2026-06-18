// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeAccountListResponseBody : TeaModel {
        /// <summary>
        /// <para>The data struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeAccountListResponseBodyData> Data { get; set; }
        public class DescribeAccountListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The description of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testaccount desc</para>
            /// </summary>
            [NameInMap("AccountDescription")]
            [Validation(Required=false)]
            public string AccountDescription { get; set; }

            /// <summary>
            /// <para>The name of the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testAccount</para>
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// <para>The permissions granted to the account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ReadWrite</para>
            /// </summary>
            [NameInMap("AccountPrivilege")]
            [Validation(Required=false)]
            public string AccountPrivilege { get; set; }

            /// <summary>
            /// <para>The type of the account.</para>
            /// <list type="bullet">
            /// <item><description>Before three-role mode is enabled: 0 indicates a standard account, and 1 indicates a privileged user account.</description></item>
            /// <item><description>After three-role mode is enabled: 0 indicates a standard account, 2 indicates a system administrator account, 3 indicates a security administrator account, and 4 indicates an audit administrator account.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AccountType")]
            [Validation(Required=false)]
            public string AccountType { get; set; }

            /// <summary>
            /// <para>The name of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-*********</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// <para>The database to which the account is granted permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testdb</para>
            /// </summary>
            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

            /// <summary>
            /// <para>The time when the account was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2012-06-08T15:00Z</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

        }

        /// <summary>
        /// <para>The response message. &quot;success&quot; is returned if the request is successful. Otherwise, the corresponding error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B2F3840-5C98-475C-B269-2D5C3A31797C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
