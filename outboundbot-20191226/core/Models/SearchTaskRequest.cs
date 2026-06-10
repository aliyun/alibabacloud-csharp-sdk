// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SearchTaskRequest : TeaModel {
        /// <summary>
        /// <para>Call start time</para>
        /// 
        /// <b>Example:</b>
        /// <para>1646582400000</para>
        /// </summary>
        [NameInMap("ActualTimeGte")]
        [Validation(Required=false)]
        public long? ActualTimeGte { get; set; }

        /// <summary>
        /// <para>Call end time</para>
        /// 
        /// <b>Example:</b>
        /// <para>1643126399000</para>
        /// </summary>
        [NameInMap("ActualTimeLte")]
        [Validation(Required=false)]
        public long? ActualTimeLte { get; set; }

        /// <summary>
        /// <para>Minimum call duration, in milliseconds</para>
        /// 
        /// <b>Example:</b>
        /// <para>12341155</para>
        /// </summary>
        [NameInMap("CallDurationGte")]
        [Validation(Required=false)]
        public long? CallDurationGte { get; set; }

        /// <summary>
        /// <para>Maximum call duration, in milliseconds</para>
        /// 
        /// <b>Example:</b>
        /// <para>12341155</para>
        /// </summary>
        [NameInMap("CallDurationLte")]
        [Validation(Required=false)]
        public long? CallDurationLte { get; set; }

        /// <summary>
        /// <para>Called number</para>
        /// 
        /// <b>Example:</b>
        /// <para>15126426342</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>Calling number</para>
        /// 
        /// <b>Example:</b>
        /// <para>051085500215</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public string CallingNumber { get; set; }

        /// <summary>
        /// <para>Instance ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d481cebe-0bb6-4d13-9649-42ce5074fb75</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Job group ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>3a30ae7c-27b2-4305-9444-7185ced9d51f</para>
        /// </summary>
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        /// <summary>
        /// <para>Job group name</para>
        /// 
        /// <b>Example:</b>
        /// <para>国寿财住院保续保_20220301_134130</para>
        /// </summary>
        [NameInMap("JobGroupNameQuery")]
        [Validation(Required=false)]
        public string JobGroupNameQuery { get; set; }

        /// <summary>
        /// <para>Job ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>11994321-e6bc-47bb-8b1c-8eef8f2f768b</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>Job status. Separate multiple statuses with commas. If you specify this parameter, it overrides jobStatusList.</para>
        /// <list type="bullet">
        /// <item><description><para>Scheduling: The job is being scheduled.</para>
        /// </description></item>
        /// <item><description><para>Executing: The job is running.</para>
        /// </description></item>
        /// <item><description><para>Succeeded: The job completed successfully.</para>
        /// </description></item>
        /// <item><description><para>Paused: The job was paused.</para>
        /// </description></item>
        /// <item><description><para>Failed: The job failed.</para>
        /// </description></item>
        /// <item><description><para>Cancelled: The job was cancelled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("JobStatusStringList")]
        [Validation(Required=false)]
        public string JobStatusStringList { get; set; }

        /// <summary>
        /// <para>Label-based filter condition for calls</para>
        /// <remarks>
        /// <para>You can only use labels that have specific enumeration values. For example, labels configured with specific values in Large Language Model (LLM) scenarios.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("LabelsJson")]
        [Validation(Required=false)]
        public List<string> LabelsJson { get; set; }

        /// <summary>
        /// <para>Other ID</para>
        /// <para><b>Valid values include the following:</b></para>
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
        /// <para>Page number</para>
        /// <remarks>
        /// <para>The first page is 0.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>Number of items per page</para>
        /// <remarks>
        /// <para>If you omit this parameter, the default value is 10.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Minimum ring duration, in seconds</para>
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
        /// <para>Scenario name</para>
        /// 
        /// <b>Example:</b>
        /// <para>国寿财</para>
        /// </summary>
        [NameInMap("ScriptNameQuery")]
        [Validation(Required=false)]
        public string ScriptNameQuery { get; set; }

        /// <summary>
        /// <para>Sort field. Default value: actualTime</para>
        /// 
        /// <b>Example:</b>
        /// <para>actualTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>Sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>asc (ascending)</para>
        /// </description></item>
        /// <item><description><para>desc (descending). Default value.</para>
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
        /// <para>Start time of the task</para>
        /// <remarks>
        /// <para>You must specify both TaskCreateTimeGte and TaskCreateTimeLte. If you omit either, the filter does not work.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1646792941</para>
        /// </summary>
        [NameInMap("TaskCreateTimeGte")]
        [Validation(Required=false)]
        public long? TaskCreateTimeGte { get; set; }

        /// <summary>
        /// <para>End time of the task</para>
        /// <remarks>
        /// <para>You must specify both TaskCreateTimeGte and TaskCreateTimeLte. If you omit either, the filter does not work.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1646792941</para>
        /// </summary>
        [NameInMap("TaskCreateTimeLte")]
        [Validation(Required=false)]
        public long? TaskCreateTimeLte { get; set; }

        /// <summary>
        /// <para>Task ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>744b27f3-437f-4a8c-a181-f668e492fd24</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>Call status. Separate multiple statuses with commas.</para>
        /// <list type="bullet">
        /// <item><description><para><b>Executing</b>: 0 (Calling).</para>
        /// </description></item>
        /// <item><description><para><b>Succeeded</b>: 1 (Connected).</para>
        /// </description></item>
        /// <item><description><para><b>NoAnswer</b>: 2 (No answer).</para>
        /// </description></item>
        /// <item><description><para><b>NotExist</b>: 3 (Nonexistent number).</para>
        /// </description></item>
        /// <item><description><para><b>Busy</b>: 4 (Line busy).</para>
        /// </description></item>
        /// <item><description><para><b>Cancelled</b>: 5 (Call canceled due to job stop).</para>
        /// </description></item>
        /// <item><description><para><b>Failed</b>: 6 (Call failed).</para>
        /// </description></item>
        /// <item><description><para><b>NotConnected</b>: 7 (Cannot connect).</para>
        /// </description></item>
        /// <item><description><para><b>PoweredOff</b>: 8 (Phone powered off).</para>
        /// </description></item>
        /// <item><description><para><b>OutOfService</b>: 9 (Called number out of service).</para>
        /// </description></item>
        /// <item><description><para><b>InArrears</b>: 10 (Called number overdue payment).</para>
        /// </description></item>
        /// <item><description><para><b>EmptyNumber</b>: 11 (Empty number, no outbound call).</para>
        /// </description></item>
        /// <item><description><para><b>PerDayCallCountLimit</b>: 12 (Daily call limit exceeded).</para>
        /// </description></item>
        /// <item><description><para><b>ContactBlockList</b>: 13 (Blacklisted).</para>
        /// </description></item>
        /// <item><description><para><b>CallerNotRegistered</b>: 14 (Caller number not registered).</para>
        /// </description></item>
        /// <item><description><para><b>Terminated</b>: 15 (Call terminated).</para>
        /// </description></item>
        /// <item><description><para><b>VerificationCancelled</b>: 16 (Call canceled due to pre-call validation failure).</para>
        /// </description></item>
        /// <item><description><para><b>OutOfServiceNoCall</b>: 17 (Called number out of service, no outbound call).</para>
        /// </description></item>
        /// <item><description><para><b>InArrearsNoCall</b>: 18 (Called number overdue payment, no outbound call).</para>
        /// </description></item>
        /// <item><description><para><b>CallingNumberNotExist</b>: 19 (Caller number does not exist).</para>
        /// </description></item>
        /// <item><description><para><b>SucceededFinish</b>: 20 (Connected and ended normally).</para>
        /// </description></item>
        /// <item><description><para><b>SucceededChatbotHangUpAfterNoAnswer</b>: 21 (Connected and robot hung up after rejection).</para>
        /// </description></item>
        /// <item><description><para><b>SucceededChatbotHangUpAfterSilence</b>: 22 (Connected and robot hung up after silence timeout).</para>
        /// </description></item>
        /// <item><description><para><b>SucceededClientHangUpAfterNoAnswer</b>: 23 (Connected and client hung up after rejection).</para>
        /// </description></item>
        /// <item><description><para><b>SucceededClientHangUp</b>: 24 (Connected and client hung up without reason).</para>
        /// </description></item>
        /// <item><description><para><b>SucceededTransferByIntent</b>: 25 (Connected and transferred to agent based on intent match).</para>
        /// </description></item>
        /// <item><description><para><b>SucceededTransferAfterNoAnswer</b>: 26 (Connected and transferred to agent after rejection).</para>
        /// </description></item>
        /// <item><description><para><b>SucceededInoInterAction</b>: 27 (Connected and no interaction from client side).</para>
        /// </description></item>
        /// <item><description><para><b>SucceededError</b>: 28 (Connected but system error interrupted).</para>
        /// </description></item>
        /// <item><description><para><b>SucceededSpecialInterceptVoiceAssistant</b>: 29 (Connected but intercepted by voice assistant).</para>
        /// </description></item>
        /// <item><description><para><b>SucceededSpecialInterceptExtensionNumberTransfer</b>: 30 (Connected but intercepted by extension transfer).</para>
        /// </description></item>
        /// <item><description><para><b>SucceededSpecialInterceptCustomSpecialIntercept</b>: 31 (Connected but intercepted by custom rule).</para>
        /// </description></item>
        /// <item><description><para><b>HighRiskSipCode</b>: 32 (High-risk SIP code, no outbound call).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Executing</para>
        /// </summary>
        [NameInMap("TaskStatusStringList")]
        [Validation(Required=false)]
        public string TaskStatusStringList { get; set; }

        /// <summary>
        /// <para>User ID. A unique identifier for a user.</para>
        /// <remarks>
        /// <para>This field is passed when you upload an outbound call list.</para>
        /// <list type="bullet">
        /// <item><description><para>If you upload the list in JSON format, the user ID is the value of referenceId.</para>
        /// </description></item>
        /// <item><description><para>If you upload the list as an Excel file, the user ID is the value of contactId.</para>
        /// </description></item>
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
