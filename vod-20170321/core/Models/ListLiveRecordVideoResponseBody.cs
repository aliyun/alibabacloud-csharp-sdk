// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListLiveRecordVideoResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of videos.</para>
        /// </summary>
        [NameInMap("LiveRecordVideoList")]
        [Validation(Required=false)]
        public ListLiveRecordVideoResponseBodyLiveRecordVideoList LiveRecordVideoList { get; set; }
        public class ListLiveRecordVideoResponseBodyLiveRecordVideoList : TeaModel {
            [NameInMap("LiveRecordVideo")]
            [Validation(Required=false)]
            public List<ListLiveRecordVideoResponseBodyLiveRecordVideoListLiveRecordVideo> LiveRecordVideo { get; set; }
            public class ListLiveRecordVideoResponseBodyLiveRecordVideoListLiveRecordVideo : TeaModel {
                /// <summary>
                /// <para>The name of the app.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testApp</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The ID of the playlist.</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("PlaylistId")]
                [Validation(Required=false)]
                public string PlaylistId { get; set; }

                /// <summary>
                /// <para>The recording end time. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-08T08:44:56Z</para>
                /// </summary>
                [NameInMap("RecordEndTime")]
                [Validation(Required=false)]
                public string RecordEndTime { get; set; }

                /// <summary>
                /// <para>The recording start time. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-08T07:40:56Z</para>
                /// </summary>
                [NameInMap("RecordStartTime")]
                [Validation(Required=false)]
                public string RecordStartTime { get; set; }

                /// <summary>
                /// <para>The name of the live-to-VOD file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>live-test</para>
                /// </summary>
                [NameInMap("StreamName")]
                [Validation(Required=false)]
                public string StreamName { get; set; }

                /// <summary>
                /// <para>The information about the live-to-VOD file.</para>
                /// </summary>
                [NameInMap("Video")]
                [Validation(Required=false)]
                public ListLiveRecordVideoResponseBodyLiveRecordVideoListLiveRecordVideoVideo Video { get; set; }
                public class ListLiveRecordVideoResponseBodyLiveRecordVideoListLiveRecordVideoVideo : TeaModel {
                    /// <summary>
                    /// <para>The ID of the video category.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>78</para>
                    /// </summary>
                    [NameInMap("CateId")]
                    [Validation(Required=false)]
                    public int? CateId { get; set; }

                    /// <summary>
                    /// <para>The category of the video.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Category name</para>
                    /// </summary>
                    [NameInMap("CateName")]
                    [Validation(Required=false)]
                    public string CateName { get; set; }

                    /// <summary>
                    /// <para>The URL of the video thumbnail.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://example.aliyundoc.com/coversample.jpg">https://example.aliyundoc.com/coversample.jpg</a></para>
                    /// </summary>
                    [NameInMap("CoverURL")]
                    [Validation(Required=false)]
                    public string CoverURL { get; set; }

                    /// <summary>
                    /// <para>The time when the audio or video file was created. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2017-12-08T07:40:56Z</para>
                    /// </summary>
                    [NameInMap("CreationTime")]
                    [Validation(Required=false)]
                    public string CreationTime { get; set; }

                    /// <summary>
                    /// <para>The description of the video file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Description of the ApsaraVideo VOD video</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The duration of the video file. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>135.6</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public float? Duration { get; set; }

                    /// <summary>
                    /// <para>The time when the video was updated. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2017-12-08T09:40:56Z</para>
                    /// </summary>
                    [NameInMap("ModifyTime")]
                    [Validation(Required=false)]
                    public string ModifyTime { get; set; }

                    /// <summary>
                    /// <para>The size of the source video file. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10897890</para>
                    /// </summary>
                    [NameInMap("Size")]
                    [Validation(Required=false)]
                    public long? Size { get; set; }

                    /// <summary>
                    /// <para>The array of video snapshot URLs.</para>
                    /// </summary>
                    [NameInMap("Snapshots")]
                    [Validation(Required=false)]
                    public ListLiveRecordVideoResponseBodyLiveRecordVideoListLiveRecordVideoVideoSnapshots Snapshots { get; set; }
                    public class ListLiveRecordVideoResponseBodyLiveRecordVideoListLiveRecordVideoVideoSnapshots : TeaModel {
                        [NameInMap("Snapshot")]
                        [Validation(Required=false)]
                        public List<string> Snapshot { get; set; }

                    }

                    /// <summary>
                    /// <para>The status of the video. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Uploading</b></description></item>
                    /// <item><description><b>UploadFail</b></description></item>
                    /// <item><description><b>UploadSuccess</b></description></item>
                    /// <item><description><b>Transcoding</b></description></item>
                    /// <item><description><b>TranscodeFail</b></description></item>
                    /// <item><description><b>Blocked</b></description></item>
                    /// <item><description><b>Normal</b>: The video is normal.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Normal</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The tags of the video. Multiple tags are separated with commas (,).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tag1, tag2</para>
                    /// </summary>
                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public string Tags { get; set; }

                    /// <summary>
                    /// <para>The ID of the transcoding template group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TemplateGroupId")]
                    [Validation(Required=false)]
                    public string TemplateGroupId { get; set; }

                    /// <summary>
                    /// <para>The title of the video.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Title of the ApsaraVideo VOD video</para>
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// <para>The ID of the video.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>93ab850b4f6f*****54b6e91d24d81d4</para>
                    /// </summary>
                    [NameInMap("VideoId")]
                    [Validation(Required=false)]
                    public string VideoId { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A13-****-D7393642CA58</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of videos.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
