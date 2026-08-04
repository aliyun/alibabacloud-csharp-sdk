// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetResourceGroupRequestRequest : TeaModel {
        /// <summary>
        /// <para>The container status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Waiting</description></item>
        /// <item><description>Running</description></item>
        /// <item><description>Terminated</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("PodStatus")]
        [Validation(Required=false)]
        public string PodStatus { get; set; }

        /// <summary>
        /// <para>The resource group ID. Each resource group has a globally unique resource group ID. You can use the resource group ID to obtain information about the resource group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rgf0zhfqn1d4ity2</para>
        /// </summary>
        [NameInMap("ResourceGroupID")]
        [Validation(Required=false)]
        public string ResourceGroupID { get; set; }

    }

}
