// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeClassDetailsResponseBody : TeaModel {
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("ClassCode")]
        [Validation(Required=false)]
        public string ClassCode { get; set; }

        [NameInMap("ClassGroup")]
        [Validation(Required=false)]
        public string ClassGroup { get; set; }

        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public string Cpu { get; set; }

        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        [NameInMap("InstructionSetArch")]
        [Validation(Required=false)]
        public string InstructionSetArch { get; set; }

        [NameInMap("MaxConnections")]
        [Validation(Required=false)]
        public string MaxConnections { get; set; }

        [NameInMap("MaxIOMBPS")]
        [Validation(Required=false)]
        public string MaxIOMBPS { get; set; }

        [NameInMap("MaxIOPS")]
        [Validation(Required=false)]
        public string MaxIOPS { get; set; }

        [NameInMap("MemoryClass")]
        [Validation(Required=false)]
        public string MemoryClass { get; set; }

        [NameInMap("ReferencePrice")]
        [Validation(Required=false)]
        public string ReferencePrice { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
