// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListAvailableImagesShrinkRequest : TeaModel {
        [NameInMap("DirectoryService")]
        [Validation(Required=false)]
        public string DirectoryServiceShrink { get; set; }

        [NameInMap("EnableHT")]
        [Validation(Required=false)]
        public bool? EnableHT { get; set; }

        [NameInMap("HPCInterConnect")]
        [Validation(Required=false)]
        public string HPCInterConnect { get; set; }

        [NameInMap("ImageOwnerAlias")]
        [Validation(Required=false)]
        public string ImageOwnerAlias { get; set; }

        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("IsPublic")]
        [Validation(Required=false)]
        public bool? IsPublic { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string SchedulerShrink { get; set; }

    }

}
