// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class CommonSimpleAsset : TeaModel {
        /// <summary>
        /// 行政区域地址
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public CommonAddress Address { get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// 审核状态
        /// </summary>
        [NameInMap("AuditStatus")]
        [Validation(Required=false)]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        [NameInMap("Author")]
        [Validation(Required=false)]
        public string Author { get; set; }

        /// <summary>
        /// 资产描述
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [NameInMap("Extends")]
        [Validation(Required=false)]
        public Dictionary<string, object> Extends { get; set; }

        /// <summary>
        /// 资产ID
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// 图像资源
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public CommonMediaResource Image { get; set; }

        /// <summary>
        /// 定义Label， eg:type:advertise 支持广告类型的label
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public Dictionary<string, object> Labels { get; set; }

        /// <summary>
        /// 经纬度地理位置
        /// </summary>
        [NameInMap("Location")]
        [Validation(Required=false)]
        public TypeLatLng Location { get; set; }

        /// <summary>
        /// 资产来源
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// 资产状态
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// 概要
        /// </summary>
        [NameInMap("Synopsis")]
        [Validation(Required=false)]
        public string Synopsis { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// 视频资源
        /// </summary>
        [NameInMap("Video")]
        [Validation(Required=false)]
        public CommonMediaResource Video { get; set; }

    }

}
