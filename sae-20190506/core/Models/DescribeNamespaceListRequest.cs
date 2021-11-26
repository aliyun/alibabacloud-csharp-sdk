// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class DescribeNamespaceListRequest : TeaModel {
        [NameInMap("ContainCustom")]
        [Validation(Required=false)]
        public bool? ContainCustom { get; set; }

        [NameInMap("HybridCloudExclude")]
        [Validation(Required=false)]
        public bool? HybridCloudExclude { get; set; }

    }

}
