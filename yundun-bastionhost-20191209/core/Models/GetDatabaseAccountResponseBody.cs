// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetDatabaseAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned information about the database account.</para>
        /// </summary>
        [NameInMap("DatabaseAccount")]
        [Validation(Required=false)]
        public GetDatabaseAccountResponseBodyDatabaseAccount DatabaseAccount { get; set; }
        public class GetDatabaseAccountResponseBodyDatabaseAccount : TeaModel {
            /// <summary>
            /// <para>The database account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("DatabaseAccountId")]
            [Validation(Required=false)]
            public string DatabaseAccountId { get; set; }

            /// <summary>
            /// <para>The name of the database account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>uac</para>
            /// </summary>
            [NameInMap("DatabaseAccountName")]
            [Validation(Required=false)]
            public string DatabaseAccountName { get; set; }

            /// <summary>
            /// <para>The database name. A value is returned for this parameter if the database engine is PostgreSQL or Oracle.</para>
            /// 
            /// <b>Example:</b>
            /// <para>orcl</para>
            /// </summary>
            [NameInMap("DatabaseSchema")]
            [Validation(Required=false)]
            public string DatabaseSchema { get; set; }

            /// <summary>
            /// <para>Indicates whether the database account has a password.
            /// Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasPassword")]
            [Validation(Required=false)]
            public bool? HasPassword { get; set; }

            /// <summary>
            /// <para>The logon attribute. A value is returned for this parameter if the database engine is Oracle. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SERVICENAME</description></item>
            /// <item><description>SID</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SID</para>
            /// </summary>
            [NameInMap("LoginAttribute")]
            [Validation(Required=false)]
            public string LoginAttribute { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FA06D274-8D0A-59FB-8B7E-584C0EEBBFFF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
