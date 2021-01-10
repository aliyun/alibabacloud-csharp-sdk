// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class SaveLinkeLinktCustomfieldorderRequest : TeaModel {
        [NameInMap("CustomFieldVOListRepeatList")]
        [Validation(Required=false)]
        public List<long?> CustomFieldVOListRepeatList { get; set; }

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
