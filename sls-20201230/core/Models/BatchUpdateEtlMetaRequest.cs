// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class BatchUpdateEtlMetaRequest : TeaModel {
        [NameInMap("etlMetaList")]
        [Validation(Required=false)]
        public BatchUpdateEtlMetaRequestEtlMetaList EtlMetaList { get; set; }
        public class BatchUpdateEtlMetaRequestEtlMetaList : TeaModel {
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            [NameInMap("etlMetaKey")]
            [Validation(Required=false)]
            public string EtlMetaKey { get; set; }

            [NameInMap("etlMetaName")]
            [Validation(Required=false)]
            public string EtlMetaName { get; set; }

            [NameInMap("etlMetaTag")]
            [Validation(Required=false)]
            public string EtlMetaTag { get; set; }

            [NameInMap("etlMetaValue")]
            [Validation(Required=false)]
            public Dictionary<string, object> EtlMetaValue { get; set; }

        }

    }

}
