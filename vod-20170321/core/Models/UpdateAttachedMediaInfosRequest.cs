// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateAttachedMediaInfosRequest : TeaModel {
        /// <summary>
        /// <para>The update content. You can update the information of up to 20 auxiliary media assets at a time. For the parameter structure, see the <b>UpdateContent</b> table below.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The <c>Title</c>, <c>Description</c>, and <c>Tags</c> fields cannot contain emoticons.</description></item>
        /// <item><description>If a parameter is specified, the corresponding field is updated. Otherwise, the corresponding field is not overwritten or updated.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;MediaId&quot;:&quot;bbc65bba53f6ed90de118a7849****&quot;,&quot;Title&quot;:&quot; title1&quot;,&quot;Description&quot;:&quot; description1&quot;,&quot;Tags&quot;:&quot; tag1, tag2&quot;},{&quot;MediaId&quot;:&quot;f45cf4eba5cb90233389558c39****&quot;,&quot;Title2&quot;:&quot; title&quot;,&quot;Description2&quot;:&quot; description&quot;,&quot;Tags&quot;:&quot; tag3, tag4&quot;}]</para>
        /// </summary>
        [NameInMap("UpdateContent")]
        [Validation(Required=false)]
        public string UpdateContent { get; set; }

    }

}
