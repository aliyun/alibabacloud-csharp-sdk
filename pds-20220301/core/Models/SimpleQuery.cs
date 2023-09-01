// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class SimpleQuery : TeaModel {
        [NameInMap("field")]
        [Validation(Required=false)]
        public byte[] Field { get; set; }

        [NameInMap("operation")]
        [Validation(Required=false)]
        public byte[] Operation { get; set; }

        [NameInMap("sub_queries")]
        [Validation(Required=false)]
        public List<SimpleQuery> SubQueries { get; set; }

        [NameInMap("value")]
        [Validation(Required=false)]
        public byte[] Value { get; set; }

    }

}
