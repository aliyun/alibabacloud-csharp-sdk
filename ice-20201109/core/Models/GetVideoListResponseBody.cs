// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetVideoListResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The information about the audio and video files.</para>
        /// </summary>
        [NameInMap("MediaList")]
        [Validation(Required=false)]
        public List<GetVideoListResponseBodyMediaList> MediaList { get; set; }
        public class GetVideoListResponseBodyMediaList : TeaModel {
            /// <summary>
            /// <para>The ID of the application. Default value: app-1000000.</para>
            /// 
            /// <b>Example:</b>
            /// <para>app-1000000</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The ID of the category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3679</para>
            /// </summary>
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            /// <summary>
            /// <para>The name of the category.</para>
            /// </summary>
            [NameInMap("CateName")]
            [Validation(Required=false)]
            public string CateName { get; set; }

            /// <summary>
            /// <para>The URL of the thumbnail.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://example.aliyundoc.com/snapshot/****.jpg?auth_key=1498476426-0-0-f00b9455c49a423ce69cf4e27333">http://example.aliyundoc.com/snapshot/****.jpg?auth_key=1498476426-0-0-f00b9455c49a423ce69cf4e27333</a>****</para>
            /// </summary>
            [NameInMap("CoverUrl")]
            [Validation(Required=false)]
            public string CoverUrl { get; set; }

            /// <summary>
            /// <para>The time when the audio or video file was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-11-14T09:15:50Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the audio or video file.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The duration. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>135.6</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public float? Duration { get; set; }

            /// <summary>
            /// <para>The ID of the audio or video file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1c6ce34007d571ed94667630a6bc****</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

            /// <summary>
            /// <para>The time when the audio or video file was updated. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-11-14T09:16:50Z</para>
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

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
            /// <para>The array of video snapshot URLs.</para>
            /// </summary>
            [NameInMap("Snapshots")]
            [Validation(Required=false)]
            public List<string> Snapshots { get; set; }

            /// <summary>
            /// <para>The status of the video.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PrepareFail: The file is abnormal.</description></item>
            /// <item><description>UploadFail: The video failed to be uploaded.</description></item>
            /// <item><description>UploadSucc: The video is uploaded.</description></item>
            /// <item><description>Transcoding: The video is being transcoded.</description></item>
            /// <item><description>TranscodeFail: The video failed to be transcoded.</description></item>
            /// <item><description>ProduceFail: The video failed to be produced.</description></item>
            /// <item><description>Normal: The video is normal.</description></item>
            /// <item><description>Uploading: The video is being uploaded.</description></item>
            /// <item><description>Preparing: The file is being generated.</description></item>
            /// <item><description>Blocked: The video is blocked.</description></item>
            /// <item><description>checking: The video is being reviewed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The storage address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>out-****.oss-cn-shanghai.aliyuncs.com</para>
            /// </summary>
            [NameInMap("StorageLocation")]
            [Validation(Required=false)]
            public string StorageLocation { get; set; }

            /// <summary>
            /// <para>The tags of the audio or video file.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

            /// <summary>
            /// <para>The title of the audio or video file.</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The total number of audio and video files that meet the conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>163</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
