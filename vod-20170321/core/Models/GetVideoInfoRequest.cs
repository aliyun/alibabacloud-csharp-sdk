// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoInfoRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the audio or video file. You can specify only one ID in each call. You can use one of the following methods to obtain the ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Media Files</b> &gt; <b>Audio/Video</b>. On the Video and Audio page, view the ID of the audio or video file. This method is applicable to files that are uploaded by using the ApsaraVideo VOD console.</description></item>
        /// <item><description>Obtain the value of VideoId from the response to the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation that you called to obtain the upload URL and credential.</description></item>
        /// <item><description>Obtain the value of VideoId from the response to the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation that you called to query the media ID after the media file is uploaded.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9b73864d75f1d231e9001cd5f8****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
