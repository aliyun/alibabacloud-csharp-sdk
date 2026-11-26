// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDatabaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The access control information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>=Tc/test_001\ntest_001=CTc/test_001</para>
        /// </summary>
        [NameInMap("AccessPrivilege")]
        [Validation(Required=false)]
        public string AccessPrivilege { get; set; }

        /// <summary>
        /// <para>The character set.</para>
        /// <para>For the valid values, refer to the References at <a href="https://www.postgresql.org/docs/current/multibyte.html">https://www.postgresql.org/docs/current/multibyte.html</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UTF8</para>
        /// </summary>
        [NameInMap("CharacterSetName")]
        [Validation(Required=false)]
        public string CharacterSetName { get; set; }

        /// <summary>
        /// <para>The locale setting of the database, which specifies the string comparison and sorting rules.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The locale must be compatible with the character set specified by the CharacterSetName parameter.</description></item>
        /// <item><description>Valid values: You can run the SELECT DISTINCT collname FROM pg_collation; command to query the valid values. If this parameter is not specified, the default value is en_US.utf8.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>en_US.utf8</para>
        /// </summary>
        [NameInMap("Collate")]
        [Validation(Required=false)]
        public string Collate { get; set; }

        /// <summary>
        /// <para>The maximum number of concurrent connections. A value of -1 indicates no limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("ConnLimit")]
        [Validation(Required=false)]
        public string ConnLimit { get; set; }

        /// <summary>
        /// <para>The locale setting of the database, which specifies the character classification and case conversion rules.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The locale must be compatible with the character set specified by the CharacterSetName parameter.</description></item>
        /// <item><description>You can run the SELECT DISTINCT collctype FROM pg_collation; command to query the valid values. If this parameter is not specified, the default value is en_US.utf8.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>en_US.utf8</para>
        /// </summary>
        [NameInMap("Ctype")]
        [Validation(Required=false)]
        public string Ctype { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// <list type="bullet">
        /// <item><description><para>It can contain only letters, digits, and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>It must start with a letter.</para>
        /// </description></item>
        /// <item><description><para>It cannot exceed 63 characters in length.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test01</para>
        /// </summary>
        [NameInMap("DatabaseName")]
        [Validation(Required=false)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// <para>The description of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A user management database storing customer profiles.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The owner of the database.</para>
        /// <list type="bullet">
        /// <item><description><para>It can contain only lowercase letters, digits, and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>It must start with a lowercase letter and end with a lowercase letter or a digit.</para>
        /// </description></item>
        /// <item><description><para>It cannot start with gp.</para>
        /// </description></item>
        /// <item><description><para>It must be 2 to 16 characters in length.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testadb</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The size of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000 MB</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public string Size { get; set; }

        /// <summary>
        /// <para>The tablespace of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg_default</para>
        /// </summary>
        [NameInMap("TableSpace")]
        [Validation(Required=false)]
        public string TableSpace { get; set; }

    }

}
