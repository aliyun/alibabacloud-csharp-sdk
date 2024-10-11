// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteDynamicImageRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the animated stickers.</para>
        /// <list type="bullet">
        /// <item><description>Separate multiple IDs with commas (,). You can specify a maximum of 10 IDs.</description></item>
        /// <item><description>If you do not set this parameter, the system finds the video specified by the VideoId parameter and deletes the information about the animated stickers associated with the video. If more than 10 animated stickers are associated with the video specified by the VideoId parameter, the deletion request is denied.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>beafec3834a4e52ea52042a4****,8281c8519847fd8970e79e80b6****</para>
        /// </summary>
        [NameInMap("DynamicImageIds")]
        [Validation(Required=false)]
        public string DynamicImageIds { get; set; }

        /// <summary>
        /// <para>The ID of the video associated with the animated stickers whose information you want to delete.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2321077d460b028700ef6c2f4d****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
