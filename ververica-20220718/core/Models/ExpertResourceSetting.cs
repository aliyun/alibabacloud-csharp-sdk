// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ExpertResourceSetting : TeaModel {
        [NameInMap("jobmanagerResourceSettingSpec")]
        [Validation(Required=false)]
        public BasicResourceSettingSpec JobmanagerResourceSettingSpec { get; set; }

        [NameInMap("resourcePlan")]
        [Validation(Required=false)]
        public string ResourcePlan { get; set; }

    }

}
