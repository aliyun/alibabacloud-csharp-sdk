// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20140828.Models
{
    public class DescribeScalingConfigurationsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("ScalingConfigurations")]
        [Validation(Required=false)]
        public DescribeScalingConfigurationsResponseBodyScalingConfigurations ScalingConfigurations { get; set; }
        public class DescribeScalingConfigurationsResponseBodyScalingConfigurations : TeaModel {
            [NameInMap("ScalingConfiguration")]
            [Validation(Required=false)]
            public List<DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfiguration> ScalingConfiguration { get; set; }
            public class DescribeScalingConfigurationsResponseBodyScalingConfigurationsScalingConfiguration : TeaModel {
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("MatchCriteria")]
                [Validation(Required=false)]
                public string MatchCriteria { get; set; }

            }
        };

    }

}
