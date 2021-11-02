// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedStatisticsResponseBody : TeaModel {
        [NameInMap("ExposedAsapVulCount")]
        [Validation(Required=false)]
        public int? ExposedAsapVulCount { get; set; }

        [NameInMap("ExposedComponentCount")]
        [Validation(Required=false)]
        public int? ExposedComponentCount { get; set; }

        [NameInMap("ExposedInstanceCount")]
        [Validation(Required=false)]
        public int? ExposedInstanceCount { get; set; }

        [NameInMap("ExposedIpCount")]
        [Validation(Required=false)]
        public int? ExposedIpCount { get; set; }

        [NameInMap("ExposedLaterVulCount")]
        [Validation(Required=false)]
        public int? ExposedLaterVulCount { get; set; }

        [NameInMap("ExposedNntfVulCount")]
        [Validation(Required=false)]
        public int? ExposedNntfVulCount { get; set; }

        [NameInMap("ExposedPortCount")]
        [Validation(Required=false)]
        public int? ExposedPortCount { get; set; }

        [NameInMap("ExposedWeekPasswordMachineCount")]
        [Validation(Required=false)]
        public int? ExposedWeekPasswordMachineCount { get; set; }

        [NameInMap("GatewayAssetCount")]
        [Validation(Required=false)]
        public int? GatewayAssetCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
