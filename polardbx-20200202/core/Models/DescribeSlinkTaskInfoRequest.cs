// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeSlinkTaskInfoRequest : TeaModel {
        [NameInMap("FailPageNumber")]
        [Validation(Required=false)]
        public int? FailPageNumber { get; set; }

        [NameInMap("FailPageSize")]
        [Validation(Required=false)]
        public int? FailPageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SlinkTaskId")]
        [Validation(Required=false)]
        public string SlinkTaskId { get; set; }

        [NameInMap("SuccessPageNumber")]
        [Validation(Required=false)]
        public long? SuccessPageNumber { get; set; }

        [NameInMap("SuccessPageSize")]
        [Validation(Required=false)]
        public long? SuccessPageSize { get; set; }

    }

}
