// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>Callback URL triggered after template execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.com/callback">http://example.com/callback</a></para>
        /// </summary>
        [NameInMap("Callback")]
        [Validation(Required=false)]
        public string Callback { get; set; }

        /// <summary>
        /// <para>Template creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-12-10T10:00:00Z</para>
        /// </summary>
        [NameInMap("CreatedTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

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
        /// <para>Storage file format. Separate multiple values with commas. Valid values: mp4, flv, hls, jpg</para>
        /// 
        /// <b>Example:</b>
        /// <para>hls</para>
        /// </summary>
        [NameInMap("FileFormat")]
        [Validation(Required=false)]
        public string FileFormat { get; set; }

        /// <summary>
        /// <para>Storage path for FLV files.</para>
        /// <remarks>
        /// <para>Applies only to recording templates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>osspath/record/{StreamName}/{EscapedStartTime}_{EscapedEndTime}</para>
        /// </summary>
        [NameInMap("Flv")]
        [Validation(Required=false)]
        public string Flv { get; set; }

        /// <summary>
        /// <para>Storage path for HLS .m3u8 files.</para>
        /// <remarks>
        /// <para>Applies only to recording templates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>osspath/record/{StreamName}/{EscapedStartTime}_{EscapedEndTime}</para>
        /// </summary>
        [NameInMap("HlsM3u8")]
        [Validation(Required=false)]
        public string HlsM3u8 { get; set; }

        /// <summary>
        /// <para>Storage path for HLS .ts files.</para>
        /// <remarks>
        /// <para>Applies only to recording templates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>osspath/record/{StreamName}/{UnixTimestamp}_{Sequence}</para>
        /// </summary>
        [NameInMap("HlsTs")]
        [Validation(Required=false)]
        public string HlsTs { get; set; }

        /// <summary>
        /// <para>Template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>323*****998-cn-qingdao</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Operation interval, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        /// <summary>
        /// <para>Storage path for JPG files used for on-demand snapshots.</para>
        /// <remarks>
        /// <para>Applies only to snapshot templates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>osspath/snapshot/{AppName}/{StreamName}/{UnixTimestamp}_ondemand.jpg</para>
        /// </summary>
        [NameInMap("JpgOnDemand")]
        [Validation(Required=false)]
        public string JpgOnDemand { get; set; }

        /// <summary>
        /// <para>Storage path for JPG files used to overwrite snapshots.</para>
        /// <remarks>
        /// <para>Applies only to snapshot templates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>osspath/snapshot/{AppName}/{StreamName}.jpg</para>
        /// </summary>
        [NameInMap("JpgOverwrite")]
        [Validation(Required=false)]
        public string JpgOverwrite { get; set; }

        /// <summary>
        /// <para>Storage path for JPG files used for sequential snapshots.</para>
        /// <remarks>
        /// <para>Applies only to snapshot templates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>osspath/snapshot/{AppName}/{StreamName}/{UnixTimestamp}.jpg</para>
        /// </summary>
        [NameInMap("JpgSequence")]
        [Validation(Required=false)]
        public string JpgSequence { get; set; }

        /// <summary>
        /// <para>Storage path for MP4 files.</para>
        /// <remarks>
        /// <para>Applies only to recording templates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>osspath/record/{StreamName}/{EscapedStartTime}_{EscapedEndTime}</para>
        /// </summary>
        [NameInMap("Mp4")]
        [Validation(Required=false)]
        public string Mp4 { get; set; }

        /// <summary>
        /// <para>Template name.</para>
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
        /// <para>my_oss_bucket</para>
        /// </summary>
        [NameInMap("OssBucket")]
        [Validation(Required=false)]
        public string OssBucket { get; set; }

        /// <summary>
        /// <para>OSS domain name.</para>
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

        /// <summary>
        /// <para>OSS region, which is the service center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Timeshift retention period, in days.</para>
        /// <remarks>
        /// <para>Applies only to timeshift templates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Retention")]
        [Validation(Required=false)]
        public long? Retention { get; set; }

        /// <summary>
        /// <para>List of transcoding configurations.</para>
        /// <remarks>
        /// <para>Applies only to transcoding templates.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TransConfigs")]
        [Validation(Required=false)]
        public List<DescribeTemplateResponseBodyTransConfigs> TransConfigs { get; set; }
        public class DescribeTemplateResponseBodyTransConfigs : TeaModel {
            /// <summary>
            /// <para>Video frame rate, in fps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("Fps")]
            [Validation(Required=false)]
            public long? Fps { get; set; }

            /// <summary>
            /// <para>Video GOP, in frames.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("Gop")]
            [Validation(Required=false)]
            public long? Gop { get; set; }

            /// <summary>
            /// <para>Video height.</para>
            /// 
            /// <b>Example:</b>
            /// <para>720</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }

            /// <summary>
            /// <para>Transcoding configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>399*****430-cn-qingdao</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Transcoding rule name. The name appears as a suffix in the transcoded stream. We recommend using recognizable suffixes such as sd or 200k. Only letters and digits are supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sd</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Video bitrate, in kbps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>800</para>
            /// </summary>
            [NameInMap("VideoBitrate")]
            [Validation(Required=false)]
            public long? VideoBitrate { get; set; }

            /// <summary>
            /// <para>Video encoding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>h264</para>
            /// </summary>
            [NameInMap("VideoCodec")]
            [Validation(Required=false)]
            public string VideoCodec { get; set; }

            /// <summary>
            /// <para>Video width.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1280</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }

        }

        /// <summary>
        /// <para>Template trigger type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>auto</para>
        /// </description></item>
        /// <item><description><para>ondemand</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Applies only to recording templates.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("Trigger")]
        [Validation(Required=false)]
        public string Trigger { get; set; }

        /// <summary>
        /// <para>Template type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>record</para>
        /// </description></item>
        /// <item><description><para>snapshot</para>
        /// </description></item>
        /// <item><description><para>transcode</para>
        /// </description></item>
        /// <item><description><para>timeshift</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>record</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
