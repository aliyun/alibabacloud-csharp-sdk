// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetAKSPlanTimeseriesRequest : TeaModel {
        [NameInMap("FullData")]
        [Validation(Required=false)]
        public bool? FullData { get; set; }

        [NameInMap("TimeSeriesId")]
        [Validation(Required=false)]
        public string TimeSeriesId { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
