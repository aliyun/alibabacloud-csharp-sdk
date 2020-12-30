// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeNetworkOptimizationSettingsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Settings")]
        [Validation(Required=false)]
        public DescribeNetworkOptimizationSettingsResponseBodySettings Settings { get; set; }
        public class DescribeNetworkOptimizationSettingsResponseBodySettings : TeaModel {
            [NameInMap("Setting")]
            [Validation(Required=false)]
            public List<DescribeNetworkOptimizationSettingsResponseBodySettingsSetting> Setting { get; set; }
            public class DescribeNetworkOptimizationSettingsResponseBodySettingsSetting : TeaModel {
                public string Type { get; set; }
                public string Domain { get; set; }
            }
        };

    }

}
