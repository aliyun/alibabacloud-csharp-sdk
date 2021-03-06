// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BindApplicationToEdgeInstanceRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=true)]
        public string InstanceId { get; set; }

        [NameInMap("ApplicationId")]
        [Validation(Required=true)]
        public string ApplicationId { get; set; }

        [NameInMap("ApplicationVersion")]
        [Validation(Required=true)]
        public string ApplicationVersion { get; set; }

    }

}
