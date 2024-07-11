// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreateStateConfigurationShrinkRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The configuration mode. Valid values: ApplyOnce: The configuration is applied only once. After a configuration is updated, the new configuration is applied. ApplyAndMonitor: The configuration is applied only once. After the configuration is applied, the system only checks whether the configuration is migrated in the future. ApplyAndAutoCorrect: The configuration is always applied.
        /// </summary>
        [NameInMap("ConfigureMode")]
        [Validation(Required=false)]
        public string ConfigureMode { get; set; }

        /// <summary>
        /// The description of the desired-state configuration.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The parameters.
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The resource group ID.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The schedule expression. The interval between two schedules must be a minimum of 30 minutes.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScheduleExpression")]
        [Validation(Required=false)]
        public string ScheduleExpression { get; set; }

        /// <summary>
        /// The schedule type. Set the value to rate.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScheduleType")]
        [Validation(Required=false)]
        public string ScheduleType { get; set; }

        /// <summary>
        /// The tags to be added to the configuration.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// The resources to be queried.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Targets")]
        [Validation(Required=false)]
        public string Targets { get; set; }

        /// <summary>
        /// The name of the template. The name must be 1 to 200 characters in length and can contain letters, digits, hyphens (-), and underscores (_).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// The version number of the template. If you do not specify this parameter, the latest version of the template is used.
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
