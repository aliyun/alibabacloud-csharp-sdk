// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class LoggingEnabled : TeaModel {
        /// <summary>
        /// 存储访问日志的存储空间
        /// </summary>
        [NameInMap("TargetBucket")]
        [Validation(Required=false)]
        public string TargetBucket { get; set; }

        /// <summary>
        /// 保存的日志文件前缀
        /// </summary>
        [NameInMap("TargetPrefix")]
        [Validation(Required=false)]
        public string TargetPrefix { get; set; }

    }

}
