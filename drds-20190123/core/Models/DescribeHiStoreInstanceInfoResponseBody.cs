// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeHiStoreInstanceInfoResponseBody : TeaModel {
        [NameInMap("HiStoreInstanceInfo")]
        [Validation(Required=false)]
        public DescribeHiStoreInstanceInfoResponseBodyHiStoreInstanceInfo HiStoreInstanceInfo { get; set; }
        public class DescribeHiStoreInstanceInfoResponseBodyHiStoreInstanceInfo : TeaModel {
            [NameInMap("DiskSize")]
            [Validation(Required=false)]
            public int? DiskSize { get; set; }
            [NameInMap("RpmVersion")]
            [Validation(Required=false)]
            public string RpmVersion { get; set; }
            [NameInMap("HistoreInstanceId")]
            [Validation(Required=false)]
            public string HistoreInstanceId { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }
            [NameInMap("MachineSpec")]
            [Validation(Required=false)]
            public string MachineSpec { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
