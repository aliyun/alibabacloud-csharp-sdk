// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateODPInstancesUsersRequest : TeaModel {
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("UpdatePrivileges")]
        [Validation(Required=false)]
        public bool? UpdatePrivileges { get; set; }

        [NameInMap("UserJsonStr")]
        [Validation(Required=false)]
        public string UserJsonStr { get; set; }

    }

}
