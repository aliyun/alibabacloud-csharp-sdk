// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class MeteringConfig : TeaModel {
        /// <summary>
        /// 日志仓库
        /// </summary>
        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public LogConfig LogConfig { get; set; }

        /// <summary>
        /// 支付用户
        /// </summary>
        [NameInMap("payerId")]
        [Validation(Required=false)]
        public string PayerId { get; set; }

        /// <summary>
        /// 权限
        /// </summary>
        [NameInMap("role")]
        [Validation(Required=false)]
        public string Role { get; set; }

    }

}
