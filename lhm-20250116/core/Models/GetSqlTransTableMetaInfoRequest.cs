// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LHM20250116.Models
{
    public class GetSqlTransTableMetaInfoRequest : TeaModel {
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
        /// <para>The source script content. You must Base64-encode the script before passing it in. The server decodes the content before parsing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT * FROM t;</para>
        /// </summary>
        [NameInMap("sourceSqlScript")]
        [Validation(Required=false)]
        public string SourceSqlScript { get; set; }

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
