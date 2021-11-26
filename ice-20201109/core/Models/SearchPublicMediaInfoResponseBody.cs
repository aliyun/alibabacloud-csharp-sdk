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
                [NameInMap("MediaBasicInfo")]
                [Validation(Required=false)]
                public SearchPublicMediaInfoResponseBodyPublicMediaInfosMediaInfoMediaBasicInfo MediaBasicInfo { get; set; }
                public class SearchPublicMediaInfoResponseBodyPublicMediaInfosMediaInfoMediaBasicInfo : TeaModel {
                    /// <summary>
                    /// 媒资业务类型
                    /// </summary>
                    [NameInMap("BusinessType")]
                    [Validation(Required=false)]
                    public string BusinessType { get; set; }

                    /// <summary>
                    /// 分类
                    /// </summary>
                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                    /// <summary>
                    /// 封面地址
                    /// </summary>
                    [NameInMap("CoverURL")]
                    [Validation(Required=false)]
                    public string CoverURL { get; set; }

                    /// <summary>
                    /// 媒资创建时间
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    /// <summary>
                    /// 媒资删除时间
                    /// </summary>
                    [NameInMap("DeletedTime")]
                    [Validation(Required=false)]
                    public string DeletedTime { get; set; }

                    /// <summary>
                    /// 内容描述
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// MediaId
                    /// </summary>
                    [NameInMap("MediaId")]
                    [Validation(Required=false)]
                    public string MediaId { get; set; }

                    /// <summary>
                    /// 标签
                    /// </summary>
                    [NameInMap("MediaTags")]
                    [Validation(Required=false)]
                    public string MediaTags { get; set; }

                    /// <summary>
                    /// 媒资媒体类型
                    /// </summary>
                    [NameInMap("MediaType")]
                    [Validation(Required=false)]
                    public string MediaType { get; set; }

                    /// <summary>
                    /// 媒资修改时间
                    /// </summary>
                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public string ModifiedTime { get; set; }

                    /// <summary>
                    /// 来源
                    /// </summary>
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public string Source { get; set; }

                    /// <summary>
                    /// 雪碧图
                    /// </summary>
                    [NameInMap("SpriteImages")]
                    [Validation(Required=false)]
                    public string SpriteImages { get; set; }

                    /// <summary>
                    /// 资源状态
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// 标题
                    /// </summary>
                    [NameInMap("Title")]
                    [Validation(Required=false)]
                    public string Title { get; set; }

                    /// <summary>
                    /// 用户数据
                    /// </summary>
                    [NameInMap("UserData")]
                    [Validation(Required=false)]
                    public string UserData { get; set; }

                }
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }
            };

            [NameInMap("RemainingAuthTime")]
            [Validation(Required=false)]
            public string RemainingAuthTime { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
