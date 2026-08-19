// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoPlayAuthRequest : TeaModel {
        /// <summary>
        /// <para>The API version number. Set the value to <b>1.0.0</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.0</para>
        /// </summary>
        [NameInMap("ApiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// <para>The expiration time of the playback credential. Unit: <b>seconds</b>. If the credential expires, the playback URL cannot be obtained. You must obtain a new credential.</para>
        /// <list type="bullet">
        /// <item><description>Default value: <b>100</b>.</description></item>
        /// <item><description>Valid values: <c>[100,3000]</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("AuthInfoTimeout")]
        [Validation(Required=false)]
        public long? AuthInfoTimeout { get; set; }

        /// <summary>
        /// <para>The custom ID. Only lowercase letters, uppercase letters, digits, hyphens, and underscores are supported. Length: 6 to 64 characters. The ID is unique per user.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123-123</para>
        /// </summary>
        [NameInMap("ReferenceId")]
        [Validation(Required=false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// <para>The audio or video ID. Only a single audio or video ID is supported. You can obtain the ID by using the following methods:</para>
        /// <list type="bullet">
        /// <item><description>For videos uploaded through the console, log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Files</b> &gt; <b>Audio/Video</b> to view the audio or video ID.</description></item>
        /// <item><description>When uploading audio or video files by calling the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation, the audio or video ID is the value of the VideoId response parameter.</description></item>
        /// <item><description>After the audio or video file is uploaded, you can call the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation to query the audio or video ID, which is the value of the VideoId response parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dfde02284a5c46622a097adaf44a****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
