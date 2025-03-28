// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeJobMonitorRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. This parameter will be removed in the future.</para>
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
        /// <para>The dynamic part in the error message. This parameter is used to replace the <b>%s</b> variable in the <b>ErrMessage</b> parameter.</para>
        /// <remarks>
        /// <para> If the specified <b>DtsJobId</b> parameter is invalid, <b>The Value of Input Parameter %s is not valid</b> is returned for <b>ErrMessage</b> and <b>DtsJobId</b> is returned for <b>DynamicMessage</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>DtsJobId</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The error code returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>403</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the call failed.</para>
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
        /// <para>The monitoring rules of the DTS task.</para>
        /// </summary>
        [NameInMap("MonitorRules")]
        [Validation(Required=false)]
        public List<DescribeJobMonitorRuleResponseBodyMonitorRules> MonitorRules { get; set; }
        public class DescribeJobMonitorRuleResponseBodyMonitorRules : TeaModel {
            /// <summary>
            /// <para>The threshold that triggers the alert.</para>
            /// <list type="bullet">
            /// <item><description>If the request parameter <b>Type</b> of the <a href="https://help.aliyun.com/document_detail/212332.html">CreateJobMonitorRule</a> operation is set to <b>delay</b>, the unit of DelayRuleTime is seconds.</description></item>
            /// <item><description>If the request parameter <b>Type</b> of the <a href="https://help.aliyun.com/document_detail/212332.html">CreateJobMonitorRule</a> operation is set to <b>full_timeout</b>, the unit of DelayRuleTime is hours.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("DelayRuleTime")]
            [Validation(Required=false)]
            public long? DelayRuleTime { get; set; }

            /// <summary>
            /// <para>Task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bi6e22ay243****</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The task type of the DTS instance, with values: - <b>normal</b>: Migration or synchronization task. - <b>full_check</b>: Associated full check task. - <b>etl_check</b>: Associated incremental check task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>normal</para>
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// <para>Alarm threshold.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("NoticeValue")]
            [Validation(Required=false)]
            public int? NoticeValue { get; set; }

            /// <summary>
            /// <para>The statistical period for incremental validation tasks, in minutes.</para>
            /// <remarks>
            /// <para>Currently supported values are 1 minute, 5 minutes, 10 minutes, and 30 minutes.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// <para>The mobile phone numbers that receive alert notifications. Multiple mobile numbers are separated by commas (,).</para>
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
            /// <item><description><b>Y</b>: The monitoring rule is enabled.</description></item>
            /// <item><description><b>N</b>: The monitoring rule is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Y</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The number of cycles for the incremental validation task.</para>
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
            /// <item><description><b>delay</b>: If the task latency reaches the threshold, an alert is triggered.</description></item>
            /// <item><description><b>error</b>: If an exception occurs, an alert is triggered.</description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0CA14388-DD89-4A7B-8CDD-884A10CE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>:The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The topics of all subtasks in the distributed change tracking task.</para>
        /// </summary>
        [NameInMap("Topics")]
        [Validation(Required=false)]
        public List<string> Topics { get; set; }

    }

}
