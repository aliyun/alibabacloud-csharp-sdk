// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class UpdateCustomizedFilterRequest : TeaModel {
        [NameInMap("BlackWhiteType")]
        [Validation(Required=false)]
        public string BlackWhiteType { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        [NameInMap("ValueType")]
        [Validation(Required=false)]
        public string ValueType { get; set; }

        [NameInMap("ValueCompareType")]
        [Validation(Required=false)]
        public string ValueCompareType { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
