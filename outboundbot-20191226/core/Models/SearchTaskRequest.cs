// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SearchTaskRequest : TeaModel {
        /// <summary>
        /// <para>The start time of the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1646582400000</para>
        /// </summary>
        [NameInMap("ActualTimeGte")]
        [Validation(Required=false)]
        public long? ActualTimeGte { get; set; }

        /// <summary>
        /// <para>The end time of the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1643126399000</para>
        /// </summary>
        [NameInMap("ActualTimeLte")]
        [Validation(Required=false)]
        public long? ActualTimeLte { get; set; }

        /// <summary>
        /// <para>The minimum call duration for the search, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12341155</para>
        /// </summary>
        [NameInMap("CallDurationGte")]
        [Validation(Required=false)]
        public long? CallDurationGte { get; set; }

        /// <summary>
        /// <para>The maximum call duration for the search, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12341155</para>
        /// </summary>
        [NameInMap("CallDurationLte")]
        [Validation(Required=false)]
        public long? CallDurationLte { get; set; }

        /// <summary>
        /// <para>The called number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15126426342</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>The calling number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>051085500215</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public string CallingNumber { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d481cebe-0bb6-4d13-9649-42ce5074fb75</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The job group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3a30ae7c-27b2-4305-9444-7185ced9d51f</para>
        /// </summary>
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        /// <summary>
        /// <para>The name of the job group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ChinaLifePCHospitalizationInsuranceRenewal_20220301_134130</para>
        /// </summary>
        [NameInMap("JobGroupNameQuery")]
        [Validation(Required=false)]
        public string JobGroupNameQuery { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11994321-e6bc-47bb-8b1c-8eef8f2f768b</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The job statuses. Separate multiple statuses with commas (,). If this field is not empty, it overwrites jobStatusList. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Scheduling: The job is being scheduled.</description></item>
        /// <item><description>Executing: The job is being executed.</description></item>
        /// <item><description>Succeeded: The job is finished and the called party is reached.</description></item>
        /// <item><description>Paused: The job is stopped.</description></item>
        /// <item><description>Failed: The job is finished but the called party is not reached.</description></item>
        /// <item><description>Cancelled: The job is canceled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("JobStatusStringList")]
        [Validation(Required=false)]
        public string JobStatusStringList { get; set; }

        /// <summary>
        /// <para>The filter conditions for call labels.</para>
        /// <remarks>
        /// <para>You can only filter by labels that are configured with specific enumerated label values, which means labels configured with specific values in large language model scenarios.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("LabelsJson")]
        [Validation(Required=false)]
        public List<string> LabelsJson { get; set; }

        /// <summary>
        /// <para>The other IDs.</para>
        /// <para><b>This includes the following IDs:</b></para>
        /// <list type="bullet">
        /// <item><description><para>sessionID</para>
        /// </description></item>
        /// <item><description><para>taskid</para>
        /// </description></item>
        /// <item><description><para>jobid</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AVD-2021-39685</para>
        /// </summary>
        [NameInMap("OtherId")]
        [Validation(Required=false)]
        public string OtherId { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <remarks>
        /// <para>Page numbers for this API operation start from 0 by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <remarks>
        /// <para>If this parameter is left empty, the default value is 10.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The minimum ringing duration for the search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RecordingDurationGte")]
        [Validation(Required=false)]
        public long? RecordingDurationGte { get; set; }

        /// <summary>
        /// <para>The minimum ringing duration for the search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("RecordingDurationLte")]
        [Validation(Required=false)]
        public long? RecordingDurationLte { get; set; }

        /// <summary>
        /// <para>The scenario name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>China Life P&amp;C</para>
        /// </summary>
        [NameInMap("ScriptNameQuery")]
        [Validation(Required=false)]
        public string ScriptNameQuery { get; set; }

        /// <summary>
        /// <para>The sort field. Default value: actualTime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>actualTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>asc: Ascending order.</para>
        /// </description></item>
        /// <item><description><para>desc: Descending order. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>The start time of the task.</para>
        /// <remarks>
        /// <para>This parameter must be specified together with the TaskCreateTimeLte parameter. Otherwise, it does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1646792941</para>
        /// </summary>
        [NameInMap("TaskCreateTimeGte")]
        [Validation(Required=false)]
        public long? TaskCreateTimeGte { get; set; }

        /// <summary>
        /// <para>The end time of the task.</para>
        /// <remarks>
        /// <para>This parameter must be specified together with the TaskCreateTimeGte parameter. Otherwise, it does not take effect.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1646792941</para>
        /// </summary>
        [NameInMap("TaskCreateTimeLte")]
        [Validation(Required=false)]
        public long? TaskCreateTimeLte { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>744b27f3-437f-4a8c-a181-f668e492fd24</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The call statuses. Separate multiple statuses with commas (,). Valid values:
        /// (Note: The <b>Succeeded</b> status is subdivided into specific causes. The <b>Succeeded</b>: 1 (Connected) status is not displayed. All subsequent returned values are specific subdivided cause types.)</para>
        /// <list type="bullet">
        /// <item><description><b>Executing</b>: 0 (Dialing).</description></item>
        /// <item><description><b>Succeeded</b>: 1 (Connected).</description></item>
        /// <item><description><b>NoAnswer</b>: 2 (Not connected - No answer).</description></item>
        /// <item><description><b>NotExist</b>: 3 (Not connected - Nonexistent number).</description></item>
        /// <item><description><b>Busy</b>: 4 (Not connected - Busy).</description></item>
        /// <item><description><b>Cancelled</b>: 5 (Not called - Task stopped).</description></item>
        /// <item><description><b>Failed</b>: 6 (Failed).</description></item>
        /// <item><description><b>NotConnected</b>: 7 (Not connected - Unreachable).</description></item>
        /// <item><description><b>PoweredOff</b>: 8 (Not connected - Powered off).</description></item>
        /// <item><description><b>OutOfService</b>: 9 (Not connected - Suspended).</description></item>
        /// <item><description><b>InArrears</b>: 10 (Not connected - Overdue payment).</description></item>
        /// <item><description><b>EmptyNumber</b>: 11 (Not called - Nonexistent number, no call).</description></item>
        /// <item><description><b>PerDayCallCountLimit</b>: 12 (Not called - Daily limit exceeded).</description></item>
        /// <item><description><b>ContactBlockList</b>: 13 (Not called - Blacklisted).</description></item>
        /// <item><description><b>CallerNotRegistered</b>: 14 (Not called - Calling number not registered).</description></item>
        /// <item><description><b>Terminated</b>: 15 (Not called - Terminated).</description></item>
        /// <item><description><b>VerificationCancelled</b>: 16 (Not called - Canceled due to pre-call verification failure).</description></item>
        /// <item><description><b>OutOfServiceNoCall</b>: 17 (Not called - Suspended, no call).</description></item>
        /// <item><description><b>InArrearsNoCall</b>: 18 (Not called - Overdue payment, no call).</description></item>
        /// <item><description><b>CallingNumberNotExist</b>: 19 (Not called - Calling number does not exist).</description></item>
        /// <item><description><b>SucceededFinish</b>: 20 (Connected - Finished normally).</description></item>
        /// <item><description><b>SucceededChatbotHangUpAfterNoAnswer</b>: 21 (Connected - Bot hung up after unrecognized intent).</description></item>
        /// <item><description><b>SucceededChatbotHangUpAfterSilence</b>: 22 (Connected - Hung up due to silence timeout).</description></item>
        /// <item><description><b>SucceededClientHangUpAfterNoAnswer</b>: 23 (Connected - User hung up after unrecognized intent).</description></item>
        /// <item><description><b>SucceededClientHangUp</b>: 24 (Connected - User hung up without reason).</description></item>
        /// <item><description><b>SucceededTransferByIntent</b>: 25 (Connected - Transferred to agent due to matched intent).</description></item>
        /// <item><description><b>SucceededTransferAfterNoAnswer</b>: 26 (Connected - Transferred to agent after unrecognized intent).</description></item>
        /// <item><description><b>SucceededInoInterAction</b>: 27 (Connected - No interaction on the user side).</description></item>
        /// <item><description><b>SucceededError</b>: 28 (Connected - Interrupted due to system exception).</description></item>
        /// <item><description><b>SucceededSpecialInterceptVoiceAssistant</b>: 29 (Connected - Special interception - Voice assistant).</description></item>
        /// <item><description><b>SucceededSpecialInterceptExtensionNumberTransfer</b>: 30 (Connected - Special interception - Extension number transfer).</description></item>
        /// <item><description><b>SucceededSpecialInterceptCustomSpecialIntercept</b>: 31 (Connected - Special interception - Custom interception).</description></item>
        /// <item><description><b>HighRiskSipCode</b>: 32 (Not called - High risk, no call).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Executing</para>
        /// </summary>
        [NameInMap("TaskStatusStringList")]
        [Validation(Required=false)]
        public string TaskStatusStringList { get; set; }

        /// <summary>
        /// <para>The user ID, which is the unique identifier of the user.</para>
        /// <remarks>
        /// <para>This field is passed when you upload an outbound call list.</para>
        /// <list type="bullet">
        /// <item><description>If the list is uploaded in JSON format, the user ID is the value of referenceId.</description></item>
        /// <item><description>If the list is uploaded in an Excel file, the user ID is the value of contactId.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>C01</para>
        /// </summary>
        [NameInMap("UserIdMatch")]
        [Validation(Required=false)]
        public string UserIdMatch { get; set; }

    }

}
