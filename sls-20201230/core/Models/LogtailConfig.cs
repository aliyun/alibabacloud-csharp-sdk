// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class LogtailConfig : TeaModel {
        /// <summary>
        /// logtail 配置的名称。
        /// </summary>
        [NameInMap("configName")]
        [Validation(Required=false)]
        public string ConfigName { get; set; }

        /// <summary>
        /// 创建时间，unix 时间戳。
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// logtail 输入的详细配置。
        /// </summary>
        [NameInMap("inputDetail")]
        [Validation(Required=false)]
        public Dictionary<string, object> InputDetail { get; set; }

        /// <summary>
        /// logtail 读取日志的输入类型。
        /// </summary>
        [NameInMap("inputType")]
        [Validation(Required=false)]
        public string InputType { get; set; }

        /// <summary>
        /// 最后一次修改时间，unix 时间戳。
        /// </summary>
        [NameInMap("lastModifyTime")]
        [Validation(Required=false)]
        public long? LastModifyTime { get; set; }

        /// <summary>
        /// 日志样例，可以用于自动生成正则捕获字段。
        /// </summary>
        [NameInMap("logSample")]
        [Validation(Required=false)]
        public string LogSample { get; set; }

        /// <summary>
        /// logtail 输出的详细配置。
        /// </summary>
        [NameInMap("outputDetail")]
        [Validation(Required=false)]
        public LogtailConfigOutputDetail OutputDetail { get; set; }
        public class LogtailConfigOutputDetail : TeaModel {
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }
            [NameInMap("logstoreName")]
            [Validation(Required=false)]
            public string LogstoreName { get; set; }
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }
        };

        /// <summary>
        /// logtail 输出的目标类型。这里固定选择 LogService。
        /// </summary>
        [NameInMap("outputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

    }

}
