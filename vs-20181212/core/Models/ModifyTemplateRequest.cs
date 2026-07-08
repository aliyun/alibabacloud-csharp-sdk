// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ModifyTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The callback URL that is used after the template is executed.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.com/callback">http://example.com/callback</a></para>
        /// </summary>
        [NameInMap("Callback")]
        [Validation(Required=false)]
        public string Callback { get; set; }

        /// <summary>
        /// <para>The description of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>录制模板</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The file format for storage. Separate multiple values with commas. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>mp4</para>
        /// </description></item>
        /// <item><description><para>flv</para>
        /// </description></item>
        /// <item><description><para>hls</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Recording in FLV and MP4 formats is not supported in the China (Qingdao) region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hls</para>
        /// </summary>
        [NameInMap("FileFormat")]
        [Validation(Required=false)]
        public string FileFormat { get; set; }

        /// <summary>
        /// <para>The storage path for FLV files. For information about the format, see the description of the Mp4 parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>osspath/record/{StreamName}/{EscapedStartTime}_{EscapedEndTime}</para>
        /// </summary>
        [NameInMap("Flv")]
        [Validation(Required=false)]
        public string Flv { get; set; }

        /// <summary>
        /// <para>The storage path for HLS M3U8 files. For information about the format, see the description of the Mp4 parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>osspath/record/{StreamName}/{EscapedStartTime}_{EscapedEndTime}</para>
        /// </summary>
        [NameInMap("HlsM3u8")]
        [Validation(Required=false)]
        public string HlsM3u8 { get; set; }

        /// <summary>
        /// <para>The storage path for HLS TS files.</para>
        /// <list type="bullet">
        /// <item><description><para>The path supports variables such as {AppName}, {StreamName}, {UnixTimestamp}, and {Sequence}.</para>
        /// </description></item>
        /// <item><description><para>You must include the {UnixTimestamp} and {Sequence} variables.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>osspath/record/{StreamName}/{UnixTimestamp}_{Sequence}</para>
        /// </summary>
        [NameInMap("HlsTs")]
        [Validation(Required=false)]
        public string HlsTs { get; set; }

        /// <summary>
        /// <para>The ID of the template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>323*****998-cn-qingdao</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The operation interval, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        /// <summary>
        /// <para>The storage path for JPG files. This path is used for on-demand snapshots.</para>
        /// <list type="bullet">
        /// <item><description><para>Only JPG images are supported.</para>
        /// </description></item>
        /// <item><description><para>The path supports variables such as {AppName}, {StreamName}, {UnixTimestamp}, and {Sequence}.</para>
        /// </description></item>
        /// <item><description><para>You must include either {UnixTimestamp} or {Sequence}.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>osspath/snapshot/{AppName}/{StreamName}/{UnixTimestamp}_ondemand.jpg</para>
        /// </summary>
        [NameInMap("JpgOnDemand")]
        [Validation(Required=false)]
        public string JpgOnDemand { get; set; }

        /// <summary>
        /// <para>The storage path for JPG files. This path is used to overwrite snapshots.</para>
        /// <list type="bullet">
        /// <item><description><para>Only JPG images are supported.</para>
        /// </description></item>
        /// <item><description><para>The path supports variables such as {AppName} and {StreamName}.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>osspath/snapshot/{AppName}/{StreamName}.jpg</para>
        /// </summary>
        [NameInMap("JpgOverwrite")]
        [Validation(Required=false)]
        public string JpgOverwrite { get; set; }

        /// <summary>
        /// <para>The storage path for JPG files. This path is used for sequence snapshots.</para>
        /// <list type="bullet">
        /// <item><description><para>Only JPG images are supported.</para>
        /// </description></item>
        /// <item><description><para>The path supports variables such as {AppName}, {StreamName}, {UnixTimestamp}, and {Sequence}.</para>
        /// </description></item>
        /// <item><description><para>You must include either {UnixTimestamp} or {Sequence}.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>osspath/snapshot/{AppName}/{StreamName}/{UnixTimestamp}.jpg</para>
        /// </summary>
        [NameInMap("JpgSequence")]
        [Validation(Required=false)]
        public string JpgSequence { get; set; }

        /// <summary>
        /// <para>The storage path for MP4 files.</para>
        /// <list type="bullet">
        /// <item><description><para>The path supports variables such as {AppName}, {StreamName}, {Sequence}, {EscapedStartTime}, and {EscapedEndTime}.</para>
        /// </description></item>
        /// <item><description><para>You must include {EscapedStartTime} and {EscapedEndTime}.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>osspath/record/{StreamName}/{EscapedStartTime}_{EscapedEndTime}</para>
        /// </summary>
        [NameInMap("Mp4")]
        [Validation(Required=false)]
        public string Mp4 { get; set; }

        /// <summary>
        /// <para>The name of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>录制模板</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bucketname</para>
        /// </summary>
        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        /// <summary>
        /// <para>The domain name of the OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss-cn-qingdao.aliyuncs.com</para>
        /// </summary>
        [NameInMap("OssEndpoint")]
        [Validation(Required=false)]
        public string OssEndpoint { get; set; }

        /// <summary>
        /// <para>The prefix of the OSS file.</para>
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
        /// <para>The region where the Object Storage Service (OSS) bucket is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The retention period for time shifting, in days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public long? Retention { get; set; }

        /// <summary>
        /// <para>An array of transcoding configurations of the TransConfig type, in a JSON-formatted string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Fps&quot;:25,&quot;Gop&quot;:50,&quot;Height&quot;:720,&quot;VideoCodec&quot;:&quot;h264&quot;,&quot;Width&quot;:1280,&quot;Name&quot;:&quot;sd&quot;,&quot;VideoBitrate&quot;:800}]</para>
        /// </summary>
        [NameInMap("TransConfigsJSON")]
        [Validation(Required=false)]
        public string TransConfigsJSON { get; set; }

        /// <summary>
        /// <para>The trigger type of the template. The default value is auto. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>auto (automatic)</para>
        /// </description></item>
        /// <item><description><para>ondemand (on-demand)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public string Trigger { get; set; }

    }

}
