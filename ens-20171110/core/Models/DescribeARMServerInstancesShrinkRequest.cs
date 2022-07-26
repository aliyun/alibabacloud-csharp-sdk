// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeARMServerInstancesShrinkRequest : TeaModel {
        [NameInMap("EnsRegionIds")]
        [Validation(Required=false)]
        public string EnsRegionIdsShrink { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ServerIds")]
        [Validation(Required=false)]
        public string ServerIdsShrink { get; set; }

    }

}
