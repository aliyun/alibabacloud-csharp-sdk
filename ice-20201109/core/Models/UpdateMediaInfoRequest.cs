// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateMediaInfoRequest : TeaModel {
        /// <summary>
        /// 是否以append的形式更新DynamicMetaDataList字段
        /// </summary>
        [NameInMap("AppendDynamicMeta")]
        [Validation(Required=false)]
        public bool? AppendDynamicMeta { get; set; }

        /// <summary>
        /// 是否以append的形式更新Tags字段
        /// </summary>
        [NameInMap("AppendTags")]
        [Validation(Required=false)]
        public bool? AppendTags { get; set; }

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
        /// 封面图，仅视频媒资有效
        /// </summary>
        [NameInMap("CoverURL")]
        [Validation(Required=false)]
        public string CoverURL { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 用户自定义元数据
        /// </summary>
        [NameInMap("DynamicMetaDataList")]
        [Validation(Required=false)]
        public string DynamicMetaDataList { get; set; }

        /// <summary>
        /// 媒资媒体类型
        /// </summary>
        [NameInMap("InputURL")]
        [Validation(Required=false)]
        public string InputURL { get; set; }

        /// <summary>
        /// 媒资Id
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// 标签,如果有多个标签用逗号隔开
        /// </summary>
        [NameInMap("MediaTags")]
        [Validation(Required=false)]
        public string MediaTags { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 用户数据，最大1024字节
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
