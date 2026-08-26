// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class CreateOneMetaSqlTemplateRequest : TeaModel {
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
        /// <para>sales template</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The content of the SQL template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SELECT SUM(amount) AS total_sales FROM store_daily_sales</para>
        /// </summary>
        [NameInMap("Expr")]
        [Validation(Required=false)]
        public string Expr { get; set; }

        /// <summary>
        /// <para>The knowledge source of the SQL template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DATA_AGENT</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The custom template parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;start_day_id&quot;: &quot;2026-08-01&quot;, &quot;end_day_id&quot;: &quot;2026-08-16&quot;}</para>
        /// </summary>
        [NameInMap("SqlParams")]
        [Validation(Required=false)]
        public string SqlParams { get; set; }

        /// <summary>
        /// <para>The tag of the SQL template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sales</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>The title of the SQL template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecommerce_sales</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
