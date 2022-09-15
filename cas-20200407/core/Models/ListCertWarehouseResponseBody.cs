// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cas20200407.Models
{
    public class ListCertWarehouseResponseBody : TeaModel {
        [NameInMap("CertWarehouseList")]
        [Validation(Required=false)]
        public List<ListCertWarehouseResponseBodyCertWarehouseList> CertWarehouseList { get; set; }
        public class ListCertWarehouseResponseBodyCertWarehouseList : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("IsExpired")]
            [Validation(Required=false)]
            public bool? IsExpired { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PcaInstanceId")]
            [Validation(Required=false)]
            public string PcaInstanceId { get; set; }

            [NameInMap("Qps")]
            [Validation(Required=false)]
            public long? Qps { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("WhId")]
            [Validation(Required=false)]
            public long? WhId { get; set; }

        }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ShowSize")]
        [Validation(Required=false)]
        public long? ShowSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
