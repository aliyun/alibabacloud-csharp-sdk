// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedStatisticsDetailRequest : TeaModel {
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("StatisticsType")]
        [Validation(Required=false)]
        public string StatisticsType { get; set; }

        [NameInMap("StatisticsTypeInstanceValue")]
        [Validation(Required=false)]
        public string StatisticsTypeInstanceValue { get; set; }

        [NameInMap("StatisticsTypeGatewayType")]
        [Validation(Required=false)]
        public string StatisticsTypeGatewayType { get; set; }

    }

}
