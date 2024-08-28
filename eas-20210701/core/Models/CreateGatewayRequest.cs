// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateGatewayRequest : TeaModel {
        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// Specifies whether to enable Internet access. Default value: false.
        /// 
        /// Valid values:
        /// 
        /// *   true
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        /// *   false
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// 
        ///     <!-- -->
        /// </summary>
        [NameInMap("EnableInternet")]
        [Validation(Required=false)]
        public bool? EnableInternet { get; set; }

        /// <summary>
        /// Specifies whether to enable internal network access. Default value: true.
        /// </summary>
        [NameInMap("EnableIntranet")]
        [Validation(Required=false)]
        public bool? EnableIntranet { get; set; }

        /// <summary>
        /// The instance type used for the private gateway.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The private gateway alias.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

    }

}
