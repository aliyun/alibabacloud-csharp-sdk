// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class OssieModelView : TeaModel {
        /// <summary>
        /// <para>The UUID of the associated instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mc-SH-cd3ns***</para>
        /// </summary>
        [NameInMap("CatalogUuid")]
        [Validation(Required=false)]
        public string CatalogUuid { get; set; }

        /// <summary>
        /// <para>The UUID of the associated database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>md-SH-q8XzcK***</para>
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
        /// <para>The semantic document format type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JSON</para>
        /// </summary>
        [NameInMap("DocFormat")]
        [Validation(Required=false)]
        public string DocFormat { get; set; }

        /// <summary>
        /// <para>The domain topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Order</para>
        /// </summary>
        [NameInMap("DomainTopic")]
        [Validation(Required=false)]
        public string DomainTopic { get; set; }

        /// <summary>
        /// <para>The expression content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>select 1</para>
        /// </summary>
        [NameInMap("Expr")]
        [Validation(Required=false)]
        public string Expr { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1663809374000</para>
        /// </summary>
        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public long? GmtCreated { get; set; }

        /// <summary>
        /// <para>The modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1780539699000</para>
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        /// <summary>
        /// <para>The UUID of the semantic knowledge.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dfb58bd***</para>
        /// </summary>
        [NameInMap("KnowledgeUuid")]
        [Validation(Required=false)]
        public string KnowledgeUuid { get; set; }

        /// <summary>
        /// <para>The semantic document content.</para>
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
        [NameInMap("RawDoc")]
        [Validation(Required=false)]
        public string RawDoc { get; set; }

        /// <summary>
        /// <para>The semantic type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ossie</para>
        /// </summary>
        [NameInMap("SemanticType")]
        [Validation(Required=false)]
        public string SemanticType { get; set; }

        /// <summary>
        /// <para>The source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>USER_EDIT</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The document summary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>knowledge summary</para>
        /// </summary>
        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        /// <summary>
        /// <para>The knowledge base tag.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1dq7qod8hxtt1***</para>
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

        /// <summary>
        /// <para>The version information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.1</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
