// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class Condition : TeaModel {
        [NameInMap("int_equals")]
        [Validation(Required=false)]
        public List<long?> IntEquals { get; set; }

        [NameInMap("int_not_equals")]
        [Validation(Required=false)]
        public List<long?> IntNotEquals { get; set; }

        [NameInMap("string_equals")]
        [Validation(Required=false)]
        public List<string> StringEquals { get; set; }

        [NameInMap("string_not_equals")]
        [Validation(Required=false)]
        public List<string> StringNotEquals { get; set; }

    }

}
