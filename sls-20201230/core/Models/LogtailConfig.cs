// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class LogtailConfig : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-config</para>
        /// </summary>
        [NameInMap("configName")]
        [Validation(Required=false)]
        public string ConfigName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1655176807</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("inputDetail")]
        [Validation(Required=false)]
        public Dictionary<string, object> InputDetail { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file</para>
        /// </summary>
        [NameInMap("inputType")]
        [Validation(Required=false)]
        public string InputType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1655176807</para>
        /// </summary>
        [NameInMap("lastModifyTime")]
        [Validation(Required=false)]
        public long? LastModifyTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-06-14 11:13:29.796 | DEBUG    | <b>main</b>:<module>:1 - hello world</para>
        /// </summary>
        [NameInMap("logSample")]
        [Validation(Required=false)]
        public string LogSample { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("outputDetail")]
        [Validation(Required=false)]
        public LogtailConfigOutputDetail OutputDetail { get; set; }
        public class LogtailConfigOutputDetail : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-intranet.log.aliyuncs.com</para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-logstore</para>
            /// </summary>
            [NameInMap("logstoreName")]
            [Validation(Required=false)]
            public string LogstoreName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>logs</para>
            /// </summary>
            [NameInMap("telemetryType")]
            [Validation(Required=false)]
            public string TelemetryType { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LogService</para>
        /// </summary>
        [NameInMap("outputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

    }

}
