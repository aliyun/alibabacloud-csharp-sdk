// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoInfosRequest : TeaModel {
        /// <summary>
        /// <para>The list of custom IDs. Separate multiple IDs with commas (,). You can specify a maximum of 20 IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123-123,1234-1234</para>
        /// </summary>
        [NameInMap("ReferenceIds")]
        [Validation(Required=false)]
        public string ReferenceIds { get; set; }

        /// <summary>
        /// <para>The list of audio or video IDs. Separate multiple IDs with commas (,). You can specify a maximum of 20 IDs. You can obtain the audio or video ID by using the following methods:</para>
        /// <list type="bullet">
        /// <item><description>If the video is uploaded by using the ApsaraVideo VOD console, log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Files</b> &gt; <b>Audio/Video</b> to view the audio or video ID.</description></item>
        /// <item><description>Obtain the audio or video ID from the value of the VideoId response parameter when you call the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation to obtain the upload URL and credential.</description></item>
        /// <item><description>After the audio or video file is uploaded, you can call the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation to query the audio or video ID, which is the value of the VideoId response parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>7753d144efd8e649c6c45fe0579****,7753d144efd74d6c45fe0570****</para>
        /// </summary>
        [NameInMap("VideoIds")]
        [Validation(Required=false)]
        public string VideoIds { get; set; }

    }

}
