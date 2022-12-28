// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyClusterCnnfStatusUserConfirmRequest : TeaModel {
        [NameInMap("ClusterIds")]
        [Validation(Required=false)]
        public List<string> ClusterIds { get; set; }

        [NameInMap("UserConfirm")]
        [Validation(Required=false)]
        public bool? UserConfirm { get; set; }

    }

}
