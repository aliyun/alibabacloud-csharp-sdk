// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterAddonsUpgradeStatusShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of component names.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("componentIds")]
        [Validation(Required=false)]
        public string ComponentIdsShrink { get; set; }

    }

}
