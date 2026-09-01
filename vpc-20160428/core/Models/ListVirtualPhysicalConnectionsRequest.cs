// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVirtualPhysicalConnectionsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the shared Express Connect circuits have been confirmed and accepted by the tenant. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Yes.</description></item>
        /// <item><description><b>false</b>: No.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsConfirmed")]
        [Validation(Required=false)]
        public bool? IsConfirmed { get; set; }

        /// <summary>
        /// <para>The number of entries per page when you query results by page. Valid values: <b>1</b> to <b>100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>Specifies whether a next query token exists. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter for the first query or if no next query exists.</description></item>
        /// <item><description>If a next query exists, set this parameter to the NextToken value returned by the previous API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dd20****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the Express Connect circuit associated with the shared Express Connect circuits.</para>
        /// <para>In the following content of this topic, the Express Connect circuit associated with the shared Express Connect circuits is referred to as the Express Connect circuit, to distinguish it from the shared Express Connect circuits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1ciz7ekd2grn1as****</para>
        /// </summary>
        [NameInMap("PhysicalConnectionId")]
        [Validation(Required=false)]
        public string PhysicalConnectionId { get; set; }

        /// <summary>
        /// <para>The region ID of the shared Express Connect circuits.</para>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the shared Express Connect circuits belong.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tag list.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<ListVirtualPhysicalConnectionsRequestTags> Tags { get; set; }
        public class ListVirtualPhysicalConnectionsRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The Alibaba Cloud account information of the shared Express Connect circuits owner.</para>
        /// 
        /// <b>Example:</b>
        /// <para>189xxx</para>
        /// </summary>
        [NameInMap("VirtualPhysicalConnectionAliUids")]
        [Validation(Required=false)]
        public List<string> VirtualPhysicalConnectionAliUids { get; set; }

        /// <summary>
        /// <para>The business status of the shared Express Connect circuits. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: Normal.</description></item>
        /// <item><description><b>FinancialLocked</b>: Locked due to overdue payment.</description></item>
        /// <item><description><b>SecurityLocked</b>: Locked for security reasons.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("VirtualPhysicalConnectionBusinessStatus")]
        [Validation(Required=false)]
        public string VirtualPhysicalConnectionBusinessStatus { get; set; }

        /// <summary>
        /// <para>The shared Express Connect circuits information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-xxx</para>
        /// </summary>
        [NameInMap("VirtualPhysicalConnectionIds")]
        [Validation(Required=false)]
        public List<string> VirtualPhysicalConnectionIds { get; set; }

        /// <summary>
        /// <para>The business status information of the shared Express Connect circuits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-xxx</para>
        /// </summary>
        [NameInMap("VirtualPhysicalConnectionStatuses")]
        [Validation(Required=false)]
        public List<string> VirtualPhysicalConnectionStatuses { get; set; }

        /// <summary>
        /// <para>The VLAN ID of the shared Express Connect circuits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-xxx</para>
        /// </summary>
        [NameInMap("VlanIds")]
        [Validation(Required=false)]
        public List<string> VlanIds { get; set; }

    }

}
