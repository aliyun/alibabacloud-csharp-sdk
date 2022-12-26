// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class PageImageRegistryRequest : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegistryNameLike")]
        [Validation(Required=false)]
        public string RegistryNameLike { get; set; }

        [NameInMap("RegistryTypeInList")]
        [Validation(Required=false)]
        public List<string> RegistryTypeInList { get; set; }

        [NameInMap("RegistryTypeNotInList")]
        [Validation(Required=false)]
        public List<string> RegistryTypeNotInList { get; set; }

        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
