// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeSoarTaskAndActionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the task execution.</para>
        /// </summary>
        [NameInMap("Details")]
        [Validation(Required=false)]
        public DescribeSoarTaskAndActionsResponseBodyDetails Details { get; set; }
        public class DescribeSoarTaskAndActionsResponseBodyDetails : TeaModel {
            /// <summary>
            /// <para>The total number of action logs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("ActionLogNum")]
            [Validation(Required=false)]
            public int? ActionLogNum { get; set; }

            /// <summary>
            /// <para>The list of component actions executed in the playbook.</para>
            /// </summary>
            [NameInMap("Actions")]
            [Validation(Required=false)]
            public List<DescribeSoarTaskAndActionsResponseBodyDetailsActions> Actions { get; set; }
            public class DescribeSoarTaskAndActionsResponseBodyDetailsActions : TeaModel {
                /// <summary>
                /// <para>The name of the component action.</para>
                /// 
                /// <b>Example:</b>
                /// <para>formatdata</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The UUID of the component action execution record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>091be399-a937-4276-af78-xxxxxxxx</para>
                /// </summary>
                [NameInMap("ActionUuid")]
                [Validation(Required=false)]
                public string ActionUuid { get; set; }

                /// <summary>
                /// <para>The name of the asset used by the component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SLS Asset</para>
                /// </summary>
                [NameInMap("AssetName")]
                [Validation(Required=false)]
                public string AssetName { get; set; }

                /// <summary>
                /// <para>The name of the component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DataFormat</para>
                /// </summary>
                [NameInMap("Component")]
                [Validation(Required=false)]
                public string Component { get; set; }

                /// <summary>
                /// <para>The end time of the component run. This is a 13-digit timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1699868848766</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The custom node name of the component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DataFormat_1</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The start time of the component run. This is a 13-digit timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1699868848731</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The result of the component run. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>success</b>: The run was successful.</para>
                /// </description></item>
                /// <item><description><para><b>fail</b>: The run failed.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The end time of the playbook run. This is a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1699868848767</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The error message for the playbook task. This field is empty if the task is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stime not match</para>
            /// </summary>
            [NameInMap("ErrorMsg")]
            [Validation(Required=false)]
            public string ErrorMsg { get; set; }

            /// <summary>
            /// <para>The request parameters of the playbook task.</para>
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
            /// <para>The request ID of the playbook task. This is the unique ID for each task run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>17f75844-75cc-4174-86da-cec07a690142</para>
            /// </summary>
            [NameInMap("RequestUuid")]
            [Validation(Required=false)]
            public string RequestUuid { get; set; }

            /// <summary>
            /// <para>The start time of the playbook run. This is a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1699868848645</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The status of the playbook task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>success</b>: The task was successful.</para>
            /// </description></item>
            /// <item><description><para><b>fail</b>: The task failed.</para>
            /// </description></item>
            /// <item><description><para><b>running</b>: The task is running.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The MD5 value of the playbook configuration that was run.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ed127287-6699-4e4d-b986-9f770879xxx</para>
            /// </summary>
            [NameInMap("TaskFlowMd5")]
            [Validation(Required=false)]
            public string TaskFlowMd5 { get; set; }

            /// <summary>
            /// <para>The name of the playbook task. This is the same as the playbook UUID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>92af3c79-1754-4646-9366-9ddbd1e45536</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The trigger type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>debug</b>: A task for debugging a playbook.</para>
            /// </description></item>
            /// <item><description><para><b>manual</b>: A manually triggered task.</para>
            /// </description></item>
            /// <item><description><para><b>siem</b>: An event-triggered task.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>siem</para>
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that triggered the playbook task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127xxxx4392</para>
            /// </summary>
            [NameInMap("TriggerUser")]
            [Validation(Required=false)]
            public string TriggerUser { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public DescribeSoarTaskAndActionsResponseBodyPage Page { get; set; }
        public class DescribeSoarTaskAndActionsResponseBodyPage : TeaModel {
            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18017A93-3D5D-503A-8308-914543F1CBA3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
