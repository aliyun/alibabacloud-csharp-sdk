// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to unbind instance tags from the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Unbinds instance tags from the instance.</description></item>
        /// <item><description><b>false</b>: Does not unbind instance tags. You must specify the tags to unbind in the <b>TagKey.N</b> parameter.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You must specify at least one of <b>TagKey.N</b> and this parameter.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If you specify both <b>TagKey.N</b> and this parameter, this parameter does not take effect.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>The region ID. Specify this parameter to indicate the region where the instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">Supported regions</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the data migration, synchronization, or change tracking instance. You can call the <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> operation to query instance IDs.</para>
        /// <remarks>
        /// <para>N specifies the sequence number of the instance ID. For example, ResourceId.0 specifies the first instance ID, and ResourceId.1 specifies the second instance ID. You can unbind tags from 1 to 50 instances at a time.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsntk10k6r12v****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. The only valid value is <b>ALIYUN::DTS::INSTANCE</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN::DTS::INSTANCE</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tag key.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>N specifies the sequence number of the tag key. For example, TagKey.0 specifies the first tag key, and TagKey.1 specifies the second tag key. You can unbind 1 to 20 tag keys at a time.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>Empty strings are not allowed.</description></item>
        /// <item><description>You must specify at least one of <b>All</b> and this parameter.</description></item>
        /// <item><description>If you specify both <b>All</b> and this parameter, only this parameter takes effect.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>testkey1</para>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
