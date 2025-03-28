// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to unbind all tags from the specified instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: unbinds all tags from the specified instances.</description></item>
        /// <item><description><b>false</b>: To unbind only specific tags, you must specify the <b>TagKey.N</b> parameter.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>You must specify at least one of the All and <b>TagKey.N</b> parameters.</description></item>
        /// <item><description>If you specify both the All parameter and the <b>TagKey.N</b> parameter, the All parameter does not take effect.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>The ID of the region where the data migration, data synchronization, or change tracking instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the data migration, synchronization, and subscription instances, which can be queried by calling the <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> API. &gt; N indicates the Nth instance ID to be passed. For example, ResourceId.0 represents passing the first instance ID; ResourceId.1 represents passing the second instance ID. You can unbind tags for 1 to 50 instances simultaneously.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsntk10k6r12v****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Valid value: <b>ALIYUN::DTS::INSTANCE</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN::DTS::INSTANCE</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>Tag key. &gt; - N indicates the position of the tag key being passed. For example, TagKey.0 represents the first tag key; TagKey.1 represents the second tag key. Up to 20 tag keys can be unbound simultaneously. - Empty strings are not allowed. - At least one of <b>All</b> or this parameter must be provided. - If both <b>All</b> and this parameter are provided, only this parameter will take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testkey1</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
