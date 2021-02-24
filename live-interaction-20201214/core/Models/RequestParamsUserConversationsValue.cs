// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live_interaction20201214.Models
{
    public class RequestParamsUserConversationsValue : TeaModel {
        /// <summary>
        /// 是否置顶
        /// </summary>
        [NameInMap("Top")]
        [Validation(Required=false)]
        public bool? Top { get; set; }

        /// <summary>
        /// 未读数
        /// </summary>
        [NameInMap("RedPoint")]
        [Validation(Required=false)]
        public long? RedPoint { get; set; }

        /// <summary>
        /// 是否免打扰
        /// </summary>
        [NameInMap("Mute")]
        [Validation(Required=false)]
        public bool? Mute { get; set; }

        /// <summary>
        /// 是否可见
        /// </summary>
        [NameInMap("Visible")]
        [Validation(Required=false)]
        public bool? Visible { get; set; }

        /// <summary>
        /// 创建时间戳
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 修改时间戳
        /// </summary>
        [NameInMap("ModifyTime")]
        [Validation(Required=false)]
        public long? ModifyTime { get; set; }

        /// <summary>
        /// 自定义信息
        /// </summary>
        [NameInMap("UserExtensions")]
        [Validation(Required=false)]
        public Dictionary<string, string> UserExtensions { get; set; }

    }

}
