// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class CustomRuntimeConfig : TeaModel {
        /// <summary>
        /// 启动入口命令接收的参数
        /// </summary>
        [NameInMap("args")]
        [Validation(Required=false)]
        public List<string> Args { get; set; }

        /// <summary>
        /// 启动入口命令
        /// </summary>
        [NameInMap("command")]
        [Validation(Required=false)]
        public List<string> Command { get; set; }

    }

}
