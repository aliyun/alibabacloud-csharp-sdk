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
        /// <para>Specifies whether the call is hung up due to unrecognized intent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("HasHangUpByRejectionFilter")]
        [Validation(Required=false)]
        public bool? HasHangUpByRejectionFilter { get; set; }

        /// <summary>
        /// <para>Specifies whether the call flow is completed.</para>
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
        /// <item><description>Scheduling: Scheduling.</description></item>
        /// <item><description>Executing: Executing.</description></item>
        /// <item><description>Succeeded: Completed - Reached.</description></item>
        /// <item><description>Paused: Paused.</description></item>
        /// <item><description>Failed: Completed - Not reached.</description></item>
        /// <item><description>Cancelled: Canceled - Manual intervention.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Succeeded</para>
        /// </summary>
        [NameInMap("JobStatusFilter")]
        [Validation(Required=false)]
        public string JobStatusFilter { get; set; }

        /// <summary>
        /// <para>The filter condition for call labels.</para>
        /// <remarks>
        /// <para>This condition can only filter by labels that are configured with specific enumerated label values, which means labels configured with specific label values in large language model scenarios.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("LabelsJson")]
        [Validation(Required=false)]
        public List<string> LabelsJson { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <remarks>
        /// <para>Notice: This parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para>The call status. Separate multiple values with commas, such as [&quot;Executing&quot;,&quot;Succeeded&quot;].
        /// Valid values:
        /// (Note: The <b>Succeeded</b> status is subdivided into specific causes. The general <b>Succeeded</b>: 1 (Connected) status is not returned. All returned values are specific subdivided causes.)</para>
        /// <list type="bullet">
        /// <item><description><b>Executing</b>: 0 (Dialing).</description></item>
        /// <item><description><b>Succeeded</b>: 1 (Connected).</description></item>
        /// <item><description><b>NoAnswer</b>: 2 (Not connected - no answer).</description></item>
        /// <item><description><b>NotExist</b>: 3 (Not connected - nonexistent number).</description></item>
        /// <item><description><b>Busy</b>: 4 (Not connected - busy).</description></item>
        /// <item><description><b>Cancelled</b>: 5 (Not dialed - task stopped).</description></item>
        /// <item><description><b>Failed</b>: 6 (Failed).</description></item>
        /// <item><description><b>NotConnected</b>: 7 (Not connected - unreachable).</description></item>
        /// <item><description><b>PoweredOff</b>: 8 (Not connected - powered off).</description></item>
        /// <item><description><b>OutOfService</b>: 9 (Not connected - callee out of service).</description></item>
        /// <item><description><b>InArrears</b>: 10 (Not connected - callee has overdue payments).</description></item>
        /// <item><description><b>EmptyNumber</b>: 11 (Not dialed - nonexistent number, not dialed).</description></item>
        /// <item><description><b>PerDayCallCountLimit</b>: 12 (Not dialed - daily limit exceeded).</description></item>
        /// <item><description><b>ContactBlockList</b>: 13 (Not dialed - blacklisted).</description></item>
        /// <item><description><b>CallerNotRegistered</b>: 14 (Not dialed - caller number not registered).</description></item>
        /// <item><description><b>Terminated</b>: 15 (Not dialed - terminated).</description></item>
        /// <item><description><b>VerificationCancelled</b>: 16 (Not dialed - canceled due to pre-call verification failure).</description></item>
        /// <item><description><b>OutOfServiceNoCall</b>: 17 (Not dialed - callee out of service, not dialed).</description></item>
        /// <item><description><b>InArrearsNoCall</b>: 18 (Not dialed - callee has overdue payments, not dialed).</description></item>
        /// <item><description><b>CallingNumberNotExist</b>: 19 (Not dialed - caller number does not exist).</description></item>
        /// <item><description><b>SucceededFinish</b>: 20 (Connected - normal completion).</description></item>
        /// <item><description><b>SucceededChatbotHangUpAfterNoAnswer</b>: 21 (Connected - robot hung up after intent not recognized).</description></item>
        /// <item><description><b>SucceededChatbotHangUpAfterSilence</b>: 22 (Connected - hung up due to silence timeout).</description></item>
        /// <item><description><b>SucceededClientHangUpAfterNoAnswer</b>: 23 (Connected - user hung up after intent not recognized).</description></item>
        /// <item><description><b>SucceededClientHangUp</b>: 24 (Connected - user hung up without reason).</description></item>
        /// <item><description><b>SucceededTransferByIntent</b>: 25 (Connected - transferred to a human agent due to matched intent).</description></item>
        /// <item><description><b>SucceededTransferAfterNoAnswer</b>: 26 (Connected - transferred to a human agent after intent not recognized).</description></item>
        /// <item><description><b>SucceededInoInterAction</b>: 27 (Connected - no interaction from the user).</description></item>
        /// <item><description><b>SucceededError</b>: 28 (Connected - interrupted by a system exception).</description></item>
        /// <item><description><b>SucceededSpecialInterceptVoiceAssistant</b>: 29 (Connected - special interception - voice assistant).</description></item>
        /// <item><description><b>SucceededSpecialInterceptExtensionNumberTransfer</b>: 30 (Connected - special interception - extension number transfer).</description></item>
        /// <item><description><b>SucceededSpecialInterceptCustomSpecialIntercept</b>: 31 (Connected - special interception - custom interception).</description></item>
        /// <item><description><b>HighRiskSipCode</b>: 32 (Not dialed - high risk, not dialed).</description></item>
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
