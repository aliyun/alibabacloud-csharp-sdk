// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ExpressConnectRouter20230901.Models
{
    public class DescribeExpressConnectRouterChildInstanceResponseBody : TeaModel {
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
        /// <para>The list of child instances.</para>
        /// </summary>
        [NameInMap("ChildInstanceList")]
        [Validation(Required=false)]
        public List<DescribeExpressConnectRouterChildInstanceResponseBodyChildInstanceList> ChildInstanceList { get; set; }
        public class DescribeExpressConnectRouterChildInstanceResponseBodyChildInstanceList : TeaModel {
            /// <summary>
            /// <para>The ID used to associate the Express Connect Router (ECR) with the VBR.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecr-assoc-9p2qxx5phpca2m****</para>
            /// </summary>
            [NameInMap("AssociationId")]
            [Validation(Required=false)]
            public string AssociationId { get; set; }

            /// <summary>
            /// <para>The instance ID of the border router for routing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vbr-gw8vjq2zjux3ifsc9****</para>
            /// </summary>
            [NameInMap("ChildInstanceId")]
            [Validation(Required=false)]
            public string ChildInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the child instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ChildInstanceName")]
            [Validation(Required=false)]
            public string ChildInstanceName { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID to which the child instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>112101171212****</para>
            /// </summary>
            [NameInMap("ChildInstanceOwnerId")]
            [Validation(Required=false)]
            public long? ChildInstanceOwnerId { get; set; }

            /// <summary>
            /// <para>The region where the child instance resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("ChildInstanceRegionId")]
            [Validation(Required=false)]
            public string ChildInstanceRegionId { get; set; }

            /// <summary>
            /// <para>The type of the child instance. Valid values: <b>VBR</b>: virtual border router.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VBR</para>
            /// </summary>
            [NameInMap("ChildInstanceType")]
            [Validation(Required=false)]
            public string ChildInstanceType { get; set; }

            /// <summary>
            /// <para>The description of the child instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

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
            /// <para>The time when the association was created. The time is displayed in UTC and follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-09T12:18:23Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the association was modified. The time is displayed in UTC and follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-09T12:18:23Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID to which the border router for routing belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>167509154715****</para>
            /// </summary>
            [NameInMap("OwnerId")]
            [Validation(Required=false)]
            public long? OwnerId { get; set; }

            /// <summary>
            /// <para>The region where the VBR resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The deployment status of the associated resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>CREATING</b>: creating.</para>
            /// </description></item>
            /// <item><description><para><b>ACTIVE</b>: created.</para>
            /// </description></item>
            /// <item><description><para><b>ASSOCIATING</b>: associating.</para>
            /// </description></item>
            /// <item><description><para><b>DISSOCIATING</b>: dissociating.</para>
            /// </description></item>
            /// <item><description><para><b>UPDATING</b>: updating.</para>
            /// </description></item>
            /// <item><description><para><b>DELETING</b>: deleting.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The status code that indicates whether the call was successful. A value of 200 indicates that the attachment was successful. Other values indicate that the attachment failed. For more information about the causes of failures, see the error codes.</para>
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
        /// <para>The maximum number of entries returned. Valid values: 1 to 2147483647. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
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
        /// <para>AAAAAYws9fJ0Ur4MGm/5OkDoW/Zn0J0/sCjivzwX9oBcwFnWaaas/kSG+J/WzLOxJHS4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>05130E79-588D-5C40-A718-C4863A59****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>True</b>: successful.</description></item>
        /// <item><description><b>False</b>: failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of associated resources.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
