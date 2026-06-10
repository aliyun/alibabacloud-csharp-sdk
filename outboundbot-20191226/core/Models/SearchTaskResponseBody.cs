// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class SearchTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Request status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Labels available for filtering.</para>
        /// <remarks>
        /// <para>Displays all labels with enumeration values in this job group.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<SearchTaskResponseBodyLabels> Labels { get; set; }
        public class SearchTaskResponseBodyLabels : TeaModel {
            /// <summary>
            /// <para>Label name</para>
            /// 
            /// <b>Example:</b>
            /// <para>是否满意</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>List of label values</para>
            /// </summary>
            [NameInMap("ValueList")]
            [Validation(Required=false)]
            public List<string> ValueList { get; set; }

        }

        /// <summary>
        /// <para>Response message</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>Number of items per page</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of tasks</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("SearchTaskInfoList")]
        [Validation(Required=false)]
        public List<SearchTaskResponseBodySearchTaskInfoList> SearchTaskInfoList { get; set; }
        public class SearchTaskResponseBodySearchTaskInfoList : TeaModel {
            /// <summary>
            /// <para>Actual execution time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1643436089677</para>
            /// </summary>
            [NameInMap("ActualTime")]
            [Validation(Required=false)]
            public long? ActualTime { get; set; }

            /// <summary>
            /// <para>Call duration, in milliseconds</para>
            /// 
            /// <b>Example:</b>
            /// <para>46000</para>
            /// </summary>
            [NameInMap("CallDuration")]
            [Validation(Required=false)]
            public int? CallDuration { get; set; }

            /// <summary>
            /// <para>Call duration</para>
            /// 
            /// <b>Example:</b>
            /// <para>47″</para>
            /// </summary>
            [NameInMap("CallDurationDisplay")]
            [Validation(Required=false)]
            public string CallDurationDisplay { get; set; }

            /// <summary>
            /// <para>Called number</para>
            /// 
            /// <b>Example:</b>
            /// <para>15205879599</para>
            /// </summary>
            [NameInMap("CalledNumber")]
            [Validation(Required=false)]
            public string CalledNumber { get; set; }

            /// <summary>
            /// <para>Calling number</para>
            /// 
            /// <b>Example:</b>
            /// <para>02152739269</para>
            /// </summary>
            [NameInMap("CallingNumber")]
            [Validation(Required=false)]
            public string CallingNumber { get; set; }

            /// <summary>
            /// <para>Exception details</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;code&quot;:&quot;OutboundCallError.SipCodeError&quot;, &quot;params&quot;:[{&quot;key&quot;:&quot;SipCode&quot;,&quot;value&quot;:&quot;500&quot;}]}]</para>
            /// </summary>
            [NameInMap("DialException")]
            [Validation(Required=false)]
            public string DialException { get; set; }

            /// <summary>
            /// <para>Exception codes shown on the remarks page</para>
            /// </summary>
            [NameInMap("DialExceptionCodes")]
            [Validation(Required=false)]
            public List<string> DialExceptionCodes { get; set; }

            /// <summary>
            /// <para>Exception details</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;OutboundCallError.SipTrunkError&quot;]</para>
            /// </summary>
            [NameInMap("DialExceptionOld")]
            [Validation(Required=false)]
            public string DialExceptionOld { get; set; }

            /// <summary>
            /// <para>Indicates whether the called party answered</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasAnswered")]
            [Validation(Required=false)]
            public bool? HasAnswered { get; set; }

            /// <summary>
            /// <para>Indicates whether the call ended due to rejection</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasHangUpByRejection")]
            [Validation(Required=false)]
            public bool? HasHangUpByRejection { get; set; }

            /// <summary>
            /// <para>Indicates whether the last audio playback completed before hangup</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasLastPlaybackCompleted")]
            [Validation(Required=false)]
            public bool? HasLastPlaybackCompleted { get; set; }

            /// <summary>
            /// <para>Indicates whether the conversation ended</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HasReachedEndOfFlow")]
            [Validation(Required=false)]
            public bool? HasReachedEndOfFlow { get; set; }

            /// <summary>
            /// <para>Instance ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>73df6283-26b2-402d-bad0-ffa489923ea1</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Job group ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>37db3113-ad34-4ba3-b930-468f016bbf95</para>
            /// </summary>
            [NameInMap("JobGroupId")]
            [Validation(Required=false)]
            public string JobGroupId { get; set; }

            /// <summary>
            /// <para>Job group name</para>
            /// 
            /// <b>Example:</b>
            /// <para>85成新（有笔记划线）2021_11_14_18_00_51</para>
            /// </summary>
            [NameInMap("JobGroupName")]
            [Validation(Required=false)]
            public string JobGroupName { get; set; }

            /// <summary>
            /// <para>Job ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>6203248e-e652-4ef8-a1eb-586ed7b54dc2</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>Job status</para>
            /// <list type="bullet">
            /// <item><description><para>0: Scheduling</para>
            /// </description></item>
            /// <item><description><para>1: Executing</para>
            /// </description></item>
            /// <item><description><para>2: Succeeded</para>
            /// </description></item>
            /// <item><description><para>3: Paused</para>
            /// </description></item>
            /// <item><description><para>4: Failed</para>
            /// </description></item>
            /// <item><description><para>5: Cancelled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public int? JobStatus { get; set; }

            /// <summary>
            /// <para>Display text for job status</para>
            /// <list type="bullet">
            /// <item><description><para>0: Scheduling</para>
            /// </description></item>
            /// <item><description><para>1: Executing</para>
            /// </description></item>
            /// <item><description><para>2: Succeeded</para>
            /// </description></item>
            /// <item><description><para>3: Paused</para>
            /// </description></item>
            /// <item><description><para>4: Failed</para>
            /// </description></item>
            /// <item><description><para>5: Cancelled</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>调度中</para>
            /// </summary>
            [NameInMap("JobStatusName")]
            [Validation(Required=false)]
            public string JobStatusName { get; set; }

            /// <summary>
            /// <para>Job status</para>
            /// <list type="bullet">
            /// <item><description><para>Scheduling (0)</para>
            /// </description></item>
            /// <item><description><para>Executing (1)</para>
            /// </description></item>
            /// <item><description><para>Completed—Reached (2)</para>
            /// </description></item>
            /// <item><description><para>Paused (3)</para>
            /// </description></item>
            /// <item><description><para>Failed—Line busy (4)</para>
            /// </description></item>
            /// <item><description><para>Cancelled (5)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Scheduling</para>
            /// </summary>
            [NameInMap("JobStatusString")]
            [Validation(Required=false)]
            public string JobStatusString { get; set; }

            /// <summary>
            /// <para>Labels matched for this outbound call</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<SearchTaskResponseBodySearchTaskInfoListLabels> Labels { get; set; }
            public class SearchTaskResponseBodySearchTaskInfoListLabels : TeaModel {
                /// <summary>
                /// <para>Label name</para>
                /// 
                /// <b>Example:</b>
                /// <para>是否满意</para>
                /// </summary>
                [NameInMap("K")]
                [Validation(Required=false)]
                public string K { get; set; }

                /// <summary>
                /// <para>Matched label value</para>
                /// 
                /// <b>Example:</b>
                /// <para>是</para>
                /// </summary>
                [NameInMap("V")]
                [Validation(Required=false)]
                public string V { get; set; }

            }

            /// <summary>
            /// <para>Ringing duration, in seconds</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RecordingDuration")]
            [Validation(Required=false)]
            public int? RecordingDuration { get; set; }

            /// <summary>
            /// <para>Scenario name</para>
            /// 
            /// <b>Example:</b>
            /// <para>慢病线索</para>
            /// </summary>
            [NameInMap("ScriptName")]
            [Validation(Required=false)]
            public string ScriptName { get; set; }

            /// <summary>
            /// <para>Task creation time</para>
            /// 
            /// <b>Example:</b>
            /// <para>1646792941</para>
            /// </summary>
            [NameInMap("TaskCreateTime")]
            [Validation(Required=false)]
            public long? TaskCreateTime { get; set; }

            /// <summary>
            /// <para>Reason why the task ended</para>
            /// <list type="bullet">
            /// <item><description><para>FINISHED(1,&quot;Normal completion&quot;)</para>
            /// </description></item>
            /// <item><description><para>CHATBOT_HANGUP_AFTER_NOANSWER(2, &quot;Robot hangup after rejection&quot;)</para>
            /// </description></item>
            /// <item><description><para>CHATBOT_HANGUP_AFTER_SILENCE(3, &quot;Robot hangup after silence timeout&quot;)</para>
            /// </description></item>
            /// <item><description><para>CLIENT_HANGUP_AFTER_NOANSWER(4, &quot;Client hangup after rejection&quot;)</para>
            /// </description></item>
            /// <item><description><para>CLIENT_HANGUP(5, &quot;Client hangup without reason&quot;)</para>
            /// </description></item>
            /// <item><description><para>TRANSFER_BY_INTENT(6, &quot;Transfer to agent based on intent match&quot;)</para>
            /// </description></item>
            /// <item><description><para>TRANSFER_AFTER_NOANSWER(7, &quot;Transfer to agent after rejection&quot;)</para>
            /// </description></item>
            /// <item><description><para>INO_INTERACTION(8, &quot;No interaction from client side&quot;)</para>
            /// </description></item>
            /// <item><description><para>ERROR(9, &quot;System error interrupted&quot;)</para>
            /// </description></item>
            /// <item><description><para>SPECIAL_INTERCEPT_VOICE_ASSISTANT(10, &quot;Intercepted by voice assistant&quot;)</para>
            /// </description></item>
            /// <item><description><para>SPECIAL_INTERCEPT_EXTENSION_NUMBER_TRANSFER(11, &quot;Intercepted by extension transfer&quot;)</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OutOfService</para>
            /// </summary>
            [NameInMap("TaskEndReason")]
            [Validation(Required=false)]
            public int? TaskEndReason { get; set; }

            /// <summary>
            /// <para>Task ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>479aea04-3a92-4ac3-935d-c8798c667850</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>Valid values:</para>
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
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public int? TaskStatus { get; set; }

            /// <summary>
            /// <para>Display text for task status</para>
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
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>正在拨打</para>
            /// </summary>
            [NameInMap("TaskStatusName")]
            [Validation(Required=false)]
            public string TaskStatusName { get; set; }

            /// <summary>
            /// <para>Task status</para>
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
            [NameInMap("TaskStatusString")]
            [Validation(Required=false)]
            public string TaskStatusString { get; set; }

            /// <summary>
            /// <para>User ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>12334134</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>Username</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request succeeded</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>Total number of items</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        /// <summary>
        /// <para>Complete list of label keys</para>
        /// </summary>
        [NameInMap("VariableNames")]
        [Validation(Required=false)]
        public List<string> VariableNames { get; set; }

    }

}
