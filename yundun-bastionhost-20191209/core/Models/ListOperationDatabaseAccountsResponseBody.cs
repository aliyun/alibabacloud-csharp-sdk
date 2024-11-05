// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListOperationDatabaseAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The database accounts returned.</para>
        /// </summary>
        [NameInMap("DatabaseAccounts")]
        [Validation(Required=false)]
        public List<ListOperationDatabaseAccountsResponseBodyDatabaseAccounts> DatabaseAccounts { get; set; }
        public class ListOperationDatabaseAccountsResponseBodyDatabaseAccounts : TeaModel {
            /// <summary>
            /// <para>The name of the PostgreSQL or Oracle database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xe</para>
            /// </summary>
            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

            /// <summary>
            /// <para>The database account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("DatabaseAccountId")]
            [Validation(Required=false)]
            public string DatabaseAccountId { get; set; }

            /// <summary>
            /// <para>The name of the database account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("DatabaseAccountName")]
            [Validation(Required=false)]
            public string DatabaseAccountName { get; set; }

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
            /// <para>Indicates whether a password is configured for the database host account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasPassword")]
            [Validation(Required=false)]
            public string HasPassword { get; set; }

            /// <summary>
            /// <para>The logon attribute. One of the following values is returned if the database engine is Oracle:</para>
            /// <list type="bullet">
            /// <item><description><b>SERVICENAME</b></description></item>
            /// <item><description><b>SID</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SID</para>
            /// </summary>
            [NameInMap("LoginAttribute")]
            [Validation(Required=false)]
            public string LoginAttribute { get; set; }

            /// <summary>
            /// <para>The protocol that is used by the database account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("ProtocolName")]
            [Validation(Required=false)]
            public string ProtocolName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
