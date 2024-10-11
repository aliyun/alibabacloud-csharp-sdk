// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UploadStreamByURLRequest : TeaModel {
        /// <summary>
        /// <para>The quality of the video stream.</para>
        /// <para>For more information about valid values of this parameter, see <a href="https://help.aliyun.com/document_detail/124671.html">Parameters for media assets</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HD</para>
        /// </summary>
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// <para>The file name extension of the transcoded stream.</para>
        /// <para>For more information, see the Supported media file formats section in <a href="https://help.aliyun.com/document_detail/55396.html">Overview</a>.</para>
        /// <para>If you set a value for this parameter, the file name extension specified in StreamURL is overwritten.</para>
        /// <remarks>
        /// <para> This parameter is required if you do not specify a file name extension in StreamURL.</para>
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
        /// <item><description>SDR+</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The HDR type of the transcoded stream is not case-sensitive.</para>
        /// </description></item>
        /// <item><description><para>You can leave this parameter empty for non-HDR streams.</para>
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
        /// <para>The media ID in ApsaraVideo VOD.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca3a8f6e49*****57b65806709586</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The URL of the transcoded stream.</para>
        /// <para>If URL authentication is required, you must pass authentication information in this parameter and make sure that the URL can be accessed over the Internet.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/lesson-01.mp4">https://example.com/lesson-01.mp4</a></para>
        /// </summary>
        [NameInMap("StreamURL")]
        [Validation(Required=false)]
        public string StreamURL { get; set; }

        /// <summary>
        /// <para>The user-defined parameter. For more information, see the &quot;UserData: specifies the custom configurations for media upload&quot; section of the <a href="https://help.aliyun.com/document_detail/86952.html">Request parameters</a> topic.</para>
        /// <remarks>
        /// <para> The callback configurations you specify for this parameter take effect only after you specify the HTTP callback URL and select specific callback events in the ApsaraVideo VOD console. For more information about how to configure HTTP callback settings in the ApsaraVideo VOD console, see <a href="https://help.aliyun.com/document_detail/86071.html">Configure callback settings</a>.</para>
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
