// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class ScheduledSQLConfiguration : TeaModel {
        /// <summary>
        /// <para>The write mode. Three configurations are supported: log2log, log2metric, and metric2metric.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>log2log</para>
        /// </summary>
        [NameInMap("dataFormat")]
        [Validation(Required=false)]
        public string DataFormat { get; set; }

        /// <summary>
        /// <para>The destination endpoint.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-intranet.log.aliyuncs.com</para>
        /// </summary>
        [NameInMap("destEndpoint")]
        [Validation(Required=false)]
        public string DestEndpoint { get; set; }

        /// <summary>
        /// <para>The destination logstore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dest-logstore-demo</para>
        /// </summary>
        [NameInMap("destLogstore")]
        [Validation(Required=false)]
        public string DestLogstore { get; set; }

        /// <summary>
        /// <para>The destination project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>project-demo</para>
        /// </summary>
        [NameInMap("destProject")]
        [Validation(Required=false)]
        public string DestProject { get; set; }

        /// <summary>
        /// <para>The ARN of the role used to write data to the destination.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789:role/aliyunlogetlrole</para>
        /// </summary>
        [NameInMap("destRoleArn")]
        [Validation(Required=false)]
        public string DestRoleArn { get; set; }

        /// <summary>
        /// <para>Specifies whether to ensure accurate computation results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("forceComplete")]
        [Validation(Required=false)]
        public bool? ForceComplete { get; set; }

        /// <summary>
        /// <para>The start time. For more information, see <a href="https://help.aliyun.com/document_detail/286459.html">From Logstore to MetricStore</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1712592000</para>
        /// </summary>
        [NameInMap("fromTime")]
        [Validation(Required=false)]
        public long? FromTime { get; set; }

        /// <summary>
        /// <para>The start of the SQL time window.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>@m-1m</para>
        /// </summary>
        [NameInMap("fromTimeExpr")]
        [Validation(Required=false)]
        public string FromTimeExpr { get; set; }

        /// <summary>
        /// <para>The concurrency.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("maxConcurrency")]
        [Validation(Required=false)]
        public long? MaxConcurrency { get; set; }

        /// <summary>
        /// <para>The maximum number of retries upon SQL timeout. Valid values: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxRetries")]
        [Validation(Required=false)]
        public long? MaxRetries { get; set; }

        /// <summary>
        /// <para>The maximum timeout period for SQL execution. Unit: seconds. Valid values: 60 to 1800.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("maxRunTimeInSeconds")]
        [Validation(Required=false)]
        public long? MaxRunTimeInSeconds { get; set; }

        /// <summary>
        /// <para>The SQL configuration. For more information, see <a href="https://help.aliyun.com/document_detail/286459.html">From Logstore to MetricStore</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   addLabels: &quot;{}&quot;,
        ///   hashLabels: &quot;[]&quot;,
        ///   labelKeys: &quot;[\&quot;your label1\&quot;,\&quot;your label2\&quot;]&quot;,
        ///   metricKeys: &quot;[\&quot;your Indicator1\&quot;,\&quot;your Indicator2\&quot;]&quot;,
        ///   metricName: &quot;&quot;,
        ///   timeKey: &quot;&quot;
        /// }</para>
        /// </summary>
        [NameInMap("parameters")]
        [Validation(Required=false)]
        public Dictionary<string, object> Parameters { get; set; }

        /// <summary>
        /// <para>The resource pool type. A value of enhanced indicates the enhanced resource pool.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enhanced</para>
        /// </summary>
        [NameInMap("resourcePool")]
        [Validation(Required=false)]
        public string ResourcePool { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of the role used to execute the SQL statement.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::123456789:role/aliyunlogetlrole</para>
        /// </summary>
        [NameInMap("roleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The analytic statement of the scheduled query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description>| select *</description></item>
        /// </list>
        /// </summary>
        [NameInMap("script")]
        [Validation(Required=false)]
        public string Script { get; set; }

        /// <summary>
        /// <para>The source logstore.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>source-logstore-demo</para>
        /// </summary>
        [NameInMap("sourceLogstore")]
        [Validation(Required=false)]
        public string SourceLogstore { get; set; }

        /// <summary>
        /// <para>The SQL type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>searchQuery</para>
        /// </summary>
        [NameInMap("sqlType")]
        [Validation(Required=false)]
        public string SqlType { get; set; }

        /// <summary>
        /// <para>The end time. For more information, see <a href="https://help.aliyun.com/document_detail/286459.html">From Logstore to MetricStore</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("toTime")]
        [Validation(Required=false)]
        public long? ToTime { get; set; }

        /// <summary>
        /// <para>The end of the SQL time window.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>@m</para>
        /// </summary>
        [NameInMap("toTimeExpr")]
        [Validation(Required=false)]
        public string ToTimeExpr { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the Exactly-Once write protocol.</para>
        /// </summary>
        [NameInMap("usingExactlyOnce")]
        [Validation(Required=false)]
        public bool? UsingExactlyOnce { get; set; }

    }

}
