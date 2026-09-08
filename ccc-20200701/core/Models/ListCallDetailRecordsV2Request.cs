// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCallDetailRecordsV2Request : TeaModel {
        /// <summary>
        /// <para>The list of visitor channel types.</para>
        /// <para>Valid values:</para>
        /// <para>Web: web page.</para>
        /// <para>DingTalkServiceWindow: DingTalk service window.</para>
        /// <para>AliMe: chatbot.</para>
        /// <para>DingTalkRobot: DingTalk chatbot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Web&quot;,&quot;AliMe&quot;]</para>
        /// </summary>
        [NameInMap("AccessChannelTypeList")]
        [Validation(Required=false)]
        public string AccessChannelTypeList { get; set; }

        /// <summary>
        /// <para>The ID of the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent@ccc-test</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <para>Indicates whether the AI post-call analytics report is ready.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AnalyticsReportReady")]
        [Validation(Required=false)]
        public bool? AnalyticsReportReady { get; set; }

        /// <summary>
        /// <para>The intermediate number. The number must be an available outbound number under the instance. In a back-to-back call, this number is used to call the caller and the callee sequentially.</para>
        /// 
        /// <b>Example:</b>
        /// <para>021****4972</para>
        /// </summary>
        [NameInMap("Broker")]
        [Validation(Required=false)]
        public string Broker { get; set; }

        /// <summary>
        /// <para>The called number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>191***9993</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>The calling number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>191***9993</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public string CallingNumber { get; set; }

        /// <summary>
        /// <para>Filters results by hangup cause.</para>
        /// <para>Valid values:</para>
        /// <para>AbandonedInQueue: Abandoned while queuing.</para>
        /// <para>NoAnswer: Customer did not answer.</para>
        /// <para>QueuingTimeout: Queuing timed out.</para>
        /// <para>Voicemail: Transferred to voice mail.</para>
        /// <para>QueuingFailed: Transfer to agent failed.</para>
        /// <para>QueuingOverflow: Queue overflow.</para>
        /// <para>AbandonedInVoiceNavigator: Abandoned during intelligent navigation.</para>
        /// <para>Success: Ended normally.</para>
        /// <para>IVRException: IVR exception.</para>
        /// <para>AbandonedInRing: Abandoned while ringing.</para>
        /// <para>AbandonedInIVR: Abandoned in IVR.</para>
        /// <para>Reject: Customer rejected the call.</para>
        /// <para>ForwardToOutsideNumber: Forwarded to an external number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Success&quot;,&quot;NoAnswer&quot;]</para>
        /// </summary>
        [NameInMap("ContactDispositionList")]
        [Validation(Required=false)]
        public string ContactDispositionList { get; set; }

        /// <summary>
        /// <para>The list of call IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;job-123456789&quot;,&quot;job-234567891&quot;]</para>
        /// </summary>
        [NameInMap("ContactIdList")]
        [Validation(Required=false)]
        public string ContactIdList { get; set; }

        /// <summary>
        /// <para>Filters results by call type.</para>
        /// <para>Valid values:</para>
        /// <para>OUTBOUND: outbound call.</para>
        /// <para>BACK2BACK: back-to-back call.</para>
        /// <para>PRIVACY_DIAL: encrypted call.</para>
        /// <para>INTERNAL: internal call.</para>
        /// <para>PREDICTIVE: predictive outbound call.</para>
        /// <para>INBOUND: inbound call.</para>
        /// <para>CONFERENCE: conference call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;INBOUND&quot;,&quot;OUTBOUND&quot;]</para>
        /// </summary>
        [NameInMap("ContactTypeList")]
        [Validation(Required=false)]
        public string ContactTypeList { get; set; }

        /// <summary>
        /// <para>Filters results by the reason for unanswered calls.</para>
        /// <para>Valid values:</para>
        /// <para>NoAnswer: No answer.</para>
        /// <para>OutOfService: Out of service.</para>
        /// <para>NotExist: Number does not exist.</para>
        /// <para>Restricted: Call restricted.</para>
        /// <para>Busy: Line busy.</para>
        /// <para>NotConnected: Cannot be connected.</para>
        /// <para>PowerOff: Phone powered off.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;NotConnected&quot;,&quot;NoAnswer&quot;]</para>
        /// </summary>
        [NameInMap("EarlyMediaStateList")]
        [Validation(Required=false)]
        public string EarlyMediaStateList { get; set; }

        /// <summary>
        /// <para>The end time of the historical data to retrieve. The default value is the current time. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1657879880010</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The ID of the first agent who participated in the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent@ccc-test</para>
        /// </summary>
        [NameInMap("FirstAgentId")]
        [Validation(Required=false)]
        public string FirstAgentId { get; set; }

        /// <summary>
        /// <para>The instance ID of the call center.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The media type.</para>
        /// <para>Valid values:</para>
        /// <para>AUDIO: voice call.</para>
        /// <para>VIDEO: video call.</para>
        /// <para>CHAT: message.</para>
        /// <para>ALL: all types.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AUDIO</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <para>The phone number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>191***9993</para>
        /// </summary>
        [NameInMap("Number")]
        [Validation(Required=false)]
        public string Number { get; set; }

        /// <summary>
        /// <para>The field by which to sort the results. This parameter is optional. Default value: startTime (call start time).</para>
        /// <para>Valid values:</para>
        /// <para>startTime: call start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>startTime</para>
        /// </summary>
        [NameInMap("OrderByField")]
        [Validation(Required=false)]
        public string OrderByField { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The party that hung up.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;AGENT\&quot;]</para>
        /// </summary>
        [NameInMap("ReleaseInitiatorList")]
        [Validation(Required=false)]
        public string ReleaseInitiatorList { get; set; }

        /// <summary>
        /// <para>The hangup reason.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;VisitorInitiatedClosure\&quot;,\&quot;AgentInitiatedClosure\&quot;]</para>
        /// </summary>
        [NameInMap("ReleaseReasonList")]
        [Validation(Required=false)]
        public string ReleaseReasonList { get; set; }

        /// <summary>
        /// <para>Filters results by satisfaction description. The description content is defined by the customer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Satisfied&quot;,&quot;Average&quot;]</para>
        /// </summary>
        [NameInMap("SatisfactionDescriptionList")]
        [Validation(Required=false)]
        public string SatisfactionDescriptionList { get; set; }

        /// <summary>
        /// <para>Filters results by satisfaction rating. Separate multiple satisfaction ratings with commas (,).</para>
        /// <para>Valid values:</para>
        /// <para>-2: Not sent.</para>
        /// <para>-1: Not rated.</para>
        /// <para>Other positive numbers: custom satisfaction rating values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;-1&quot;,&quot;3&quot;]
        /// [&quot;&gt;2&quot;]
        /// [&quot;&lt;3&quot;]</para>
        /// </summary>
        [NameInMap("SatisfactionRateList")]
        [Validation(Required=false)]
        public string SatisfactionRateList { get; set; }

        /// <summary>
        /// <para>The satisfaction survey channel.</para>
        /// <para>Valid values:</para>
        /// <para>IVR: voice-based satisfaction survey.</para>
        /// <para>SMS: SMS-based satisfaction survey.</para>
        /// <para>CHAT: message-based satisfaction survey.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IVR</para>
        /// </summary>
        [NameInMap("SatisfactionSurveyChannel")]
        [Validation(Required=false)]
        public string SatisfactionSurveyChannel { get; set; }

        /// <summary>
        /// <para>The custom query text that follows the Lucene query syntax.</para>
        /// <para>The following table describes the supported query fields and query types:</para>
        /// <para>accessChannelUserId: the visitor ID. Supports exact match and fuzzy match.</para>
        /// <para>accessChannelName: the channel name. Supports exact match and fuzzy match.</para>
        /// <para>text: the session text. Supports fuzzy match.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text:please wait AND accessChannelUserId:af1a0-afaa-5086e2946e0b* AND accessChannelName:dedicated development channel*</para>
        /// </summary>
        [NameInMap("SearchPattern")]
        [Validation(Required=false)]
        public string SearchPattern { get; set; }

        /// <summary>
        /// <para>The list of skill group IDs to which the agent belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///       &quot;skg1@ccc-test&quot;,
        ///       &quot;skg2@ccc-test&quot;
        /// ]</para>
        /// </summary>
        [NameInMap("SkillGroupIdList")]
        [Validation(Required=false)]
        public string SkillGroupIdList { get; set; }

        /// <summary>
        /// <para>The sort order. Default value: DESC.</para>
        /// <para>Valid values:</para>
        /// <para>ASC: ascending order.</para>
        /// <para>DESC: descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DESC</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

        /// <summary>
        /// <para>The start time of the historical data to retrieve. The default value is 00:00 of the current day. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1657853640015</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
