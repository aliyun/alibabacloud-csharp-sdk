// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateAlertRuleRequest : TeaModel {
        /// <summary>
        /// The ID of the alert rule.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AlertId")]
        [Validation(Required=false)]
        public long? AlertId { get; set; }

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
        /// The ID of the region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The configurations of the alert template based on which you want to create an alert rule. The value must be a JSON string. You must set at least one of the **TemplateAlertId** and **TemplageAlertConfig** parameters. If you set both parameters, the **TemplateAlertId** parameter prevails. For more information about the TemplageAlertConfig parameter, see the following **additional information about the TemplageAlertConfig parameter**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplageAlertConfig")]
        [Validation(Required=false)]
        public string TemplageAlertConfig { get; set; }

    }

}
