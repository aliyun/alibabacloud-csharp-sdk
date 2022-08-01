// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class BatchModifyEtlMetaStatusRequest : TeaModel {
        [NameInMap("etlMetaKeyList")]
        [Validation(Required=false)]
        public List<string> EtlMetaKeyList { get; set; }

        [NameInMap("etlMetaName")]
        [Validation(Required=false)]
        public string EtlMetaName { get; set; }

        [NameInMap("etlMetaTag")]
        [Validation(Required=false)]
        public string EtlMetaTag { get; set; }

        [NameInMap("range")]
        [Validation(Required=false)]
        public string Range { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
