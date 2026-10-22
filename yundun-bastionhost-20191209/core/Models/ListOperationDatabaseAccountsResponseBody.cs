// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListOperationDatabaseAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of database accounts.</para>
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
            /// <para>The ID of the database account.</para>
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
            /// <para>The database instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

            /// <summary>
            /// <para>Indicates whether a password is set for the database host account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasPassword")]
            [Validation(Required=false)]
            public string HasPassword { get; set; }

            /// <summary>
            /// <para>The logon attribute. This parameter has a return value only for Oracle databases. Valid values:</para>
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
            /// <para>The protocol name of the database account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("ProtocolName")]
            [Validation(Required=false)]
            public string ProtocolName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of queried manageable database accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
