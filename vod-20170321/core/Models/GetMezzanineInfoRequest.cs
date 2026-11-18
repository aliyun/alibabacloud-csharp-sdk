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
        /// <item><description><b>video</b>: the video stream information.</description></item>
        /// <item><description><b>audio</b>: the audio stream information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>video</para>
        /// </summary>
        [NameInMap("AdditionType")]
        [Validation(Required=false)]
        public string AdditionType { get; set; }

        /// <summary>
        /// <para>The expiration time of the signature for the FileURL (source file URL). Unit: seconds. Default value: <b>3600</b>. Minimum value: <b>1</b>.</para>
        /// <list type="bullet">
        /// <item><description>If OutputType is set to <b>cdn</b>:<list type="bullet">
        /// <item><description>The FileURL expires periodically only if URL authentication is enabled. Otherwise, the FileURL is permanently valid.</description></item>
        /// <item><description>Minimum value: <b>1</b>.</description></item>
        /// <item><description>Maximum value: unlimited.</description></item>
        /// <item><description>Default value: <b>3600</b> if not specified.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If OutputType is set to <b>oss</b>:<list type="bullet">
        /// <item><description>The FileURL expires periodically only if the storage permission is set to private. Otherwise, the FileURL is permanently valid.</description></item>
        /// <item><description>Minimum value: <b>1</b>.</description></item>
        /// <item><description>Maximum value: To reduce security risks of the origin server, the maximum value is <b>2592000</b> (30 days) when the audio or video file is stored in an ApsaraVideo VOD bucket, and <b>129600</b> (36 hours) when the audio or video file is stored in a user-owned OSS bucket.</description></item>
        /// <item><description>Default value: <b>3600</b> if not specified.</description></item>
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
        /// <para>The output URL type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>oss</b>: the back-to-origin URL.</description></item>
        /// <item><description><b>cdn</b> (default): the accelerated URL.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If the bucket where the source file is stored is of the in type, only the OSS URL is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss</para>
        /// </summary>
        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

        /// <summary>
        /// <para>The custom ID. The ID must be 6 to 64 characters in length and can contain only lowercase letters, uppercase letters, digits, hyphens (-), and underscores (_). The ID must be unique per user.</para>
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
        /// <item><description>For an audio or video file uploaded in the console, log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Media Assets</b> &gt; <b>Audio/Video</b> to view the video ID.</description></item>
        /// <item><description>When you call the <a href="https://help.aliyun.com/document_detail/55407.html">Obtain the upload URL and credential for a video</a> operation to obtain the upload URL and credential, the audio or video ID is the value of the VideoId response parameter.</description></item>
        /// <item><description>After a video is uploaded, you can call the <a href="https://help.aliyun.com/document_detail/86044.html">Search media information</a> operation to query the audio or video ID, which is the value of the VideoId response parameter.</description></item>
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
