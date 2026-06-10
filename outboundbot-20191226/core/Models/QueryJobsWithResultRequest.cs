// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class QueryJobsWithResultRequest : TeaModel {
        /// <summary>
        /// <para>Filters for calls that ended on or before the specified time. Specify the time as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1579055783000</para>
        /// </summary>
        [NameInMap("EndActualTimeFilter")]
        [Validation(Required=false)]
        public long? EndActualTimeFilter { get; set; }

        /// <summary>
        /// <para>Filters jobs by whether the call was answered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HasAnsweredFilter")]
        [Validation(Required=false)]
        public bool? HasAnsweredFilter { get; set; }

        /// <summary>
        /// <para>Filters jobs by whether the call was disconnected due to a rejection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HasHangUpByRejectionFilter")]
        [Validation(Required=false)]
        public bool? HasHangUpByRejectionFilter { get; set; }

        /// <summary>
        /// <para>Filters jobs by whether the call flow was completed.</para>
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
        /// <para>The job failure reasons to filter by.</para>
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
        /// <para>The job status to filter by. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Scheduling</c>: The job is scheduled and awaiting execution.</para>
        /// </description></item>
        /// <item><description><para><c>Executing</c>: The job is in progress.</para>
        /// </description></item>
        /// <item><description><para><c>Succeeded</c>: The job is completed and the contact was reached.</para>
        /// </description></item>
        /// <item><description><para><c>Paused</c>: The job is paused.</para>
        /// </description></item>
        /// <item><description><para><c>Failed</c>: The job completed but failed to reach the contact.</para>
        /// </description></item>
        /// <item><description><para><c>Cancelled</c>: The job was canceled by a user.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("JobStatusFilter")]
        [Validation(Required=false)]
        public string JobStatusFilter { get; set; }

        /// <summary>
        /// <para>The filter conditions for calls, based on their labels.</para>
        /// <remarks>
        /// <para>This filter applies only to labels that are configured with a predefined set of values (enumerated values). These labels are typically used in large model scenarios.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("LabelsJson")]
        [Validation(Required=false)]
        public List<string> LabelsJson { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size</para>
        /// <remarks>
        /// <para>Notice: This parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The search query for a specific job, such as the contact\&quot;s phone number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1882020****</para>
        /// </summary>
        [NameInMap("QueryText")]
        [Validation(Required=false)]
        public string QueryText { get; set; }

        /// <summary>
        /// <para>Filters for calls that started on or after the specified time. Specify the time as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1579055782000</para>
        /// </summary>
        [NameInMap("StartActualTimeFilter")]
        [Validation(Required=false)]
        public long? StartActualTimeFilter { get; set; }

        /// <summary>
        /// <para>The call statuses to filter by. You can specify multiple statuses as a JSON array of strings, such as <c>[&quot;Executing&quot;, &quot;Succeeded&quot;]</c>.
        /// Valid values:
        /// (Note: The <b>Succeeded</b> status is subdivided into more specific reasons. The general <b>Succeeded</b> (1: Connected) status is no longer returned. Instead, one of the more specific sub-statuses is returned.)</para>
        /// <list type="bullet">
        /// <item><description><para><b>Executing</b> (0): The call is being placed.</para>
        /// </description></item>
        /// <item><description><para><b>Succeeded</b> (1): The call was connected.</para>
        /// </description></item>
        /// <item><description><para><b>NoAnswer</b> (2): Not connected - No answer.</para>
        /// </description></item>
        /// <item><description><para><b>NotExist</b> (3): Not connected - The dialed number does not exist.</para>
        /// </description></item>
        /// <item><description><para><b>Busy</b> (4): Not connected - The line was busy.</para>
        /// </description></item>
        /// <item><description><para><b>Cancelled</b> (5): Not placed - The job was stopped before the call could be dialed.</para>
        /// </description></item>
        /// <item><description><para><b>Failed</b> (6): The call failed.</para>
        /// </description></item>
        /// <item><description><para><b>NotConnected</b> (7): Not connected - The call could not be connected.</para>
        /// </description></item>
        /// <item><description><para><b>PoweredOff</b> (8): Not connected - The recipient\&quot;s phone was powered off.</para>
        /// </description></item>
        /// <item><description><para><b>OutOfService</b> (9): Not connected - The recipient\&quot;s number is out of service.</para>
        /// </description></item>
        /// <item><description><para><b>InArrears</b> (10): Not connected - The recipient\&quot;s account is in arrears.</para>
        /// </description></item>
        /// <item><description><para><b>EmptyNumber</b> (11): Not placed - The number was identified as an empty number and was not dialed.</para>
        /// </description></item>
        /// <item><description><para><b>PerDayCallCountLimit</b> (12): Not placed - The daily call limit was reached.</para>
        /// </description></item>
        /// <item><description><para><b>ContactBlockList</b> (13): Not placed - The number is on a blocklist.</para>
        /// </description></item>
        /// <item><description><para><b>CallerNotRegistered</b> (14): Not placed - The calling number is not registered.</para>
        /// </description></item>
        /// <item><description><para><b>Terminated</b> (15): Not placed - The call was terminated.</para>
        /// </description></item>
        /// <item><description><para><b>VerificationCancelled</b> (16): Not placed - Canceled after failing a pre-call verification.</para>
        /// </description></item>
        /// <item><description><para><b>OutOfServiceNoCall</b> (17): Not placed - The number is out of service and was not dialed.</para>
        /// </description></item>
        /// <item><description><para><b>InArrearsNoCall</b> (18): Not placed - The recipient is in arrears and was not dialed.</para>
        /// </description></item>
        /// <item><description><para><b>CallingNumberNotExist</b> (19): Not placed - The calling number does not exist.</para>
        /// </description></item>
        /// <item><description><para><b>SucceededFinish</b> (20): Connected - The call completed normally.</para>
        /// </description></item>
        /// <item><description><para><b>SucceededChatbotHangUpAfterNoAnswer</b> (21): Connected - The chatbot hung up after a rejection.</para>
        /// </description></item>
        /// <item><description><para><b>SucceededChatbotHangUpAfterSilence</b> (22): Connected - The chatbot hung up due to a silence timeout.</para>
        /// </description></item>
        /// <item><description><para><b>SucceededClientHangUpAfterNoAnswer</b> (23): Connected - The user hung up after a rejection.</para>
        /// </description></item>
        /// <item><description><para><b>SucceededClientHangUp</b> (24): Connected - The user hung up for no specific reason.</para>
        /// </description></item>
        /// <item><description><para><b>SucceededTransferByIntent</b> (25): Connected - The call was transferred to an agent based on user intent.</para>
        /// </description></item>
        /// <item><description><para><b>SucceededTransferAfterNoAnswer</b> (26): Connected - The call was transferred to an agent after a rejection.</para>
        /// </description></item>
        /// <item><description><para><b>SucceededInoInterAction</b> (27): Connected - No interaction from the user.</para>
        /// </description></item>
        /// <item><description><para><b>SucceededError</b> (28): Connected - The call was interrupted by a system error.</para>
        /// </description></item>
        /// <item><description><para><b>SucceededSpecialInterceptVoiceAssistant</b> (29): Connected - Intercepted by a voice assistant.</para>
        /// </description></item>
        /// <item><description><para><b>SucceededSpecialInterceptExtensionNumberTransfer</b> (30): Connected - Intercepted for an extension number transfer.</para>
        /// </description></item>
        /// <item><description><para><b>SucceededSpecialInterceptCustomSpecialIntercept</b> (31): Connected - Intercepted by a custom rule.</para>
        /// </description></item>
        /// <item><description><para><b>HighRiskSipCode</b> (32): Not placed - High-risk SIP code.</para>
        /// </description></item>
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
