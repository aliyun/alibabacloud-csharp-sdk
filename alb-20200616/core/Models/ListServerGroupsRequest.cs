// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListServerGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries to return for a single request. Valid values: <b>1</b> to <b>100</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to retrieve the next page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>For the first request or when no subsequent request is required, leave this parameter empty.</description></item>
        /// <item><description>For a subsequent request, set this parameter to the <b>NextToken</b> value returned from the previous API call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXG****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-atstuj3rtop****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of server group IDs.</para>
        /// </summary>
        [NameInMap("ServerGroupIds")]
        [Validation(Required=false)]
        public List<string> ServerGroupIds { get; set; }

        /// <summary>
        /// <para>The list of server group names. You can specify up to 10 server group names.</para>
        /// </summary>
        [NameInMap("ServerGroupNames")]
        [Validation(Required=false)]
        public List<string> ServerGroupNames { get; set; }

        /// <summary>
        /// <para>The server group type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Instance</b>: the server type, which includes ECS, ENI, and ECI instances.</para>
        /// </description></item>
        /// <item><description><para><b>Ip</b>: the IP address type.</para>
        /// </description></item>
        /// <item><description><para><b>Fc</b>: the Function Compute type.</para>
        /// </description></item>
        /// <item><description><para>If you leave this parameter empty, all types are queried.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("ServerGroupType")]
        [Validation(Required=false)]
        public string ServerGroupType { get; set; }

        /// <summary>
        /// <para>The list of tags that are added to the server group. You can specify up to 10 tags in a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListServerGroupsRequestTag> Tag { get; set; }
        public class ListServerGroupsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can specify up to 10 tag keys.</para>
            /// <para>The key can be up to 64 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. You can specify up to 10 tag values.</para>
            /// <para>The value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The VPC-connected instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp15zckdt37pq72zv****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
