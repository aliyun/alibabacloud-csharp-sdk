// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateLoggingRequest : TeaModel {
        /// <summary>
        /// 服务日志配置列表。
        /// </summary>
        [NameInMap("loggingDetails")]
        [Validation(Required=false)]
        public List<CreateLoggingRequestLoggingDetails> LoggingDetails { get; set; }
        public class CreateLoggingRequestLoggingDetails : TeaModel {
            /// <summary>
            /// 该种类服务日志要保存到的 logstore 名称。
            /// </summary>
            [NameInMap("logstore")]
            [Validation(Required=false)]
            public string Logstore { get; set; }

            /// <summary>
            /// 服务日志的种类。可选 "consumergroup_log"、 "logtail_alarm"、"operation_log"、"logtail_profile"、"metering"、"logtail_status"、"scheduled_sql_alert"、 "etl_alert" 等。
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// 服务日志要保存到的 project 名称。
        /// </summary>
        [NameInMap("loggingProject")]
        [Validation(Required=false)]
        public string LoggingProject { get; set; }

    }

}
