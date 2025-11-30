// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class BatchGetMediaInfosResponseBody : TeaModel {
        [NameInMap("IgnoredList")]
        [Validation(Required=false)]
        public List<string> IgnoredList { get; set; }

        /// <summary>
        /// <para>The queried media assets.</para>
        /// </summary>
        [NameInMap("MediaInfos")]
        [Validation(Required=false)]
        public List<BatchGetMediaInfosResponseBodyMediaInfos> MediaInfos { get; set; }
        public class BatchGetMediaInfosResponseBodyMediaInfos : TeaModel {
            /// <summary>
            /// <para>FileInfos</para>
            /// </summary>
            [NameInMap("FileInfoList")]
            [Validation(Required=false)]
            public List<BatchGetMediaInfosResponseBodyMediaInfosFileInfoList> FileInfoList { get; set; }
            public class BatchGetMediaInfosResponseBodyMediaInfosFileInfoList : TeaModel {
                /// <summary>
                /// <para>The basic information of the file, including the duration and size.</para>
                /// </summary>
                [NameInMap("FileBasicInfo")]
                [Validation(Required=false)]
                public BatchGetMediaInfosResponseBodyMediaInfosFileInfoListFileBasicInfo FileBasicInfo { get; set; }
                public class BatchGetMediaInfosResponseBodyMediaInfosFileInfoListFileBasicInfo : TeaModel {
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
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <para>The file name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example</para>
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
                    /// <para>1080</para>
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
                    /// <para>1920</para>
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
            public BatchGetMediaInfosResponseBodyMediaInfosMediaBasicInfo MediaBasicInfo { get; set; }
            public class BatchGetMediaInfosResponseBodyMediaInfosMediaBasicInfo : TeaModel {
                [NameInMap("Biz")]
                [Validation(Required=false)]
                public string Biz { get; set; }

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
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <para>The thumbnail URL of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.png?Expires=">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.png?Expires=</a><ExpireTime>&amp;OSSAccessKeyId=<OSSAccessKeyId>&amp;Signature=<Signature>&amp;security-token=<SecurityToken></para>
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// <para>The time when the media asset was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-26T04:11:10Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the media asset was deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-12-26T04:11:10Z</para>
                /// </summary>
                [NameInMap("DeletedTime")]
                [Validation(Required=false)]
                public string DeletedTime { get; set; }

                /// <summary>
                /// <para>The description of the media asset.</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The URL of the media asset in another service.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4">https://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4</a></para>
                /// </summary>
                [NameInMap("InputURL")]
                [Validation(Required=false)]
                public string InputURL { get; set; }

                /// <summary>
                /// <para>MediaId</para>
                /// 
                /// <b>Example:</b>
                /// <para><b><b><b>c48fb37407365d4f2cd8</b></b></b></para>
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
                /// <para>The type of the media asset. Valid values:</para>
                /// <para>\- image</para>
                /// <para>\- video</para>
                /// <para>\- audio</para>
                /// <para>\- text</para>
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
                /// <para>2020-12-26T04:11:12Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <para>The snapshots of the media asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;bucket&quot;:&quot;example-bucket&quot;,&quot;count&quot;:&quot;3&quot;,&quot;iceJobId&quot;:&quot;<b><b><b>f48f0e4154976b2b8c45</b></b></b>&quot;,&quot;location&quot;:&quot;oss-cn-beijing&quot;,&quot;snapshotRegular&quot;:&quot;example.jpg&quot;,&quot;templateId&quot;:&quot;<b><b><b>e6a6440b29eb60bd7c</b></b></b>&quot;}]</para>
                /// </summary>
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public string Snapshots { get; set; }

                /// <summary>
                /// <para>The source of the media asset. Valid values:</para>
                /// <para>\- oss</para>
                /// <para>\- vod</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The sprite.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{&quot;bucket&quot;:&quot;example-bucket&quot;,&quot;count&quot;:&quot;32&quot;,&quot;iceJobId&quot;:&quot;<b><b><b>83ec44d58b2069def2e</b></b></b>&quot;,&quot;location&quot;:&quot;oss-cn-shanghai&quot;,&quot;snapshotRegular&quot;:&quot;example/example-{Count}.jpg&quot;,&quot;spriteRegular&quot;:&quot;example/example-{TileCount}.jpg&quot;,&quot;templateId&quot;:&quot;<b><b><b>e438b14ff39293eaec25</b></b></b>&quot;,&quot;tileCount&quot;:&quot;1&quot;}]</para>
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
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The transcoding status of the media asset.</para>
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
                /// <para>userDataTest</para>
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

            [NameInMap("MediaDynamicInfo")]
            [Validation(Required=false)]
            public BatchGetMediaInfosResponseBodyMediaInfosMediaDynamicInfo MediaDynamicInfo { get; set; }
            public class BatchGetMediaInfosResponseBodyMediaInfosMediaDynamicInfo : TeaModel {
                [NameInMap("DynamicMetaData")]
                [Validation(Required=false)]
                public BatchGetMediaInfosResponseBodyMediaInfosMediaDynamicInfoDynamicMetaData DynamicMetaData { get; set; }
                public class BatchGetMediaInfosResponseBodyMediaInfosMediaDynamicInfoDynamicMetaData : TeaModel {
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public string Data { get; set; }

                }

            }

            /// <summary>
            /// <para>The ID of the media asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para><b><b><b>c48fb37407365d4f2cd8</b></b></b></para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
