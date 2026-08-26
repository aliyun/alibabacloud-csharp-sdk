// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class UpdateOneMetaSqlTemplateRequest : TeaModel {
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
        /// <para>sales version 2</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The content of the SQL template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select count(1) from sales where dt = \&quot;2026-08-01\&quot;</para>
        /// </summary>
        [NameInMap("Expr")]
        [Validation(Required=false)]
        public string Expr { get; set; }

        /// <summary>
        /// <para>The UUID of the knowledge base.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86c5c290052147c***</para>
        /// </summary>
        [NameInMap("KnowledgeUuid")]
        [Validation(Required=false)]
        public string KnowledgeUuid { get; set; }

        /// <summary>
        /// <para>The custom template parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dt&quot;: &quot;2026-08-01&quot;}</para>
        /// </summary>
        [NameInMap("SqlParams")]
        [Validation(Required=false)]
        public string SqlParams { get; set; }

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
        /// <para>sales_v2</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
