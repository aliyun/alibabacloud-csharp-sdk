// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// <list type="bullet">
        /// <item><description><para>Starts from 1.</para>
        /// </description></item>
        /// <item><description><para>Default value: 1.</para>
        /// </description></item>
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
        /// <item><description><para>Valid values: 1 to 50.</para>
        /// </description></item>
        /// <item><description><para>Default value: 10.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the stack group. Call <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> to query available regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. If not specified, stack groups in all resource groups are returned.</para>
        /// <remarks>
        /// <para>You can find the resource group ID on the <b>Resource Groups</b> page in the <b>Resource Management</b> console. <a href="https://help.aliyun.com/document_detail/151181.html">View the basic information of a resource group</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxcj****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The status of the stack group. If not specified, stack groups in all states are returned.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ACTIVE: The stack group is active.</para>
        /// </description></item>
        /// <item><description><para>DELETED: The stack group is deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags of the stack group.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListStackGroupsRequestTags> Tags { get; set; }
        public class ListStackGroupsRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the stack group.</para>
            /// <remarks>
            /// <para>Tags is optional. If you specify Tags, Tags.N.Key is required.</para>
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
            /// <para>The tag value of the stack group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
