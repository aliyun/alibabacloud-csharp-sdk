// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class CheckChatappContactsShrinkRequest : TeaModel {
        /// <summary>
        /// 通道类型
        /// </summary>
        [NameInMap("ChannelType")]
        [Validation(Required=false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// 需要查询的用户列表,单次调用最多查询10个。注意：用户号码必须加国家码
        /// </summary>
        [NameInMap("Contacts")]
        [Validation(Required=false)]
        public string ContactsShrink { get; set; }

        /// <summary>
        /// 发送号码,所选择ChannelType下的Business账号，即在控制台上审核通过的Number
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

    }

}
