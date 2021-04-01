// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeOpEntitiesResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Total")]
        [Validation(Required=true)]
        public long? Total { get; set; }

        [NameInMap("OpEntities")]
        [Validation(Required=true)]
        public List<DescribeOpEntitiesResponseOpEntities> OpEntities { get; set; }
        public class DescribeOpEntitiesResponseOpEntities : TeaModel {
            [NameInMap("GmtCreate")]
            [Validation(Required=true)]
            public long? GmtCreate { get; set; }

            [NameInMap("EntityType")]
            [Validation(Required=true)]
            public int? EntityType { get; set; }

            [NameInMap("EntityObject")]
            [Validation(Required=true)]
            public string EntityObject { get; set; }

            [NameInMap("OpAction")]
            [Validation(Required=true)]
            public int? OpAction { get; set; }

            [NameInMap("OpAccount")]
            [Validation(Required=true)]
            public string OpAccount { get; set; }

            [NameInMap("OpDesc")]
            [Validation(Required=true)]
            public string OpDesc { get; set; }

        }

    }

}
