// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class LaunchSurveyRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>4685b65a-eb8f-11ec-8ea0-0242ac120002</para>
        /// </summary>
        [NameInMap("ContactFlowId")]
        [Validation(Required=false)]
        public string ContactFlowId { get; set; }

        [NameInMap("ContactFlowVariables")]
        [Validation(Required=false)]
        public string ContactFlowVariables { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>device</para>
        /// </summary>
        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>job-6580466654649****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4685b65a-eb8f-11ec-8ea0-0242ac120002</para>
        /// </summary>
        [NameInMap("SmsMetadataId")]
        [Validation(Required=false)]
        public string SmsMetadataId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>IVR</para>
        /// </summary>
        [NameInMap("SurveyChannel")]
        [Validation(Required=false)]
        public string SurveyChannel { get; set; }

        [NameInMap("SurveyTemplateId")]
        [Validation(Required=false)]
        public string SurveyTemplateId { get; set; }

        [NameInMap("SurveyTemplateVariables")]
        [Validation(Required=false)]
        public string SurveyTemplateVariables { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>agent@ccc-test</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
