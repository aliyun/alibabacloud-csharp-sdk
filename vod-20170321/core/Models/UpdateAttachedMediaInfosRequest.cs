// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateAttachedMediaInfosRequest : TeaModel {
        /// <summary>
        /// <para>The update content. You can update the information of up to 20 auxiliary media assets at a time. For the parameter structure, refer to the <b>UpdateContent</b> table below.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The update content for <c>Title</c>, <c>Description</c>, and <c>Tags</c> cannot contain emojis.</description></item>
        /// <item><description>If a parameter is passed, the corresponding field is updated. Otherwise, the field is not overwritten or updated.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;MediaId&quot;:&quot;bbc65bba53f6ed90de118a7849****&quot;,&quot;Title&quot;:&quot;Title 1&quot;,&quot;Description&quot;:&quot;Description 1&quot;,&quot;Tags&quot;:&quot;Tag 1,Tag 2&quot;},{&quot;MediaId&quot;:&quot;f45cf4eba5cb90233389558c39****&quot;,&quot;Title2&quot;:&quot;Title&quot;,&quot;Description2&quot;:&quot;Description&quot;,&quot;Tags&quot;:&quot;Tag 3,Tag 4&quot;}]</para>
        /// </summary>
        [NameInMap("UpdateContent")]
        [Validation(Required=false)]
        public string UpdateContent { get; set; }

    }

}
