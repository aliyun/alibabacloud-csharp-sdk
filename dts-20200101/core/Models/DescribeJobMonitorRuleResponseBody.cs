// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeJobMonitorRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. This parameter will be deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The ID of the data migration, data synchronization, or change tracking task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ta7w132u12h****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>The dynamic error message used to replace the <b>%s</b> placeholder in the <b>ErrMessage</b> response parameter.</para>
        /// <remarks>
        /// <para>For example, if <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, the request parameter <b>DtsJobId</b> is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DtsJobId</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code returned if the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the call fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Value of Input Parameter %s is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The monitoring rule information of the DTS task.</para>
        /// </summary>
        [NameInMap("MonitorRules")]
        [Validation(Required=false)]
        public List<DescribeJobMonitorRuleResponseBodyMonitorRules> MonitorRules { get; set; }
        public class DescribeJobMonitorRuleResponseBodyMonitorRules : TeaModel {
            /// <summary>
            /// <para>The threshold that triggers a latency alert. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("DelayRuleTime")]
            [Validation(Required=false)]
            public long? DelayRuleTime { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bi6e22ay243****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The task type of the DTS instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>normal</b>: data migration or data synchronization task.</description></item>
            /// <item><description><b>full_check</b>: associated full data validation task.</description></item>
            /// <item><description><b>etl_check</b>: associated incremental data validation task.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <para>The alert threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NoticeValue")]
            [Validation(Required=false)]
            public int? NoticeValue { get; set; }

            /// <summary>
            /// <para>The statistical period of the incremental data validation task. Unit: minutes.</para>
            /// <remarks>
            /// <para>Valid values: 1, 5, 10, and 30 minutes.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// <para>The phone numbers of the contacts to be notified when an alert is triggered. Multiple phone numbers are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1361234****,1371234****</para>
            /// </summary>
            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            /// <summary>
            /// <para>Indicates whether the monitoring rule is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Y</b>: enabled.</description></item>
            /// <item><description><b>N</b>: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The number of periods for the incremental data validation task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Times")]
            [Validation(Required=false)]
            public int? Times { get; set; }

            /// <summary>
            /// <para>The type of the monitoring rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>delay</b>: latency alert.</description></item>
            /// <item><description><b>error</b>: anomaly alert.</description></item>
            /// <item><description><b>full_timeout</b>: alert for the runtime of the full data module.</description></item>
            /// <item><description><b>warn</b>: notification alert (the task succeeded but the result did not meet expectations).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>delay</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CA14388-DD89-4A7B-8CDD-884A10CE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The Kafka topics.</para>
        /// </summary>
        [NameInMap("Topics")]
        [Validation(Required=false)]
        public List<string> Topics { get; set; }

    }

}
