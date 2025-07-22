// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class DescribeExpressConnectRouterRouteEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Authentication is failed for ****</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response code. The status code 200 indicates that the request was successful. Other status codes indicate that the request failed. For more information, see Error codes.</para>
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
        /// <para>The dynamic part in the error message. This parameter is used to replace the <c>%s</c> variable in <b>ErrMessage</b>.</para>
        /// <remarks>
        /// <para> For example, if the value of <b>ErrMessage</b> is <b>The Value of Input Parameter %s is not valid</b> and the value of <b>DynamicMessage</b> is <b>DtsJobId</b>, the request parameter <b>DtsJobId</b> is invalid.</para>
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
        /// <para>The total number of entries returned. Valid values: 1 to 2147483647. Default value: 10</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value of <b>NextToken</b> is returned, the value indicates the token that is used for the next query.</description></item>
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
        /// <para>The routes.</para>
        /// </summary>
        [NameInMap("RouteEntriesList")]
        [Validation(Required=false)]
        public List<DescribeExpressConnectRouterRouteEntriesResponseBodyRouteEntriesList> RouteEntriesList { get; set; }
        public class DescribeExpressConnectRouterRouteEntriesResponseBodyRouteEntriesList : TeaModel {
            /// <summary>
            /// <para>The AS path of the route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[64993,64512]</para>
            /// </summary>
            [NameInMap("AsPath")]
            [Validation(Required=false)]
            public string AsPath { get; set; }

            /// <summary>
            /// <para>The community value that is carried in the BGP route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9001:9263</para>
            /// </summary>
            [NameInMap("Community")]
            [Validation(Required=false)]
            public string Community { get; set; }

            /// <summary>
            /// <para>The destination CIDR block of the route.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.0.0/16</para>
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// <para>The MED value of the BGP route, which is used between the ECR and the transit router.</para>
            /// <list type="bullet">
            /// <item><description>You can set the MED value to 2000. In this case, the transit router and the ECR are used as default paths.</description></item>
            /// <item><description>If a non-default path is used, the MED value is empty.</description></item>
            /// <item><description>You can set the MED value to 2000 only for one object associated with a transit router of a CEN instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("Med")]
            [Validation(Required=false)]
            public long? Med { get; set; }

            /// <summary>
            /// <para>The ID of the next-hop instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>br-hp3u4u5f03tfuljis****</para>
            /// </summary>
            [NameInMap("NexthopInstanceId")]
            [Validation(Required=false)]
            public string NexthopInstanceId { get; set; }

            /// <summary>
            /// <para>The region ID of the next-hop instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("NexthopInstanceRegionId")]
            [Validation(Required=false)]
            public string NexthopInstanceRegionId { get; set; }

            /// <summary>
            /// <para>The state of the ECR.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of route entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
