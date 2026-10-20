// This file is auto-generated, don't edit it. Thanks.

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using Darabonba;
using Darabonba.Utils;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeClusterResourcesRequest : Darabonba.Model {
        /// <summary>
        /// <para>Specifies whether to also query resources created by cluster components.</para>
        /// <list type="bullet">
        /// <item><description><para>true: Queries the resources.</para>
        /// </description></item>
        /// <item><description><para>false: Does not query the resources.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("with_addon_resources")]
        [Validation(Required=false)]
        public bool? WithAddonResources { get; set; }

    }

}

