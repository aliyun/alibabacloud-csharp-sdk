// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeMatchedMaliciousNamesRequest : TeaModel {
        /// <summary>
        /// 设置请求和接收消息的语言类型，默认为**zh**。取值：
        /// 
        /// - **zh**：中文
        /// - **en**：英文
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// 要查询的镜像恶意样本的危险程度。可输入多个值，多个值之间使用英文逗号（,）分隔。取值：
        /// - **serious**：紧急
        /// - **suspicious**：可疑
        /// - **remind**：提醒
        /// </summary>
        [NameInMap("Levels")]
        [Validation(Required=false)]
        public string Levels { get; set; }

    }

}
