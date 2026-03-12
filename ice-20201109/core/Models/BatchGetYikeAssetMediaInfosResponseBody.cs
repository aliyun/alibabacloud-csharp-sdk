// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class BatchGetYikeAssetMediaInfosResponseBody : TeaModel {
        [NameInMap("IgnoredList")]
        [Validation(Required=false)]
        public List<string> IgnoredList { get; set; }

        [NameInMap("MediaInfos")]
        [Validation(Required=false)]
        public List<BatchGetYikeAssetMediaInfosResponseBodyMediaInfos> MediaInfos { get; set; }
        public class BatchGetYikeAssetMediaInfosResponseBodyMediaInfos : TeaModel {
            [NameInMap("BizData")]
            [Validation(Required=false)]
            public BatchGetYikeAssetMediaInfosResponseBodyMediaInfosBizData BizData { get; set; }
            public class BatchGetYikeAssetMediaInfosResponseBodyMediaInfosBizData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Label</para>
                /// </summary>
                [NameInMap("AuditBlockedLabel")]
                [Validation(Required=false)]
                public string AuditBlockedLabel { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pass</para>
                /// </summary>
                [NameInMap("AuditStatus")]
                [Validation(Required=false)]
                public string AuditStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ID</para>
                /// </summary>
                [NameInMap("CreationJobId")]
                [Validation(Required=false)]
                public string CreationJobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pd_0617169475</para>
                /// </summary>
                [NameInMap("FolderId")]
                [Validation(Required=false)]
                public string FolderId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsFavorite")]
                [Validation(Required=false)]
                public string IsFavorite { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsLogicalDeleted")]
                [Validation(Required=false)]
                public string IsLogicalDeleted { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Image</para>
                /// </summary>
                [NameInMap("MediaAssetSubType")]
                [Validation(Required=false)]
                public string MediaAssetSubType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HistoricalUpload</para>
                /// </summary>
                [NameInMap("MediaAssetType")]
                [Validation(Required=false)]
                public string MediaAssetType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pd_0617169475</para>
                /// </summary>
                [NameInMap("ProductionId")]
                [Validation(Required=false)]
                public string ProductionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>f4a26390f02371f0a1f4e6e7c7586706</para>
                /// </summary>
                [NameInMap("SourceId")]
                [Validation(Required=false)]
                public string SourceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("SourceName")]
                [Validation(Required=false)]
                public string SourceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MainBody</para>
                /// </summary>
                [NameInMap("SourceType")]
                [Validation(Required=false)]
                public string SourceType { get; set; }

            }

            [NameInMap("FileInfoList")]
            [Validation(Required=false)]
            public List<BatchGetYikeAssetMediaInfosResponseBodyMediaInfosFileInfoList> FileInfoList { get; set; }
            public class BatchGetYikeAssetMediaInfosResponseBodyMediaInfosFileInfoList : TeaModel {
                [NameInMap("FileBasicInfo")]
                [Validation(Required=false)]
                public BatchGetYikeAssetMediaInfosResponseBodyMediaInfosFileInfoListFileBasicInfo FileBasicInfo { get; set; }
                public class BatchGetYikeAssetMediaInfosResponseBodyMediaInfosFileInfoListFileBasicInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>200</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public string Duration { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>example.mp4</para>
                    /// </summary>
                    [NameInMap("FileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>191</para>
                    /// </summary>
                    [NameInMap("FileSize")]
                    [Validation(Required=false)]
                    public string FileSize { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Normal</para>
                    /// </summary>
                    [NameInMap("FileStatus")]
                    [Validation(Required=false)]
                    public string FileStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>source_file</para>
                    /// </summary>
                    [NameInMap("FileType")]
                    [Validation(Required=false)]
                    public string FileType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4?Expires=">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4?Expires=</a><ExpireTime>&amp;OSSAccessKeyId=<OSSAccessKeyId>&amp;Signature=<Signature>&amp;security-token=<SecurityToken></para>
                    /// </summary>
                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public string FileUrl { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>jpg</para>
                    /// </summary>
                    [NameInMap("FormatName")]
                    [Validation(Required=false)]
                    public string FormatName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>416</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-shanghai</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>640</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

            }

            [NameInMap("MediaBasicInfo")]
            [Validation(Required=false)]
            public BatchGetYikeAssetMediaInfosResponseBodyMediaInfosMediaBasicInfo MediaBasicInfo { get; set; }
            public class BatchGetYikeAssetMediaInfosResponseBodyMediaInfosMediaBasicInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ICE</para>
                /// </summary>
                [NameInMap("Biz")]
                [Validation(Required=false)]
                public string Biz { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>general</para>
                /// </summary>
                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public string BusinessType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>category</para>
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://dtlive-bj.oss-cn-beijing.aliyuncs.com/cover/01e1271d-ff4f-4689-9c20-e1df81486859_open_live_cover.jpg">https://dtlive-bj.oss-cn-beijing.aliyuncs.com/cover/01e1271d-ff4f-4689-9c20-e1df81486859_open_live_cover.jpg</a></para>
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2020-12-26T04:11:08Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-01-08T16:52:07Z</para>
                /// </summary>
                [NameInMap("DeletedTime")]
                [Validation(Required=false)]
                public string DeletedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sample_description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="https://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4">https://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4</a></para>
                /// </summary>
                [NameInMap("InputURL")]
                [Validation(Required=false)]
                public string InputURL { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><em><b><b>64623a94eca8516569c8f</b></b></em></para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tag1，tag2</para>
                /// </summary>
                [NameInMap("MediaTags")]
                [Validation(Required=false)]
                public string MediaTags { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>video</para>
                /// </summary>
                [NameInMap("MediaType")]
                [Validation(Required=false)]
                public string MediaType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-01-08T16:52:04Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[]</para>
                /// </summary>
                [NameInMap("Snapshots")]
                [Validation(Required=false)]
                public string Snapshots { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oss</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[{&quot;bucket&quot;:&quot;example-bucket&quot;,&quot;count&quot;:&quot;32&quot;,&quot;iceJobId&quot;:&quot;<b><b><b>83ec44d58b2069def2e</b></b></b>&quot;,&quot;location&quot;:&quot;oss-cn-shanghai&quot;,&quot;snapshotRegular&quot;:&quot;example/example-{Count}.jpg&quot;,&quot;spriteRegular&quot;:&quot;example/example-{TileCount}.jpg&quot;,&quot;templateId&quot;:&quot;<b><b><b>e438b14ff39293eaec25</b></b></b>&quot;,&quot;tileCount&quot;:&quot;1&quot;}]</para>
                /// </summary>
                [NameInMap("SpriteImages")]
                [Validation(Required=false)]
                public string SpriteImages { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>title</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Init</para>
                /// </summary>
                [NameInMap("TranscodeStatus")]
                [Validation(Required=false)]
                public string TranscodeStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>UserData</para>
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><b><b><b>c48fb37407365d4f2cd8</b></b></b></para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
