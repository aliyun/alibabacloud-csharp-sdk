// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListIntervalSkillGroupReportResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListIntervalSkillGroupReportResponseBodyData> Data { get; set; }
        public class ListIntervalSkillGroupReportResponseBodyData : TeaModel {
            [NameInMap("Back2Back")]
            [Validation(Required=false)]
            public ListIntervalSkillGroupReportResponseBodyDataBack2Back Back2Back { get; set; }
            public class ListIntervalSkillGroupReportResponseBodyDataBack2Back : TeaModel {
                [NameInMap("AgentHandleRate")]
                [Validation(Required=false)]
                public float? AgentHandleRate { get; set; }

                [NameInMap("AnswerRate")]
                [Validation(Required=false)]
                public string AnswerRate { get; set; }

                [NameInMap("AverageCustomerRingTime")]
                [Validation(Required=false)]
                public float? AverageCustomerRingTime { get; set; }

                [NameInMap("AverageRingTime")]
                [Validation(Required=false)]
                public float? AverageRingTime { get; set; }

                [NameInMap("AverageTalkTime")]
                [Validation(Required=false)]
                public string AverageTalkTime { get; set; }

                [NameInMap("CallsAgentHandled")]
                [Validation(Required=false)]
                public long? CallsAgentHandled { get; set; }

                [NameInMap("CallsAnswered")]
                [Validation(Required=false)]
                public long? CallsAnswered { get; set; }

                [NameInMap("CallsCustomerAnswered")]
                [Validation(Required=false)]
                public long? CallsCustomerAnswered { get; set; }

                [NameInMap("CallsDialed")]
                [Validation(Required=false)]
                public long? CallsDialed { get; set; }

                [NameInMap("CustomerAnswerRate")]
                [Validation(Required=false)]
                public float? CustomerAnswerRate { get; set; }

                [NameInMap("MaxCustomerRingTime")]
                [Validation(Required=false)]
                public long? MaxCustomerRingTime { get; set; }

                [NameInMap("MaxRingTime")]
                [Validation(Required=false)]
                public long? MaxRingTime { get; set; }

                [NameInMap("MaxTalkTime")]
                [Validation(Required=false)]
                public string MaxTalkTime { get; set; }

                [NameInMap("TotalCustomerRingTime")]
                [Validation(Required=false)]
                public long? TotalCustomerRingTime { get; set; }

                [NameInMap("TotalRingTime")]
                [Validation(Required=false)]
                public long? TotalRingTime { get; set; }

                [NameInMap("TotalTalkTime")]
                [Validation(Required=false)]
                public long? TotalTalkTime { get; set; }

            }

            [NameInMap("Inbound")]
            [Validation(Required=false)]
            public ListIntervalSkillGroupReportResponseBodyDataInbound Inbound { get; set; }
            public class ListIntervalSkillGroupReportResponseBodyDataInbound : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AbandonRate")]
                [Validation(Required=false)]
                public float? AbandonRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageAbandonTime")]
                [Validation(Required=false)]
                public float? AverageAbandonTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageAbandonedInQueueTime")]
                [Validation(Required=false)]
                public float? AverageAbandonedInQueueTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageAbandonedInRingTime")]
                [Validation(Required=false)]
                public float? AverageAbandonedInRingTime { get; set; }

                [NameInMap("AverageFirstResponseTime")]
                [Validation(Required=false)]
                public float? AverageFirstResponseTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageHoldTime")]
                [Validation(Required=false)]
                public float? AverageHoldTime { get; set; }

                [NameInMap("AverageResponseTime")]
                [Validation(Required=false)]
                public float? AverageResponseTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("AverageRingTime")]
                [Validation(Required=false)]
                public float? AverageRingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("AverageTalkTime")]
                [Validation(Required=false)]
                public float? AverageTalkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("AverageWaitTime")]
                [Validation(Required=false)]
                public float? AverageWaitTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("AverageWorkTime")]
                [Validation(Required=false)]
                public float? AverageWorkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAbandoned")]
                [Validation(Required=false)]
                public long? CallsAbandoned { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAbandonedInQueue")]
                [Validation(Required=false)]
                public long? CallsAbandonedInQueue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAbandonedInRing")]
                [Validation(Required=false)]
                public long? CallsAbandonedInRing { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAttendedTransferIn")]
                [Validation(Required=false)]
                public long? CallsAttendedTransferIn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAttendedTransferOut")]
                [Validation(Required=false)]
                public long? CallsAttendedTransferOut { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsBlindTransferIn")]
                [Validation(Required=false)]
                public long? CallsBlindTransferIn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsBlindTransferOut")]
                [Validation(Required=false)]
                public long? CallsBlindTransferOut { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CallsHandled")]
                [Validation(Required=false)]
                public long? CallsHandled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsHold")]
                [Validation(Required=false)]
                public long? CallsHold { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CallsOffered")]
                [Validation(Required=false)]
                public long? CallsOffered { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsOverflow")]
                [Validation(Required=false)]
                public long? CallsOverflow { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CallsQueued")]
                [Validation(Required=false)]
                public long? CallsQueued { get; set; }

                [NameInMap("CallsQueuingOverflow")]
                [Validation(Required=false)]
                public long? CallsQueuingOverflow { get; set; }

                [NameInMap("CallsQueuingTimeout")]
                [Validation(Required=false)]
                public long? CallsQueuingTimeout { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CallsRinged")]
                [Validation(Required=false)]
                public long? CallsRinged { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsTimeout")]
                [Validation(Required=false)]
                public long? CallsTimeout { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.6666666666666666</para>
                /// </summary>
                [NameInMap("HandleRate")]
                [Validation(Required=false)]
                public float? HandleRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxAbandonTime")]
                [Validation(Required=false)]
                public long? MaxAbandonTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxAbandonedInQueueTime")]
                [Validation(Required=false)]
                public long? MaxAbandonedInQueueTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxAbandonedInRingTime")]
                [Validation(Required=false)]
                public long? MaxAbandonedInRingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxHoldTime")]
                [Validation(Required=false)]
                public long? MaxHoldTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("MaxRingTime")]
                [Validation(Required=false)]
                public long? MaxRingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("MaxTalkTime")]
                [Validation(Required=false)]
                public long? MaxTalkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("MaxWaitTime")]
                [Validation(Required=false)]
                public long? MaxWaitTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>19</para>
                /// </summary>
                [NameInMap("MaxWorkTime")]
                [Validation(Required=false)]
                public long? MaxWorkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionIndex")]
                [Validation(Required=false)]
                public float? SatisfactionIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionRate")]
                [Validation(Required=false)]
                public float? SatisfactionRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionSurveysOffered")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysOffered { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionSurveysResponded")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysResponded { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ServiceLevel20")]
                [Validation(Required=false)]
                public float? ServiceLevel20 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalAbandonTime")]
                [Validation(Required=false)]
                public long? TotalAbandonTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalAbandonedInQueueTime")]
                [Validation(Required=false)]
                public long? TotalAbandonedInQueueTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalAbandonedInRingTime")]
                [Validation(Required=false)]
                public long? TotalAbandonedInRingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalHoldTime")]
                [Validation(Required=false)]
                public long? TotalHoldTime { get; set; }

                [NameInMap("TotalMessagesSent")]
                [Validation(Required=false)]
                public long? TotalMessagesSent { get; set; }

                [NameInMap("TotalMessagesSentByAgent")]
                [Validation(Required=false)]
                public long? TotalMessagesSentByAgent { get; set; }

                [NameInMap("TotalMessagesSentByCustomer")]
                [Validation(Required=false)]
                public long? TotalMessagesSentByCustomer { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>33</para>
                /// </summary>
                [NameInMap("TotalRingTime")]
                [Validation(Required=false)]
                public long? TotalRingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("TotalTalkTime")]
                [Validation(Required=false)]
                public long? TotalTalkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>33</para>
                /// </summary>
                [NameInMap("TotalWaitTime")]
                [Validation(Required=false)]
                public long? TotalWaitTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>23</para>
                /// </summary>
                [NameInMap("TotalWorkTime")]
                [Validation(Required=false)]
                public long? TotalWorkTime { get; set; }

            }

            [NameInMap("Outbound")]
            [Validation(Required=false)]
            public ListIntervalSkillGroupReportResponseBodyDataOutbound Outbound { get; set; }
            public class ListIntervalSkillGroupReportResponseBodyDataOutbound : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AnswerRate")]
                [Validation(Required=false)]
                public float? AnswerRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("AverageDialingTime")]
                [Validation(Required=false)]
                public float? AverageDialingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageHoldTime")]
                [Validation(Required=false)]
                public float? AverageHoldTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageRingTime")]
                [Validation(Required=false)]
                public float? AverageRingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("AverageTalkTime")]
                [Validation(Required=false)]
                public float? AverageTalkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("AverageWorkTime")]
                [Validation(Required=false)]
                public float? AverageWorkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallsAnswered")]
                [Validation(Required=false)]
                public long? CallsAnswered { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAttendedTransferIn")]
                [Validation(Required=false)]
                public long? CallsAttendedTransferIn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAttendedTransferOut")]
                [Validation(Required=false)]
                public long? CallsAttendedTransferOut { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsBlindTransferIn")]
                [Validation(Required=false)]
                public long? CallsBlindTransferIn { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsBlindTransferOut")]
                [Validation(Required=false)]
                public long? CallsBlindTransferOut { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CallsDialed")]
                [Validation(Required=false)]
                public long? CallsDialed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsHold")]
                [Validation(Required=false)]
                public long? CallsHold { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsRinged")]
                [Validation(Required=false)]
                public long? CallsRinged { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>49</para>
                /// </summary>
                [NameInMap("MaxDialingTime")]
                [Validation(Required=false)]
                public long? MaxDialingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxHoldTime")]
                [Validation(Required=false)]
                public long? MaxHoldTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxRingTime")]
                [Validation(Required=false)]
                public long? MaxRingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("MaxTalkTime")]
                [Validation(Required=false)]
                public long? MaxTalkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("MaxWorkTime")]
                [Validation(Required=false)]
                public long? MaxWorkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionIndex")]
                [Validation(Required=false)]
                public float? SatisfactionIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionRate")]
                [Validation(Required=false)]
                public float? SatisfactionRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionSurveysOffered")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysOffered { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionSurveysResponded")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysResponded { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("TotalDialingTime")]
                [Validation(Required=false)]
                public long? TotalDialingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalHoldTime")]
                [Validation(Required=false)]
                public long? TotalHoldTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalRingTime")]
                [Validation(Required=false)]
                public long? TotalRingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("TotalTalkTime")]
                [Validation(Required=false)]
                public long? TotalTalkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("TotalWorkTime")]
                [Validation(Required=false)]
                public long? TotalWorkTime { get; set; }

            }

            [NameInMap("Overall")]
            [Validation(Required=false)]
            public ListIntervalSkillGroupReportResponseBodyDataOverall Overall { get; set; }
            public class ListIntervalSkillGroupReportResponseBodyDataOverall : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageBreakTime")]
                [Validation(Required=false)]
                public float? AverageBreakTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageHoldTime")]
                [Validation(Required=false)]
                public float? AverageHoldTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageReadyTime")]
                [Validation(Required=false)]
                public float? AverageReadyTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageTalkTime")]
                [Validation(Required=false)]
                public float? AverageTalkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("AverageWorkTime")]
                [Validation(Required=false)]
                public float? AverageWorkTime { get; set; }

                [NameInMap("BreakCodeDetailList")]
                [Validation(Required=false)]
                public List<ListIntervalSkillGroupReportResponseBodyDataOverallBreakCodeDetailList> BreakCodeDetailList { get; set; }
                public class ListIntervalSkillGroupReportResponseBodyDataOverallBreakCodeDetailList : TeaModel {
                    [NameInMap("BreakCode")]
                    [Validation(Required=false)]
                    public string BreakCode { get; set; }

                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public long? Duration { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MaxBreakTime")]
                [Validation(Required=false)]
                public long? MaxBreakTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxHoldTime")]
                [Validation(Required=false)]
                public long? MaxHoldTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4927</para>
                /// </summary>
                [NameInMap("MaxReadyTime")]
                [Validation(Required=false)]
                public long? MaxReadyTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("MaxTalkTime")]
                [Validation(Required=false)]
                public long? MaxTalkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>19</para>
                /// </summary>
                [NameInMap("MaxWorkTime")]
                [Validation(Required=false)]
                public long? MaxWorkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.00422315148470254</para>
                /// </summary>
                [NameInMap("OccupancyRate")]
                [Validation(Required=false)]
                public float? OccupancyRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionIndex")]
                [Validation(Required=false)]
                public float? SatisfactionIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionRate")]
                [Validation(Required=false)]
                public float? SatisfactionRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionSurveysOffered")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysOffered { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionSurveysResponded")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysResponded { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("TotalBreakTime")]
                [Validation(Required=false)]
                public long? TotalBreakTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("TotalCalls")]
                [Validation(Required=false)]
                public long? TotalCalls { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalHoldTime")]
                [Validation(Required=false)]
                public long? TotalHoldTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9236</para>
                /// </summary>
                [NameInMap("TotalLoggedInTime")]
                [Validation(Required=false)]
                public long? TotalLoggedInTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>9106</para>
                /// </summary>
                [NameInMap("TotalReadyTime")]
                [Validation(Required=false)]
                public long? TotalReadyTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>13</para>
                /// </summary>
                [NameInMap("TotalTalkTime")]
                [Validation(Required=false)]
                public long? TotalTalkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>27</para>
                /// </summary>
                [NameInMap("TotalWorkTime")]
                [Validation(Required=false)]
                public long? TotalWorkTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1604639129000</para>
            /// </summary>
            [NameInMap("StatsTime")]
            [Validation(Required=false)]
            public long? StatsTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>943D8EF3-3321-471F-A104-51C96FCA94D6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
