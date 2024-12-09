// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ChangeResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the new resource group.</para>
        /// <para>You can view resource group IDs in the <a href="https://resourcemanager.console.aliyun.com/resource-groups">Resource Management console</a> .</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzmhzo******</para>
        /// </summary>
        [NameInMap("NewResourceGroupId")]
        [Validation(Required=false)]
        public string NewResourceGroupId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the cloud resource that you want to move to a new resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-5dc794a7fd254e******</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>service: service</description></item>
        /// <item><description>serviceinstance: service instance</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>service</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
