// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class ListServerGroupsRequest : TeaModel {
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
        /// <item><description>You do not need to specify this parameter for the first request or if no next query exists.</description></item>
        /// <item><description>If a next query exists, set the value to the NextToken value returned in the previous API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID of the Network Load Balancer (NLB) load balancing instance. </para>
        /// <para>You can invoke the <a href="https://help.aliyun.com/document_detail/443657.html">DescribeRegions</a> operation to query the region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the server group belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-atstuj3rtop****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The server group IDs. You can query up to 20 server group IDs at a time.</para>
        /// </summary>
        [NameInMap("ServerGroupIds")]
        [Validation(Required=false)]
        public List<string> ServerGroupIds { get; set; }

        /// <summary>
        /// <para>The server group names. You can query up to 20 server group names at a time.</para>
        /// </summary>
        [NameInMap("ServerGroupNames")]
        [Validation(Required=false)]
        public List<string> ServerGroupNames { get; set; }

        /// <summary>
        /// <para>The type of the server group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Instance</b>: server type. This type of server group supports adding <b>Ecs</b>, <b>Ens</b>, and <b>Eci</b> instances.</description></item>
        /// <item><description><b>Ip</b>: IP address type. This type of server group supports adding IP addresses directly.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("ServerGroupType")]
        [Validation(Required=false)]
        public string ServerGroupType { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListServerGroupsRequestTag> Tag { get; set; }
        public class ListServerGroupsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can specify up to 10 tag keys.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. You can specify up to 10 tag values.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the VPC to which the server group belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp15zckdt37pq72zv****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
