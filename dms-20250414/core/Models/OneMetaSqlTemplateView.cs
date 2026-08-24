// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class OneMetaSqlTemplateView : TeaModel {
        /// <summary>
        /// <para>The UUID of the associated folder.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mc-HZ-OfjcNc2z***</para>
        /// </summary>
        [NameInMap("CatalogUuid")]
        [Validation(Required=false)]
        public string CatalogUuid { get; set; }

        /// <summary>
        /// <para>The UUID of the associated database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>md-HZ-fp9K7r***</para>
        /// </summary>
        [NameInMap("DatabaseUuid")]
        [Validation(Required=false)]
        public string DatabaseUuid { get; set; }

        /// <summary>
        /// <para>The description of the SQL template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sales count</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The content of the SQL template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT store_name, daily_sales FROM store_daily_sales ORDER BY daily_sales DESC LIMIT 5</para>
        /// </summary>
        [NameInMap("Expr")]
        [Validation(Required=false)]
        public string Expr { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787302285000</para>
        /// </summary>
        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public long? GmtCreated { get; set; }

        /// <summary>
        /// <para>The modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1787302285000</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        /// <summary>
        /// <para>The UUID of the knowledge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86c5c290052147c***</para>
        /// </summary>
        [NameInMap("KnowledgeUuid")]
        [Validation(Required=false)]
        public string KnowledgeUuid { get; set; }

        /// <summary>
        /// <para>The source of the SQL template knowledge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DATA_AGENT</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The parameters of the SQL template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dt&quot;: &quot;2026-08-01&quot;}</para>
        /// </summary>
        [NameInMap("SqlParams")]
        [Validation(Required=false)]
        public string SqlParams { get; set; }

        /// <summary>
        /// <para>The summary of the SQL template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sales summary</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        /// <summary>
        /// <para>The tag of the SQL template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new_sales</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>The title of the SQL template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecommerce_sales</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The version of the SQL template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
