// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OceanBasePro20190901.Models
{
    public class ListWorkerInstancesShrinkRequest : TeaModel {
        [NameInMap("DestType")]
        [Validation(Required=false)]
        public string DestType { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("OnlyBindable")]
        [Validation(Required=false)]
        public bool? OnlyBindable { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("Specs")]
        [Validation(Required=false)]
        public string SpecsShrink { get; set; }

    }

}
