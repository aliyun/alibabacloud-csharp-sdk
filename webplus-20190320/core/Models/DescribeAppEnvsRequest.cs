// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebPlus20190320.Models
{
    public class DescribeAppEnvsRequest : TeaModel {
        [NameInMap("EnvId")]
        [Validation(Required=false)]
        public string EnvId { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("IncludeTerminated")]
        [Validation(Required=false)]
        public bool? IncludeTerminated { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("EnvName")]
        [Validation(Required=false)]
        public string EnvName { get; set; }

        [NameInMap("EnvSearch")]
        [Validation(Required=false)]
        public string EnvSearch { get; set; }

        [NameInMap("RecentUpdated")]
        [Validation(Required=false)]
        public bool? RecentUpdated { get; set; }

        [NameInMap("StackSearch")]
        [Validation(Required=false)]
        public string StackSearch { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
