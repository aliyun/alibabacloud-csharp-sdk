// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alimt20181012.Models
{
    public class GetTitleGenerateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{2:&quot;None&quot;,10:&quot;Plastic&quot;}</para>
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public string Attributes { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127896018</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{   &quot;product_id&quot;: &quot;1&quot;,   &quot;platform&quot;: &quot;ae&quot; }</para>
        /// </summary>
        [NameInMap("Extra")]
        [Validation(Required=false)]
        public string Extra { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>None,Plastic</para>
        /// </summary>
        [NameInMap("HotWords")]
        [Validation(Required=false)]
        public string HotWords { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ae</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10pcs 80ml Kitchen Disposable</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
