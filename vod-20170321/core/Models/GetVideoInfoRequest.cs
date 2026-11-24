// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoInfoRequest : TeaModel {
        /// <summary>
        /// <para>The custom ID. The ID must be 6 to 64 characters in length and can contain only lowercase letters, uppercase letters, digits, hyphens, and underscores. The ID must be unique per user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123-123</para>
        /// </summary>
        [NameInMap("ReferenceId")]
        [Validation(Required=false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// <para>The audio or video ID. Only one audio or video ID is supported. You can obtain the ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>For videos uploaded through the console, log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Assets</b> &gt; <b>Audio/Video</b> to view the audio or video ID.</description></item>
        /// <item><description>When you call the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation to obtain the upload URL and credential, the audio or video ID is the value of the VideoId response parameter.</description></item>
        /// <item><description>After the audio or video file is uploaded, you can call the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation to query the audio or video ID, which is the value of the VideoId response parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>9b73864d75f1d231e9001cd5f8****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
