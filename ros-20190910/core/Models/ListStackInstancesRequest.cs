// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <list type="bullet">
        /// <item><description>Pages start from page 1.</description></item>
        /// <item><description>Default value: 1.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: 1 to 50.</description></item>
        /// <item><description>Default value: 10.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the stack group. You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the stack group. The name must be unique within a region.\
        /// The name can be up to 255 characters in length, and can contain digits, letters, hyphens (-), and underscores (_). It must start with a digit or letter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyStackGroup</para>
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        /// <summary>
        /// <para>The ID of the destination account to which the stack belongs.</para>
        /// <list type="bullet">
        /// <item><description>If the stack group is granted self-managed permissions, the stack belongs to an Alibaba Cloud account.</description></item>
        /// <item><description>If the stack group is granted service-managed permissions, the stack belongs to a member in a resource directory.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about the destination account, see <a href="https://help.aliyun.com/document_detail/154578.html">Overview</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>156552876021****</para>
        /// </summary>
        [NameInMap("StackInstanceAccountId")]
        [Validation(Required=false)]
        public string StackInstanceAccountId { get; set; }

        /// <summary>
        /// <para>The region ID of the stack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("StackInstanceRegionId")]
        [Validation(Required=false)]
        public string StackInstanceRegionId { get; set; }

    }

}
