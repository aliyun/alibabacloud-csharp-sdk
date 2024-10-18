// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class UpdateRangeShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[[&quot;#ff0000&quot;,&quot;#ff0000&quot;,&quot;#ff0000&quot;]]</para>
        /// </summary>
        [NameInMap("BackgroundColors")]
        [Validation(Required=false)]
        public string BackgroundColorsShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[[&quot;type&quot;: &quot;path&quot;,&quot;link&quot;: &quot;<a href="https://www.dingtalk.com%22,%22text">https://www.dingtalk.com&quot;,&quot;text</a>&quot;: &quot;test&quot;]]</para>
        /// </summary>
        [NameInMap("Hyperlinks")]
        [Validation(Required=false)]
        public string HyperlinksShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>General</para>
        /// </summary>
        [NameInMap("NumberFormat")]
        [Validation(Required=false)]
        public string NumberFormat { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A3:C3</para>
        /// </summary>
        [NameInMap("RangeAddress")]
        [Validation(Required=false)]
        public string RangeAddress { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sheet1</para>
        /// </summary>
        [NameInMap("SheetId")]
        [Validation(Required=false)]
        public string SheetId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[[&quot;1&quot;,&quot;2&quot;,&quot;3&quot;]]</para>
        /// </summary>
        [NameInMap("Values")]
        [Validation(Required=false)]
        public string ValuesShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stxxxx</para>
        /// </summary>
        [NameInMap("WorkbookId")]
        [Validation(Required=false)]
        public string WorkbookId { get; set; }

    }

}
