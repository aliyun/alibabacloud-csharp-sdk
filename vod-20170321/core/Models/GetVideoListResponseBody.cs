// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoListResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of media files returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        /// <summary>
        /// <para>The information about the audio or video files. Information about a maximum of 5,000 audio or video files can be returned.</para>
        /// </summary>
        [NameInMap("VideoList")]
        [Validation(Required=false)]
        public GetVideoListResponseBodyVideoList VideoList { get; set; }
        public class GetVideoListResponseBodyVideoList : TeaModel {
            [NameInMap("Video")]
            [Validation(Required=false)]
            public List<GetVideoListResponseBodyVideoListVideo> Video { get; set; }
            public class GetVideoListResponseBodyVideoListVideo : TeaModel {
                /// <summary>
                /// <para>The ID of the application. Default value: <b>app-1000000</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>app-1000000</para>
                /// </summary>
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// <para>The category ID of the audio or video file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>781111</para>
                /// </summary>
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                /// <summary>
                /// <para>The name of the category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Category name</para>
                /// </summary>
                [NameInMap("CateName")]
                [Validation(Required=false)]
                public string CateName { get; set; }

                /// <summary>
                /// <para>The thumbnail URL of the audio or video file.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.aliyundoc.com/****.jpg">https://example.aliyundoc.com/****.jpg</a></para>
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// <para>The time when the audio or video file was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>hh:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-11-14T09:15:50Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The description of the audio or video file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Video description in ApsaraVideo VOD</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The duration of the audio or video file. Unit: seconds. 86,400 seconds is equivalent to 24 hours.</para>
                /// 
                /// <b>Example:</b>
                /// <para>135.6</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public float? Duration { get; set; }

                /// <summary>
                /// <para>The time when the video was updated. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>hh:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-11-14T09:16:50Z</para>
                /// </summary>
                [NameInMap("ModificationTime")]
                [Validation(Required=false)]
                public string ModificationTime { get; set; }

                /// <summary>
                /// <para>The period of time in which the audio or video file remains in the restored state.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-03-30T10:14:14Z</para>
                /// </summary>
                [NameInMap("RestoreExpiration")]
                [Validation(Required=false)]
                public string RestoreExpiration { get; set; }

                /// <summary>
                /// <para>The restoration status of the audio or video file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Processing</b></description></item>
                /// <item><description><b>Success</b></description></item>
                /// <item><description><b>Failed</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Success</para>
                /// </summary>
                [NameInMap("RestoreStatus")]
                [Validation(Required=false)]
                public string RestoreStatus { get; set; }

                /// <summary>
                /// <para>The size of the source file. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10897890</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <para>The URL array of video snapshots.</para>
                /// </summary>
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public GetVideoListResponseBodyVideoListVideoSnapshots Snapshots { get; set; }
                public class GetVideoListResponseBodyVideoListVideoSnapshots : TeaModel {
                    [NameInMap("Snapshot")]
                    [Validation(Required=false)]
                    public List<string> Snapshot { get; set; }

                }

                /// <summary>
                /// <para>The status of the audio or video file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Uploading</b>: The video is being uploaded.</description></item>
                /// <item><description><b>UploadFail</b>: The video failed to be uploaded.</description></item>
                /// <item><description><b>UploadSucc</b>: The video is uploaded.</description></item>
                /// <item><description><b>Transcoding</b>: The video is being transcoded.</description></item>
                /// <item><description><b>TranscodeFail</b>: The video failed to be transcoded.</description></item>
                /// <item><description><b>checking</b>: The video is being reviewed.</description></item>
                /// <item><description><b>Blocked</b>: The video is blocked.</description></item>
                /// <item><description><b>Normal</b>: The video is normal.</description></item>
                /// <item><description><b>ProduceFail</b>: The video failed to be produced.</description></item>
                /// </list>
                /// <para>For more information about each video status, see the &quot;Status: the status of a video&quot; section of the <a href="~~52839#section-p7c-jgy-070~~">Basic data types</a> topic.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The storage class of the audio or video file. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Standard</b>: All media resources are stored as Standard objects.</description></item>
                /// <item><description><b>IA</b>: All media resources are stored as IA objects.</description></item>
                /// <item><description><b>Archive</b>: All media resources are stored as Archive objects.</description></item>
                /// <item><description><b>ColdArchive</b>: All media resources are stored as Cold Archive objects.</description></item>
                /// <item><description><b>SourceIA</b>: Only the source files are IA objects.</description></item>
                /// <item><description><b>SourceArchive</b>: Only the source files are Archive objects.</description></item>
                /// <item><description><b>SourceColdArchive</b>: Only the source files are Cold Archive objects.</description></item>
                /// <item><description><b>Changing</b>: The storage class of the audio or video file is being changed.</description></item>
                /// <item><description><b>SourceChanging</b>: The storage class of the source file is being changed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("StorageClass")]
                [Validation(Required=false)]
                public string StorageClass { get; set; }

                /// <summary>
                /// <para>The storage address of the audio or video file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>out-****.oss-cn-shanghai.aliyuncs.com</para>
                /// </summary>
                [NameInMap("StorageLocation")]
                [Validation(Required=false)]
                public string StorageLocation { get; set; }

                /// <summary>
                /// <para>The tags of the audio or video file. Multiple tags are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>Tag 1,Tag 2</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public string Tags { get; set; }

                /// <summary>
                /// <para>The title of the audio or video file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Video title in ApsaraVideo VOD</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

                /// <summary>
                /// <para>The ID of the audio or video file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9ae2af636ca6c10412f44891fc****</para>
                /// </summary>
                [NameInMap("VideoId")]
                [Validation(Required=false)]
                public string VideoId { get; set; }

            }

        }

    }

}
