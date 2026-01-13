// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDatabaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The permission control information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>=Tc/test_001\ntest_001=CTc/test_001</para>
        /// </summary>
        [NameInMap("AccessPrivilege")]
        [Validation(Required=false)]
        public string AccessPrivilege { get; set; }

        /// <summary>
        /// <para>The character set.</para>
        /// <para>For more information about the value range, see Document <a href="https://www.postgresql.org/docs/current/multibyte.html">https://www.postgresql.org/docs/current/multibyte.html</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UTF8</para>
        /// </summary>
        [NameInMap("CharacterSetName")]
        [Validation(Required=false)]
        public string CharacterSetName { get; set; }

        /// <summary>
        /// <para>Database locale parameter that specifies string comparison and sorting rules.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The locale must be compatible with the character set specified by the CharacterSetName parameter.</para>
        /// </description></item>
        /// <item><description><para>Collate: You can query available collations using the command SELECT DISTINCT collname FROM pg_collation;. If not specified, the default value is en_US.utf8.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en_US.utf8</para>
        /// </summary>
        [NameInMap("Collate")]
        [Validation(Required=false)]
        public string Collate { get; set; }

        /// <summary>
        /// <para>Limits the number of concurrent connections. -1 indicates unlimited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("ConnLimit")]
        [Validation(Required=false)]
        public string ConnLimit { get; set; }

        /// <summary>
        /// <para>Database locale parameter that specifies character classification and case conversion rules.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The locale must be compatible with the character set specified by the CharacterSetName parameter.</para>
        /// </description></item>
        /// <item><description><para>You can execute the SELECT DISTINCT collctype FROM pg_collation; statement to obtain the field value. The default value is en_US.utf8.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en_US.utf8</para>
        /// </summary>
        [NameInMap("Ctype")]
        [Validation(Required=false)]
        public string Ctype { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The database name.</para>
        /// <list type="bullet">
        /// <item><description>Only contain letters, digits, and underscores (_).</description></item>
        /// <item><description>Must start with a letter.</description></item>
        /// <item><description>Up to 63 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test01</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The database comment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A user management database storing customer profiles.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The owner of the table.</para>
        /// <list type="bullet">
        /// <item><description>Contain lowercase letters, digits, and underscores (_).</description></item>
        /// <item><description>Must start with a lowercase letter and end with a lowercase letter or a digit.</description></item>
        /// <item><description>Cannot start with gp.</description></item>
        /// <item><description>Must be 2 to 16 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testadb</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The database size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000 MB</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public string Size { get; set; }

        /// <summary>
        /// <para>The database tablespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg_default</para>
        /// </summary>
        [NameInMap("TableSpace")]
        [Validation(Required=false)]
        public string TableSpace { get; set; }

    }

}
