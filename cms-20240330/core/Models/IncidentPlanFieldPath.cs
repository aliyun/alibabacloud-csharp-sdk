// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class IncidentPlanFieldPath : TeaModel {
        [NameInMap("fieldAlias")]
        [Validation(Required=false)]
        public string FieldAlias { get; set; }

        [NameInMap("fieldPath")]
        [Validation(Required=false)]
        public List<string> FieldPath { get; set; }

    }

}
