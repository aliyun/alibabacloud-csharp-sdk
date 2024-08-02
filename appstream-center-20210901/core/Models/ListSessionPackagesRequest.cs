// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListSessionPackagesRequest : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("SessionPackageId")]
        [Validation(Required=false)]
        public string SessionPackageId { get; set; }

        [NameInMap("SessionPackageName")]
        [Validation(Required=false)]
        public string SessionPackageName { get; set; }

        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

        [NameInMap("StateList")]
        [Validation(Required=false)]
        public List<int?> StateList { get; set; }

    }

}
