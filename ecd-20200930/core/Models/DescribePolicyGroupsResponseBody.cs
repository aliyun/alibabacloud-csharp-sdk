// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribePolicyGroupsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DescribePolicyGroups")]
        [Validation(Required=false)]
        public List<DescribePolicyGroupsResponseBodyDescribePolicyGroups> DescribePolicyGroups { get; set; }
        public class DescribePolicyGroupsResponseBodyDescribePolicyGroups : TeaModel {
            [NameInMap("PolicyStatus")]
            [Validation(Required=false)]
            public string PolicyStatus { get; set; }

            [NameInMap("WatermarkType")]
            [Validation(Required=false)]
            public string WatermarkType { get; set; }

            [NameInMap("PolicyGroupId")]
            [Validation(Required=false)]
            public string PolicyGroupId { get; set; }

            [NameInMap("WatermarkTransparency")]
            [Validation(Required=false)]
            public string WatermarkTransparency { get; set; }

            [NameInMap("UsbRedirect")]
            [Validation(Required=false)]
            public string UsbRedirect { get; set; }

            [NameInMap("PolicyGroupType")]
            [Validation(Required=false)]
            public string PolicyGroupType { get; set; }

            [NameInMap("WatermarkCustomText")]
            [Validation(Required=false)]
            public string WatermarkCustomText { get; set; }

            [NameInMap("Watermark")]
            [Validation(Required=false)]
            public string Watermark { get; set; }

            [NameInMap("Clipboard")]
            [Validation(Required=false)]
            public string Clipboard { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("LocalDrive")]
            [Validation(Required=false)]
            public string LocalDrive { get; set; }

        }

    }

}
