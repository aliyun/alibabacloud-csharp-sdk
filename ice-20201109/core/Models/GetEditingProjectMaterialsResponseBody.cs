// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetEditingProjectMaterialsResponseBody : TeaModel {
        /// <summary>
        /// <para>Media assets associated with live streams.</para>
        /// </summary>
        [NameInMap("LiveMaterials")]
        [Validation(Required=false)]
        public List<GetEditingProjectMaterialsResponseBodyLiveMaterials> LiveMaterials { get; set; }
        public class GetEditingProjectMaterialsResponseBodyLiveMaterials : TeaModel {
            /// <summary>
            /// <para>Name of the live streaming application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testrecord</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>Streaming domain name for live streaming.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.alivecdn.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>Streaming URL for the live stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rtmp://test.alivecdn.com/testrecord/teststream</para>
            /// </summary>
            [NameInMap("LiveUrl")]
            [Validation(Required=false)]
            public string LiveUrl { get; set; }

            /// <summary>
            /// <para>Name of the live stream.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testrecord</para>
            /// </summary>
            [NameInMap("StreamName")]
            [Validation(Required=false)]
            public string StreamName { get; set; }

        }

        /// <summary>
        /// <para>Collection of matching media assets.</para>
        /// </summary>
        [NameInMap("MediaInfos")]
        [Validation(Required=false)]
        public List<GetEditingProjectMaterialsResponseBodyMediaInfos> MediaInfos { get; set; }
        public class GetEditingProjectMaterialsResponseBodyMediaInfos : TeaModel {
            /// <summary>
            /// <para>File information.</para>
            /// </summary>
            [NameInMap("FileInfoList")]
            [Validation(Required=false)]
            public List<GetEditingProjectMaterialsResponseBodyMediaInfosFileInfoList> FileInfoList { get; set; }
            public class GetEditingProjectMaterialsResponseBodyMediaInfosFileInfoList : TeaModel {
                /// <summary>
                /// <para>Basic file information, such as duration and size.</para>
                /// </summary>
                [NameInMap("FileBasicInfo")]
                [Validation(Required=false)]
                public GetEditingProjectMaterialsResponseBodyMediaInfosFileInfoListFileBasicInfo FileBasicInfo { get; set; }
                public class GetEditingProjectMaterialsResponseBodyMediaInfosFileInfoListFileBasicInfo : TeaModel {
                    /// <summary>
                    /// <para>Bitrate of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1132.68</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <para>Duration of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>216.206667</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <para>Name of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example.mp4</para>
                    /// </summary>
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// <para>Size of the file, in bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30611502</para>
                    /// </summary>
                    [NameInMap("FileSize")]
                    [Validation(Required=false)]
                    public string FileSize { get; set; }

                    /// <summary>
                    /// <para>Status of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Normal</para>
                    /// </summary>
                    [NameInMap("FileStatus")]
                    [Validation(Required=false)]
                    public string FileStatus { get; set; }

                    /// <summary>
                    /// <para>Type of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>source_file</para>
                    /// </summary>
                    [NameInMap("FileType")]
                    [Validation(Required=false)]
                    public string FileType { get; set; }

                    /// <summary>
                    /// <para>OSS URL of the file.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4?Expires=">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4?Expires=</a><ExpireTime>&amp;OSSAccessKeyId=<OSSAccessKeyId>&amp;Signature=<Signature>&amp;security-token=<SecurityToken></para>
                    /// </summary>
                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public string FileUrl { get; set; }

                    /// <summary>
                    /// <para>Container format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mov,mp4,m4a,3gp,3g2,mj2</para>
                    /// </summary>
                    [NameInMap("FormatName")]
                    [Validation(Required=false)]
                    public string FormatName { get; set; }

                    /// <summary>
                    /// <para>Height of the video.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>540</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <para>Region where the file is stored.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-shanghai</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <para>Width of the video.</para>
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
            /// <para>Basic information about the media asset.</para>
            /// </summary>
            [NameInMap("MediaBasicInfo")]
            [Validation(Required=false)]
            public GetEditingProjectMaterialsResponseBodyMediaInfosMediaBasicInfo MediaBasicInfo { get; set; }
            public class GetEditingProjectMaterialsResponseBodyMediaInfosMediaBasicInfo : TeaModel {
                /// <summary>
                /// <para>Business type of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>general</para>
                /// </summary>
                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public string BusinessType { get; set; }

                /// <summary>
                /// <para>Category of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>video</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>URL of the thumbnail image.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://sample-bucket.oss-cn-shanghai.aliyuncs.com/sample-corver.jpg?Expires=1628670610&OSSAccessKeyId=AK&Signature=signature">http://sample-bucket.oss-cn-shanghai.aliyuncs.com/sample-corver.jpg?Expires=1628670610&amp;OSSAccessKeyId=AK&amp;Signature=signature</a></para>
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// <para>Time when the media asset was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-26T04:11:08Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Time when the media asset was deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-26T04:11:08Z</para>
                /// </summary>
                [NameInMap("DeletedTime")]
                [Validation(Required=false)]
                public string DeletedTime { get; set; }

                /// <summary>
                /// <para>Description of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sample_description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>URL of the media asset in the source system.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://bucket.oss-cn-shanghai.aliyuncs.com/file.mp4">http://bucket.oss-cn-shanghai.aliyuncs.com/file.mp4</a></para>
                /// </summary>
                [NameInMap("InputURL")]
                [Validation(Required=false)]
                public string InputURL { get; set; }

                /// <summary>
                /// <para>ID of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para><em><b><b>64623a94eca8516569c8f</b></b></em></para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>Tags associated with the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tag1</para>
                /// </summary>
                [NameInMap("MediaTags")]
                [Validation(Required=false)]
                public string MediaTags { get; set; }

                /// <summary>
                /// <para>Media type of the asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>video</para>
                /// </summary>
                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                /// <summary>
                /// <para>Time when the media asset was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-26T04:11:08Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>Thumbnail images.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public string Snapshots { get; set; }

                /// <summary>
                /// <para>Source of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>Sprite image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("SpriteImages")]
                [Validation(Required=false)]
                public string SpriteImages { get; set; }

                /// <summary>
                /// <para>Status of the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Title of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file.mp4</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>Status of the transcoding task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Init</para>
                /// </summary>
                [NameInMap("TranscodeStatus")]
                [Validation(Required=false)]
                public string TranscodeStatus { get; set; }

                /// <summary>
                /// <para>User-defined data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>userData</para>
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

            /// <summary>
            /// <para>ID of the media asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para><em><b><b>64623a94eca8516569c8fe</b></b></em></para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

        }

        /// <summary>
        /// <para>ID of the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em><b><b>67ae06542b9b93e0d1c387</b></b></em></para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>Media assets associated with the editing project. After a live stream ends, it is linked to a standard editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para><em><b><b>9b145c5cafc2e057304fcd</b></b></em></para>
        /// </summary>
        [NameInMap("ProjectMaterials")]
        [Validation(Required=false)]
        public List<string> ProjectMaterials { get; set; }

        /// <summary>
        /// <para>ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>89-C21D-4B78-AE24-3788B8</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
