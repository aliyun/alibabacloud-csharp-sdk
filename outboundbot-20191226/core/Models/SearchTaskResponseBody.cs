// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SearchTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The request status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>The label information that can be used as filter conditions.</para>
        /// <remarks>
        /// <para>Displays all label information with enumerated values in this job group.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<SearchTaskResponseBodyLabels> Labels { get; set; }
        public class SearchTaskResponseBodyLabels : TeaModel {
            /// <summary>
            /// <para>The label name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Satisfied</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of label values.</para>
            /// </summary>
            [NameInMap("ValueList")]
            [Validation(Required=false)]
            public List<string> ValueList { get; set; }

        }

        /// <summary>
        /// <para>The message returned by the API operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("SearchTaskInfoList")]
        [Validation(Required=false)]
        public List<SearchTaskResponseBodySearchTaskInfoList> SearchTaskInfoList { get; set; }
        public class SearchTaskResponseBodySearchTaskInfoList : TeaModel {
            /// <summary>
            /// <para>The actual execution time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1643436089677</para>
            /// </summary>
            [NameInMap("ActualTime")]
            [Validation(Required=false)]
            public long? ActualTime { get; set; }

            /// <summary>
            /// <para>The call duration, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>46000</para>
            /// </summary>
            [NameInMap("CallDuration")]
            [Validation(Required=false)]
            public int? CallDuration { get; set; }

            /// <summary>
            /// <para>The call duration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47″</para>
            /// </summary>
            [NameInMap("CallDurationDisplay")]
            [Validation(Required=false)]
            public string CallDurationDisplay { get; set; }

            /// <summary>
            /// <para>The called number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15205879599</para>
            /// </summary>
            [NameInMap("CalledNumber")]
            [Validation(Required=false)]
            public string CalledNumber { get; set; }

            /// <summary>
            /// <para>The calling number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>02152739269</para>
            /// </summary>
            [NameInMap("CallingNumber")]
            [Validation(Required=false)]
            public string CallingNumber { get; set; }

            /// <summary>
            /// <para>The exception information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;code&quot;:&quot;OutboundCallError.SipCodeError&quot;, &quot;params&quot;:[{&quot;key&quot;:&quot;SipCode&quot;,&quot;value&quot;:&quot;500&quot;}]}]</para>
            /// </summary>
            [NameInMap("DialException")]
            [Validation(Required=false)]
            public string DialException { get; set; }

            /// <summary>
            /// <para>The field used for displaying remarks on the page.</para>
            /// </summary>
            [NameInMap("DialExceptionCodes")]
            [Validation(Required=false)]
            public List<string> DialExceptionCodes { get; set; }

            /// <summary>
            /// <para>The exception information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;OutboundCallError.SipTrunkError&quot;]</para>
            /// </summary>
            [NameInMap("DialExceptionOld")]
            [Validation(Required=false)]
            public string DialExceptionOld { get; set; }

            /// <summary>
            /// <para>Indicates whether the call is answered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasAnswered")]
            [Validation(Required=false)]
            public bool? HasAnswered { get; set; }

            /// <summary>
            /// <para>Indicates whether the call is hung up due to unrecognized intent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasHangUpByRejection")]
            [Validation(Required=false)]
            public bool? HasHangUpByRejection { get; set; }

            /// <summary>
            /// <para>Indicates whether the last sentence is fully played before hanging up.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasLastPlaybackCompleted")]
            [Validation(Required=false)]
            public bool? HasLastPlaybackCompleted { get; set; }

            /// <summary>
            /// <para>Indicates whether the dialogue is completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasReachedEndOfFlow")]
            [Validation(Required=false)]
            public bool? HasReachedEndOfFlow { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>73df6283-26b2-402d-bad0-ffa489923ea1</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The job group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>37db3113-ad34-4ba3-b930-468f016bbf95</para>
            /// </summary>
            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

            /// <summary>
            /// <para>The name of the job group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>85% new (with notes and underlines) 2021_11_14_18_00_51</para>
            /// </summary>
            [NameInMap("JobGroupName")]
            [Validation(Required=false)]
            public string JobGroupName { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6203248e-e652-4ef8-a1eb-586ed7b54dc2</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The job status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Scheduling.</description></item>
            /// <item><description>1: Executing.</description></item>
            /// <item><description>2: Succeeded (Reached).</description></item>
            /// <item><description>3: Paused.</description></item>
            /// <item><description>4: Failed (Not connected - Busy).</description></item>
            /// <item><description>5: Cancelled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public int? JobStatus { get; set; }

            /// <summary>
            /// <para>The display content of the job status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Scheduling.</description></item>
            /// <item><description>1: Executing.</description></item>
            /// <item><description>2: Succeeded (Reached).</description></item>
            /// <item><description>3: Paused.</description></item>
            /// <item><description>4: Failed (Not connected - Busy).</description></item>
            /// <item><description>5: Cancelled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduling</para>
            /// </summary>
            [NameInMap("JobStatusName")]
            [Validation(Required=false)]
            public string JobStatusName { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Scheduling: Scheduling (0).</description></item>
            /// <item><description>Executing: Executing (1).</description></item>
            /// <item><description>Succeeded: Reached (2).</description></item>
            /// <item><description>Paused: Paused (3).</description></item>
            /// <item><description>Failed: Not connected - Busy (4).</description></item>
            /// <item><description>Cancelled: Cancelled (5).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduling</para>
            /// </summary>
            [NameInMap("JobStatusString")]
            [Validation(Required=false)]
            public string JobStatusString { get; set; }

            /// <summary>
            /// <para>The label hit status of the current outbound call.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<SearchTaskResponseBodySearchTaskInfoListLabels> Labels { get; set; }
            public class SearchTaskResponseBodySearchTaskInfoListLabels : TeaModel {
                /// <summary>
                /// <para>The label name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Satisfied</para>
                /// </summary>
                [NameInMap("K")]
                [Validation(Required=false)]
                public string K { get; set; }

                /// <summary>
                /// <para>The matched label value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Yes</para>
                /// </summary>
                [NameInMap("V")]
                [Validation(Required=false)]
                public string V { get; set; }

            }

            /// <summary>
            /// <para>The ringing duration, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RecordingDuration")]
            [Validation(Required=false)]
            public int? RecordingDuration { get; set; }

            /// <summary>
            /// <para>The scenario name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Chronic disease leads</para>
            /// </summary>
            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// <para>The task creation time. The value is a UNIX timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1646792941</para>
            /// </summary>
            [NameInMap("TaskCreateTime")]
            [Validation(Required=false)]
            public long? TaskCreateTime { get; set; }

            /// <summary>
            /// <para>The reason why the task ended. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>FINISHED (1): The task completed normally.</description></item>
            /// <item><description>CHATBOT_HANGUP_AFTER_NOANSWER (2): The robot hung up after an unrecognized intent.</description></item>
            /// <item><description>CHATBOT_HANGUP_AFTER_SILENCE (3): The robot hung up due to a silence timeout.</description></item>
            /// <item><description>CLIENT_HANGUP_AFTER_NOANSWER (4): The user hung up after an unrecognized intent.</description></item>
            /// <item><description>CLIENT_HANGUP (5): The user hung up without a specific reason.</description></item>
            /// <item><description>TRANSFER_BY_INTENT (6): The call was transferred to an agent due to a matched intent.</description></item>
            /// <item><description>TRANSFER_AFTER_NOANSWER (7): The call was transferred to an agent after an unrecognized intent.</description></item>
            /// <item><description>INO_INTERACTION (8): No interaction occurred on the user side.</description></item>
            /// <item><description>ERROR (9): The task was interrupted by a system exception.</description></item>
            /// <item><description>SPECIAL_INTERCEPT_VOICE_ASSISTANT (10): The call was intercepted by the voice assistant.</description></item>
            /// <item><description>SPECIAL_INTERCEPT_EXTENSION_NUMBER_TRANSFER (11): The call was intercepted during extension number transfer.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OutOfService</para>
            /// </summary>
            [NameInMap("TaskEndReason")]
            [Validation(Required=false)]
            public int? TaskEndReason { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>479aea04-3a92-4ac3-935d-c8798c667850</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:
            /// (Note: The <b>Succeeded</b> status is subdivided into specific causes. The general <b>Succeeded</b>: 1 (Connected) status is not displayed. Instead, specific subdivided causes are returned.)</para>
            /// <list type="bullet">
            /// <item><description><b>Executing</b>: 0 (Dialing).</description></item>
            /// <item><description><b>Succeeded</b>: 1 (Connected).</description></item>
            /// <item><description><b>NoAnswer</b>: 2 (Not connected - No answer).</description></item>
            /// <item><description><b>NotExist</b>: 3 (Not connected - Nonexistent number).</description></item>
            /// <item><description><b>Busy</b>: 4 (Not connected - Busy).</description></item>
            /// <item><description><b>Cancelled</b>: 5 (Not dialed - Task stopped).</description></item>
            /// <item><description><b>Failed</b>: 6 (Failed).</description></item>
            /// <item><description><b>NotConnected</b>: 7 (Not connected - Unreachable).</description></item>
            /// <item><description><b>PoweredOff</b>: 8 (Not connected - Powered off).</description></item>
            /// <item><description><b>OutOfService</b>: 9 (Not connected - Suspended).</description></item>
            /// <item><description><b>InArrears</b>: 10 (Not connected - Overdue payment).</description></item>
            /// <item><description><b>EmptyNumber</b>: 11 (Not dialed - Nonexistent number, not dialed).</description></item>
            /// <item><description><b>PerDayCallCountLimit</b>: 12 (Not dialed - Daily limit exceeded).</description></item>
            /// <item><description><b>ContactBlockList</b>: 13 (Not dialed - Blacklisted).</description></item>
            /// <item><description><b>CallerNotRegistered</b>: 14 (Not dialed - Caller number not registered).</description></item>
            /// <item><description><b>Terminated</b>: 15 (Not dialed - Terminated).</description></item>
            /// <item><description><b>VerificationCancelled</b>: 16 (Not dialed - Canceled due to pre-call verification failure).</description></item>
            /// <item><description><b>OutOfServiceNoCall</b>: 17 (Not dialed - Callee suspended, not dialed).</description></item>
            /// <item><description><b>InArrearsNoCall</b>: 18 (Not dialed - Callee has overdue payment, not dialed).</description></item>
            /// <item><description><b>CallingNumberNotExist</b>: 19 (Not dialed - Caller number does not exist).</description></item>
            /// <item><description><b>SucceededFinish</b>: 20 (Connected - Normal completion).</description></item>
            /// <item><description><b>SucceededChatbotHangUpAfterNoAnswer</b>: 21 (Connected - Robot hung up after unrecognized intent).</description></item>
            /// <item><description><b>SucceededChatbotHangUpAfterSilence</b>: 22 (Connected - Hung up due to silence timeout).</description></item>
            /// <item><description><b>SucceededClientHangUpAfterNoAnswer</b>: 23 (Connected - User hung up after unrecognized intent).</description></item>
            /// <item><description><b>SucceededClientHangUp</b>: 24 (Connected - User hung up without reason).</description></item>
            /// <item><description><b>SucceededTransferByIntent</b>: 25 (Connected - Transferred to agent due to matched intent).</description></item>
            /// <item><description><b>SucceededTransferAfterNoAnswer</b>: 26 (Connected - Transferred to agent after unrecognized intent).</description></item>
            /// <item><description><b>SucceededInoInterAction</b>: 27 (Connected - No interaction on user side).</description></item>
            /// <item><description><b>SucceededError</b>: 28 (Connected - Interrupted by system exception).</description></item>
            /// <item><description><b>SucceededSpecialInterceptVoiceAssistant</b>: 29 (Connected - Special interception - Voice assistant).</description></item>
            /// <item><description><b>SucceededSpecialInterceptExtensionNumberTransfer</b>: 30 (Connected - Special interception - Extension number transfer).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            /// <summary>
            /// <para>The display content of the call status. Valid values:
            /// (Note: The <b>Succeeded</b> status is subdivided into specific causes. The general <b>Succeeded</b>: 1 (Connected) status is not displayed. Instead, specific subdivided causes are returned.)</para>
            /// <list type="bullet">
            /// <item><description><b>Executing</b>: 0 (Dialing).</description></item>
            /// <item><description><b>Succeeded</b>: 1 (Connected).</description></item>
            /// <item><description><b>NoAnswer</b>: 2 (Not connected - No answer).</description></item>
            /// <item><description><b>NotExist</b>: 3 (Not connected - Nonexistent number).</description></item>
            /// <item><description><b>Busy</b>: 4 (Not connected - Busy).</description></item>
            /// <item><description><b>Cancelled</b>: 5 (Not dialed - Task stopped).</description></item>
            /// <item><description><b>Failed</b>: 6 (Failed).</description></item>
            /// <item><description><b>NotConnected</b>: 7 (Not connected - Unreachable).</description></item>
            /// <item><description><b>PoweredOff</b>: 8 (Not connected - Powered off).</description></item>
            /// <item><description><b>OutOfService</b>: 9 (Not connected - Suspended).</description></item>
            /// <item><description><b>InArrears</b>: 10 (Not connected - Overdue payment).</description></item>
            /// <item><description><b>EmptyNumber</b>: 11 (Not dialed - Nonexistent number, not dialed).</description></item>
            /// <item><description><b>PerDayCallCountLimit</b>: 12 (Not dialed - Daily limit exceeded).</description></item>
            /// <item><description><b>ContactBlockList</b>: 13 (Not dialed - Blacklisted).</description></item>
            /// <item><description><b>CallerNotRegistered</b>: 14 (Not dialed - Caller number not registered).</description></item>
            /// <item><description><b>Terminated</b>: 15 (Not dialed - Terminated).</description></item>
            /// <item><description><b>VerificationCancelled</b>: 16 (Not dialed - Canceled due to pre-call verification failure).</description></item>
            /// <item><description><b>OutOfServiceNoCall</b>: 17 (Not dialed - Callee suspended, not dialed).</description></item>
            /// <item><description><b>InArrearsNoCall</b>: 18 (Not dialed - Callee has overdue payment, not dialed).</description></item>
            /// <item><description><b>CallingNumberNotExist</b>: 19 (Not dialed - Caller number does not exist).</description></item>
            /// <item><description><b>SucceededFinish</b>: 20 (Connected - Normal completion).</description></item>
            /// <item><description><b>SucceededChatbotHangUpAfterNoAnswer</b>: 21 (Connected - Robot hung up after unrecognized intent).</description></item>
            /// <item><description><b>SucceededChatbotHangUpAfterSilence</b>: 22 (Connected - Hung up due to silence timeout).</description></item>
            /// <item><description><b>SucceededClientHangUpAfterNoAnswer</b>: 23 (Connected - User hung up after unrecognized intent).</description></item>
            /// <item><description><b>SucceededClientHangUp</b>: 24 (Connected - User hung up without reason).</description></item>
            /// <item><description><b>SucceededTransferByIntent</b>: 25 (Connected - Transferred to agent due to matched intent).</description></item>
            /// <item><description><b>SucceededTransferAfterNoAnswer</b>: 26 (Connected - Transferred to agent after unrecognized intent).</description></item>
            /// <item><description><b>SucceededInoInterAction</b>: 27 (Connected - No interaction on user side).</description></item>
            /// <item><description><b>SucceededError</b>: 28 (Connected - Interrupted by system exception).</description></item>
            /// <item><description><b>SucceededSpecialInterceptVoiceAssistant</b>: 29 (Connected - Special interception - Voice assistant).</description></item>
            /// <item><description><b>SucceededSpecialInterceptExtensionNumberTransfer</b>: 30 (Connected - Special interception - Extension number transfer).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Dialing</para>
            /// </summary>
            [NameInMap("TaskStatusName")]
            [Validation(Required=false)]
            public string TaskStatusName { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:
            /// (Note: The <b>Succeeded</b> status is subdivided into specific causes. The general <b>Succeeded</b>: 1 (Connected) status is not displayed. Instead, specific subdivided causes are returned.)</para>
            /// <list type="bullet">
            /// <item><description><b>Executing</b>: 0 (Dialing).</description></item>
            /// <item><description><b>Succeeded</b>: 1 (Connected).</description></item>
            /// <item><description><b>NoAnswer</b>: 2 (Not connected - No answer).</description></item>
            /// <item><description><b>NotExist</b>: 3 (Not connected - Nonexistent number).</description></item>
            /// <item><description><b>Busy</b>: 4 (Not connected - Busy).</description></item>
            /// <item><description><b>Cancelled</b>: 5 (Not dialed - Task stopped).</description></item>
            /// <item><description><b>Failed</b>: 6 (Failed).</description></item>
            /// <item><description><b>NotConnected</b>: 7 (Not connected - Unreachable).</description></item>
            /// <item><description><b>PoweredOff</b>: 8 (Not connected - Powered off).</description></item>
            /// <item><description><b>OutOfService</b>: 9 (Not connected - Suspended).</description></item>
            /// <item><description><b>InArrears</b>: 10 (Not connected - Overdue payment).</description></item>
            /// <item><description><b>EmptyNumber</b>: 11 (Not dialed - Nonexistent number, not dialed).</description></item>
            /// <item><description><b>PerDayCallCountLimit</b>: 12 (Not dialed - Daily limit exceeded).</description></item>
            /// <item><description><b>ContactBlockList</b>: 13 (Not dialed - Blacklisted).</description></item>
            /// <item><description><b>CallerNotRegistered</b>: 14 (Not dialed - Caller number not registered).</description></item>
            /// <item><description><b>Terminated</b>: 15 (Not dialed - Terminated).</description></item>
            /// <item><description><b>VerificationCancelled</b>: 16 (Not dialed - Canceled due to pre-call verification failure).</description></item>
            /// <item><description><b>OutOfServiceNoCall</b>: 17 (Not dialed - Callee suspended, not dialed).</description></item>
            /// <item><description><b>InArrearsNoCall</b>: 18 (Not dialed - Callee has overdue payment, not dialed).</description></item>
            /// <item><description><b>CallingNumberNotExist</b>: 19 (Not dialed - Caller number does not exist).</description></item>
            /// <item><description><b>SucceededFinish</b>: 20 (Connected - Normal completion).</description></item>
            /// <item><description><b>SucceededChatbotHangUpAfterNoAnswer</b>: 21 (Connected - Robot hung up after unrecognized intent).</description></item>
            /// <item><description><b>SucceededChatbotHangUpAfterSilence</b>: 22 (Connected - Hung up due to silence timeout).</description></item>
            /// <item><description><b>SucceededClientHangUpAfterNoAnswer</b>: 23 (Connected - User hung up after unrecognized intent).</description></item>
            /// <item><description><b>SucceededClientHangUp</b>: 24 (Connected - User hung up without reason).</description></item>
            /// <item><description><b>SucceededTransferByIntent</b>: 25 (Connected - Transferred to agent due to matched intent).</description></item>
            /// <item><description><b>SucceededTransferAfterNoAnswer</b>: 26 (Connected - Transferred to agent after unrecognized intent).</description></item>
            /// <item><description><b>SucceededInoInterAction</b>: 27 (Connected - No interaction on user side).</description></item>
            /// <item><description><b>SucceededError</b>: 28 (Connected - Interrupted by system exception).</description></item>
            /// <item><description><b>SucceededSpecialInterceptVoiceAssistant</b>: 29 (Connected - Special interception - Voice assistant).</description></item>
            /// <item><description><b>SucceededSpecialInterceptExtensionNumberTransfer</b>: 30 (Connected - Special interception - Extension number transfer).</description></item>
            /// <item><description><b>SucceededSpecialInterceptCustomSpecialIntercept</b>: 31 (Connected - Special interception - Custom interception).</description></item>
            /// <item><description><b>HighRiskSipCode</b>: 32 (Not dialed - High risk, not dialed).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Executing</para>
            /// </summary>
            [NameInMap("TaskStatusString")]
            [Validation(Required=false)]
            public string TaskStatusString { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12334134</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The username.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        /// <summary>
        /// <para>The full set of label name keys.</para>
        /// </summary>
        [NameInMap("VariableNames")]
        [Validation(Required=false)]
        public List<string> VariableNames { get; set; }

    }

}
