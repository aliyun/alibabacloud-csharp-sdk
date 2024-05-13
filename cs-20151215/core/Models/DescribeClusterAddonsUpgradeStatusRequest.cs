// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterAddonsUpgradeStatusRequest : TeaModel {
        /// <summary>
        /// The list of component names.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("componentIds")]
        [Validation(Required=false)]
        public List<string> ComponentIds { get; set; }

    }

}
