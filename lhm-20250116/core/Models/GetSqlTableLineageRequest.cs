// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetSqlTableLineageRequest : TeaModel {
        /// <summary>
        /// <para>The default schema (database) name, which is used to complete table references in the SQL script that do not explicitly specify a database name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db_demo</para>
        /// </summary>
        [NameInMap("defaultSchema")]
        [Validation(Required=false)]
        public string DefaultSchema { get; set; }

        /// <summary>
        /// <para>The SQL dialect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hive</para>
        /// </summary>
        [NameInMap("dialect")]
        [Validation(Required=false)]
        public string Dialect { get; set; }

        /// <summary>
        /// <para>The source script content, Base64-encoded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>U0VMRUNUICogRlJPTSB0Ow==</para>
        /// </summary>
        [NameInMap("sourceSqlScriptBase64")]
        [Validation(Required=false)]
        public string SourceSqlScriptBase64 { get; set; }

    }

}
