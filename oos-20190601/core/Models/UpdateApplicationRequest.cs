// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class UpdateApplicationRequest : TeaModel {
        [NameInMap("AlarmConfig")]
        [Validation(Required=false)]
        public UpdateApplicationRequestAlarmConfig AlarmConfig { get; set; }
        public class UpdateApplicationRequestAlarmConfig : TeaModel {
            [NameInMap("ContactGroups")]
            [Validation(Required=false)]
            public List<string> ContactGroups { get; set; }

            [NameInMap("HealthCheckUrl")]
            [Validation(Required=false)]
            public string HealthCheckUrl { get; set; }

            [NameInMap("TemplateIds")]
            [Validation(Required=false)]
            public List<string> TemplateIds { get; set; }

        }

        [NameInMap("DeleteAlarmRulesBeforeUpdate")]
        [Validation(Required=false)]
        public bool? DeleteAlarmRulesBeforeUpdate { get; set; }

        /// <summary>
        /// The description to be updated for the application.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The application name.
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
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tags { get; set; }

    }

}
