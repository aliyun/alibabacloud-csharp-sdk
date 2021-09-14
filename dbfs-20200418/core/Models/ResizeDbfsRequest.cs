// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class ResizeDbfsRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("FsId")]
        [Validation(Required=false)]
        public string FsId { get; set; }

        [NameInMap("NewSizeG")]
        [Validation(Required=false)]
        public int? NewSizeG { get; set; }

    }

}
