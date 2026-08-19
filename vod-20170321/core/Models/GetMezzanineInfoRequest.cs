// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetMezzanineInfoRequest : TeaModel {
        /// <summary>
        /// <para>The type of additional information. Separate multiple values with commas (,). By default, only basic information is returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>video</b>: video stream information.</description></item>
        /// <item><description><b>audio</b>: audio stream information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("AdditionType")]
        [Validation(Required=false)]
        public string AdditionType { get; set; }

        /// <summary>
        /// <para>The validity period of the signature for FileURL (source file URL). Unit: seconds. Default value: <b>3600</b>. The minimum value is <b>1</b>.</para>
        /// <list type="bullet">
        /// <item><description>If OutputType is set to <b>cdn</b>:<list type="bullet">
        /// <item><description>FileURL expires periodically only if URL signing is enabled. Otherwise, FileURL is permanently valid.</description></item>
        /// <item><description>Minimum value: <b>1</b>.</description></item>
        /// <item><description>Maximum value: unlimited.</description></item>
        /// <item><description>Default value: <b>3600</b> if this parameter is not specified.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If OutputType is set to <b>oss</b>:<list type="bullet">
        /// <item><description>FileURL expires periodically only if the storage permission is set to private. Otherwise, FileURL is permanently valid.</description></item>
        /// <item><description>Minimum value: <b>1</b>.</description></item>
        /// <item><description>Maximum value: To reduce security risks to the origin server, the maximum value is <b>2592000</b> (30 days) when the audio or video file is stored in a bucket managed by ApsaraVideo VOD, and <b>129600</b> (36 hours) when the file is stored in your own OSS bucket.</description></item>
        /// <item><description>Default value: <b>3600</b> if this parameter is not specified.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("AuthTimeout")]
        [Validation(Required=false)]
        public long? AuthTimeout { get; set; }

        /// <summary>
        /// <para>The type of the output URL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>oss</b>: back-to-origin URL.</description></item>
        /// <item><description><b>cdn</b> (default): CDN URL.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the bucket type of the source file is in, only the OSS URL is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

        /// <summary>
        /// <para>The custom ID. Only lowercase letters, uppercase letters, digits, hyphens (-), and underscores (_) are supported. The value must be 6 to 64 characters in length and is unique at the user level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123-123</para>
        /// </summary>
        [NameInMap("ReferenceId")]
        [Validation(Required=false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// <para>The audio or video ID. You can obtain the ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>For audio or video files uploaded through the console, log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Files</b> &gt; <b>Audio/Video</b> to view the video ID.</description></item>
        /// <item><description>Obtain the video ID from the VideoId parameter returned by the <a href="https://help.aliyun.com/document_detail/55407.html">CreateUploadVideo</a> operation when you request an upload URL and credential.</description></item>
        /// <item><description>After the video is uploaded, call the <a href="https://help.aliyun.com/document_detail/86044.html">SearchMedia</a> operation to query the audio or video ID, which is the value of VideoId in the response.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1f1a6fc03ca04814031b8a6559e****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
