// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class DescribeInstanceGrantedToExpressConnectRouterResponseBody : TeaModel {
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
        /// <para>IllegalParamFormat.Name</para>
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
        /// <para>The param format of Name **** is illegal.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The network instances whose permissions are granted to the ECR.</para>
        /// </summary>
        [NameInMap("EcrGrantedInstanceList")]
        [Validation(Required=false)]
        public List<DescribeInstanceGrantedToExpressConnectRouterResponseBodyEcrGrantedInstanceList> EcrGrantedInstanceList { get; set; }
        public class DescribeInstanceGrantedToExpressConnectRouterResponseBodyEcrGrantedInstanceList : TeaModel {
            /// <summary>
            /// <para>The ECR ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecr-mezk2idmsd0vx2****</para>
            /// </summary>
            [NameInMap("EcrId")]
            [Validation(Required=false)]
            public string EcrId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that owns the ECR to which you want to grant permissions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1456408190545060</para>
            /// </summary>
            [NameInMap("EcrOwnerAliUid")]
            [Validation(Required=false)]
            public string EcrOwnerAliUid { get; set; }

            /// <summary>
            /// <para>The time when the network instance was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1669023139000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the network instance was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1669023139000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The authorization ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gr-8gdelo13mi99g1****</para>
            /// </summary>
            [NameInMap("GrantId")]
            [Validation(Required=false)]
            public string GrantId { get; set; }

            /// <summary>
            /// <para>The ID of the network instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vbr-j6cwxhgg0s5nuephp****</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud enterprise account that owns the network instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>26842</para>
            /// </summary>
            [NameInMap("NodeOwnerBid")]
            [Validation(Required=false)]
            public string NodeOwnerBid { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that owns the network instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>129845258050****</para>
            /// </summary>
            [NameInMap("NodeOwnerUid")]
            [Validation(Required=false)]
            public long? NodeOwnerUid { get; set; }

            /// <summary>
            /// <para>The region ID of the network instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("NodeRegionId")]
            [Validation(Required=false)]
            public string NodeRegionId { get; set; }

            /// <summary>
            /// <para>The type of the network instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>VBR</b></description></item>
            /// <item><description><b>VPC</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VBR</para>
            /// </summary>
            [NameInMap("NodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>The state of the network instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

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
        /// <para>The total number of entries returned. Valid values: 1 to 2147483647. Default value: 20.</para>
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
        /// <para>FFlMqGuJ10uN3l+FX/cBrGDNXUOUifNeOuAJlT4dc3vsWD6DsNSFAC2FtpeH5QOSG2WFdyRoun7gSLCm5o69YnAQ==</para>
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
        /// <para>The total number of network instances whose permissions are granted to the ECR.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
