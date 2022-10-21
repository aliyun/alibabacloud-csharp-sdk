// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class DeploymentLayout : TeaModel {
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        [NameInMap("ComponentName")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        [NameInMap("NodeSelector")]
        [Validation(Required=false)]
        public NodeSelector NodeSelector { get; set; }

    }

}
