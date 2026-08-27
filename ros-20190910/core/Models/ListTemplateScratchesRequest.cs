// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListTemplateScratchesRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the resource scenario list.</para>
        /// <para>Start value: 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Settings for paging.</para>
        /// <para>Maximum value: 50.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the resource scenario.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> to query the most recent region list.</para>
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
        /// <para>rg-acfmxazb4ph6aiy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The status of the resource scenario. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>GENERATE_IN_PROGRESS: being generated.</description></item>
        /// <item><description>GENERATE_COMPLETE: generated.</description></item>
        /// <item><description>GENERATE_FAILED: failed to be generated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;GENERATE_COMPLETE&quot;]</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags of the resource scenario.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListTemplateScratchesRequestTags> Tags { get; set; }
        public class ListTemplateScratchesRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource scenario.</para>
            /// <remarks>
            /// <para>Tags is optional. If you specify Tags, you must specify Tags.N.Key.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>usage</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the resource scenario.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ts-7f7a704cf71c49a6****</para>
        /// </summary>
        [NameInMap("TemplateScratchId")]
        [Validation(Required=false)]
        public string TemplateScratchId { get; set; }

        /// <summary>
        /// <para>The type of the resource scenario. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ArchitectureReplication: resource replication.</para>
        /// </description></item>
        /// <item><description><para>ArchitectureDetection: resource detection.</para>
        /// </description></item>
        /// <item><description><para>ResourceImport: resource management.</para>
        /// </description></item>
        /// <item><description><para>ResourceMigration: resource migration.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ArchitectureReplication</para>
        /// </summary>
        [NameInMap("TemplateScratchType")]
        [Validation(Required=false)]
        public string TemplateScratchType { get; set; }

    }

}
