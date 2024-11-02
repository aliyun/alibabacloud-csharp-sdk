// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeSoarTaskAndActionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The execution details of each task.</para>
        /// </summary>
        [NameInMap("Details")]
        [Validation(Required=false)]
        public DescribeSoarTaskAndActionsResponseBodyDetails Details { get; set; }
        public class DescribeSoarTaskAndActionsResponseBodyDetails : TeaModel {
            /// <summary>
            /// <para>The list of component actions during the running of the playbook.</para>
            /// </summary>
            [NameInMap("Actions")]
            [Validation(Required=false)]
            public List<DescribeSoarTaskAndActionsResponseBodyDetailsActions> Actions { get; set; }
            public class DescribeSoarTaskAndActionsResponseBodyDetailsActions : TeaModel {
                /// <summary>
                /// <para>The action name of the component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>formatdata</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The UUID of the component execution record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>091be399-a937-4276-af78-xxxxxxxx</para>
                /// </summary>
                [NameInMap("ActionUuid")]
                [Validation(Required=false)]
                public string ActionUuid { get; set; }

                /// <summary>
                /// <para>The name of the asset that is used by the component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SLS Asset</para>
                /// </summary>
                [NameInMap("AssetName")]
                [Validation(Required=false)]
                public string AssetName { get; set; }

                /// <summary>
                /// <para>The component name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DataFormat</para>
                /// </summary>
                [NameInMap("Component")]
                [Validation(Required=false)]
                public string Component { get; set; }

                /// <summary>
                /// <para>The end of the time range during which the component is run. The value is a 13-digit timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1699868848766</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                /// <summary>
                /// <para>The custom name of the node in the component.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DataFormat_1</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The request ID of the task. The value is unique.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8dac16c6-7411-4116-8d70-xxxxxxx</para>
                /// </summary>
                [NameInMap("RequestUuid")]
                [Validation(Required=false)]
                public string RequestUuid { get; set; }

                /// <summary>
                /// <para>The beginning of the time range during which the component is run. The value is a 13-digit timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1699868848731</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

                /// <summary>
                /// <para>The running result of the component. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>success</b></description></item>
                /// <item><description><b>fail</b></description></item>
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
                /// <para>ed127287-6699-4e4d-b986-xxxxxxx</para>
                /// </summary>
                [NameInMap("TaskName")]
                [Validation(Required=false)]
                public string TaskName { get; set; }

                /// <summary>
                /// <para>The status of the triggered component action.</para>
                /// <remarks>
                /// <para> This parameter is disabled and left empty.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>NULL</para>
                /// </summary>
                [NameInMap("TaskStatus")]
                [Validation(Required=false)]
                public string TaskStatus { get; set; }

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

            /// <summary>
            /// <para>The end of the time range during which the playbook is run. The value is a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1699868848767</para>
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
            /// <para>17f75844-75cc-4174-86da-cec07a690142</para>
            /// </summary>
            [NameInMap("RequestUuid")]
            [Validation(Required=false)]
            public string RequestUuid { get; set; }

            /// <summary>
            /// <para>The flag of the task. For debugging tasks, the value is <b>DEBUG</b>. For other tasks, the parameter is left empty.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEBUG</para>
            /// </summary>
            [NameInMap("ResultLevel")]
            [Validation(Required=false)]
            public string ResultLevel { get; set; }

            /// <summary>
            /// <para>The returned information about the playbook. You can define the value in the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>deubug playbook finished</para>
            /// </summary>
            [NameInMap("ResultMessage")]
            [Validation(Required=false)]
            public string ResultMessage { get; set; }

            /// <summary>
            /// <para>The beginning of the time range during which the playbook is run. The value is a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1699868848645</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
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
            /// <para>The MD5 value of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ed127287-6699-4e4d-b986-9f770879xxx</para>
            /// </summary>
            [NameInMap("TaskFlowMd5")]
            [Validation(Required=false)]
            public string TaskFlowMd5 { get; set; }

            /// <summary>
            /// <para>The name of the task. The value is the same as the playbook UUID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>92af3c79-1754-4646-9366-9ddbd1e45536</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the task belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127xxxx4392</para>
            /// </summary>
            [NameInMap("TaskTenantId")]
            [Validation(Required=false)]
            public string TaskTenantId { get; set; }

            /// <summary>
            /// <para>The task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>debug</b>: a debugging task</description></item>
            /// <item><description><b>manual</b>: a manual task</description></item>
            /// <item><description><b>siem</b>: an event-triggered task</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>siem</para>
            /// </summary>
            [NameInMap("TriggerType")]
            [Validation(Required=false)]
            public string TriggerType { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that triggers the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>127xxxx4392</para>
            /// </summary>
            [NameInMap("TriggerUser")]
            [Validation(Required=false)]
            public string TriggerUser { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>18017A93-3D5D-503A-8308-914543F1CBA3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
