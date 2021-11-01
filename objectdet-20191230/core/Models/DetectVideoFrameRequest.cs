// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectVideoFrameRequest : TeaModel {
        /// <summary>
        /// 图片创建时间
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// AI每个功能具体配置描述，每个AI算法配置都不一样
        /// </summary>
        [NameInMap("FeatureConfig")]
        [Validation(Required=false)]
        public string FeatureConfig { get; set; }

        /// <summary>
        /// AI功能名称列表
        /// </summary>
        [NameInMap("Features")]
        [Validation(Required=false)]
        public List<string> Features { get; set; }

        /// <summary>
        /// 图像高度
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public long? Height { get; set; }

        /// <summary>
        /// 图片URL地址
        /// </summary>
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

        /// <summary>
        /// 自用拥有者pk
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// 流资源唯一描述
        /// </summary>
        [NameInMap("StreamArn")]
        [Validation(Required=false)]
        public string StreamArn { get; set; }

        /// <summary>
        /// 图像宽度
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public long? Width { get; set; }

    }

}
