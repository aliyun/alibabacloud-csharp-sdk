// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySolutionDeviceGroupPageRequest : TeaModel {
        [NameInMap("FuzzyGroupName")]
        [Validation(Required=false)]
        public string FuzzyGroupName { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("PageId")]
        [Validation(Required=true)]
        public int? PageId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("ProjectCode")]
        [Validation(Required=true)]
        public string ProjectCode { get; set; }

    }

}
