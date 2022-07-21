// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class JobDebuggerConfig : TeaModel {
        /// <summary>
        /// debugger配置信息
        /// </summary>
        [NameInMap("DebuggerConfigContent")]
        [Validation(Required=false)]
        public string DebuggerConfigContent { get; set; }

        /// <summary>
        /// debugger配置项ID
        /// </summary>
        [NameInMap("DebuggerConfigId")]
        [Validation(Required=false)]
        public string DebuggerConfigId { get; set; }

        /// <summary>
        /// debugger配置创建的时间
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// 作业ID
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

    }

}
