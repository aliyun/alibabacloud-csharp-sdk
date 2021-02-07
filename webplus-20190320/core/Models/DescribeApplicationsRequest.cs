// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribeApplicationsRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("AppSearch")]
        [Validation(Required=false)]
        public string AppSearch { get; set; }

        [NameInMap("EnvSearch")]
        [Validation(Required=false)]
        public string EnvSearch { get; set; }

        [NameInMap("StackSearch")]
        [Validation(Required=false)]
        public string StackSearch { get; set; }

        [NameInMap("CategorySearch")]
        [Validation(Required=false)]
        public string CategorySearch { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
