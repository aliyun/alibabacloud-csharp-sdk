// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class SetConnectionShareRequest : TeaModel {
        [NameInMap("ProjectId")]
        [Validation(Required=true)]
        public long? ProjectId { get; set; }

        [NameInMap("DatasourceName")]
        [Validation(Required=true)]
        public string DatasourceName { get; set; }

        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        [NameInMap("ProjectPermissions")]
        [Validation(Required=false)]
        public string ProjectPermissions { get; set; }

        [NameInMap("UserPermissions")]
        [Validation(Required=false)]
        public string UserPermissions { get; set; }

    }

}
