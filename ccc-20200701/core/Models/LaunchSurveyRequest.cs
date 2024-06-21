// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class LaunchSurveyRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ContactFlowId")]
        [Validation(Required=false)]
        public string ContactFlowId { get; set; }

        [NameInMap("ContactFlowVariables")]
        [Validation(Required=false)]
        public string ContactFlowVariables { get; set; }

        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("SmsMetadataId")]
        [Validation(Required=false)]
        public string SmsMetadataId { get; set; }

        [NameInMap("SurveyChannel")]
        [Validation(Required=false)]
        public string SurveyChannel { get; set; }

        [NameInMap("SurveyTemplateId")]
        [Validation(Required=false)]
        public string SurveyTemplateId { get; set; }

        [NameInMap("SurveyTemplateVariables")]
        [Validation(Required=false)]
        public string SurveyTemplateVariables { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
