// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteHoneypotPresetRequest : TeaModel {
        [NameInMap("HoneypotPresetId")]
        [Validation(Required=false)]
        public string HoneypotPresetId { get; set; }

        /// <summary>
        /// 设置请求和接收消息的语言类型，默认为**zh**。取值：
        /// - **zh**：中文
        /// - **en**：英文
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
