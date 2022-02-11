// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ModifyMediaInfoRequest : TeaModel {
        /// <summary>
        /// OSS存储地址
        /// </summary>
        [NameInMap("AiLabelUrl")]
        [Validation(Required=false)]
        public string AiLabelUrl { get; set; }

        /// <summary>
        /// 应用
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 媒资业务类型
        /// </summary>
        [NameInMap("BusinessType")]
        [Validation(Required=false)]
        public long? BusinessType { get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 动态数据
        /// </summary>
        [NameInMap("DynamicData")]
        [Validation(Required=false)]
        public string DynamicData { get; set; }

        /// <summary>
        /// 元数据实体ID
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public string EntityId { get; set; }

        /// <summary>
        /// 智能标签，json结构
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// 媒资Id
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// 媒资类型
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public long? MediaType { get; set; }

        /// <summary>
        /// 媒资来源
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public long? Source { get; set; }

        /// <summary>
        /// 视频标签
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
