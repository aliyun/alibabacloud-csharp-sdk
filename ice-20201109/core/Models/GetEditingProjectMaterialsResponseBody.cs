// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetEditingProjectMaterialsResponseBody : TeaModel {
        /// <summary>
        /// <para>The materials associated with the live stream.</para>
        /// </summary>
        [NameInMap("LiveMaterials")]
        [Validation(Required=false)]
        public List<GetEditingProjectMaterialsResponseBodyLiveMaterials> LiveMaterials { get; set; }
        public class GetEditingProjectMaterialsResponseBodyLiveMaterials : TeaModel {
            /// <summary>
            /// <para>The application name of the live stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testrecord</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The domain name of the live stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.alivecdn.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The URL of the live stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp://test.alivecdn.com/testrecord/teststream</para>
            /// </summary>
            [NameInMap("LiveUrl")]
            [Validation(Required=false)]
            public string LiveUrl { get; set; }

            /// <summary>
            /// <para>The name of the live stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testrecord</para>
            /// </summary>
            [NameInMap("StreamName")]
            [Validation(Required=false)]
            public string StreamName { get; set; }

        }

        /// <summary>
        /// <para>The media assets that meet the specified conditions.</para>
        /// </summary>
        [NameInMap("MediaInfos")]
        [Validation(Required=false)]
        public List<GetEditingProjectMaterialsResponseBodyMediaInfos> MediaInfos { get; set; }
        public class GetEditingProjectMaterialsResponseBodyMediaInfos : TeaModel {
            /// <summary>
            /// <para>The information about the file.</para>
            /// </summary>
            [NameInMap("FileInfoList")]
            [Validation(Required=false)]
            public List<GetEditingProjectMaterialsResponseBodyMediaInfosFileInfoList> FileInfoList { get; set; }
            public class GetEditingProjectMaterialsResponseBodyMediaInfosFileInfoList : TeaModel {
                /// <summary>
                /// <para>The basic information of the file, such as the duration and size.</para>
                /// </summary>
                [NameInMap("FileBasicInfo")]
                [Validation(Required=false)]
                public GetEditingProjectMaterialsResponseBodyMediaInfosFileInfoListFileBasicInfo FileBasicInfo { get; set; }
                public class GetEditingProjectMaterialsResponseBodyMediaInfosFileInfoListFileBasicInfo : TeaModel {
                    /// <summary>
                    /// <para>The bitrate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1132.68</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <para>The duration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>216.206667</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <para>The file name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example.mp4</para>
                    /// </summary>
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// <para>The file size. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30611502</para>
                    /// </summary>
                    [NameInMap("FileSize")]
                    [Validation(Required=false)]
                    public string FileSize { get; set; }

                    /// <summary>
                    /// <para>The file status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Normal</para>
                    /// </summary>
                    [NameInMap("FileStatus")]
                    [Validation(Required=false)]
                    public string FileStatus { get; set; }

                    /// <summary>
                    /// <para>The file type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>source_file</para>
                    /// </summary>
                    [NameInMap("FileType")]
                    [Validation(Required=false)]
                    public string FileType { get; set; }

                    /// <summary>
                    /// <para>The Object Storage Service (OSS) URL of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4?Expires=">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4?Expires=</a><ExpireTime>&amp;OSSAccessKeyId=<OSSAccessKeyId>&amp;Signature=<Signature>&amp;security-token=<SecurityToken></para>
                    /// </summary>
                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public string FileUrl { get; set; }

                    /// <summary>
                    /// <para>The container format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mov,mp4,m4a,3gp,3g2,mj2</para>
                    /// </summary>
                    [NameInMap("FormatName")]
                    [Validation(Required=false)]
                    public string FormatName { get; set; }

                    /// <summary>
                    /// <para>The height.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>540</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <para>The region in which the file resides.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-shanghai</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <para>The width.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>960</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

            }

            /// <summary>
            /// <para>The basic information of the media asset.</para>
            /// </summary>
            [NameInMap("MediaBasicInfo")]
            [Validation(Required=false)]
            public GetEditingProjectMaterialsResponseBodyMediaInfosMediaBasicInfo MediaBasicInfo { get; set; }
            public class GetEditingProjectMaterialsResponseBodyMediaInfosMediaBasicInfo : TeaModel {
                /// <summary>
                /// <para>The business type of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>general</para>
                /// </summary>
                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public string BusinessType { get; set; }

                /// <summary>
                /// <para>The category of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>video</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The thumbnail URL of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://sample-bucket.oss-cn-shanghai.aliyuncs.com/sample-corver.jpg?Expires=1628670610&OSSAccessKeyId=AK&Signature=signature">http://sample-bucket.oss-cn-shanghai.aliyuncs.com/sample-corver.jpg?Expires=1628670610&amp;OSSAccessKeyId=AK&amp;Signature=signature</a></para>
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// <para>The time when the media asset was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-26T04:11:08Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the media asset was deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-26T04:11:08Z</para>
                /// </summary>
                [NameInMap("DeletedTime")]
                [Validation(Required=false)]
                public string DeletedTime { get; set; }

                /// <summary>
                /// <para>The description of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sample_description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The URL of the media asset in another service.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://bucket.oss-cn-shanghai.aliyuncs.com/file.mp4">http://bucket.oss-cn-shanghai.aliyuncs.com/file.mp4</a></para>
                /// </summary>
                [NameInMap("InputURL")]
                [Validation(Required=false)]
                public string InputURL { get; set; }

                /// <summary>
                /// <para>The ID of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para><em><b><b>64623a94eca8516569c8f</b></b></em></para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The tags of the media asset.</para>
                /// </summary>
                [NameInMap("MediaTags")]
                [Validation(Required=false)]
                public string MediaTags { get; set; }

                /// <summary>
                /// <para>The type of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>video</para>
                /// </summary>
                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                /// <summary>
                /// <para>The time when the media asset was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-26T04:11:08Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The snapshots of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public string Snapshots { get; set; }

                /// <summary>
                /// <para>The source of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The sprite of the media asset</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("SpriteImages")]
                [Validation(Required=false)]
                public string SpriteImages { get; set; }

                /// <summary>
                /// <para>The status of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The title of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file.mp4</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The transcoding status of the media asset.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>TranscodeSuccess: transcoding completed.</description></item>
                /// <item><description>TranscodeFailed: transcoding failed.</description></item>
                /// <item><description>Init: initializing.</description></item>
                /// <item><description>Transcoding: transcoding in progress.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Init</para>
                /// </summary>
                [NameInMap("TranscodeStatus")]
                [Validation(Required=false)]
                public string TranscodeStatus { get; set; }

                /// <summary>
                /// <para>The user data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>userData</para>
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

            /// <summary>
            /// <para>The ID of the media asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para><em><b><b>64623a94eca8516569c8fe</b></b></em></para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

        }

        /// <summary>
        /// <para>The project ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em><b><b>67ae06542b9b93e0d1c387</b></b></em></para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The materials associated with the editing project. A live stream editing project will be associated with a regular editing project after the live streaming ends.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em><b><b>9b145c5cafc2e057304fcd</b></b></em></para>
        /// </summary>
        [NameInMap("ProjectMaterials")]
        [Validation(Required=false)]
        public List<string> ProjectMaterials { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>89-C21D-4B78-AE24-3788B8</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
