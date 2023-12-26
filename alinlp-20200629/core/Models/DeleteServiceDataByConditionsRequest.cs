// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alinlp20200629.Models
{
    public class DeleteServiceDataByConditionsRequest : TeaModel {
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public Dictionary<string, object> Conditions { get; set; }

        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public long? ServiceId { get; set; }

    }

}
