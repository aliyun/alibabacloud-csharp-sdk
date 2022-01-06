// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tdsr20200101.Models
{
    public class DetailSubSceneResponseBody : TeaModel {
        /// <summary>
        /// 返回码
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// 图片路径/视频封面路径
        /// </summary>
        [NameInMap("CoverUrl")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// 切图路径
        /// </summary>
        [NameInMap("CubemapPath")]
        [Validation(Required=false)]
        public string CubemapPath { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        /// <summary>
        /// 子场景id
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// 矫正后图的路径
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 墙线标注数据
        /// </summary>
        [NameInMap("LayoutData")]
        [Validation(Required=false)]
        public string LayoutData { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// 子场景名称
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 原图路径
        /// </summary>
        [NameInMap("OriginUrl")]
        [Validation(Required=false)]
        public string OriginUrl { get; set; }

        /// <summary>
        /// 请求ID，与入参requestId对应
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 图片ID/视频ID
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 子场景状态
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public long? Status { get; set; }

        /// <summary>
        /// 是否请求成功
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// 图片路径/视频路径
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
