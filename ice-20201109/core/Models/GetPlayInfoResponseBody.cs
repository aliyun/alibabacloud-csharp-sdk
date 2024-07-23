// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetPlayInfoResponseBody : TeaModel {
        [NameInMap("MediaBase")]
        [Validation(Required=false)]
        public GetPlayInfoResponseBodyMediaBase MediaBase { get; set; }
        public class GetPlayInfoResponseBodyMediaBase : TeaModel {
            [NameInMap("CateId")]
            [Validation(Required=false)]
            public long? CateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>https://***.oss-cn-shanghai.aliyuncs.com/cover/281c64d6-b5fb-4c57-97cd-84da56a8b151_large_cover_url.jpg</para>
            /// </summary>
            [NameInMap("CoverURL")]
            [Validation(Required=false)]
            public string CoverURL { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-09-22T10:07:31+08:00</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2eea77a61c7b4ddd95bec34a6f65b***</para>
            /// </summary>
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public string MediaId { get; set; }

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
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testTitle</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("PlayInfoList")]
        [Validation(Required=false)]
        public List<GetPlayInfoResponseBodyPlayInfoList> PlayInfoList { get; set; }
        public class GetPlayInfoResponseBodyPlayInfoList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("BitDepth")]
            [Validation(Required=false)]
            public int? BitDepth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Bitrate")]
            [Validation(Required=false)]
            public string Bitrate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-10T02:28:49Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HD</para>
            /// </summary>
            [NameInMap("Definition")]
            [Validation(Required=false)]
            public string Definition { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>9.0464</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public string Duration { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Encrypt")]
            [Validation(Required=false)]
            public long? Encrypt { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>AliyunVoDEncryption</para>
            /// </summary>
            [NameInMap("EncryptType")]
            [Validation(Required=false)]
            public string EncryptType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://outin-***.oss-cn-shanghai.aliyuncs.com/sv/43a68ee9-181809b6aba/43a68ee9-181809b6aba.mpeg">http://outin-***.oss-cn-shanghai.aliyuncs.com/sv/43a68ee9-181809b6aba/43a68ee9-181809b6aba.mpeg</a></para>
            /// </summary>
            [NameInMap("FileURL")]
            [Validation(Required=false)]
            public string FileURL { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mp4</para>
            /// </summary>
            [NameInMap("Format")]
            [Validation(Required=false)]
            public string Format { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>25</para>
            /// </summary>
            [NameInMap("Fps")]
            [Validation(Required=false)]
            public string Fps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>HDR</para>
            /// </summary>
            [NameInMap("HDRType")]
            [Validation(Required=false)]
            public string HDRType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1080</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public long? Height { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>36c9d38e70bf43ed9f7f8f48d6356***</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2022-05-13T11:39:41.714+08:00</para>
            /// </summary>
            [NameInMap("ModificationTime")]
            [Validation(Required=false)]
            public string ModificationTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("NarrowBandType")]
            [Validation(Required=false)]
            public string NarrowBandType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>https://***.aliyuncdn.com/sv/756bee1-17f980f0945/756bee1-17f980f0945.mp4</para>
            /// </summary>
            [NameInMap("PlayURL")]
            [Validation(Required=false)]
            public string PlayURL { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>418112</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>&quot;{\&quot;ims.audioServiceType\&quot;: \&quot;AudioEnhancement\&quot;}&quot;</para>
            /// </summary>
            [NameInMap("StreamTags")]
            [Validation(Required=false)]
            public string StreamTags { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("StreamType")]
            [Validation(Required=false)]
            public string StreamType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("TransTemplateType")]
            [Validation(Required=false)]
            public string TransTemplateType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5bed88672b1e2520ead228935ed51***</para>
            /// </summary>
            [NameInMap("WatermarkId")]
            [Validation(Required=false)]
            public string WatermarkId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1024</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public long? Width { get; set; }

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
