// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CheckFileDeploymentRequest : TeaModel {
        [NameInMap("CheckerInstanceId")]
        [Validation(Required=true)]
        public string CheckerInstanceId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=true)]
        public string Status { get; set; }

        [NameInMap("CheckDetailUrl")]
        [Validation(Required=false)]
        public string CheckDetailUrl { get; set; }

    }

}
