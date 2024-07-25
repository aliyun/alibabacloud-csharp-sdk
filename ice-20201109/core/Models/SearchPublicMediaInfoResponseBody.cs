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
            [NameInMap("Authorized")]
            [Validation(Required=false)]
            public bool? Authorized { get; set; }

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
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public string Data { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// BasicInfo
                /// </summary>
                [NameInMap("MediaBasicInfo")]
                [Validation(Required=false)]
                public SearchPublicMediaInfoResponseBodyPublicMediaInfosMediaInfoMediaBasicInfo MediaBasicInfo { get; set; }
                public class SearchPublicMediaInfoResponseBodyPublicMediaInfosMediaInfoMediaBasicInfo : TeaModel {
                    [NameInMap("BusinessType")]
                    [Validation(Required=false)]
                    public string BusinessType { get; set; }

                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    [NameInMap("CoverURL")]
                    [Validation(Required=false)]
                    public string CoverURL { get; set; }

                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    [NameInMap("DeletedTime")]
                    [Validation(Required=false)]
                    public string DeletedTime { get; set; }

                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// MediaId
                    /// </summary>
                    [NameInMap("MediaId")]
                    [Validation(Required=false)]
                    public string MediaId { get; set; }

                    [NameInMap("MediaTags")]
                    [Validation(Required=false)]
                    public string MediaTags { get; set; }

                    [NameInMap("MediaType")]
                    [Validation(Required=false)]
                    public string MediaType { get; set; }

                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public string ModifiedTime { get; set; }

                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    [NameInMap("SpriteImages")]
                    [Validation(Required=false)]
                    public string SpriteImages { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    [NameInMap("UserData")]
                    [Validation(Required=false)]
                    public string UserData { get; set; }

                }

                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

            }

            [NameInMap("RemainingAuthTime")]
            [Validation(Required=false)]
            public string RemainingAuthTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
