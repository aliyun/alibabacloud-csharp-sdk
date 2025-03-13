// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class DescribeAccountAuthorityResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeAccountAuthorityResponseBodyData Data { get; set; }
        public class DescribeAccountAuthorityResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the database account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test1</para>
            /// </summary>
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            /// <summary>
            /// <para>The databases on which permissions are granted.</para>
            /// </summary>
            [NameInMap("AllowDatabases")]
            [Validation(Required=false)]
            public List<string> AllowDatabases { get; set; }

            /// <summary>
            /// <para>The dictionaries on which permissions are granted.</para>
            /// </summary>
            [NameInMap("AllowDictionaries")]
            [Validation(Required=false)]
            public List<string> AllowDictionaries { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cc-bp100p4q1g9z3****</para>
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// <para>Indicates whether the DDL permissions are granted to the database account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The account has the permissions to execute DDL statements.</description></item>
            /// <item><description><b>false</b>: The account does not have the permissions to execute DDL statements.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DdlAuthority")]
            [Validation(Required=false)]
            public bool? DdlAuthority { get; set; }

            /// <summary>
            /// <para>Indicates whether the DML permissions are granted to the database account. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The account has the permissions to read data from the database, write data to the database, and modify the settings of the database.</description></item>
            /// <item><description>1: The account only has the permissions to read data from the database.</description></item>
            /// <item><description>2: The account only has the permissions to read data from the database and modify the settings of the database.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("DmlAuthority")]
            [Validation(Required=false)]
            public int? DmlAuthority { get; set; }

            /// <summary>
            /// <para>All databases.</para>
            /// </summary>
            [NameInMap("TotalDatabases")]
            [Validation(Required=false)]
            public List<string> TotalDatabases { get; set; }

            /// <summary>
            /// <para>The database.</para>
            /// </summary>
            [NameInMap("TotalDictionaries")]
            [Validation(Required=false)]
            public List<string> TotalDictionaries { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5178C10-1407-4987-9133-DE4DC9119F75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
