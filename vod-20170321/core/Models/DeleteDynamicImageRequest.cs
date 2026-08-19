// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteDynamicImageRequest : TeaModel {
        /// <summary>
        /// <para>The list of animated sticker IDs. The animated sticker ID is the value of the DynamicImageId response parameter returned by the <a href="https://help.aliyun.com/document_detail/180958.html">ListDynamicImage</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>Separate multiple IDs with commas (,). You can specify a maximum of 10 IDs.</description></item>
        /// <item><description><b>If you do not specify this parameter, all animated stickers associated with the specified VideoId are deleted. However, if the video has more than 10 animated stickers, the deletion request is rejected.</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>beafec3834a4e52ea52042a4****,8281c8519847fd8970e79e80b6****</para>
        /// </summary>
        [NameInMap("DynamicImageIds")]
        [Validation(Required=false)]
        public string DynamicImageIds { get; set; }

        /// <summary>
        /// <para>The ID of the video associated with the animated stickers that you want to delete. You can obtain the video ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>For videos uploaded through the console, log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Files</b> &gt; <b>Audio/Video</b> to view the video ID.</description></item>
        /// <item><description>Obtain the video ID from the value of the VideoId response parameter when you call the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation to obtain the upload URL and credential.</description></item>
        /// <item><description>After the video is uploaded, call the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation to query the video ID, which is the value of the VideoId response parameter.</description></item>
        /// </list>
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
