// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListLinkeLinktDynamiccustomfieldoptionsRequest : TeaModel {
        [NameInMap("DependentParamMap")]
        [Validation(Required=false)]
        public string DependentParamMap { get; set; }

        [NameInMap("FieldId")]
        [Validation(Required=false)]
        public long? FieldId { get; set; }

        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
