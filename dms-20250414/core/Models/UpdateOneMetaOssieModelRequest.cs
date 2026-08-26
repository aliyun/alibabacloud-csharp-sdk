// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class UpdateOneMetaOssieModelRequest : TeaModel {
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
        /// <para>The semantic description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Order summary</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The document type of the semantic model. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>JSON</description></item>
        /// <item><description>YAML</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>JSON</para>
        /// </summary>
        [NameInMap("DocFormat")]
        [Validation(Required=false)]
        public string DocFormat { get; set; }

        /// <summary>
        /// <para>The document definition of the semantic model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;version&quot;: &quot;0.2.0.dev0&quot;,
        ///   &quot;semantic_model&quot;: [
        ///     {
        ///       &quot;name&quot;: &quot;sales&quot;,
        ///       &quot;datasets&quot;: [
        ///         {
        ///           &quot;name&quot;: &quot;orders&quot;,
        ///           &quot;source&quot;: &quot;analytics.public.orders&quot;
        ///         }
        ///       ]
        ///     }
        ///   ]
        /// }</para>
        /// </summary>
        [NameInMap("Document")]
        [Validation(Required=false)]
        public string Document { get; set; }

        /// <summary>
        /// <para>The UUID of the knowledge.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86c5c290052147c***</para>
        /// </summary>
        [NameInMap("KnowledgeUuid")]
        [Validation(Required=false)]
        public string KnowledgeUuid { get; set; }

        /// <summary>
        /// <para>The tag of the semantic model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sales</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>The semantic title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Order total</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
