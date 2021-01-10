// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class CreateCustomizedFilterRequest : TeaModel {
        [NameInMap("VersionType")]
        [Validation(Required=false)]
        public string VersionType { get; set; }

        [NameInMap("BlackWhiteType")]
        [Validation(Required=false)]
        public string BlackWhiteType { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("ValueCompareType")]
        [Validation(Required=false)]
        public string ValueCompareType { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ValueType")]
        [Validation(Required=false)]
        public string ValueType { get; set; }

        [NameInMap("VersionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
