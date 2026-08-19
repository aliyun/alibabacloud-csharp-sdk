// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The audio or video information.</para>
        /// </summary>
        [NameInMap("Video")]
        [Validation(Required=false)]
        public GetVideoInfoResponseBodyVideo Video { get; set; }
        public class GetVideoInfoResponseBodyVideo : TeaModel {
            /// <summary>
            /// <para>The application ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-****</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The final review result of the audio or video file. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Normal</b>: Approved.</description></item>
            /// <item><description><b>Blocked</b>: Blocked.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }

            /// <summary>
            /// <para>The category ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>781111****</para>
            /// </summary>
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            /// <summary>
            /// <para>The category name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cate1</para>
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
            /// <para>The time when the audio or video file was created. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-11-14T09:15:50Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The custom media asset information.</para>
            /// <remarks>
            /// <para>This parameter is deprecated. The API no longer returns this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;aaa&quot;:&quot;test&quot;}</para>
            /// </summary>
            [NameInMap("CustomMediaInfo")]
            [Validation(Required=false)]
            public string CustomMediaInfo { get; set; }

            /// <summary>
            /// <para>The description of the audio or video file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud VOD video description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The status of the offline download switch. After the offline download feature is enabled, mobile users can cache videos to their local devices for offline viewing by using ApsaraVideo Player. For more information, see <a href="https://help.aliyun.com/document_detail/86107.html">Offline download</a>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: enabled. Offline download is allowed.</description></item>
            /// <item><description><b>off</b>: disabled. Offline download is not allowed.</description></item>
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
            /// <para>135.6</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            /// <summary>
            /// <para>The time when the audio or video file was last updated. The time is in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-11-14T10:15:50Z</para>
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// <para>The custom ID. Only lowercase letters, uppercase letters, digits, hyphens, and underscores are supported. The length is 6 to 64 characters. The ID is unique at the user level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123-123</para>
            /// </summary>
            [NameInMap("ReferenceId")]
            [Validation(Required=false)]
            public string ReferenceId { get; set; }

            /// <summary>
            /// <para>The region where the audio or video file is stored.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The expiration time of the media asset restoration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-30T10:14:14Z</para>
            /// </summary>
            [NameInMap("RestoreExpiration")]
            [Validation(Required=false)]
            public string RestoreExpiration { get; set; }

            /// <summary>
            /// <para>The restoration status of the media asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Processing</b>: The media asset is being restored.</description></item>
            /// <item><description><b>Success</b>: The media asset is restored.</description></item>
            /// <item><description><b>Failed</b>: The media asset failed to be restored.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("RestoreStatus")]
            [Validation(Required=false)]
            public string RestoreStatus { get; set; }

            /// <summary>
            /// <para>The size of the audio or video source file. Unit: bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10897890</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            [NameInMap("Snapshots")]
            [Validation(Required=false)]
            public GetVideoInfoResponseBodyVideoSnapshots Snapshots { get; set; }
            public class GetVideoInfoResponseBodyVideoSnapshots : TeaModel {
                [NameInMap("Snapshot")]
                [Validation(Required=false)]
                public List<string> Snapshot { get; set; }

            }

            /// <summary>
            /// <para>The status of the audio or video file. For more information about the operations that can be performed on audio and video files in each status and the limits, see <a href="~~52839#title-vqg-8cz-7p8~~">Status: audio and video status</a>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Uploading</b>: The file is being uploaded.</description></item>
            /// <item><description><b>UploadFail</b>: The file failed to be uploaded.</description></item>
            /// <item><description><b>UploadSucc</b>: The file is uploaded.</description></item>
            /// <item><description><b>Transcoding</b>: The file is being transcoded.</description></item>
            /// <item><description><b>TranscodeFail</b>: The file failed to be transcoded.</description></item>
            /// <item><description><b>Blocked</b>: The file is blocked.</description></item>
            /// <item><description><b>Normal</b>: The file is in a normal state.</description></item>
            /// </list>
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
            /// <item><description><b>IA</b>: Infrequent Access (media asset).</description></item>
            /// <item><description><b>Archive</b>: Archive (media asset).</description></item>
            /// <item><description><b>ColdArchive</b>: Cold Archive (media asset).</description></item>
            /// <item><description><b>SourceIA</b>: Infrequent Access (source file).</description></item>
            /// <item><description><b>SourceArchive</b>: Archive (source file).</description></item>
            /// <item><description><b>SourceColdArchive</b>: Cold Archive (source file).</description></item>
            /// <item><description><b>Changing</b>: The storage class of the media asset is being changed.</description></item>
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
            /// <para>out-201703232251****.oss-cn-shanghai.aliyuncs.com</para>
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
            /// <para>The transcoding template group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9ae2af636ca64835b0c10412f448****</para>
            /// </summary>
            [NameInMap("TemplateGroupId")]
            [Validation(Required=false)]
            public string TemplateGroupId { get; set; }

            /// <summary>
            /// <para>The title of the audio or video file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud VOD Video Title</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The custom settings. The value is a JSON string that supports settings such as message callbacks and upload acceleration. For more information, see <a href="https://help.aliyun.com/document_detail/86952.html">UserData</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;MessageCallback&quot;:{&quot;CallbackURL&quot;:&quot;<a href="http://example.aliyundoc.com%22%7D,%22Extend%22:%7B%22localId%22:%22*****%22,%22test%22:%22www%22%7D%7D">http://example.aliyundoc.com&quot;},&quot;Extend&quot;:{&quot;localId&quot;:&quot;*****&quot;,&quot;test&quot;:&quot;www&quot;}}</a></para>
            /// </summary>
            [NameInMap("UserData")]
            [Validation(Required=false)]
            public string UserData { get; set; }

            /// <summary>
            /// <para>The audio or video ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9b73864d75f1d231e9001cd5f8****</para>
            /// </summary>
            [NameInMap("VideoId")]
            [Validation(Required=false)]
            public string VideoId { get; set; }

        }

    }

}
