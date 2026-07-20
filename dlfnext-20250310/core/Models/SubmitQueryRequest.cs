// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class SubmitQueryRequest : TeaModel {
        /// <summary>
        /// <para>The default catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_catalog</para>
        /// </summary>
        [NameInMap("defaultCatalog")]
        [Validation(Required=false)]
        public string DefaultCatalog { get; set; }

        /// <summary>
        /// <para>The default database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_db</para>
        /// </summary>
        [NameInMap("defaultDatabase")]
        [Validation(Required=false)]
        public string DefaultDatabase { get; set; }

        /// <summary>
        /// <para>The limit on the number of returned results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The SQL text. Multiple statements separated by semicolons are supported and executed sequentially within the same session.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select * from table_name;</para>
        /// </summary>
        [NameInMap("sql")]
        [Validation(Required=false)]
        public string Sql { get; set; }

        /// <summary>
        /// <para>The execution specifications. Default value: standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("tier")]
        [Validation(Required=false)]
        public string Tier { get; set; }

    }

}
