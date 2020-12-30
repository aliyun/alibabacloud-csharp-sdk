// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ExecuteDataCorrectRequest : TeaModel {
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public string Tid { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        [NameInMap("ActionName")]
        [Validation(Required=false)]
        public string ActionName { get; set; }

        [NameInMap("ActionDetail")]
        [Validation(Required=false)]
        public Dictionary<string, object> ActionDetail { get; set; }

    }

}
