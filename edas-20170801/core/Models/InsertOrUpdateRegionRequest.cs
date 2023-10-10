// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class InsertOrUpdateRegionRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable remote debugging. Valid values:
        /// 
        /// *   true: enables remote debugging.
        /// *   false: disables remote debugging.
        /// </summary>
        [NameInMap("DebugEnable")]
        [Validation(Required=false)]
        public bool? DebugEnable { get; set; }

        /// <summary>
        /// The description of the namespace. The description can be up to 128 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to create or modify the namespace. If this parameter is left empty or is set to 0, the namespace is created. Otherwise, the namespace is modified.
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// The ID of the MSE registry.
        /// </summary>
        [NameInMap("MseInstanceId")]
        [Validation(Required=false)]
        public string MseInstanceId { get; set; }

        /// <summary>
        /// The name of the namespace. The name can be up to 63 characters in length.
        /// </summary>
        [NameInMap("RegionName")]
        [Validation(Required=false)]
        public string RegionName { get; set; }

        /// <summary>
        /// The ID of the namespace.
        /// 
        /// *   The ID of a custom namespace is in the `Region ID:Namespace identifier` format. Example: cn-beijing:tdy218.
        /// *   The ID of the default namespace is in the `region ID` format. Example: cn-beijing.
        /// </summary>
        [NameInMap("RegionTag")]
        [Validation(Required=false)]
        public string RegionTag { get; set; }

        /// <summary>
        /// The type of the registry.
        /// 
        /// *   default: the shared registry of Enterprise Distributed Application Service (EDAS)
        /// *   exclusive_mse: a Microservices Engine (MSE) registry
        /// </summary>
        [NameInMap("RegistryType")]
        [Validation(Required=false)]
        public string RegistryType { get; set; }

    }

}
