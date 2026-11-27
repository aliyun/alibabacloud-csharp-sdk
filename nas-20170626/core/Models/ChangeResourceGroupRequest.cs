// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ChangeResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the new resource group.</para>
        /// <para>You can view the resource group ID in the <a href="https://resourcemanager.console.aliyun.com/resource-groups?">Resource Management console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmwavnfdf****</para>
        /// </summary>
        [NameInMap("NewResourceGroupId")]
        [Validation(Required=false)]
        public string NewResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the zone is located.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2412111.html">DescribeRegions</a> operation to query the latest region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31a8e4****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>filesystem: file system.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>filesystem</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
