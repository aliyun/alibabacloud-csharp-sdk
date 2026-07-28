// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ChangeResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the new resource group.</para>
        /// <remarks>
        /// <para>A resource group is a mechanism for managing resources by group within an Alibaba Cloud account. Resource groups help you address the complexity of resource grouping and authorization management within a single cloud account. For more information, see <a href="https://help.aliyun.com/document_detail/94475.html">What is Resource Management</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp1drpcfz9srr393h****</para>
        /// </summary>
        [NameInMap("NewResourceGroupId")]
        [Validation(Required=false)]
        public string NewResourceGroupId { get; set; }

        /// <summary>
        /// <para>The region ID of the resource group that you want to modify.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the Express Connect circuit resource whose resource group you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp16qjewdsunr41m1****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PHYSICALCONNECTION</b>: Express Connect circuit instance.</description></item>
        /// <item><description><b>VIRTUALBORDERROUTER</b>: Virtual Border Router.</description></item>
        /// <item><description><b>ROUTERINTERFACE</b>: VBR uplink.</description></item>
        /// <item><description><b>TRAFFICQOS</b>: QoS policy.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PHYSICALCONNECTION</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
