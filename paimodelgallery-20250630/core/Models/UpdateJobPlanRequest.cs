// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAIModelGallery20250630.Models
{
    public class UpdateJobPlanRequest : TeaModel {
        [NameInMap("JobPlanCurrentStep")]
        [Validation(Required=false)]
        public string JobPlanCurrentStep { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<UpdateJobPlanRequestTag> Tag { get; set; }
        public class UpdateJobPlanRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
