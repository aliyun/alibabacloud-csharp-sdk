// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class WorkloadDetails : TeaModel {
        [NameInMap("DLC")]
        [Validation(Required=false)]
        public QuotaJob DLC { get; set; }

        [NameInMap("DSW")]
        [Validation(Required=false)]
        public QuotaJob DSW { get; set; }

        [NameInMap("EAS")]
        [Validation(Required=false)]
        public QuotaJob EAS { get; set; }

        [NameInMap("Summary")]
        [Validation(Required=false)]
        public QuotaJob Summary { get; set; }

    }

}
