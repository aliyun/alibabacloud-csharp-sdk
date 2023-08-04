// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds_data20220330.Models
{
    public class SqlParameter : TeaModel {
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("TypeHint")]
        [Validation(Required=false)]
        public string TypeHint { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public Field Value { get; set; }

    }

}
