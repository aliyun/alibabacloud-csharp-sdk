// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class ListPermissionResourcePopRequest : TeaModel {
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("operatorId")]
        [Validation(Required=false)]
        public string OperatorId { get; set; }

        [NameInMap("operatorType")]
        [Validation(Required=false)]
        public string OperatorType { get; set; }

        [NameInMap("resourcePrefix")]
        [Validation(Required=false)]
        public string ResourcePrefix { get; set; }

    }

}
