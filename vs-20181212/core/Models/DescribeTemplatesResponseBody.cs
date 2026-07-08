// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageCount")]
        [Validation(Required=false)]
        public long? PageCount { get; set; }

        /// <summary>
        /// <para>Page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// <para>Number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F3F88C96-CA6E-573E-B8F7-5BE83A1A0BCF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Template list.</para>
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<DescribeTemplatesResponseBodyTemplates> Templates { get; set; }
        public class DescribeTemplatesResponseBodyTemplates : TeaModel {
            /// <summary>
            /// <para>Callback URL after template execution.</para>
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
            /// <para>2018-12-10T10:00:00Z</para>
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
            /// <para>Storage file format. Separate multiple values with commas. Valid values: mp4, flv, hls, jpg.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hls</para>
            /// </summary>
            [NameInMap("FileFormat")]
            [Validation(Required=false)]
            public string FileFormat { get; set; }

            /// <summary>
            /// <para>FLV storage path.</para>
            /// <remarks>
            /// <para>This applies only to recording templates.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>osspath/record/{StreamName}/{EscapedStartTime}_{EscapedEndTime}</para>
            /// </summary>
            [NameInMap("Flv")]
            [Validation(Required=false)]
            public string Flv { get; set; }

            /// <summary>
            /// <para>HLS storage path for M3U8 files.</para>
            /// <remarks>
            /// <para>This applies only to recording templates.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>osspath/record/{StreamName}/{EscapedStartTime}_{EscapedEndTime}</para>
            /// </summary>
            [NameInMap("HlsM3u8")]
            [Validation(Required=false)]
            public string HlsM3u8 { get; set; }

            /// <summary>
            /// <para>HLS storage path for TS files.</para>
            /// <remarks>
            /// <para>This applies only to recording templates.</para>
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
            /// <para>Operation interval in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("Interval")]
            [Validation(Required=false)]
            public long? Interval { get; set; }

            /// <summary>
            /// <para>JPG storage path for on-demand snapshots.</para>
            /// <remarks>
            /// <para>This applies only to snapshot templates.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>osspath/snapshot/{AppName}/{StreamName}/{UnixTimestamp}_ondemand.jpg</para>
            /// </summary>
            [NameInMap("JpgOnDemand")]
            [Validation(Required=false)]
            public string JpgOnDemand { get; set; }

            /// <summary>
            /// <para>JPG storage path for overwrite snapshots.</para>
            /// <remarks>
            /// <para>This applies only to snapshot templates.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>osspath/snapshot/{AppName}/{StreamName}.jpg</para>
            /// </summary>
            [NameInMap("JpgOverwrite")]
            [Validation(Required=false)]
            public string JpgOverwrite { get; set; }

            /// <summary>
            /// <para>JPG storage path for sequential snapshots.</para>
            /// <remarks>
            /// <para>This applies only to snapshot templates.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>osspath/snapshot/{AppName}/{StreamName}/{UnixTimestamp}.jpg</para>
            /// </summary>
            [NameInMap("JpgSequence")]
            [Validation(Required=false)]
            public string JpgSequence { get; set; }

            /// <summary>
            /// <para>MP4 storage path.</para>
            /// <remarks>
            /// <para>This applies only to recording templates.</para>
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
            /// <para>The OSS bucket.</para>
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
            /// <para>my_prefix</para>
            /// </summary>
            [NameInMap("OssFilePrefix")]
            [Validation(Required=false)]
            public string OssFilePrefix { get; set; }

            /// <summary>
            /// <para>OSS region, also known as service center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-qingdao</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>Time-shifting retention period in days.</para>
            /// <remarks>
            /// <para>This applies only to time-shifting templates.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Retention")]
            [Validation(Required=false)]
            public long? Retention { get; set; }

            /// <summary>
            /// <para>Transcoding configuration list.</para>
            /// <remarks>
            /// <para>This applies only to transcoding templates.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("TransConfigs")]
            [Validation(Required=false)]
            public List<DescribeTemplatesResponseBodyTemplatesTransConfigs> TransConfigs { get; set; }
            public class DescribeTemplatesResponseBodyTemplatesTransConfigs : TeaModel {
                /// <summary>
                /// <para>Video frame rate in fps.</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("Fps")]
                [Validation(Required=false)]
                public long? Fps { get; set; }

                /// <summary>
                /// <para>Video GOP in frames.</para>
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
                /// <para>Transcoding rule name. This name becomes the suffix of the transcoded stream. Use a descriptive suffix such as sd or 200k. Only letters and numbers are allowed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sd</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Video bitrate in kbps.</para>
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

                /// <summary>
                /// <para>Transcoding configuration ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>399788187729597430-cn-qingdao</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

            }

            /// <summary>
            /// <para>Template trigger type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>auto (automatic)</para>
            /// </description></item>
            /// <item><description><para>ondemand (on demand)</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This applies only to recording templates.</para>
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
            /// <item><description><para>record (recording)</para>
            /// </description></item>
            /// <item><description><para>snapshot (snapshot)</para>
            /// </description></item>
            /// <item><description><para>transcode (transcoding)</para>
            /// </description></item>
            /// <item><description><para>timeshift (time shifting)</para>
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

        /// <summary>
        /// <para>Total number of templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
