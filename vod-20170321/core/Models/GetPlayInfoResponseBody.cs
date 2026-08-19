// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetPlayInfoResponseBody : TeaModel {
        [NameInMap("PlayInfoList")]
        [Validation(Required=false)]
        public GetPlayInfoResponseBodyPlayInfoList PlayInfoList { get; set; }
        public class GetPlayInfoResponseBodyPlayInfoList : TeaModel {
            [NameInMap("PlayInfo")]
            [Validation(Required=false)]
            public List<GetPlayInfoResponseBodyPlayInfoListPlayInfo> PlayInfo { get; set; }
            public class GetPlayInfoResponseBodyPlayInfoListPlayInfo : TeaModel {
                [NameInMap("BitDepth")]
                [Validation(Required=false)]
                public int? BitDepth { get; set; }

                [NameInMap("Bitrate")]
                [Validation(Required=false)]
                public string Bitrate { get; set; }

                [NameInMap("CodecName")]
                [Validation(Required=false)]
                public string CodecName { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("Definition")]
                [Validation(Required=false)]
                public string Definition { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public string Duration { get; set; }

                [NameInMap("Encrypt")]
                [Validation(Required=false)]
                public long? Encrypt { get; set; }

                [NameInMap("EncryptMode")]
                [Validation(Required=false)]
                public string EncryptMode { get; set; }

                [NameInMap("EncryptType")]
                [Validation(Required=false)]
                public string EncryptType { get; set; }

                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                [NameInMap("Fps")]
                [Validation(Required=false)]
                public string Fps { get; set; }

                [NameInMap("HDRType")]
                [Validation(Required=false)]
                public string HDRType { get; set; }

                [NameInMap("Height")]
                [Validation(Required=false)]
                public long? Height { get; set; }

                [NameInMap("JobExt")]
                [Validation(Required=false)]
                public string JobExt { get; set; }

                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                [NameInMap("JobType")]
                [Validation(Required=false)]
                public int? JobType { get; set; }

                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                [NameInMap("NarrowBandType")]
                [Validation(Required=false)]
                public string NarrowBandType { get; set; }

                [NameInMap("PlayURL")]
                [Validation(Required=false)]
                public string PlayURL { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                [NameInMap("Specification")]
                [Validation(Required=false)]
                public string Specification { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StreamType")]
                [Validation(Required=false)]
                public string StreamType { get; set; }

                [NameInMap("WatermarkId")]
                [Validation(Required=false)]
                public string WatermarkId { get; set; }

                [NameInMap("Width")]
                [Validation(Required=false)]
                public long? Width { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F552E596-967D-5500-842F-17E6364****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The basic information about the audio or video file.</para>
        /// </summary>
        [NameInMap("VideoBase")]
        [Validation(Required=false)]
        public GetPlayInfoResponseBodyVideoBase VideoBase { get; set; }
        public class GetPlayInfoResponseBodyVideoBase : TeaModel {
            /// <summary>
            /// <para>The thumbnail URL of the audio or video file.</para>
            /// <remarks>
            /// <para>To obtain the thumbnail URL in real time after uploading a video, configure ApsaraVideo VOD callbacks. For more information, refer to <a href="https://help.aliyun.com/document_detail/67214.html">HTTP callback</a> and <a href="https://help.aliyun.com/document_detail/57337.html">SnapshotComplete event</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.aliyundoc.com/sample.jpg?auth_key=2333232-atb">http://example.aliyundoc.com/sample.jpg?auth_key=2333232-atb</a>****</para>
            /// </summary>
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            /// <summary>
            /// <para>The time when the audio or video file was created. The time follows the ISO 8601 standard in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-06-26T06:38:48Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The URL of the China-accessible bullet screen mask data.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.aliyundoc.com/****?auth_key=abdf2123-6783232">http://example.aliyundoc.com/****?auth_key=abdf2123-6783232</a>****</para>
            /// </summary>
            [NameInMap("DanMuURL")]
            [Validation(Required=false)]
            public string DanMuURL { get; set; }

            /// <summary>
            /// <para>The duration of the audio or video file. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.1667</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <para>The type of the media file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>video</b>: video.</description></item>
            /// <item><description><b>audio</b>: audio-only.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("MediaType")]
            [Validation(Required=false)]
            public string MediaType { get; set; }

            /// <summary>
            /// <para>The status of the audio or video file. For valid values and descriptions, refer to <a href="~~52839#title-vqg-8cz-7p8~~">Status: audio and video status</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The storage class of the media asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Standard</b>: standard.</description></item>
            /// <item><description><b>IA</b>: media asset infrequent access.</description></item>
            /// <item><description><b>Archive</b>: media asset archive.</description></item>
            /// <item><description><b>ColdArchive</b>: media asset cold archive.</description></item>
            /// <item><description><b>SourceIA</b>: source file infrequent access.</description></item>
            /// <item><description><b>SourceArchive</b>: source file archive.</description></item>
            /// <item><description><b>SourceColdArchive</b>: source file cold archive.</description></item>
            /// <item><description><b>Changing</b>: media asset storage class is being changed.</description></item>
            /// <item><description><b>SourceChanging</b>: source file storage class is being changed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("StorageClass")]
            [Validation(Required=false)]
            public string StorageClass { get; set; }

            /// <summary>
            /// <para>The title of the audio or video file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud VOD</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The audio or video ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>93ab850b4f654b6e91d24d81d44****</para>
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

    }

}
