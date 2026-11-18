// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UpdateVideoInfosRequest : TeaModel {
        /// <summary>
        /// <para>The update content. You can modify object information of up to 20 audio or video files at a time. Separate object information of multiple audio or video files with commas (,). If you attempt to update more than 20 files at a time, the update fails and the <c>CountExceededMax</c> error is returned.
        /// The value must be a JSON string. For more information about how to construct the parameters, see the <b>UpdateContent</b> table below.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;VideoId&quot;:&quot;f45cf4eba5cb90233389558c39****&quot;,&quot;Title&quot;:&quot;Alibaba Cloud VOD Video Title1&quot;},{&quot;VideoId&quot;:&quot;f45cf4eba5c84233389558c36****&quot;,&quot;Title&quot;:&quot;Alibaba Cloud VOD Video Title2&quot;}]</para>
        /// </summary>
        [NameInMap("UpdateContent")]
        [Validation(Required=false)]
        public string UpdateContent { get; set; }

    }

}
