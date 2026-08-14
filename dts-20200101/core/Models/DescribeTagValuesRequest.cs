// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeTagValuesRequest : TeaModel {
        /// <summary>
        /// <para>The type of the tag key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Custom</b>: a user-added tag key.</description></item>
        /// <item><description><b>System</b>: a system-created tag key.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is left empty, all tag keys are returned by default.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Custom</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The key of the tag.</para>
        /// <remarks>
        /// <para>This parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>owner</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The page number. Specifies the page to return when a tag key has multiple tag values. The value must be a positive integer that does not exceed the maximum value of the Integer data type. This parameter is typically used together with PageSize. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of tag values to return per page when a tag key has multiple tag values. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region in which the DTS instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
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
        /// <para>The ID of the data migration, data synchronization, or change tracking instance. You can call the <a href="https://help.aliyun.com/document_detail/209702.html">DescribeDtsJobs</a> operation to query the instance ID.</para>
        /// <remarks>
        /// <para>If this parameter is left empty, all tag values of the specified tag key for the current account are returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>dtsl5o11f9029c****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type defined by the system. Set the value to <b>ALIYUN::DTS::INSTANCE</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALIYUN::DTS::INSTANCE</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

    }

}
