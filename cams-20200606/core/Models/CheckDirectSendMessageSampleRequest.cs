// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CheckDirectSendMessageSampleRequest : TeaModel {
        /// <summary>
        /// <para>The SpaceId of an ISV sub-customer or the instance ID of a direct customer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cams-xx**</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The body of an interactive message.</para>
        /// </summary>
        [NameInMap("Interactive")]
        [Validation(Required=false)]
        public Dictionary<string, object> Interactive { get; set; }

        /// <summary>
        /// <para>The body of a text message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;text&quot;: &quot;This is a direct send message&quot;}</para>
        /// </summary>
        [NameInMap("Text")]
        [Validation(Required=false)]
        public Dictionary<string, object> Text { get; set; }

        /// <summary>
        /// <para>The type of the direct message content. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>interactive</para>
        /// </description></item>
        /// <item><description><para>text</para>
        /// </description></item>
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
