// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListRouteTargetGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The ClientToken value can contain only ASCII characters. If you do not specify this parameter, the system uses the RequestId of the API request as the ClientToken. The RequestId may be different for each API request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1</b> to <b>50</b>. Default value: <b>50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The ID of a route target group member instance. This parameter filters route target groups that contain the specified member instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ep-xxxx</para>
        /// </summary>
        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. If not all results are returned in a query, a value is returned for NextToken. In the next query, set NextToken to this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID of the VPC to which the route target group belongs. You can call the DescribeRegions operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group. For more information about resource groups, see What is a resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazdjdhd****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of route target group IDs.</para>
        /// <para>You can specify up to 50 instance IDs in a single query.</para>
        /// </summary>
        [NameInMap("RouteTargetGroupIds")]
        [Validation(Required=false)]
        public List<string> RouteTargetGroupIds { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListRouteTargetGroupsRequestTag> Tag { get; set; }
        public class ListRouteTargetGroupsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You can specify up to 20 tag keys. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource. You can specify up to 20 tag values. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FinanceJoshua</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the VPC to which the route target group belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xxxx</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
