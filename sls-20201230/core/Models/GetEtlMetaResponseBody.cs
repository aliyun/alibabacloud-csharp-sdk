// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class GetEtlMetaResponseBody : TeaModel {
        [NameInMap("etlMetaList")]
        [Validation(Required=false)]
        public List<EtlMeta> EtlMetaList { get; set; }

        [NameInMap("total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
