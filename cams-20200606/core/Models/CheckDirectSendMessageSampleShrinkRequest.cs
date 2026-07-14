// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CheckDirectSendMessageSampleShrinkRequest : TeaModel {
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
        /// </summary>
        [NameInMap("Interactive")]
        [Validation(Required=false)]
        public string InteractiveShrink { get; set; }

        /// <summary>
        /// <para>The message body of the text content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;text&quot;: &quot;This is a direct send message&quot;}</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public string TextShrink { get; set; }

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
