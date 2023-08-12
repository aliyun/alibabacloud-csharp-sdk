// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetSyntheticMonitorsRequest : TeaModel {
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public GetSyntheticMonitorsRequestFilter Filter { get; set; }
        public class GetSyntheticMonitorsRequestFilter : TeaModel {
            [NameInMap("MonitorCategory")]
            [Validation(Required=false)]
            public int? MonitorCategory { get; set; }

            [NameInMap("Network")]
            [Validation(Required=false)]
            public int? Network { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public int? TaskType { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
