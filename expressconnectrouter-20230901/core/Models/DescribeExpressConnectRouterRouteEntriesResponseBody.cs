// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class DescribeExpressConnectRouterRouteEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Authentication is failed for ****</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The status code that indicates whether the call is successful. A value of 200 indicates success. Other values indicate failure. For more information about the cause of failure, see Error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The dynamic error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IllegalParamFormat.EcrId</para>
        /// </summary>
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        /// <summary>
        /// <para>The dynamic error message, which is used to replace <c>%s</c> in the <b>ErrMessage</b> error message.</para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, it indicates that the <b>DtsJobId</b> request parameter is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>The param format of EcrId **** is illegal.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned. Valid values: 1 to 2147483647. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The message returned for the instance operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The token for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no subsequent query is required.</description></item>
        /// <item><description>If <b>NextToken</b> has a return value, the value indicates the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>gAAAAABkWwFTUMNCdWC0VMYOIylA56Hx6JUfCZlk5hQ5g_fnKmetN6303tqq5UJ2ouJzyT2fDOdzb-NqyEB5jcY8Z2euX7qHDA==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6FABF516-FED3-5697-BDA2-B18C5D9A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of route entries.</para>
        /// </summary>
        [NameInMap("RouteEntriesList")]
        [Validation(Required=false)]
        public List<DescribeExpressConnectRouterRouteEntriesResponseBodyRouteEntriesList> RouteEntriesList { get; set; }
        public class DescribeExpressConnectRouterRouteEntriesResponseBodyRouteEntriesList : TeaModel {
            /// <summary>
            /// <para>The AS path traversed by the route entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[64993,64512]</para>
            /// </summary>
            [NameInMap("AsPath")]
            [Validation(Required=false)]
            public string AsPath { get; set; }

            /// <summary>
            /// <para>The community value carried by the BGP route entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9001:9263</para>
            /// </summary>
            [NameInMap("Community")]
            [Validation(Required=false)]
            public string Community { get; set; }

            /// <summary>
            /// <para>The destination CIDR block of the route entry.</para>
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// <para>The MED value carried by the BGP route entry, which takes effect for routing between the Express Connect Router (ECR) and the TR. </para>
            /// <list type="bullet">
            /// <item><description>The MED value can be set to 2000. After the configuration, the TR and the Express Connect Router (ECR) serve as the default path. </description></item>
            /// <item><description>For a non-default path, the MED value is empty. </description></item>
            /// <item><description>For TRs in the same Cloud Enterprise Network (CEN), only one associated object can have the MED value set to 2000.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("Med")]
            [Validation(Required=false)]
            public long? Med { get; set; }

            /// <summary>
            /// <para>The next hop instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vbr-hp3u4u5f03tfuljis****</para>
            /// </summary>
            [NameInMap("NexthopInstanceId")]
            [Validation(Required=false)]
            public string NexthopInstanceId { get; set; }

            /// <summary>
            /// <para>The region where the next hop instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("NexthopInstanceRegionId")]
            [Validation(Required=false)]
            public string NexthopInstanceRegionId { get; set; }

            /// <summary>
            /// <para>The status of the Express Connect Router (ECR) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: The call was successful.</description></item>
        /// <item><description><b>False</b>: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
