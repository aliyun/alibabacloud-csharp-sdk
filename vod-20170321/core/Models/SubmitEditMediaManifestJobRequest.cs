// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitEditMediaManifestJobRequest : TeaModel {
        /// <summary>
        /// <para>The list of audio tracks to be added. The value is a JSON string array. Each element contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>Language</b>: the language identifier of the audio track.</description></item>
        /// <item><description><b>Name</b>: the display name of the track. If this field is not specified, the default value is audio-{Language}.</description></item>
        /// <item><description><b>AudioUrl</b>: the URL of the audio file, which is an OSS object URL.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Language&quot;:&quot;spa&quot;,&quot;Name&quot;:&quot;audio-spa&quot;,&quot;AudioUrl&quot;:&quot;<a href="https://your-bucket.oss-cn-shanghai.aliyuncs.com/audio/spa.aac%22%7D%5D">https://your-bucket.oss-cn-shanghai.aliyuncs.com/audio/spa.aac&quot;}]</a></para>
        /// </summary>
        [NameInMap("AudioTracks")]
        [Validation(Required=false)]
        public string AudioTracks { get; set; }

        /// <summary>
        /// <para>The job ID of the target AUTO stream.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2c6581d59240de5e258ffa4c71a3****</para>
        /// </summary>
        [NameInMap("AutoStreamJobId")]
        [Validation(Required=false)]
        public string AutoStreamJobId { get; set; }

        /// <summary>
        /// <para>The output configuration. The value is a JSON string. It contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>OutputDir</b>: the output directory. By default, this field is set to the same directory as the source manifest.</description></item>
        /// <item><description><b>ManifestName</b>: the file name of the output master playlist. Default value: master. The .m3u8 extension is not allowed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;OutputDir&quot;:&quot;output/editmanifest/&quot;,&quot;ManifestName&quot;:&quot;master&quot;}</para>
        /// </summary>
        [NameInMap("OutputConfig")]
        [Validation(Required=false)]
        public string OutputConfig { get; set; }

        /// <summary>
        /// <para>The configuration of tracks to be removed. The value is a JSON string. It contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>AudioLanguages</b>: the list of audio language identifiers for which the entire audio tracks are to be removed.</description></item>
        /// <item><description><b>SubtitleLanguages</b>: the list of subtitle language identifiers for which the entire subtitle tracks are to be removed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AudioLanguages&quot;:[&quot;fra&quot;],&quot;SubtitleLanguages&quot;:[&quot;ger&quot;]}</para>
        /// </summary>
        [NameInMap("RemoveTracks")]
        [Validation(Required=false)]
        public string RemoveTracks { get; set; }

        /// <summary>
        /// <para>The list of subtitle tracks to be added. The value is a JSON string array. Each element contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>Language</b>: the language identifier of the subtitle track. If this field is not specified, the subtitle track is ignored.</description></item>
        /// <item><description><b>SubtitleUrl</b>: the URL of the subtitle file in WebVTT format, which is an OSS object URL.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Language&quot;:&quot;eng&quot;,&quot;SubtitleUrl&quot;:&quot;<a href="https://your-bucket.oss-cn-shanghai.aliyuncs.com/sub/eng.vtt%22%7D%5D">https://your-bucket.oss-cn-shanghai.aliyuncs.com/sub/eng.vtt&quot;}]</a></para>
        /// </summary>
        [NameInMap("Subtitles")]
        [Validation(Required=false)]
        public string Subtitles { get; set; }

        /// <summary>
        /// <para>The manifest editing template ID, which is returned after the AddManifestEditTemplate operation is called. If this parameter is specified, the output tracks are orchestrated based on the fixed video, audio, and subtitle item configurations in the template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9c6581d59240de5e258ffa4c71a3e01b</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The custom pass-through data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;remark&quot;:&quot;add-french-remove-english&quot;}</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para><b>The target video ID</b>, used for authentication isolation and consistency verification.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2cd8a4f4a67cb7fb8e1236f847f4****</para>
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

        /// <summary>
        /// <para>The list of video tracks to be added. The value is a JSON string array. Each element contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>Name</b>: the display name of the track. If this field is not specified, the video track is ignored.</description></item>
        /// <item><description><b>VideoUrl</b>: the URL of the video stream manifest file, which is an OSS object URL.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Name&quot;:&quot;uhd&quot;,&quot;VideoUrl&quot;:&quot;<a href="https://your-bucket.oss-cn-shanghai.aliyuncs.com/video/uhd/uhd.m3u8%22%7D%5D">https://your-bucket.oss-cn-shanghai.aliyuncs.com/video/uhd/uhd.m3u8&quot;}]</a></para>
        /// </summary>
        [NameInMap("VideoTracks")]
        [Validation(Required=false)]
        public string VideoTracks { get; set; }

    }

}
