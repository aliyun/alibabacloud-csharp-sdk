// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeAccountAuthorityResponseBody : TeaModel {
        /// <summary>
        /// <para>The database account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The list of authorized databases.</para>
        /// </summary>
        [NameInMap("AllowDatabases")]
        [Validation(Required=false)]
        public List<string> AllowDatabases { get; set; }

        /// <summary>
        /// <para>The list of authorized dictionaries.</para>
        /// </summary>
        [NameInMap("AllowDictionaries")]
        [Validation(Required=false)]
        public List<string> AllowDictionaries { get; set; }

        /// <summary>
        /// <para>Indicates whether the account has DDL permissions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: DDL is allowed.</description></item>
        /// <item><description><b>false</b>: DDL is not allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DdlAuthority")]
        [Validation(Required=false)]
        public bool? DdlAuthority { get; set; }

        /// <summary>
        /// <para>Indicates whether the account has DML permissions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>all</b>: Read, write, and settings permissions.</description></item>
        /// <item><description><b>readOnly,modify</b>: Read and settings permissions.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("DmlAuthority")]
        [Validation(Required=false)]
        public string DmlAuthority { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5178C10-1407-4987-9133-DE4DC9119F75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of all databases.</para>
        /// </summary>
        [NameInMap("TotalDatabases")]
        [Validation(Required=false)]
        public List<string> TotalDatabases { get; set; }

        /// <summary>
        /// <para>The list of all dictionaries.</para>
        /// </summary>
        [NameInMap("TotalDictionaries")]
        [Validation(Required=false)]
        public List<string> TotalDictionaries { get; set; }

    }

}
