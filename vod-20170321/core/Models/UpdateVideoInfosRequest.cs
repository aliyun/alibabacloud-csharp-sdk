// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateVideoInfosRequest : TeaModel {
        /// <summary>
        /// <para>The new information about audios or videos. You can modify the information about up to 20 audios or videos at a time. Separate multiple audios or videos with commas (,). When you modify the information exceed 20 audios or videos at a time, the update will fail with an error code <b>CountExceededMax</b>.</para>
        /// <para>The value is a JSON string. For more information, see the <b>UpdateContent</b> section of this topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;VideoId&quot;:&quot;f45cf4eba5cb90233389558c39****&quot;,&quot;Title&quot;:&quot;test title1&quot;},{&quot;VideoId&quot;:&quot;f45cf4eba5c84233389558c36****&quot;,&quot;Title&quot;:&quot;test title2&quot;}]</para>
        /// </summary>
        [NameInMap("UpdateContent")]
        [Validation(Required=false)]
        public string UpdateContent { get; set; }

    }

}
