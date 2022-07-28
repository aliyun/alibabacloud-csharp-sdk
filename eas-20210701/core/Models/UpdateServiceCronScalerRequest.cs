// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateServiceCronScalerRequest : TeaModel {
        [NameInMap("ExcludeDates")]
        [Validation(Required=false)]
        public List<string> ExcludeDates { get; set; }

        [NameInMap("ScaleJobs")]
        [Validation(Required=false)]
        public List<UpdateServiceCronScalerRequestScaleJobs> ScaleJobs { get; set; }
        public class UpdateServiceCronScalerRequestScaleJobs : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Schedule")]
            [Validation(Required=false)]
            public string Schedule { get; set; }

            [NameInMap("TargetSize")]
            [Validation(Required=false)]
            public int? TargetSize { get; set; }

        }

    }

}
