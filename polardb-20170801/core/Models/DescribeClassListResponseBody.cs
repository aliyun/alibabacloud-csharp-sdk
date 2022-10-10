// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeClassListResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeClassListResponseBodyItems> Items { get; set; }
        public class DescribeClassListResponseBodyItems : TeaModel {
            [NameInMap("ClassCode")]
            [Validation(Required=false)]
            public string ClassCode { get; set; }

            [NameInMap("ClassGroup")]
            [Validation(Required=false)]
            public string ClassGroup { get; set; }

            [NameInMap("ClassTypeLevel")]
            [Validation(Required=false)]
            public string ClassTypeLevel { get; set; }

            [NameInMap("Cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            [NameInMap("MaxConnections")]
            [Validation(Required=false)]
            public string MaxConnections { get; set; }

            [NameInMap("MaxIOPS")]
            [Validation(Required=false)]
            public string MaxIOPS { get; set; }

            [NameInMap("MemoryClass")]
            [Validation(Required=false)]
            public string MemoryClass { get; set; }

            [NameInMap("ReferencePrice")]
            [Validation(Required=false)]
            public string ReferencePrice { get; set; }

        }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
