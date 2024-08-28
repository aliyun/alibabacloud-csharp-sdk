// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class UpdateGatewayRequest : TeaModel {
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
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        [NameInMap("IsDefault")]
        [Validation(Required=false)]
        public bool? IsDefault { get; set; }

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
