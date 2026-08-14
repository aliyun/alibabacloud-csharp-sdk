// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeFailoverTestJobsRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> value as the <b>ClientToken</b> value. The <b>RequestId</b> value is different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The filter information.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<DescribeFailoverTestJobsRequestFilter> Filter { get; set; }
        public class DescribeFailoverTestJobsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The filter condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>JobId</b>: the failover test job ID.</para>
            /// </description></item>
            /// <item><description><para><b>JobName</b>: the failover test job name.</para>
            /// </description></item>
            /// <item><description><para><b>JobStatus</b>: the failover test job status.</para>
            /// </description></item>
            /// <item><description><para><b>ResourceId</b>: the failover test resource ID.</para>
            /// </description></item>
            /// <item><description><para><b>ResourceName</b>: the failover test resource name.</para>
            /// </description></item>
            /// <item><description><para><b>ResourceType</b>: the failover test resource type.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>You can specify up to 5 unique filter conditions. If you specify a resource ID or resource name, you must also specify the resource type. All filter conditions must be met to return accurate query results.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>JobId</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The filter values that correspond to the filter condition.</para>
            /// <remarks>
            /// <para>Each filter condition can contain up to 5 filter values. These filter values use the OR logic. A record is considered a match if it matches any one of the filter values.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page for a paginated query. Valid values: <b>1</b> to <b>100</b>. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Leave this parameter empty for the first query or if no subsequent query is required.</para>
        /// </description></item>
        /// <item><description><para>If a subsequent query is required, set this parameter to the NextToken value returned in the previous API call.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region where the failover test jobs reside.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query the region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

    }

}
