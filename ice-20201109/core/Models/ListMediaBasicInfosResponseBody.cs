// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListMediaBasicInfosResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("MediaInfos")]
        [Validation(Required=false)]
        public List<ListMediaBasicInfosResponseBodyMediaInfos> MediaInfos { get; set; }
        public class ListMediaBasicInfosResponseBodyMediaInfos : TeaModel {
            /// <summary>
            /// <para>FileInfos</para>
            /// </summary>
            [NameInMap("FileInfoList")]
            [Validation(Required=false)]
            public List<ListMediaBasicInfosResponseBodyMediaInfosFileInfoList> FileInfoList { get; set; }
            public class ListMediaBasicInfosResponseBodyMediaInfosFileInfoList : TeaModel {
                [NameInMap("FileBasicInfo")]
                [Validation(Required=false)]
                public ListMediaBasicInfosResponseBodyMediaInfosFileInfoListFileBasicInfo FileBasicInfo { get; set; }
                public class ListMediaBasicInfosResponseBodyMediaInfosFileInfoListFileBasicInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1912.13</para>
                    /// </summary>
                    [NameInMap("Bitrate")]
                    [Validation(Required=false)]
                    public string Bitrate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2021-01-08T16:52:04Z</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>60.00000</para>
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
                    /// <para>14340962</para>
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
                    /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example2.mp4?Expires=">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example2.mp4?Expires=</a><ExpireTime>&amp;OSSAccessKeyId=<OSSAccessKeyId>&amp;Signature=<Signature>&amp;security-token=<SecurityToken></para>
                    /// </summary>
                    [NameInMap("FileUrl")]
                    [Validation(Required=false)]
                    public string FileUrl { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mov,mp4,m4a,3gp,3g2,mj2</para>
                    /// </summary>
                    [NameInMap("FormatName")]
                    [Validation(Required=false)]
                    public string FormatName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>720</para>
                    /// </summary>
                    [NameInMap("Height")]
                    [Validation(Required=false)]
                    public string Height { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2021-01-08T16:52:07Z</para>
                    /// </summary>
                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public string ModifiedTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-shanghai</para>
                    /// </summary>
                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1280</para>
                    /// </summary>
                    [NameInMap("Width")]
                    [Validation(Required=false)]
                    public string Width { get; set; }

                }

            }

            /// <summary>
            /// <para>BasicInfo</para>
            /// </summary>
            [NameInMap("MediaBasicInfo")]
            [Validation(Required=false)]
            public ListMediaBasicInfosResponseBodyMediaInfosMediaBasicInfo MediaBasicInfo { get; set; }
            public class ListMediaBasicInfosResponseBodyMediaInfosMediaBasicInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>ICE</para>
                /// </summary>
                [NameInMap("Biz")]
                [Validation(Required=false)]
                public string Biz { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>opening</para>
                /// </summary>
                [NameInMap("BusinessType")]
                [Validation(Required=false)]
                public string BusinessType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3049</para>
                /// </summary>
                [NameInMap("CateId")]
                [Validation(Required=false)]
                public long? CateId { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.png?Expires=">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.png?Expires=</a><ExpireTime>&amp;OSSAccessKeyId=<OSSAccessKeyId>&amp;Signature=<Signature>&amp;security-token=<SecurityToken></para>
                /// </summary>
                [NameInMap("CoverURL")]
                [Validation(Required=false)]
                public string CoverURL { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2021-01-08T16:52:04Z</para>
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
                /// <para><b><b>019b82e24b37a1c2958dec38</b></b></para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tags,tags2</para>
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
                /// <para>2021-01-08T16:52:07Z</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123-123</para>
                /// </summary>
                [NameInMap("ReferenceId")]
                [Validation(Required=false)]
                public string ReferenceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>[{&quot;bucket&quot;:&quot;example-bucket&quot;,&quot;count&quot;:&quot;3&quot;,&quot;iceJobId&quot;:&quot;<b><b><b>f48f0e4154976b2b8c45</b></b></b>&quot;,&quot;location&quot;:&quot;oss-cn-beijing&quot;,&quot;snapshotRegular&quot;:&quot;example.jpg&quot;,&quot;templateId&quot;:&quot;<b><b><b>e6a6440b29eb60bd7c</b></b></b>&quot;}]</para>
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
                /// <para>general</para>
                /// </summary>
                [NameInMap("UploadSource")]
                [Validation(Required=false)]
                public string UploadSource { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>userData</para>
                /// </summary>
                [NameInMap("UserData")]
                [Validation(Required=false)]
                public string UserData { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para><b><b>019b82e24b37a1c2958dec38</b></b></para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>8EqYpQbZ6Eh7+Zz8DxVYoQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>B7-7F87-4792-BFE9-63CD21</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
