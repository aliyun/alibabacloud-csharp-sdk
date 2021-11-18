// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ModifyCabInstanceRequest : TeaModel {
        [NameInMap("CallCenterInstanceId")]
        [Validation(Required=false)]
        public string CallCenterInstanceId { get; set; }

        [NameInMap("InstanceDescription")]
        [Validation(Required=false)]
        public string InstanceDescription { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("MaxConcurrentConversation")]
        [Validation(Required=false)]
        public int? MaxConcurrentConversation { get; set; }

    }

}
