// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterResourcesRequest : TeaModel {
        /// <summary>
        /// Specifies whether to query the resources created by cluster components.
        /// </summary>
        [NameInMap("with_addon_resources")]
        [Validation(Required=false)]
        public bool? WithAddonResources { get; set; }

    }

}
