// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreateApplicationRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("CloudMonitorContactGroupList")]
        [Validation(Required=false)]
        public string CloudMonitorContactGroupList { get; set; }

        [NameInMap("CloudMonitorEnableSubscribeEvent")]
        [Validation(Required=false)]
        public bool? CloudMonitorEnableSubscribeEvent { get; set; }

        [NameInMap("CloudMonitorEnableInstallAgent")]
        [Validation(Required=false)]
        public bool? CloudMonitorEnableInstallAgent { get; set; }

        [NameInMap("CloudMonitorTemplateIdList")]
        [Validation(Required=false)]
        public string CloudMonitorTemplateIdList { get; set; }

        [NameInMap("CloudMonitorRuleEnabled")]
        [Validation(Required=false)]
        public bool? CloudMonitorRuleEnabled { get; set; }

    }

}
