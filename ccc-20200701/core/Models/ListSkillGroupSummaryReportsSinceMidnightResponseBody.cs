// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListSkillGroupSummaryReportsSinceMidnightResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
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
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("PagedSkillGroupSummaryReport")]
        [Validation(Required=false)]
        public ListSkillGroupSummaryReportsSinceMidnightResponseBodyPagedSkillGroupSummaryReport PagedSkillGroupSummaryReport { get; set; }
        public class ListSkillGroupSummaryReportsSinceMidnightResponseBodyPagedSkillGroupSummaryReport : TeaModel {
            /// <summary>
            /// <para>A list of skill group summary reports.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListSkillGroupSummaryReportsSinceMidnightResponseBodyPagedSkillGroupSummaryReportList> List { get; set; }
            public class ListSkillGroupSummaryReportsSinceMidnightResponseBodyPagedSkillGroupSummaryReportList : TeaModel {
                /// <summary>
                /// <para>Inbound call metrics.</para>
                /// </summary>
                [NameInMap("Inbound")]
                [Validation(Required=false)]
                public ListSkillGroupSummaryReportsSinceMidnightResponseBodyPagedSkillGroupSummaryReportListInbound Inbound { get; set; }
                public class ListSkillGroupSummaryReportsSinceMidnightResponseBodyPagedSkillGroupSummaryReportListInbound : TeaModel {
                    /// <summary>
                    /// <para>The number of calls abandoned while waiting in the skill group queue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AbandonedInQueueOfQueueCount")]
                    [Validation(Required=false)]
                    public long? AbandonedInQueueOfQueueCount { get; set; }

                    /// <summary>
                    /// <para>The number of calls routed to the skill group and answered by an agent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AnsweredByAgentOfQueueCount")]
                    [Validation(Required=false)]
                    public long? AnsweredByAgentOfQueueCount { get; set; }

                    /// <summary>
                    /// <para>The maximum queue wait time for a call answered by an agent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AnsweredByAgentOfQueueMaxWaitTimeDuration")]
                    [Validation(Required=false)]
                    public long? AnsweredByAgentOfQueueMaxWaitTimeDuration { get; set; }

                    /// <summary>
                    /// <para>The total queue wait time for calls answered by an agent, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AnsweredByAgentOfQueueWaitTimeDuration")]
                    [Validation(Required=false)]
                    public long? AnsweredByAgentOfQueueWaitTimeDuration { get; set; }

                    /// <summary>
                    /// <para>The average ring time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageRingTime")]
                    [Validation(Required=false)]
                    public long? AverageRingTime { get; set; }

                    /// <summary>
                    /// <para>The average talk time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public long? AverageTalkTime { get; set; }

                    /// <summary>
                    /// <para>The average after-call work time, in seconds (<c>TotalWorkTime</c> / <c>CallsHandled</c>).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public long? AverageWorkTime { get; set; }

                    [NameInMap("CallsAbandoned")]
                    [Validation(Required=false)]
                    public long? CallsAbandoned { get; set; }

                    /// <summary>
                    /// <para>The number of attended transfers initiated. If a call is transferred multiple times, each transfer is counted separately.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAttendedTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferOut { get; set; }

                    /// <summary>
                    /// <para>The number of blind transfers initiated. If a call is transferred multiple times, each transfer is counted separately.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsBlindTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferOut { get; set; }

                    /// <summary>
                    /// <para>The number of handled inbound calls. Each call is counted once per queue entry, regardless of how many agents answer it.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsHandled")]
                    [Validation(Required=false)]
                    public long? CallsHandled { get; set; }

                    /// <summary>
                    /// <para>The number of calls offered to the skill group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsOffered")]
                    [Validation(Required=false)]
                    public long? CallsOffered { get; set; }

                    [NameInMap("CallsOverflow")]
                    [Validation(Required=false)]
                    public string CallsOverflow { get; set; }

                    [NameInMap("CallsQueuingCanceled")]
                    [Validation(Required=false)]
                    public string CallsQueuingCanceled { get; set; }

                    [NameInMap("CallsQueuingFailure")]
                    [Validation(Required=false)]
                    public string CallsQueuingFailure { get; set; }

                    [NameInMap("CallsQueuingRerouted")]
                    [Validation(Required=false)]
                    public string CallsQueuingRerouted { get; set; }

                    [NameInMap("CallsQueuingTimeout")]
                    [Validation(Required=false)]
                    public long? CallsQueuingTimeout { get; set; }

                    /// <summary>
                    /// <para>The number of calls answered by an agent within 10 seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsServiceLevel10")]
                    [Validation(Required=false)]
                    public long? CallsServiceLevel10 { get; set; }

                    /// <summary>
                    /// <para>The number of calls answered by an agent within 20 seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsServiceLevel20")]
                    [Validation(Required=false)]
                    public long? CallsServiceLevel20 { get; set; }

                    /// <summary>
                    /// <para>The number of calls answered by an agent within 30 seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsServiceLevel30")]
                    [Validation(Required=false)]
                    public long? CallsServiceLevel30 { get; set; }

                    [NameInMap("CallsTimeout")]
                    [Validation(Required=false)]
                    public long? CallsTimeout { get; set; }

                    /// <summary>
                    /// <para>The number of calls that were abandoned while an agent in the skill group was being alerted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("GiveUpByAgentOfQueueCount")]
                    [Validation(Required=false)]
                    public long? GiveUpByAgentOfQueueCount { get; set; }

                    /// <summary>
                    /// <para>The handle rate (<c>CallsHandled</c> / <c>CallsOffered</c>). The value can exceed 100% because the handle and offer events might occur in different time windows.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("HandleRate")]
                    [Validation(Required=false)]
                    public float? HandleRate { get; set; }

                    /// <summary>
                    /// <para>The number of calls that entered the skill group queue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("InComingQueueOfQueueCount")]
                    [Validation(Required=false)]
                    public long? InComingQueueOfQueueCount { get; set; }

                    /// <summary>
                    /// <para>The maximum ring time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxRingTime")]
                    [Validation(Required=false)]
                    public long? MaxRingTime { get; set; }

                    /// <summary>
                    /// <para>The maximum talk time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public string MaxTalkTime { get; set; }

                    /// <summary>
                    /// <para>The maximum after-call work time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    /// <summary>
                    /// <para>The number of calls that overflowed from the skill group queue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("OverFlowInQueueOfQueueCount")]
                    [Validation(Required=false)]
                    public long? OverFlowInQueueOfQueueCount { get; set; }

                    /// <summary>
                    /// <para>The maximum queue wait time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("QueueMaxWaitTimeDuration")]
                    [Validation(Required=false)]
                    public long? QueueMaxWaitTimeDuration { get; set; }

                    /// <summary>
                    /// <para>The queue wait time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("QueueWaitTimeDuration")]
                    [Validation(Required=false)]
                    public long? QueueWaitTimeDuration { get; set; }

                    /// <summary>
                    /// <para>The satisfaction index, calculated as the average of single-digit keypad inputs from satisfaction surveys.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    /// <summary>
                    /// <para>The number of satisfaction surveys offered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionSurveysOffered")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysOffered { get; set; }

                    /// <summary>
                    /// <para>The number of satisfaction surveys responded to.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionSurveysResponded")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysResponded { get; set; }

                    /// <summary>
                    /// <para>The percentage of calls answered within 20 seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ServiceLevel20")]
                    [Validation(Required=false)]
                    public float? ServiceLevel20 { get; set; }

                    /// <summary>
                    /// <para>The total ring time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalRingTime")]
                    [Validation(Required=false)]
                    public long? TotalRingTime { get; set; }

                    /// <summary>
                    /// <para>The total talk time for inbound calls, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    /// <summary>
                    /// <para>The total after-call work time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalWorkTime")]
                    [Validation(Required=false)]
                    public long? TotalWorkTime { get; set; }

                }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ccc-test</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Outbound call metrics.</para>
                /// </summary>
                [NameInMap("Outbound")]
                [Validation(Required=false)]
                public ListSkillGroupSummaryReportsSinceMidnightResponseBodyPagedSkillGroupSummaryReportListOutbound Outbound { get; set; }
                public class ListSkillGroupSummaryReportsSinceMidnightResponseBodyPagedSkillGroupSummaryReportListOutbound : TeaModel {
                    /// <summary>
                    /// <para>The answer rate, expressed as a percentage (%).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AnswerRate")]
                    [Validation(Required=false)]
                    public float? AnswerRate { get; set; }

                    /// <summary>
                    /// <para>The average dialing time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageDialingTime")]
                    [Validation(Required=false)]
                    public long? AverageDialingTime { get; set; }

                    /// <summary>
                    /// <para>The average talk time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public long? AverageTalkTime { get; set; }

                    /// <summary>
                    /// <para>The average after-call work time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public long? AverageWorkTime { get; set; }

                    [NameInMap("CallsAbandoned")]
                    [Validation(Required=false)]
                    public long? CallsAbandoned { get; set; }

                    [NameInMap("CallsAgentHandled")]
                    [Validation(Required=false)]
                    public long? CallsAgentHandled { get; set; }

                    /// <summary>
                    /// <para>The number of answered outbound calls.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAnswered")]
                    [Validation(Required=false)]
                    public long? CallsAnswered { get; set; }

                    /// <summary>
                    /// <para>The number of outbound calls dialed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsDialed")]
                    [Validation(Required=false)]
                    public long? CallsDialed { get; set; }

                    [NameInMap("CallsOffered")]
                    [Validation(Required=false)]
                    public long? CallsOffered { get; set; }

                    [NameInMap("CallsQueuingCancelled")]
                    [Validation(Required=false)]
                    public long? CallsQueuingCancelled { get; set; }

                    [NameInMap("CallsQueuingFailed")]
                    [Validation(Required=false)]
                    public long? CallsQueuingFailed { get; set; }

                    [NameInMap("CallsQueuingFailure")]
                    [Validation(Required=false)]
                    public long? CallsQueuingFailure { get; set; }

                    [NameInMap("CallsQueuingOverflow")]
                    [Validation(Required=false)]
                    public long? CallsQueuingOverflow { get; set; }

                    [NameInMap("CallsQueuingRerouted")]
                    [Validation(Required=false)]
                    public long? CallsQueuingRerouted { get; set; }

                    [NameInMap("CallsQueuingTimeout")]
                    [Validation(Required=false)]
                    public long? CallsQueuingTimeout { get; set; }

                    /// <summary>
                    /// <para>The number of calls answered by an agent within 30 seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsServiceLevel30")]
                    [Validation(Required=false)]
                    public string CallsServiceLevel30 { get; set; }

                    [NameInMap("CallsServiceLevel30V2")]
                    [Validation(Required=false)]
                    public long? CallsServiceLevel30V2 { get; set; }

                    /// <summary>
                    /// <para>The maximum dialing time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxDialingTime")]
                    [Validation(Required=false)]
                    public long? MaxDialingTime { get; set; }

                    /// <summary>
                    /// <para>The maximum talk time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    /// <summary>
                    /// <para>The maximum after-call work time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    /// <summary>
                    /// <para>The satisfaction index, calculated as the average of single-digit keypad inputs from satisfaction surveys.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    /// <summary>
                    /// <para>The number of satisfaction surveys offered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionSurveysOffered")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysOffered { get; set; }

                    /// <summary>
                    /// <para>The number of satisfaction surveys responded to.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionSurveysResponded")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysResponded { get; set; }

                    /// <summary>
                    /// <para>The total dialing time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalDialingTime")]
                    [Validation(Required=false)]
                    public long? TotalDialingTime { get; set; }

                    /// <summary>
                    /// <para>The total talk time for outbound calls, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    [NameInMap("TotalWaitTime")]
                    [Validation(Required=false)]
                    public long? TotalWaitTime { get; set; }

                    /// <summary>
                    /// <para>The total after-call work time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalWorkTime")]
                    [Validation(Required=false)]
                    public long? TotalWorkTime { get; set; }

                }

                /// <summary>
                /// <para>Overall metrics.</para>
                /// </summary>
                [NameInMap("Overall")]
                [Validation(Required=false)]
                public ListSkillGroupSummaryReportsSinceMidnightResponseBodyPagedSkillGroupSummaryReportListOverall Overall { get; set; }
                public class ListSkillGroupSummaryReportsSinceMidnightResponseBodyPagedSkillGroupSummaryReportListOverall : TeaModel {
                    /// <summary>
                    /// <para>The average ready time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageReadyTime")]
                    [Validation(Required=false)]
                    public long? AverageReadyTime { get; set; }

                    /// <summary>
                    /// <para>The average talk time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public long? AverageTalkTime { get; set; }

                    /// <summary>
                    /// <para>The average after-call work time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public long? AverageWorkTime { get; set; }

                    /// <summary>
                    /// <para>The maximum ready time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxReadyTime")]
                    [Validation(Required=false)]
                    public long? MaxReadyTime { get; set; }

                    /// <summary>
                    /// <para>The maximum talk time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    /// <summary>
                    /// <para>The maximum after-call work time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    /// <summary>
                    /// <para>The agent occupancy rate, expressed as a percentage (%).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("OccupancyRate")]
                    [Validation(Required=false)]
                    public float? OccupancyRate { get; set; }

                    /// <summary>
                    /// <para>The satisfaction index, calculated as the average of single-digit keypad inputs from satisfaction surveys.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    /// <summary>
                    /// <para>The number of satisfaction surveys offered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionSurveysOffered")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysOffered { get; set; }

                    /// <summary>
                    /// <para>The number of satisfaction surveys responded to.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionSurveysResponded")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysResponded { get; set; }

                    /// <summary>
                    /// <para>The total break time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalBreakTime")]
                    [Validation(Required=false)]
                    public long? TotalBreakTime { get; set; }

                    /// <summary>
                    /// <para>The total number of calls (<c>CallsOffered</c> + <c>CallsDialed</c>).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalCalls")]
                    [Validation(Required=false)]
                    public long? TotalCalls { get; set; }

                    /// <summary>
                    /// <para>The total logged-in time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalLoggedInTime")]
                    [Validation(Required=false)]
                    public long? TotalLoggedInTime { get; set; }

                    /// <summary>
                    /// <para>The total ready time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalReadyTime")]
                    [Validation(Required=false)]
                    public long? TotalReadyTime { get; set; }

                    /// <summary>
                    /// <para>The total talk time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    /// <summary>
                    /// <para>The total after-call work time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalWorkTime")]
                    [Validation(Required=false)]
                    public long? TotalWorkTime { get; set; }

                }

                /// <summary>
                /// <para>The skill group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skillgroup@ccc-test</para>
                /// </summary>
                [NameInMap("SkillGroupId")]
                [Validation(Required=false)]
                public string SkillGroupId { get; set; }

                /// <summary>
                /// <para>The name of the skill group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试技能组</para>
                /// </summary>
                [NameInMap("SkillGroupName")]
                [Validation(Required=false)]
                public string SkillGroupName { get; set; }

                /// <summary>
                /// <para>The timestamp when the metrics were collected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-09-13 00:00:00</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

            /// <summary>
            /// <para>The page number. The valid range is 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page. The valid range is 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2B36CEBC-6D11-5451-9E6B-C6D1927841C5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
