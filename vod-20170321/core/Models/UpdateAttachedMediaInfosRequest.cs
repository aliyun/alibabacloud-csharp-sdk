// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateAttachedMediaInfosRequest : TeaModel {
        /// <summary>
        /// <para>The new information about the one or more images. You can modify the information about up to 20 auxiliary media assets at a time. For more information, see the <b>UpdateContent</b> section of this topic.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You cannot specify emojis for <c>Title</c>, <c>Description</c>, or <c>Tags</c>.</description></item>
        /// <item><description>The specific parameter of a video is updated only when a new value is passed in the parameter.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;MediaId &quot;:&quot;bbc65bba53f6ed90de118a7849****&quot;,&quot;Title&quot;:&quot; test title1&quot;,&quot;Description&quot;:&quot;test description1&quot;,&quot;Tags&quot;:&quot;tag1,tag2&quot;},{&quot;MediaId &quot;:&quot;f45cf4eba5cb90233389558c39****&quot;,&quot;Title2&quot;:&quot;test title2&quot;,&quot;Description2&quot;:&quot;test description2&quot;,&quot;Tags&quot;:&quot;tag3,tag4&quot;}]</para>
        /// </summary>
        [NameInMap("UpdateContent")]
        [Validation(Required=false)]
        public string UpdateContent { get; set; }

    }

}
