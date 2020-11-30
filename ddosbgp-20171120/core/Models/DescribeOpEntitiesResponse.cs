// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddosbgp20171120.Models
{
    public class DescribeOpEntitiesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("OpEntities")]
        [Validation(Required=true)]
        public List<DescribeOpEntitiesResponseOpEntities> OpEntities { get; set; }
        public class DescribeOpEntitiesResponseOpEntities : TeaModel {
            [NameInMap("EntityObject")]
            [Validation(Required=true)]
            public string EntityObject { get; set; }

            [NameInMap("EntityType")]
            [Validation(Required=true)]
            public int? EntityType { get; set; }

            [NameInMap("OpDesc")]
            [Validation(Required=true)]
            public string OpDesc { get; set; }

            [NameInMap("OpAccount")]
            [Validation(Required=true)]
            public string OpAccount { get; set; }

            [NameInMap("OpAction")]
            [Validation(Required=true)]
            public int? OpAction { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=true)]
            public long GmtCreate { get; set; }

        }

    }

}
