// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CheckDirectSendMessageSampleRequest : TeaModel {
        /// <summary>
        /// <para>The space ID of the ISV sub-customer or the instance ID of the direct customer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-xx**</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The message body of the interactive type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;type&quot;: &quot;cta_url&quot;, &quot;header&quot;: { &quot;type&quot;: &quot;text&quot;,&quot;text&quot;: &quot;Order Update&quot;}, &quot;body&quot;: { &quot;text&quot;: &quot;Your order is ready.&quot;}, &quot;action&quot;: { &quot;name&quot;: &quot;cta_url&quot;, &quot;parameters&quot;: { &quot;display_text&quot;: &quot;View Order&quot;,&quot;url&quot;: &quot;<a href="https://example.com">https://example.com</a>&quot;  } } }</para>
        /// </summary>
        [NameInMap("Interactive")]
        [Validation(Required=false)]
        public Dictionary<string, object> Interactive { get; set; }

        /// <summary>
        /// <para>The message body of the text content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;text&quot;: &quot;This is a direct send message&quot;}</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public Dictionary<string, object> Text { get; set; }

        /// <summary>
        /// <para>The direct-send content type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>interactive</description></item>
        /// <item><description>text</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>interactive</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
