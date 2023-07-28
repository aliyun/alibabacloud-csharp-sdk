// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class CreateHybridMonitorNamespaceRequest : TeaModel {
        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The data retention period of the namespace. Valid values:
        /// 
        /// *   cms.s1.large: 15 days
        /// *   cms.s1.xlarge: 32 days
        /// *   cms.s1.2xlarge: 63 days
        /// *   cms.s1.3xlarge (default value): 93 days
        /// *   cms.s1.6xlarge: 185 days
        /// *   cms.s1.12xlarge: 376 days
        /// 
        /// For information about the pricing for different retention periods, see the **Pricing** section in [Billing of the dashboard feature](~~223532~~).
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
