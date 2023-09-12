// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ImportAppAlertRulesRequest : TeaModel {
        /// <summary>
        /// The IDs of the alert contact groups. The value must be a JSON array.
        /// </summary>
        [NameInMap("ContactGroupIds")]
        [Validation(Required=false)]
        public string ContactGroupIds { get; set; }

        /// <summary>
        /// Specifies whether to enable the alert rule after it is created. Default value: `false`.
        /// 
        /// *   `true`: enables the alert rule.
        /// *   `false`: disables the alert rule.
        /// </summary>
        [NameInMap("IsAutoStart")]
        [Validation(Required=false)]
        public bool? IsAutoStart { get; set; }

        /// <summary>
        /// The process identifiers (PIDs) of the applications associated with the alert rule. The value must be a JSON array. For more information about how to obtain the PID, see [Obtain the PID of an application](~~186100#section-bkl-3j6-ezg~~).
        /// </summary>
        [NameInMap("Pids")]
        [Validation(Required=false)]
        public string Pids { get; set; }

        /// <summary>
        /// The ID of the region where the associated applications reside.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The list of tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ImportAppAlertRulesRequestTags> Tags { get; set; }
        public class ImportAppAlertRulesRequestTags : TeaModel {
            /// <summary>
            /// The tag key.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The configurations of the alert template based on which you want to create an alert rule. The value must be a JSON string. You must set at least one of the **TemplateAlertId** and **TemplageAlertConfig** parameters. If you set both parameters, the **TemplateAlertId** parameter prevails. For more information about the TemplageAlertConfig parameter, see the following **additional information about the TemplageAlertConfig parameter**.
        /// </summary>
        [NameInMap("TemplageAlertConfig")]
        [Validation(Required=false)]
        public string TemplageAlertConfig { get; set; }

        /// <summary>
        /// The ID of the alert template. You must set at least one of the **TemplateAlertId** and **TemplageAlertConfig** parameters. If you set both parameters, the **TemplateAlertId** parameter prevails.
        /// </summary>
        [NameInMap("TemplateAlertId")]
        [Validation(Required=false)]
        public string TemplateAlertId { get; set; }

    }

}
