// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class LogConfig : TeaModel {
        /// <summary>
        /// 开启实例级别指标
        /// </summary>
        [NameInMap("enableInstanceMetrics")]
        [Validation(Required=false)]
        public bool? EnableInstanceMetrics { get; set; }

        /// <summary>
        /// 开启请求级别指标
        /// </summary>
        [NameInMap("enableRequestMetrics")]
        [Validation(Required=false)]
        public bool? EnableRequestMetrics { get; set; }

        /// <summary>
        /// 日志切分规则
        /// </summary>
        [NameInMap("logBeginRule")]
        [Validation(Required=false)]
        public string LogBeginRule { get; set; }

        /// <summary>
        /// 日志库
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// 日志项目
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

    }

}
