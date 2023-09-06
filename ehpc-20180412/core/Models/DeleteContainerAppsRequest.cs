// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DeleteContainerAppsRequest : TeaModel {
        /// <summary>
        /// The information about containers.
        /// </summary>
        [NameInMap("ContainerApp")]
        [Validation(Required=false)]
        public List<DeleteContainerAppsRequestContainerApp> ContainerApp { get; set; }
        public class DeleteContainerAppsRequestContainerApp : TeaModel {
            /// <summary>
            /// The ID of the containerized application that you want to delete. Valid values of N: 1 to 100.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

    }

}
