// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class CreateTemplateRequest : TeaModel {
        /// <summary>
        /// <para>Callback URL to be invoked after template execution.  </para>
        /// <remarks>
        /// <para>Note: Templates triggered on demand do not support callback parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.com/callback">http://example.com/callback</a></para>
        /// </summary>
        [NameInMap("Callback")]
        [Validation(Required=false)]
        public string Callback { get; set; }

        /// <summary>
        /// <para>Template description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>录制模板</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Storage file format. Multiple values are separated by commas. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>mp4</description></item>
        /// <item><description>flv</description></item>
        /// <item><description>hls<remarks>
        /// <para>The Qingdao ingest endpoint does not support recording in FLV or MP4 formats.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hls</para>
        /// </summary>
        [NameInMap("FileFormat")]
        [Validation(Required=false)]
        public string FileFormat { get; set; }

        /// <summary>
        /// <para>Storage path for FLV files. For the format, see the description for Mp4.</para>
        /// 
        /// <b>Example:</b>
        /// <para>osspath/record/{StreamName}/{EscapedStartTime}_{EscapedEndTime}</para>
        /// </summary>
        [NameInMap("Flv")]
        [Validation(Required=false)]
        public string Flv { get; set; }

        /// <summary>
        /// <para>Storage path for HLS m3u8 files. For the format, see the description for Mp4.</para>
        /// 
        /// <b>Example:</b>
        /// <para>osspath/record/{StreamName}/{EscapedStartTime}_{EscapedEndTime}</para>
        /// </summary>
        [NameInMap("HlsM3u8")]
        [Validation(Required=false)]
        public string HlsM3u8 { get; set; }

        /// <summary>
        /// <para>Storage path for HLS .ts files.</para>
        /// <list type="bullet">
        /// <item><description>Variables can be used in the path. Supported variables include {AppName}, {StreamName}, {UnixTimestamp}, and {Sequence}.</description></item>
        /// <item><description>The variables {UnixTimestamp} and {Sequence} must both be included.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>osspath/record/{StreamName}/{UnixTimestamp}_{Sequence}</para>
        /// </summary>
        [NameInMap("HlsTs")]
        [Validation(Required=false)]
        public string HlsTs { get; set; }

        /// <summary>
        /// <para>Operation epoch, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        /// <summary>
        /// <para>Storage path for on-demand JPG screenshots.</para>
        /// <list type="bullet">
        /// <item><description>Only JPG images are currently supported.</description></item>
        /// <item><description>Variables can be used in the path. Supported variables include {AppName}, {StreamName}, {UnixTimestamp}, and {Sequence}.</description></item>
        /// <item><description>Either {UnixTimestamp} or {Sequence} must be included.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>osspath/snapshot/{AppName}/{StreamName}/{UnixTimestamp}_ondemand.jpg</para>
        /// </summary>
        [NameInMap("JpgOnDemand")]
        [Validation(Required=false)]
        public string JpgOnDemand { get; set; }

        /// <summary>
        /// <para>Storage path for JPG files used in overwrite snapshots.  </para>
        /// <list type="bullet">
        /// <item><description>Only JPG images are currently supported.  </description></item>
        /// <item><description>Supports variable substitution with {AppName} and {StreamName}.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>osspath/snapshot/{AppName}/{StreamName}.jpg</para>
        /// </summary>
        [NameInMap("JpgOverwrite")]
        [Validation(Required=false)]
        public string JpgOverwrite { get; set; }

        /// <summary>
        /// <para>Storage path for JPG files used in sequential snapshots.  </para>
        /// <list type="bullet">
        /// <item><description>Only JPG images are currently supported.  </description></item>
        /// <item><description>Supports variable substitution with {AppName}, {StreamName}, {UnixTimestamp}, and {Sequence}.  </description></item>
        /// <item><description>Either {UnixTimestamp} or {Sequence} is required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>osspath/snapshot/{AppName}/{StreamName}/{UnixTimestamp}.jpg</para>
        /// </summary>
        [NameInMap("JpgSequence")]
        [Validation(Required=false)]
        public string JpgSequence { get; set; }

        /// <summary>
        /// <para>Storage path for MP4 files.  </para>
        /// <list type="bullet">
        /// <item><description>The path supports variable substitution. Available variables include {AppName}, {StreamName}, {Sequence}, {EscapedStartTime}, and {EscapedEndTime}.  </description></item>
        /// <item><description>{EscapedStartTime} and {EscapedEndTime} are required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>osspath/record/{StreamName}/{EscapedStartTime}_{EscapedEndTime}</para>
        /// </summary>
        [NameInMap("Mp4")]
        [Validation(Required=false)]
        public string Mp4 { get; set; }

        /// <summary>
        /// <para>Template Name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>录制模板</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bucketname</para>
        /// </summary>
        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        /// <summary>
        /// <para>Domain name of OSS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-cn-qingdao.aliyuncs.com</para>
        /// </summary>
        [NameInMap("OssEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

        /// <summary>
        /// <para>OSS file prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-prefix</para>
        /// </summary>
        [NameInMap("OssFilePrefix")]
        [Validation(Required=false)]
        public string OssFilePrefix { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Region where the OSS bucket resides, that is, the service center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>Time-shift retention period, in days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public long? Retention { get; set; }

        /// <summary>
        /// <para>An array of TransConfig-type transcoding configurations, formatted as a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Fps&quot;:25,&quot;Gop&quot;:50,&quot;Height&quot;:720,&quot;VideoCodec&quot;:&quot;h264&quot;,&quot;Width&quot;:1280,&quot;Name&quot;:&quot;sd&quot;,&quot;VideoBitrate&quot;:800}]</para>
        /// </summary>
        [NameInMap("TransConfigsJSON")]
        [Validation(Required=false)]
        public string TransConfigsJSON { get; set; }

        /// <summary>
        /// <para>Template trigger type. Default value: auto. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>auto (automatic)  </description></item>
        /// <item><description>ondemand (on-demand)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public string Trigger { get; set; }

        /// <summary>
        /// <para>Template type. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description>record (recording)  </description></item>
        /// <item><description>snapshot (snapshot)  </description></item>
        /// <item><description>transcode (transcoding)  </description></item>
        /// <item><description>timeshift (time shifting)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>record</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
