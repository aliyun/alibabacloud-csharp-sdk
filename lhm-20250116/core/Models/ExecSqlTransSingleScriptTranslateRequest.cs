// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class ExecSqlTransSingleScriptTranslateRequest : TeaModel {
        /// <summary>
        /// <para>The source SQL dialect type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hive</para>
        /// </summary>
        [NameInMap("sourceDialect")]
        [Validation(Required=false)]
        public string SourceDialect { get; set; }

        /// <summary>
        /// <para>The source script content. It must be Base64-encoded before being passed in. The server decodes the content before performing the conversion.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT * FROM t;</para>
        /// </summary>
        [NameInMap("sourceSqlScript")]
        [Validation(Required=false)]
        public string SourceSqlScript { get; set; }

        /// <summary>
        /// <para>The table name mapping. In string format, the source table and target table are separated by a comma (,).</para>
        /// </summary>
        [NameInMap("tableMapping")]
        [Validation(Required=false)]
        public List<string> TableMapping { get; set; }

        /// <summary>
        /// <para>The target SQL dialect type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hive</para>
        /// </summary>
        [NameInMap("targetDialect")]
        [Validation(Required=false)]
        public string TargetDialect { get; set; }

    }

}
