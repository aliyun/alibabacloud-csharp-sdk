// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class DescribeDisabledExpressConnectRouterRouteEntriesResponseBody : TeaModel {
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
        /// <para>The status code. A value of 200 indicates that the call was successful. Other values indicate that the call failed. For more information about the causes of failure, see error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of queried route entries.</para>
        /// </summary>
        [NameInMap("DisabledRouteEntryList")]
        [Validation(Required=false)]
        public List<DescribeDisabledExpressConnectRouterRouteEntriesResponseBodyDisabledRouteEntryList> DisabledRouteEntryList { get; set; }
        public class DescribeDisabledExpressConnectRouterRouteEntriesResponseBodyDisabledRouteEntryList : TeaModel {
            /// <summary>
            /// <para>The destination CIDR block of the route entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.100.110/32</para>
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// <para>The instance ID of the Express Connect Router (ECR).</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecr-mezk2idmsd0vx2****</para>
            /// </summary>
            [NameInMap("EcrId")]
            [Validation(Required=false)]
            public string EcrId { get; set; }

            /// <summary>
            /// <para>The time when the route entry was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1682317345</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The instance ID of the next hop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>br-hp3u4u5f03tfuljis****</para>
            /// </summary>
            [NameInMap("NexthopInstanceId")]
            [Validation(Required=false)]
            public string NexthopInstanceId { get; set; }

            /// <summary>
            /// <para>The region ID of the next hop instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("NexthopInstanceRegionId")]
            [Validation(Required=false)]
            public string NexthopInstanceRegionId { get; set; }

        }

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
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsInstanceId</b>, it indicates that the <b>DtsInstanceId</b> request parameter is invalid.</para>
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
        /// <para>The maximum number of entries to return. Valid values: 1 to 2147483647. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The message returned by the operation.</para>
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
        /// <item><description>If NextToken is empty, no next query is required.</description></item>
        /// <item><description>If NextToken is returned, the value indicates the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>gAAAAABkDTaRFnmxUoMLVOn8YTIgYFeL2ch8j0sJs8VCIU8SS5438m3D9X1VqspCcaUEHRN9I_AfVwMhZHAhcNivifK_OtQxJQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6FABF516-FED3-5697-BDA2-B18C5D9A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the disabled Express Connect Router (ECR) routing is successfully queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: The query was successful.</description></item>
        /// <item><description><b>False</b>: The query failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of route entry.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
