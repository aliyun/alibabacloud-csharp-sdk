// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class LogtailConfig : TeaModel {
        /// <summary>
        /// <para>The name of the Logtail configuration. The name must be unique in the project to which the Logtail configuration belongs. After the Logtail configuration is created, you cannot change the name of the Logtail configuration. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name can contain only lowercase letters, digits, hyphens (-), and underscores (_).</description></item>
        /// <item><description>The name must start and end with a lowercase letter or a digit.</description></item>
        /// <item><description>The name must be 2 to 128 characters in length.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-config</para>
        /// </summary>
        [NameInMap("configName")]
        [Validation(Required=false)]
        public string ConfigName { get; set; }

        /// <summary>
        /// <para>The time at which the Logtail configuration was created. The value is a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1655176807</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The detailed settings of the data source. For more information, see <a href="https://help.aliyun.com/document_detail/29058.html">inputDetail</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;logType&quot;: &quot;common_reg_log&quot;, &quot;logPath&quot;: &quot;/var/log/httpd/&quot;, &quot;filePattern&quot;: &quot;access*.log&quot;, &quot;localStorage&quot;: true, &quot;timeFormat&quot;: &quot;%Y/%m/%d %H:%M:%S&quot;, &quot;logBeginRegex&quot;: &quot;.*&quot;, &quot;regex&quot;: &quot;(\w+)(\s+)&quot;, &quot;key&quot; :[&quot;key1&quot;, &quot;key2&quot;], &quot;filterKey&quot;:[&quot;key1&quot;], &quot;filterRegex&quot;:[&quot;regex1&quot;], &quot;fileEncoding&quot;:&quot;utf8&quot;, &quot;topicFormat&quot;: &quot;none&quot;</para>
        /// </summary>
        [NameInMap("inputDetail")]
        [Validation(Required=false)]
        public Dictionary<string, object> InputDetail { get; set; }

        /// <summary>
        /// <para>The type of the data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>plugin</b>: Logs such as MySQL binary logs are collected by using Logtail plug-ins.</description></item>
        /// <item><description><b>file</b>: Logs from text files are collected by using existing modes, including the full regex mode and delimiter mode.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>file</para>
        /// </summary>
        [NameInMap("inputType")]
        [Validation(Required=false)]
        public string InputType { get; set; }

        /// <summary>
        /// <para>The time at which the Logtail configuration was last modified. The value is a UNIX timestamp representing the number of seconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1655176807</para>
        /// </summary>
        [NameInMap("lastModifyTime")]
        [Validation(Required=false)]
        public long? LastModifyTime { get; set; }

        /// <summary>
        /// <para>The sample log.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-06-14 11:13:29.796 | DEBUG    | <b>main</b>:<module>:1 - hello world</para>
        /// </summary>
        [NameInMap("logSample")]
        [Validation(Required=false)]
        public string LogSample { get; set; }

        /// <summary>
        /// <para>The detailed settings of the data destination. For more information, see <a href="https://help.aliyun.com/document_detail/29058.html">outputDetail</a>.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("outputDetail")]
        [Validation(Required=false)]
        public LogtailConfigOutputDetail OutputDetail { get; set; }
        public class LogtailConfigOutputDetail : TeaModel {
            /// <summary>
            /// <para>The endpoint. For more information, see <a href="https://help.aliyun.com/document_detail/29008.html">Endpoints</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-intranet.log.aliyuncs.com</para>
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// <para>The name of the Logstore.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-logstore</para>
            /// </summary>
            [NameInMap("logstoreName")]
            [Validation(Required=false)]
            public string LogstoreName { get; set; }

            /// <summary>
            /// <para>The ID of the region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The type of observable data in the Logstore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logs</para>
            /// </summary>
            [NameInMap("telemetryType")]
            [Validation(Required=false)]
            public string TelemetryType { get; set; }

        }

        /// <summary>
        /// <para>The type of the data destination. Set the value to LogService. Collected logs can be uploaded to only Simple Log Service.</para>
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
