// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListDatabaseAccountsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned database accounts.</para>
        /// </summary>
        [NameInMap("DatabaseAccounts")]
        [Validation(Required=false)]
        public List<ListDatabaseAccountsResponseBodyDatabaseAccounts> DatabaseAccounts { get; set; }
        public class ListDatabaseAccountsResponseBodyDatabaseAccounts : TeaModel {
            /// <summary>
            /// <para>The database account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>59</para>
            /// </summary>
            [NameInMap("DatabaseAccountId")]
            [Validation(Required=false)]
            public string DatabaseAccountId { get; set; }

            /// <summary>
            /// <para>The name of the database account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DatabaseAccountName")]
            [Validation(Required=false)]
            public string DatabaseAccountName { get; set; }

            /// <summary>
            /// <para>The database ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

            /// <summary>
            /// <para>The name of the database. A value is returned for this parameter if the engine of the database with the specified database ID is PostgreSQL or Oracle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>orcl</para>
            /// </summary>
            [NameInMap("DatabaseSchema")]
            [Validation(Required=false)]
            public string DatabaseSchema { get; set; }

            /// <summary>
            /// <para>Indicates whether the database account has a password. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasPassword")]
            [Validation(Required=false)]
            public string HasPassword { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4F6C075F-FC86-476E-943B-097BD4E12948</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of database accounts returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
