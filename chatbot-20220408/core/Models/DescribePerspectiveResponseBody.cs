// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class DescribePerspectiveResponseBody : TeaModel {
        /// <summary>
        /// 创建时间 UTC时间
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 修改时间 UTC时间
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public string ModifyTime { get; set; }

        /// <summary>
        /// 视角名称
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 视角编码（用于问答api）
        /// </summary>
        [NameInMap("PerspectiveCode")]
        [Validation(Required=false)]
        public string PerspectiveCode { get; set; }

        /// <summary>
        /// 视角主键（code_id）
        /// </summary>
        [NameInMap("PerspectiveId")]
        [Validation(Required=false)]
        public string PerspectiveId { get; set; }

        /// <summary>
        /// 请求Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 是否自定义
        /// </summary>
        [NameInMap("SelfDefine")]
        [Validation(Required=false)]
        public bool? SelfDefine { get; set; }

        /// <summary>
        /// 数据状态：3：选中；1：未选中
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
