// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListVirtualPhysicalConnectionsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the hosted connection is accepted by the tenant. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsConfirmed")]
        [Validation(Required=false)]
        public bool? IsConfirmed { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1</b> to <b>100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>You do not need to specify this parameter for the first request.</description></item>
        /// <item><description>You must specify the token that is obtained from the previous query as the value of NextToken.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dd20****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the Express Connect circuit over which the hosted connections are created.</para>
        /// <para>Express Connect circuits in this topic refer to Express Connect circuits over which hosted connections are created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-bp1ciz7ekd2grn1as****</para>
        /// </summary>
        [NameInMap("PhysicalConnectionId")]
        [Validation(Required=false)]
        public string PhysicalConnectionId { get; set; }

        /// <summary>
        /// <para>The region ID of the hosted connection.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the hosted connection belongs.</para>
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
            /// <para>The key of tag N to add to the resource. You can specify at most 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>It can be up to 64 characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceDept</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N to add to the resource. You can specify at most 20 tag values. The tag value can be an empty string.</para>
            /// <para>It can be up to 128 characters in length and can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The information about the Alibaba Cloud account that owns the hosted connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>189xxx</para>
        /// </summary>
        [NameInMap("VirtualPhysicalConnectionAliUids")]
        [Validation(Required=false)]
        public List<string> VirtualPhysicalConnectionAliUids { get; set; }

        /// <summary>
        /// <para>The business status of the hosted connection. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b></description></item>
        /// <item><description><b>FinancialLocked</b></description></item>
        /// <item><description><b>SecurityLocked</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("VirtualPhysicalConnectionBusinessStatus")]
        [Validation(Required=false)]
        public string VirtualPhysicalConnectionBusinessStatus { get; set; }

        /// <summary>
        /// <para>The information about the hosted connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-xxx</para>
        /// </summary>
        [NameInMap("VirtualPhysicalConnectionIds")]
        [Validation(Required=false)]
        public List<string> VirtualPhysicalConnectionIds { get; set; }

        /// <summary>
        /// <para>The business status of the hosted connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-xxx</para>
        /// </summary>
        [NameInMap("VirtualPhysicalConnectionStatuses")]
        [Validation(Required=false)]
        public List<string> VirtualPhysicalConnectionStatuses { get; set; }

        /// <summary>
        /// <para>The VLAN ID of the hosted connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pc-xxx</para>
        /// </summary>
        [NameInMap("VlanIds")]
        [Validation(Required=false)]
        public List<string> VlanIds { get; set; }

    }

}
