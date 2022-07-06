// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class LogtailConfig : TeaModel {
        /// <summary>
        /// configName
        /// </summary>
        [NameInMap("configName")]
        [Validation(Required=false)]
        public string ConfigName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// inputDetail
        /// </summary>
        [NameInMap("inputDetail")]
        [Validation(Required=false)]
        public LogtailConfigInputDetail InputDetail { get; set; }
        public class LogtailConfigInputDetail : TeaModel {
            [NameInMap("adjustTimezone")]
            [Validation(Required=false)]
            public bool? AdjustTimezone { get; set; }
            [NameInMap("delayAlarmBytes")]
            [Validation(Required=false)]
            public long? DelayAlarmBytes { get; set; }
            [NameInMap("enableTag")]
            [Validation(Required=false)]
            public bool? EnableTag { get; set; }
            [NameInMap("filePattern")]
            [Validation(Required=false)]
            public string FilePattern { get; set; }
            [NameInMap("filterKey")]
            [Validation(Required=false)]
            public List<string> FilterKey { get; set; }
            [NameInMap("filterRegex")]
            [Validation(Required=false)]
            public List<string> FilterRegex { get; set; }
            [NameInMap("localStorage")]
            [Validation(Required=false)]
            public bool? LocalStorage { get; set; }
            [NameInMap("logBeginRegex")]
            [Validation(Required=false)]
            public string LogBeginRegex { get; set; }
            [NameInMap("logPath")]
            [Validation(Required=false)]
            public string LogPath { get; set; }
            [NameInMap("logTimezone")]
            [Validation(Required=false)]
            public string LogTimezone { get; set; }
            [NameInMap("logType")]
            [Validation(Required=false)]
            public string LogType { get; set; }
            [NameInMap("maxSendRate")]
            [Validation(Required=false)]
            public int? MaxSendRate { get; set; }
            [NameInMap("mergeType")]
            [Validation(Required=false)]
            public string MergeType { get; set; }
            [NameInMap("priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }
            [NameInMap("sendRateExpire")]
            [Validation(Required=false)]
            public int? SendRateExpire { get; set; }
            [NameInMap("sensitive_keys")]
            [Validation(Required=false)]
            public List<LogtailConfigInputDetailSensitiveKeys> SensitiveKeys { get; set; }
            public class LogtailConfigInputDetailSensitiveKeys : TeaModel {
                public bool? All { get; set; }
                public string Key { get; set; }
                public string RegexBegin { get; set; }
                public string RegexContent { get; set; }
                public string Type { get; set; }
            }
            [NameInMap("shardHashKey")]
            [Validation(Required=false)]
            public List<string> ShardHashKey { get; set; }
            [NameInMap("timeFormat")]
            [Validation(Required=false)]
            public string TimeFormat { get; set; }
            [NameInMap("topicFormat")]
            [Validation(Required=false)]
            public string TopicFormat { get; set; }
        };

        /// <summary>
        /// inputType
        /// </summary>
        [NameInMap("inputType")]
        [Validation(Required=false)]
        public string InputType { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [NameInMap("lastModifyTime")]
        [Validation(Required=false)]
        public long? LastModifyTime { get; set; }

        /// <summary>
        /// 日志样例
        /// </summary>
        [NameInMap("logSample")]
        [Validation(Required=false)]
        public string LogSample { get; set; }

        /// <summary>
        /// outputDetail
        /// </summary>
        [NameInMap("outputDetail")]
        [Validation(Required=false)]
        public LogtailConfigOutputDetail OutputDetail { get; set; }
        public class LogtailConfigOutputDetail : TeaModel {
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }
        };

        /// <summary>
        /// outputType
        /// </summary>
        [NameInMap("outputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

    }

}
