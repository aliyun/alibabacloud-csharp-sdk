// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeSoarRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public DescribeSoarRecordsResponseBodyPage Page { get; set; }
        public class DescribeSoarRecordsResponseBodyPage : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>22</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>601C2DAC-6A67-5237-BEE8-5BF1CEE96296</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The execution records.</para>
        /// </summary>
        [NameInMap("SoarExecuteRecords")]
        [Validation(Required=false)]
        public List<DescribeSoarRecordsResponseBodySoarExecuteRecords> SoarExecuteRecords { get; set; }
        public class DescribeSoarRecordsResponseBodySoarExecuteRecords : TeaModel {
            /// <summary>
            /// <para>The end of the time range to query. The value is a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1686294686000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The error message of the task. If the task is successful, this field is empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stime not match</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>The request parameters of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;input1&quot;: &quot;xx.xx.xx.xx&quot;,
            ///     &quot;input2&quot;: &quot;7d&quot;
            /// }</para>
            /// </summary>
            [NameInMap("RawEventReq")]
            [Validation(Required=false)]
            public string RawEventReq { get; set; }

            /// <summary>
            /// <para>The request ID of the task. The value is unique.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ba1ec480-aa90-4bb6-a1a7-9e311ae79321</para>
            /// </summary>
            [NameInMap("RequestUuid")]
            [Validation(Required=false)]
            public string RequestUuid { get; set; }

            /// <summary>
            /// <para>The returned information about the playbook. You can define the value in the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Playbook finish</para>
            /// </summary>
            [NameInMap("ResultMessage")]
            [Validation(Required=false)]
            public string ResultMessage { get; set; }

            /// <summary>
            /// <para>The beginning of the time range to query. The value is a 13-byte timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1675823338433</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The status of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>success</b></description></item>
            /// <item><description><b>fail</b></description></item>
            /// <item><description><b>running</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The name of the task. The value is the same as the playbook UUID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>82848ebc-eaff-4791-acd4-xxxxx</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The type of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>general</b>: a common task</description></item>
            /// <item><description><b>standard</b>: a component task</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The MD5 value of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dea65a3db87fb9bd84bbxxxxx</para>
            /// </summary>
            [NameInMap("TaskflowMd5")]
            [Validation(Required=false)]
            public string TaskflowMd5 { get; set; }

            /// <summary>
            /// <para>The type of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>debug</b>: a debugging task</description></item>
            /// <item><description><b>manual</b>: a manual task</description></item>
            /// <item><description><b>siem</b>: a task that is triggered by an event or alert</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>debug</para>
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that is used to execute the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127xxxx4392</para>
            /// </summary>
            [NameInMap("TriggerUser")]
            [Validation(Required=false)]
            public string TriggerUser { get; set; }

        }

    }

}
