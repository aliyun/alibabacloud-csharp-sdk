// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListClusterRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the namespace. You can call the ListUserDefineRegion operation to query the namespace ID. For more information, see <a href="https://help.aliyun.com/document_detail/149377.html">ListUserDefineRegion</a>.</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is left empty, the clusters in the default namespace are queried.</description></item>
        /// <item><description>If this parameter is specified, the clusters in the specified namespace are queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing:test</para>
        /// </summary>
        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. You can call the ListResourceGroup operation to query the resource group ID. For more information, see <a href="https://help.aliyun.com/document_detail/62055.html">ListResourceGroup</a>.</para>
        /// <list type="bullet">
        /// <item><description>If this parameter is left empty, the clusters in the default resource group are queried.</description></item>
        /// <item><description>If this parameter is specified, the clusters in the specified resource group are queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>461</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
