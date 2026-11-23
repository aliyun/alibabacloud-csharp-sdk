// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class DescribeExpressConnectRouterResponseBody : TeaModel {
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
        /// <para>Indicates whether the call was successful. A return value of 200 indicates success, while other values indicate failure. For the cause of failure, see the error codes.</para>
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
        /// <para>The dynamic error message, which is used to replace <c>%s</c> in the <b>ErrMessage</b> error message.</para>
        /// <remarks>
        /// <para>If <b>ErrMessage</b> returns <b>The Value of Input Parameter %s is not valid</b> and <b>DynamicMessage</b> returns <b>DtsJobId</b>, it indicates that the <b>DtsJobId</b> request parameter is invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>The param format of Name **** is illegal.</para>
        /// </summary>
        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        /// <summary>
        /// <para>The list of Express Connect Router (ECR) instances.</para>
        /// </summary>
        [NameInMap("EcrList")]
        [Validation(Required=false)]
        public List<DescribeExpressConnectRouterResponseBodyEcrList> EcrList { get; set; }
        public class DescribeExpressConnectRouterResponseBodyEcrList : TeaModel {
            /// <summary>
            /// <para>The ASN of the Express Connect Router (ECR) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>45104</para>
            /// </summary>
            [NameInMap("AlibabaSideAsn")]
            [Validation(Required=false)]
            public long? AlibabaSideAsn { get; set; }

            /// <summary>
            /// <para>The business status of the service instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Normal</b>: Normal.</para>
            /// </description></item>
            /// <item><description><para><b>FinancialLocked</b>: Locked due to overdue payment.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("BizStatus")]
            [Validation(Required=false)]
            public string BizStatus { get; set; }

            /// <summary>
            /// <para>The description of the Express Connect Router (ECR) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the Express Connect Router (ECR) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecr-mezk2idmsd0vx2****</para>
            /// </summary>
            [NameInMap("EcrId")]
            [Validation(Required=false)]
            public string EcrId { get; set; }

            /// <summary>
            /// <para>The time when the Express Connect Router (ECR) instance was created. The time is displayed in UTC and follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-16T01:44:50Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the Express Connect Router (ECR) instance was modified. The time is displayed in UTC and follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-16T01:44:50Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The name of the Express Connect Router (ECR) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID to which the Express Connect Router (ECR) instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>170646818729****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the Express Connect Router (ECR) instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-aekzuscospt****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The deployment status of the service instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ACTIVE</b>: Created.</para>
            /// </description></item>
            /// <item><description><para><b>UPDATING</b>: Updating.</para>
            /// </description></item>
            /// <item><description><para><b>ASSOCIATING</b>: Associating resources.</para>
            /// </description></item>
            /// <item><description><para><b>DISSOCIATING</b>: Dissociating resources.</para>
            /// </description></item>
            /// <item><description><para><b>LOCKED_ATTACHING</b>: Locked for association by an external system.</para>
            /// </description></item>
            /// <item><description><para><b>LOCKED_DETACHING</b>: Locked for dissociation by an external system.</para>
            /// </description></item>
            /// <item><description><para><b>RECLAIMING</b>: Pending resource release.</para>
            /// </description></item>
            /// <item><description><para><b>DELETING</b>: Deleting.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeExpressConnectRouterResponseBodyEcrListTags> Tags { get; set; }
            public class DescribeExpressConnectRouterResponseBodyEcrListTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the Express Connect Router (ECR) instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value of the Express Connect Router (ECR) instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

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
        /// <para>The maximum number of entries to return. Valid values: 1 to 2147483647. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The message returned for the operation.</para>
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
        /// <item><description>If NextToken is empty, no next query is available.</description></item>
        /// <item><description>If NextToken has a return value, the value indicates the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2w6Olxc+cMPjUtUMpttDGZkffvHCfhBKKNEyCVaq+WUEzuUWpp9+QOApNf6g==</para>
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
        /// <para>Indicates whether the query for created ECR instances was successful. Valid values:</para>
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
        /// <para>The total number of Express Connect Router (ECR) instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
