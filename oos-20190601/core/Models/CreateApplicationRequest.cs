// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreateApplicationRequest : TeaModel {
        /// <summary>
        /// The configurations of application alerts.
        /// </summary>
        [NameInMap("AlarmConfig")]
        [Validation(Required=false)]
        public CreateApplicationRequestAlarmConfig AlarmConfig { get; set; }
        public class CreateApplicationRequestAlarmConfig : TeaModel {
            /// <summary>
            /// The alert contact groups.
            /// </summary>
            [NameInMap("ContactGroups")]
            [Validation(Required=false)]
            public List<string> ContactGroups { get; set; }

            /// <summary>
            /// The health check URL of the application.
            /// </summary>
            [NameInMap("HealthCheckUrl")]
            [Validation(Required=false)]
            public string HealthCheckUrl { get; set; }

            /// <summary>
            /// The alert templates.
            /// </summary>
            [NameInMap("TemplateIds")]
            [Validation(Required=false)]
            public List<string> TemplateIds { get; set; }

        }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the application.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The application name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The region ID. Set the value to cn-hangzhou.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The ID of the service.
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

    }

}
