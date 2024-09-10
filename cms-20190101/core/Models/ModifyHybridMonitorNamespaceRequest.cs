// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifyHybridMonitorNamespaceRequest : TeaModel {
        /// <summary>
        /// The description of the namespace.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// 
        /// The name can contain letters, digits, and hyphens (-).
        /// 
        /// For information about how to obtain the name of a namespace, see [DescribeHybridMonitorNamespaceList](https://help.aliyun.com/document_detail/428880.html).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The data retention period. Valid values:
        /// 
        /// *   cms.s1.large: Data is stored for 15 days.
        /// *   cms.s1.xlarge: Data is stored for 32 days.
        /// *   cms.s1.2xlarge: Data is stored for 63 days.
        /// *   cms.s1.3xlarge: Data is stored for 93 days.
        /// *   cms.s1.6xlarge: Data is stored for 185 days.
        /// *   cms.s1.12xlarge: Data is stored for 376 days.
        /// 
        /// For information about the pricing for different retention periods, see the **Pricing** section in [Billing of the dashboard feature](https://help.aliyun.com/document_detail/223532.html).
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
