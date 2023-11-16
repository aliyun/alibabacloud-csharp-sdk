// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListOpaClusterStrategyNewRequest : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public List<string> ImageName { get; set; }

        [NameInMap("Label")]
        [Validation(Required=false)]
        public List<string> Label { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("StrategyName")]
        [Validation(Required=false)]
        public List<string> StrategyName { get; set; }

    }

}
