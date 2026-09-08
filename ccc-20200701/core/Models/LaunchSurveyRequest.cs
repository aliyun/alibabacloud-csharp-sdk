// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class LaunchSurveyRequest : TeaModel {
        /// <summary>
        /// <para>The contact flow ID of the IVR satisfaction survey flow. Ensure that the specified contact flow ID corresponds to an active satisfaction survey flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4685b65a-eb8f-11ec-8ea0-0242ac120002</para>
        /// </summary>
        [NameInMap("ContactFlowId")]
        [Validation(Required=false)]
        public string ContactFlowId { get; set; }

        /// <summary>
        /// <para>Variables passed to the contact flow. The variables configured here can be retrieved and used in the IVR flow. The format is a JSON string containing a collection of key-value pairs. This parameter is optional and defaults to empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;customerID&quot;: &quot;208880281831****&quot;,
        ///       &quot;operateType&quot;: &quot;cipherCode&quot;,
        ///       &quot;taskId&quot;: &quot;1234567890&quot;,
        ///       &quot;crmOther&quot;: &quot;123&quot;
        /// }</para>
        /// </summary>
        [NameInMap("ContactFlowVariables")]
        [Validation(Required=false)]
        public string ContactFlowVariables { get; set; }

        /// <summary>
        /// <para>Device ID. This parameter has no effect and can be filled with any value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>device</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The call ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-6580466654649****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The configuration ID for text message satisfaction. This parameter is required only when the collection channel is SMS. It is optional and defaults to empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4685b65a-eb8f-11ec-8ea0-0242ac120002</para>
        /// </summary>
        [NameInMap("SmsMetadataId")]
        [Validation(Required=false)]
        public string SmsMetadataId { get; set; }

        /// <summary>
        /// <para>The channel for collecting satisfaction feedback. This parameter is optional and defaults to Voice Satisfaction.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IVR</para>
        /// </summary>
        [NameInMap("SurveyChannel")]
        [Validation(Required=false)]
        public string SurveyChannel { get; set; }

        /// <summary>
        /// <para>The ID of the satisfaction survey template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>19dc793c-9a01-4cb0-b7d5-fcb5431bab6b</para>
        /// </summary>
        [NameInMap("SurveyTemplateId")]
        [Validation(Required=false)]
        public string SurveyTemplateId { get; set; }

        /// <summary>
        /// <para>Satisfaction survey configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("SurveyTemplateVariables")]
        [Validation(Required=false)]
        public string SurveyTemplateVariables { get; set; }

        /// <summary>
        /// <para>The agent ID that initiates the satisfaction survey.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent@ccc-test</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
