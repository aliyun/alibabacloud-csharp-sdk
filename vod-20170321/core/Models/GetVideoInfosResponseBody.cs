// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoInfosResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the videos that do not exist.</para>
        /// </summary>
        [NameInMap("NonExistVideoIds")]
        [Validation(Required=false)]
        public List<string> NonExistVideoIds { get; set; }

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
        /// <para>The information about the audio or video files.</para>
        /// </summary>
        [NameInMap("VideoList")]
        [Validation(Required=false)]
        public List<GetVideoInfosResponseBodyVideoList> VideoList { get; set; }
        public class GetVideoInfosResponseBodyVideoList : TeaModel {
            /// <summary>
            /// <para>The ID of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The ID of the category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>781111****</para>
            /// </summary>
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            /// <summary>
            /// <para>The name of the category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a category name.</para>
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
            /// <para>The time when the media file was created. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-06-26T05:38:48Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the audio or video file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a category description.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the offline download feature is enabled. If you enable the offline download feature, users can download and play videos by using the ApsaraVideo Player on a local PC. For more information, see <a href="https://help.aliyun.com/document_detail/86107.html">Configure download settings</a>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: the offline download feature is enabled.</description></item>
            /// <item><description><b>off</b>: the offline download feature is not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("DownloadSwitch")]
            [Validation(Required=false)]
            public string DownloadSwitch { get; set; }

            /// <summary>
            /// <para>The duration of the audio or video file. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            /// <summary>
            /// <para>The time when the audio or video file was last updated. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-06-26T06:38:48Z</para>
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// <para>The period of time in which the audio file remains in the restored state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-30T10:14:14Z</para>
            /// </summary>
            [NameInMap("RestoreExpiration")]
            [Validation(Required=false)]
            public string RestoreExpiration { get; set; }

            /// <summary>
            /// <para>The restoration status of the audio file. Valid values:</para>
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
            /// <para>453</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The video snapshot URLs.</para>
            /// </summary>
            [NameInMap("Snapshots")]
            [Validation(Required=false)]
            public List<string> Snapshots { get; set; }

            /// <summary>
            /// <para>The status of the video. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Uploading</b></description></item>
            /// <item><description><b>UploadFail</b></description></item>
            /// <item><description><b>UploadSucc</b></description></item>
            /// <item><description><b>Transcoding</b></description></item>
            /// <item><description><b>TranscodeFail</b></description></item>
            /// <item><description><b>Blocked</b></description></item>
            /// <item><description><b>Normal</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The storage class of the audio file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Standard</b>: All media resources are stored as Standard objects.</description></item>
            /// <item><description><b>IA</b>: All media resources are stored as IA objects.</description></item>
            /// <item><description><b>Archive</b>: All media resources are stored as Archive objects.</description></item>
            /// <item><description><b>ColdArchive</b>: All media resources are stored as Cold Archive objects.</description></item>
            /// <item><description><b>SourceIA</b>: Only the source files are IA objects.</description></item>
            /// <item><description><b>SourceArchive</b>: Only the source files are Archive objects.</description></item>
            /// <item><description><b>SourceColdArchive</b>: Only the source file is stored as a Cold Archive object.</description></item>
            /// <item><description><b>Changing</b>: The storage class of the video file is being changed.</description></item>
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
            /// <para>tag1, tag2</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// <para>The ID of the transcoding template group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b4039216985f4312a5382a4ed****</para>
            /// </summary>
            [NameInMap("TemplateGroupId")]
            [Validation(Required=false)]
            public string TemplateGroupId { get; set; }

            /// <summary>
            /// <para>The title of the audio or video file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Video tiltle</para>
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
            /// <para>7753d144efd74d6c45fe0570****</para>
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

    }

}
