// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBaselineDetailRequest : TeaModel {
        [NameInMap("BaselineItemKey")]
        [Validation(Required=false)]
        public string BaselineItemKey { get; set; }

        [NameInMap("ImageUuid")]
        [Validation(Required=false)]
        public string ImageUuid { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
