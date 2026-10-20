// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterAddonsUpgradeStatusShrinkRequest : Darabonba.Model {
        /// <summary>
        /// <para>The list of component names.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("componentIds")]
        [Validation(Required=false)]
        public string ComponentIdsShrink { get; set; }

    }

}

