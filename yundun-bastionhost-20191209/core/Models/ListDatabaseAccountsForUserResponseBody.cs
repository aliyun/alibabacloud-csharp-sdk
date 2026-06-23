// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ListDatabaseAccountsForUserResponseBody : TeaModel {
        /// <summary>
        /// <para>The database accounts returned.</para>
        /// </summary>
        [NameInMap("DatabaseAccounts")]
        [Validation(Required=false)]
        public List<ListDatabaseAccountsForUserResponseBodyDatabaseAccounts> DatabaseAccounts { get; set; }
        public class ListDatabaseAccountsForUserResponseBodyDatabaseAccounts : TeaModel {
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
            /// <para>The name of the database account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DatabaseAccountName")]
            [Validation(Required=false)]
            public string DatabaseAccountName { get; set; }

            /// <summary>
            /// <para>The ID of the database to which the database account belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>70</para>
            /// </summary>
            [NameInMap("DatabaseId")]
            [Validation(Required=false)]
            public string DatabaseId { get; set; }

            /// <summary>
            /// <para>Indicates whether the user is authorized to manage the database account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b></para>
            /// </description></item>
            /// <item><description><para><b>false</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsAuthorized")]
            [Validation(Required=false)]
            public bool? IsAuthorized { get; set; }

            /// <summary>
            /// <para>The protocol used by the database account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>MySQL</b></para>
            /// </description></item>
            /// <item><description><para><b>Oracle</b></para>
            /// </description></item>
            /// <item><description><para><b>PostgreSQL</b></para>
            /// </description></item>
            /// <item><description><para><b>SQLServer</b></para>
            /// </description></item>
            /// </list>
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
        /// <para>00E3701B-3616-55FE-93EC-E7CF5480B654</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of database accounts that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
