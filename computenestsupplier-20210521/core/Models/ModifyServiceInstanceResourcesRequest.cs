// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ModifyServiceInstanceResourcesRequest : TeaModel {
        /// <summary>
        /// The imported resources.
        /// </summary>
        [NameInMap("Resources")]
        [Validation(Required=false)]
        public string Resources { get; set; }

        /// <summary>
        /// The ID of the service instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

        /// <summary>
        /// The type of operation performed on the service instance resource. Valid values:
        /// 
        /// *   Import: The resource is imported.
        /// *   UnImport: The resource import is canceled.
        /// </summary>
        [NameInMap("ServiceInstanceResourcesAction")]
        [Validation(Required=false)]
        public string ServiceInstanceResourcesAction { get; set; }

    }

}
