// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DeleteContainerAppsRequest : TeaModel {
        [NameInMap("ContainerApp")]
        [Validation(Required=false)]
        public List<DeleteContainerAppsRequestContainerApp> ContainerApp { get; set; }
        public class DeleteContainerAppsRequestContainerApp : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

    }

}
