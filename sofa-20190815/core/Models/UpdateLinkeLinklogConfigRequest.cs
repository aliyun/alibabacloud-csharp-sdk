// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeLinklogConfigRequest : TeaModel {
        [NameInMap("Begin")]
        [Validation(Required=false)]
        public long? Begin { get; set; }

        [NameInMap("BeginMills")]
        [Validation(Required=false)]
        public long? BeginMills { get; set; }

        [NameInMap("ConfigType")]
        [Validation(Required=false)]
        public string ConfigType { get; set; }

        [NameInMap("ConfigValNum")]
        [Validation(Required=false)]
        public long? ConfigValNum { get; set; }

        [NameInMap("ConfigValStr")]
        [Validation(Required=false)]
        public string ConfigValStr { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("End")]
        [Validation(Required=false)]
        public long? End { get; set; }

        [NameInMap("EndMills")]
        [Validation(Required=false)]
        public long? EndMills { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public long? GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public long? GmtModified { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("Sorter")]
        [Validation(Required=false)]
        public string Sorter { get; set; }

    }

}
