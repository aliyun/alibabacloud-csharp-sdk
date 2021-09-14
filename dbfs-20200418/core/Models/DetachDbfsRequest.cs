// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DBFS20200418.Models
{
    public class DetachDbfsRequest : TeaModel {
        [NameInMap("FsId")]
        [Validation(Required=false)]
        public string FsId { get; set; }

        [NameInMap("ECSInstanceId")]
        [Validation(Required=false)]
        public string ECSInstanceId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
