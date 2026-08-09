// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class QueryJobsWithResultRequest : TeaModel {
        /// <summary>
        /// <para>The filter condition for the call end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1579055783000</para>
        /// </summary>
        [NameInMap("EndActualTimeFilter")]
        [Validation(Required=false)]
        public long? EndActualTimeFilter { get; set; }

        /// <summary>
        /// <para>Specifies whether the call is answered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasAnsweredFilter")]
        [Validation(Required=false)]
        public bool? HasAnsweredFilter { get; set; }

        /// <summary>
        /// <para>Specifies whether the call is hung up due to rejection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HasHangUpByRejectionFilter")]
        [Validation(Required=false)]
        public bool? HasHangUpByRejectionFilter { get; set; }

        /// <summary>
        /// <para>Specifies whether the call has reached the end of the flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasReachedEndOfFlowFilter")]
        [Validation(Required=false)]
        public bool? HasReachedEndOfFlowFilter { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9d53cd72-4050-4419-8c17-acc0bf158147</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The list of job failure reasons.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;NoAnswer&quot;]</para>
        /// </summary>
        [NameInMap("JobFailureReasonsFilter")]
        [Validation(Required=false)]
        public string JobFailureReasonsFilter { get; set; }

        /// <summary>
        /// <para>The ID of the job group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ad16fc35-d824-4102-a606-2be51c1aa6dd</para>
        /// </summary>
        [NameInMap("JobGroupId")]
        [Validation(Required=false)]
        public string JobGroupId { get; set; }

        /// <summary>
        /// <para>The job status filter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Scheduling: Scheduling in progress.</description></item>
        /// <item><description>Executing: Executing in progress.</description></item>
        /// <item><description>Succeeded: Ended - Reached.</description></item>
        /// <item><description>Paused: Paused.</description></item>
        /// <item><description>Failed: Ended - Not reached.</description></item>
        /// <item><description>Cancelled: Cancelled - Manual intervention.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("JobStatusFilter")]
        [Validation(Required=false)]
        public string JobStatusFilter { get; set; }

        /// <summary>
        /// <para>The label-based filter condition for calls.</para>
        /// <remarks>
        /// <para>This condition supports filtering only by labels that have specific enumerated label values configured, that is, labels with specific label values configured in large language model scenarios.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("LabelsJson")]
        [Validation(Required=false)]
        public List<string> LabelsJson { get; set; }

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
        /// <para>The search content. You can search by phone number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1882020****</para>
        /// </summary>
        [NameInMap("QueryText")]
        [Validation(Required=false)]
        public string QueryText { get; set; }

        /// <summary>
        /// <para>The filter condition for the call start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1579055782000</para>
        /// </summary>
        [NameInMap("StartActualTimeFilter")]
        [Validation(Required=false)]
        public long? StartActualTimeFilter { get; set; }

        /// <summary>
        /// <para>The call status. Example: [&quot;Executing&quot;,&quot;Succeeded&quot;]. Separate multiple values with commas.</para>
        /// <para>Valid values:</para>
        /// <para>(Note: The <b>Succeeded</b> status has been subdivided into specific reasons. The general <b>Succeeded</b>: 1 (Connected) status is no longer returned. Instead, specific sub-reason types are returned.)</para>
        /// <list type="bullet">
        /// <item><description><b>Executing</b>: 0 (Calling).</description></item>
        /// <item><description><b>Succeeded</b>: 1 (Connected).</description></item>
        /// <item><description><b>NoAnswer</b>: 2 (Not connected - No answer).</description></item>
        /// <item><description><b>NotExist</b>: 3 (Not connected - Nonexistent number).</description></item>
        /// <item><description><b>Busy</b>: 4 (Not connected - Busy).</description></item>
        /// <item><description><b>Cancelled</b>: 5 (Not dialed - Task stopped).</description></item>
        /// <item><description><b>Failed</b>: 6 (Failed).</description></item>
        /// <item><description><b>NotConnected</b>: 7 (Not connected - Unreachable).</description></item>
        /// <item><description><b>PoweredOff</b>: 8 (Not connected - Powered off).</description></item>
        /// <item><description><b>OutOfService</b>: 9 (Not connected - Callee out of service).</description></item>
        /// <item><description><b>InArrears</b>: 10 (Not connected - Callee has overdue payment).</description></item>
        /// <item><description><b>EmptyNumber</b>: 11 (Not dialed - Nonexistent number, no outbound call).</description></item>
        /// <item><description><b>PerDayCallCountLimit</b>: 12 (Not dialed - Daily limit exceeded).</description></item>
        /// <item><description><b>ContactBlockList</b>: 13 (Not dialed - Blacklisted).</description></item>
        /// <item><description><b>CallerNotRegistered</b>: 14 (Not dialed - Caller number not registered).</description></item>
        /// <item><description><b>Terminated</b>: 15 (Not dialed - Terminated).</description></item>
        /// <item><description><b>VerificationCancelled</b>: 16 (Not dialed - Pre-call verification failed, cancelled).</description></item>
        /// <item><description><b>OutOfServiceNoCall</b>: 17 (Not dialed - Callee out of service, no outbound call).</description></item>
        /// <item><description><b>InArrearsNoCall</b>: 18 (Not dialed - Callee has overdue payment, no outbound call).</description></item>
        /// <item><description><b>CallingNumberNotExist</b>: 19 (Not dialed - Caller number does not exist).</description></item>
        /// <item><description><b>SucceededFinish</b>: 20 (Connected - Normal completion).</description></item>
        /// <item><description><b>SucceededChatbotHangUpAfterNoAnswer</b>: 21 (Connected - Robot hung up after no recognition).</description></item>
        /// <item><description><b>SucceededChatbotHangUpAfterSilence</b>: 22 (Connected - Hung up due to silence timeout).</description></item>
        /// <item><description><b>SucceededClientHangUpAfterNoAnswer</b>: 23 (Connected - User hung up after no recognition).</description></item>
        /// <item><description><b>SucceededClientHangUp</b>: 24 (Connected - User hung up without reason).</description></item>
        /// <item><description><b>SucceededTransferByIntent</b>: 25 (Connected - Transferred to agent by intent match).</description></item>
        /// <item><description><b>SucceededTransferAfterNoAnswer</b>: 26 (Connected - Transferred to agent after no recognition).</description></item>
        /// <item><description><b>SucceededInoInterAction</b>: 27 (Connected - No interaction from user).</description></item>
        /// <item><description><b>SucceededError</b>: 28 (Connected - System exception interruption).</description></item>
        /// <item><description><b>SucceededSpecialInterceptVoiceAssistant</b>: 29 (Connected - Special intercept - Voice assistant).</description></item>
        /// <item><description><b>SucceededSpecialInterceptExtensionNumberTransfer</b>: 30 (Connected - Special intercept - Extension number transfer).</description></item>
        /// <item><description><b>SucceededSpecialInterceptCustomSpecialIntercept</b>: 31 (Connected - Special intercept - Custom intercept).</description></item>
        /// <item><description><b>HighRiskSipCode</b>: 32 (Not dialed - High risk, no outbound call).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Executing&quot;]</para>
        /// </summary>
        [NameInMap("TaskStatusFilter")]
        [Validation(Required=false)]
        public string TaskStatusFilter { get; set; }

    }

}
