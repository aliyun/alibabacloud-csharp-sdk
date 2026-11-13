// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateTaskExportTaskRequest : TeaModel {
        /// <summary>
        /// <para>The start time for the dial time search, inclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1646496000000</para>
        /// </summary>
        [NameInMap("ActualTimeGte")]
        [Validation(Required=false)]
        public long? ActualTimeGte { get; set; }

        /// <summary>
        /// <para>The end time for the dial time search, inclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1646582400000</para>
        /// </summary>
        [NameInMap("ActualTimeLte")]
        [Validation(Required=false)]
        public long? ActualTimeLte { get; set; }

        /// <summary>
        /// <para>The minimum call duration for the search, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("CallDurationGte")]
        [Validation(Required=false)]
        public long? CallDurationGte { get; set; }

        /// <summary>
        /// <para>The maximum call duration for the search, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("CallDurationLte")]
        [Validation(Required=false)]
        public long? CallDurationLte { get; set; }

        /// <summary>
        /// <para>The called number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11111111111</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>The calling number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>187********</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public string CallingNumber { get; set; }

        /// <summary>
        /// <para>Specifies whether the call was answered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasAnswered")]
        [Validation(Required=false)]
        public bool? HasAnswered { get; set; }

        /// <summary>
        /// <para>Specifies whether the call was hung up due to rejection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasHangUpByRejection")]
        [Validation(Required=false)]
        public bool? HasHangUpByRejection { get; set; }

        /// <summary>
        /// <para>Specifies whether the conversation reached the end of the flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasReachedEndOfFlow")]
        [Validation(Required=false)]
        public bool? HasReachedEndOfFlow { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1dcb09c5-d5db-4397-bf65-db854463beea</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The job group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cb731aee-0a5b-4c2b-924c-d9e82eb1d8d7</para>
        /// </summary>
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        /// <summary>
        /// <para>The job name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test_20220217_160147</para>
        /// </summary>
        [NameInMap("JobGroupNameQuery")]
        [Validation(Required=false)]
        public string JobGroupNameQuery { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>82097dd5-54df-475f-beba-eec8f4b7a3e1</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The job statuses. Separate multiple values with commas. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Scheduling: The job is being scheduled.</description></item>
        /// <item><description>Executing: The job is being executed.</description></item>
        /// <item><description>Succeeded: The job is completed and the user is reached.</description></item>
        /// <item><description>Paused: The job is stopped.</description></item>
        /// <item><description>Failed: The job is completed but the user is not reached.</description></item>
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
        /// <para>The other ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64ebe700-91b4-49cb-b457-0b7c0b598a86</para>
        /// </summary>
        [NameInMap("OtherId")]
        [Validation(Required=false)]
        public string OtherId { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

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
        /// <para>The minimum ringing duration for the search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RecordingDurationGte")]
        [Validation(Required=false)]
        public long? RecordingDurationGte { get; set; }

        /// <summary>
        /// <para>The maximum ringing duration for the search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("RecordingDurationLte")]
        [Validation(Required=false)]
        public long? RecordingDurationLte { get; set; }

        /// <summary>
        /// <para>The scenario name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("ScriptNameQuery")]
        [Validation(Required=false)]
        public string ScriptNameQuery { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>asc: ascending order.</para>
        /// </description></item>
        /// <item><description><para>desc: descending order. This is the default value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>actualTime</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The sort type. asr indicates ascending order, and desc indicates descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>The start time for the task creation time search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1646496000000</para>
        /// </summary>
        [NameInMap("TaskCreateTimeGte")]
        [Validation(Required=false)]
        public long? TaskCreateTimeGte { get; set; }

        /// <summary>
        /// <para>The end time for the task creation time search.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1646582400000</para>
        /// </summary>
        [NameInMap("TaskCreateTimeLte")]
        [Validation(Required=false)]
        public long? TaskCreateTimeLte { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64ebe700-91b4-49cb-b457-0b7c0b598a86</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The call statuses. Separate multiple values with commas. Note: The Succeeded status is subdivided into specific causes. The general Succeeded: 1 (Connected) status is not displayed. All returned values are specific subdivided cause types. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Executing: 0 (dialing).</description></item>
        /// <item><description>Succeeded: 1 (connected).</description></item>
        /// <item><description>NoAnswer: 2 (not connected - no answer).</description></item>
        /// <item><description>NotExist: 3 (not connected - nonexistent number).</description></item>
        /// <item><description>Busy: 4 (not connected - busy).</description></item>
        /// <item><description>Cancelled: 5 (not called - task stopped).</description></item>
        /// <item><description>Failed: 6 (failed).</description></item>
        /// <item><description>NotConnected: 7 (not connected - unreachable).</description></item>
        /// <item><description>PoweredOff: 8 (not connected - powered off).</description></item>
        /// <item><description>OutOfService: 9 (not connected - out of service).</description></item>
        /// <item><description>InArrears: 10 (not connected - overdue payment).</description></item>
        /// <item><description>EmptyNumber: 11 (not called - nonexistent number, no call).</description></item>
        /// <item><description>PerDayCallCountLimit: 12 (not called - daily call limit exceeded).</description></item>
        /// <item><description>ContactBlockList: 13 (not called - on blocklist).</description></item>
        /// <item><description>CallerNotRegistered: 14 (not called - calling number not registered).</description></item>
        /// <item><description>Terminated: 15 (not called - terminated).</description></item>
        /// <item><description>VerificationCancelled: 16 (not called - canceled due to pre-call verification failure).</description></item>
        /// <item><description>OutOfServiceNoCall: 17 (not called - out of service, no call).</description></item>
        /// <item><description>InArrearsNoCall: 18 (not called - overdue payment, no call).</description></item>
        /// <item><description>CallingNumberNotExist: 19 (not called - calling number does not exist).</description></item>
        /// <item><description>SucceededFinish: 20 (connected - completed normally).</description></item>
        /// <item><description>SucceededChatbotHangUpAfterNoAnswer: 21 (connected - chatbot hung up after unrecognized response).</description></item>
        /// <item><description>SucceededChatbotHangUpAfterSilence: 22 (connected - hung up due to silence timeout).</description></item>
        /// <item><description>SucceededClientHangUpAfterNoAnswer: 23 (connected - user hung up after unrecognized response).</description></item>
        /// <item><description>SucceededClientHangUp: 24 (connected - user hung up without reason).</description></item>
        /// <item><description>SucceededTransferByIntent: 25 (connected - transferred to agent due to intent match).</description></item>
        /// <item><description>SucceededTransferAfterNoAnswer: 26 (connected - transferred to agent after unrecognized response).</description></item>
        /// <item><description>SucceededInoInterAction: 27 (connected - no user interaction).</description></item>
        /// <item><description>SucceededError: 28 (connected - interrupted by system error).</description></item>
        /// <item><description>SucceededSpecialInterceptVoiceAssistant: 29 (connected - intercepted due to special condition: voice assistant).</description></item>
        /// <item><description>SucceededSpecialInterceptExtensionNumberTransfer: 30 (connected - intercepted due to special condition: extension transfer).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded,Failed</para>
        /// </summary>
        [NameInMap("TaskStatusStringList")]
        [Validation(Required=false)]
        public string TaskStatusStringList { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>82097dd5-54df-475f-beba-eec8f4b7a3e1</para>
        /// </summary>
        [NameInMap("UserIdMatch")]
        [Validation(Required=false)]
        public string UserIdMatch { get; set; }

    }

}
