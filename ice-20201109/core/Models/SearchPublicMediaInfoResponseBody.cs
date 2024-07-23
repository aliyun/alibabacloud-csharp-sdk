// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchPublicMediaInfoResponseBody : TeaModel {
        [NameInMap("PublicMediaInfos")]
        [Validation(Required=false)]
        public List<SearchPublicMediaInfoResponseBodyPublicMediaInfos> PublicMediaInfos { get; set; }
        public class SearchPublicMediaInfoResponseBodyPublicMediaInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Authorized")]
            [Validation(Required=false)]
            public bool? Authorized { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Favorite")]
            [Validation(Required=false)]
            public bool? Favorite { get; set; }

            [NameInMap("MediaInfo")]
            [Validation(Required=false)]
            public SearchPublicMediaInfoResponseBodyPublicMediaInfosMediaInfo MediaInfo { get; set; }
            public class SearchPublicMediaInfoResponseBodyPublicMediaInfosMediaInfo : TeaModel {
                [NameInMap("DynamicMetaData")]
                [Validation(Required=false)]
                public SearchPublicMediaInfoResponseBodyPublicMediaInfosMediaInfoDynamicMetaData DynamicMetaData { get; set; }
                public class SearchPublicMediaInfoResponseBodyPublicMediaInfosMediaInfoDynamicMetaData : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;{\&quot;AuditionUrl\&quot;: \&quot;<a href="http://xxx%5C%5C">http://xxx\\</a>&quot;, \&quot;AuditionCount\&quot;: 3...}&quot;</para>
                    /// </summary>
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public string Data { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>system</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>BasicInfo</para>
                /// </summary>
                [NameInMap("MediaBasicInfo")]
                [Validation(Required=false)]
                public SearchPublicMediaInfoResponseBodyPublicMediaInfosMediaInfoMediaBasicInfo MediaBasicInfo { get; set; }
                public class SearchPublicMediaInfoResponseBodyPublicMediaInfosMediaInfoMediaBasicInfo : TeaModel {
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
                    /// <para><a href="http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.png?Expires=">http://example-bucket.oss-cn-shanghai.aliyuncs.com/example.png?Expires=</a><ExpireTime>&amp;OSSAccessKeyId=<OSSAccessKeyId>&amp;Signature=<Signature>&amp;security-token=<SecurityToken></para>
                    /// </summary>
                    [NameInMap("CoverURL")]
                    [Validation(Required=false)]
                    public string CoverURL { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2020-12-26T06:04:49Z</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2020-12-29T06:04:49Z</para>
                    /// </summary>
                    [NameInMap("DeletedTime")]
                    [Validation(Required=false)]
                    public string DeletedTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>description</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>MediaId</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>icepublic-<b><b>87b921bb4a55908a72a0537e</b></b></para>
                    /// </summary>
                    [NameInMap("MediaId")]
                    [Validation(Required=false)]
                    public string MediaId { get; set; }

                    [NameInMap("MediaTags")]
                    [Validation(Required=false)]
                    public string MediaTags { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>audio</para>
                    /// </summary>
                    [NameInMap("MediaType")]
                    [Validation(Required=false)]
                    public string MediaType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2020-12-26T06:04:50Z</para>
                    /// </summary>
                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public string ModifiedTime { get; set; }

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
                    /// <para>userDataTest</para>
                    /// </summary>
                    [NameInMap("UserData")]
                    [Validation(Required=false)]
                    public string UserData { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>icepublic-<b><b>87b921bb4a55908a72a0537e</b></b></para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("RemainingAuthTime")]
            [Validation(Required=false)]
            public string RemainingAuthTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b>3CFB-2767-54FD-B311-BD15A4C1</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
