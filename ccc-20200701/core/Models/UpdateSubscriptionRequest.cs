// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class UpdateSubscriptionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rmq-cn-****.cn-shanghai.rmq.aliyuncs.com:8080</para>
        /// </summary>
        [NameInMap("AccessPoint")]
        [Validation(Required=false)]
        public string AccessPoint { get; set; }

        [NameInMap("AliyunUid")]
        [Validation(Required=false)]
        public long? AliyunUid { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ccc-event</para>
        /// </summary>
        [NameInMap("DefaultTopic")]
        [Validation(Required=false)]
        public string DefaultTopic { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Name &quot;:&quot;StopConsultant &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;QueueingRerouted &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;IvrTracking &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;DualTrackRecordingReady &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;SatisfactionSurveyResponse &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;Dialing &quot;,&quot;Disabled &quot;:false},{&quot;Name &quot;:&quot;Abandoned &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;QueueingCancelled &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;RecordingReady &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;StopCoach &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;Established &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;InitiateConsultant &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;Route2IVR &quot;,&quot;Disabled &quot;:false},{&quot;Name &quot;:&quot;Retrieved &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;CampaignPaused &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;TextStream &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;AgentRelease &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;VoicemailReady &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;Released &quot;,&quot;Disabled &quot;:false},{&quot;Name &quot;:&quot;CDRReady &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;CaseAttempted &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;AgentBreak &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;AgentRingingTimeout &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;AgentReady &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;CampaignResumed &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;AgentDialing &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;Ringing &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;StartConsultant &quot;,&quot;Disabled &quot;:false},{&quot;Name &quot;:&quot;QueueingTimeout &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;AgentTalk &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;AgentRinging &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;StartMonitor &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;BlindTransfer &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;Intercept &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;RingingTimeout &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;StartConference &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;QueueingOverflow &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;BargeIn &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;StopConference &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;AgentCheckOut &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;CampaignSubmitted &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;AgentCheckIn &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;Enqueue &quot;,&quot;Disabled &quot;:false},{&quot;Name &quot;:&quot;AttendedTransfer &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;StopMonitor &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;DispatchingFailure &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;SatisfactionSurveyOffer &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;CampaignCompleted &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;CampaignAborted &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;AssignAgent &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;Held &quot;,&quot;Disabled &quot;:true},{&quot;Name &quot;:&quot;StartCoach &quot;,&quot;Disabled &quot;:true}]</para>
        /// </summary>
        [NameInMap("EventSubscriptionsJson")]
        [Validation(Required=false)]
        public string EventSubscriptionsJson { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rmq-cn-****</para>
        /// </summary>
        [NameInMap("MqInstanceId")]
        [Validation(Required=false)]
        public string MqInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rocketmq5</para>
        /// </summary>
        [NameInMap("MqType")]
        [Validation(Required=false)]
        public string MqType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>password</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GID_xxx</para>
        /// </summary>
        [NameInMap("ProducerId")]
        [Validation(Required=false)]
        public string ProducerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>username</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

    }

}
