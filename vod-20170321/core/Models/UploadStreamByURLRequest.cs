// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UploadStreamByURLRequest : TeaModel {
        /// <summary>
        /// <para>The definition of the video stream.</para>
        /// <para>For valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/124671.html">Media asset parameter description - Definition</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HD</para>
        /// </summary>
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// <para>The file name extension of the transcoded stream file.</para>
        /// <para>For supported audio and video file formats, see <a href="https://help.aliyun.com/document_detail/55396.html">Overview</a>.</para>
        /// <para>If this parameter is not empty, it overwrites the file name extension in the StreamURL.</para>
        /// <remarks>
        /// <para>Notice: This parameter is required if the StreamURL does not contain a file name extension.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mp4</para>
        /// </summary>
        [NameInMap("FileExtension")]
        [Validation(Required=false)]
        public string FileExtension { get; set; }

        /// <summary>
        /// <para>The HDR type of the transcoded stream. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HDR</description></item>
        /// <item><description>HDR10</description></item>
        /// <item><description>HLG</description></item>
        /// <item><description>DolbyVision</description></item>
        /// <item><description>HDRVivid</description></item>
        /// <item><description>SDR+<remarks>
        /// <list type="bullet">
        /// <item><description>Case-insensitive.</description></item>
        /// <item><description>Leave this parameter empty for non-HDR videos.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HDR10</para>
        /// </summary>
        [NameInMap("HDRType")]
        [Validation(Required=false)]
        public string HDRType { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraVideo VOD media asset that corresponds to the transcoded stream.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca3a8f6e49*****57b65806709586</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The URL of the transcoded stream file.</para>
        /// <para>If the URL of the transcoded stream requires authentication, include the authentication parameters in StreamURL and make sure the URL is accessible through public network access.</para>
        /// <remarks>
        /// <para>You can obtain the audio or video URL from the console or by invoking the GetPlayInfo operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/lesson-01.mp4">https://example.com/lesson-01.mp4</a></para>
        /// </summary>
        [NameInMap("StreamURL")]
        [Validation(Required=false)]
        public string StreamURL { get; set; }

        /// <summary>
        /// <para>The metadata of the media file to upload. The value is a JSON string.</para>
        /// <list type="bullet">
        /// <item><description>For more information, see the <b>UploadMetadata</b> table below.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AddressMapping&quot;:&quot;1&quot;,&quot;CustomPath&quot;:&quot;test/xxx&quot;,&quot;CustomFileName&quot;:&quot;xxx.mp4&quot;,&quot;isOverwritePath&quot;:&quot;0&quot;}</para>
        /// </summary>
        [NameInMap("UploadMetadata")]
        [Validation(Required=false)]
        public string UploadMetadata { get; set; }

        /// <summary>
        /// <para>The custom parameter. For more information, see <a href="https://help.aliyun.com/document_detail/86952.html">UserData</a>.</para>
        /// <remarks>
        /// <para>To use the message callback in this parameter, configure the HTTP callback URL and select the corresponding callback event types in the console. Otherwise, the callback settings do not take effect. For information about how to configure HTTP callbacks in the console, see <a href="https://help.aliyun.com/document_detail/86071.html">Callback settings</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;<a href="http://aliyundoc.com%22%7D">http://aliyundoc.com&quot;}</a>, &quot;Extend&quot;:{&quot;localId&quot;:&quot;xxx&quot;,&quot;test&quot;:&quot;www&quot;}}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
