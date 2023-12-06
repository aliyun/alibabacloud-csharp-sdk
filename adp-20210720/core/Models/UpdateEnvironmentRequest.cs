// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adp20210720.Models
{
    public class UpdateEnvironmentRequest : TeaModel {
        [NameInMap("advancedConfigs")]
        [Validation(Required=false)]
        public UpdateEnvironmentRequestAdvancedConfigs AdvancedConfigs { get; set; }
        public class UpdateEnvironmentRequestAdvancedConfigs : TeaModel {
            [NameInMap("enableDeploySimulation")]
            [Validation(Required=false)]
            public bool? EnableDeploySimulation { get; set; }

            [NameInMap("enableSiteSurvey")]
            [Validation(Required=false)]
            public bool? EnableSiteSurvey { get; set; }

        }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        [NameInMap("vendorConfig")]
        [Validation(Required=false)]
        public string VendorConfig { get; set; }

    }

}
