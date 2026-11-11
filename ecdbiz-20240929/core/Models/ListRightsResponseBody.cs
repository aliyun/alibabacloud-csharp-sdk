// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EcdBiz20240929.Models
{
    public class ListRightsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business processing result code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The list of rights on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListRightsResponseBodyData> Data { get; set; }
        public class ListRightsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The size of the additional data cloud disk. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AddDataDiskSize")]
            [Validation(Required=false)]
            public int? AddDataDiskSize { get; set; }

            /// <summary>
            /// <para>The size of the additional system cloud disk. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AddRootDiskSize")]
            [Validation(Required=false)]
            public int? AddRootDiskSize { get; set; }

            /// <summary>
            /// <para>Indicates whether the cloud computer is an AI cloud computer. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: AI cloud computer.</description></item>
            /// <item><description>false: Regular cloud computer.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AiDesktop")]
            [Validation(Required=false)]
            public bool? AiDesktop { get; set; }

            /// <summary>
            /// <para>The scenario code for the commercial edition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GENERAL_OFFICE</para>
            /// </summary>
            [NameInMap("BusinessSceneCode")]
            [Validation(Required=false)]
            public string BusinessSceneCode { get; set; }

            /// <summary>
            /// <para>The compute plan code. Refer to the actual returned value of the rights.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HOURS_120_PER_MONTH</para>
            /// </summary>
            [NameInMap("CalculatingCode")]
            [Validation(Required=false)]
            public string CalculatingCode { get; set; }

            /// <summary>
            /// <para>The size of the data cloud disk. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("DataDiskSize")]
            [Validation(Required=false)]
            public int? DataDiskSize { get; set; }

            /// <summary>
            /// <para>The time when the rights record was created. The time is in RFC 3339 UTC format and ends with Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-06T01:00:00Z</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The hibernation options for the rights. The actual policy is determined in combination with the compute plan.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Hibernate")]
            [Validation(Required=false)]
            public int? Hibernate { get; set; }

            /// <summary>
            /// <para>The monthly credit information corresponding to the rights. This value may be empty if this configuration is not available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("MonthlyCredit")]
            [Validation(Required=false)]
            public string MonthlyCredit { get; set; }

            /// <summary>
            /// <para>Specifies whether the rights apply to regions outside the Chinese mainland, including Hong Kong (China), Macao (China), and Taiwan (China). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The Chinese mainland.</description></item>
            /// <item><description>1: Regions outside the Chinese mainland, including Hong Kong (China), Macao (China), and Taiwan (China).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Overseas")]
            [Validation(Required=false)]
            public int? Overseas { get; set; }

            /// <summary>
            /// <para>The cause of the rights activation failure. This value may be empty if the activation is successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The image is unavailable. Select an available image and try again</para>
            /// </summary>
            [NameInMap("RightsActiveFailureCause")]
            [Validation(Required=false)]
            public string RightsActiveFailureCause { get; set; }

            /// <summary>
            /// <para>The rights activation status. Use the returned value to determine whether the activation is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTED</para>
            /// </summary>
            [NameInMap("RightsActiveStatus")]
            [Validation(Required=false)]
            public string RightsActiveStatus { get; set; }

            /// <summary>
            /// <para>The time when the rights were activated. This value may be empty if the rights are not yet activated. The time is in RFC 3339 UTC format and ends with Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-06T01:00:00Z</para>
            /// </summary>
            [NameInMap("RightsActiveTime")]
            [Validation(Required=false)]
            public string RightsActiveTime { get; set; }

            /// <summary>
            /// <para>The end user to whom the rights are assigned. For convenience accounts, use EndUserId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user-example</para>
            /// </summary>
            [NameInMap("RightsAssignedUser")]
            [Validation(Required=false)]
            public string RightsAssignedUser { get; set; }

            /// <summary>
            /// <para>The deadline for manual activation of the rights. This is different from RightsResourceExpireTime, which is the expiration time of the resource after activation. The time is in RFC 3339 UTC format and ends with Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-12-06T00:00:00Z</para>
            /// </summary>
            [NameInMap("RightsExpireTime")]
            [Validation(Required=false)]
            public string RightsExpireTime { get; set; }

            /// <summary>
            /// <para>The GPU specification. Refer to the returned value in the rights details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eds.graphics_flagship_pro.8c16g.2g</para>
            /// </summary>
            [NameInMap("RightsGpuSpec")]
            [Validation(Required=false)]
            public string RightsGpuSpec { get; set; }

            /// <summary>
            /// <para>The rights ID. Use this value for activation. This is not the cloud computer resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>New_beds-example_0001</para>
            /// </summary>
            [NameInMap("RightsId")]
            [Validation(Required=false)]
            public string RightsId { get; set; }

            /// <summary>
            /// <para>The inventory specification corresponding to the rights.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eds.business_edition_office.4c8g</para>
            /// </summary>
            [NameInMap("RightsInventorySpec")]
            [Validation(Required=false)]
            public string RightsInventorySpec { get; set; }

            /// <summary>
            /// <para>The rights period code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BUSINESS_WEEK_1</para>
            /// </summary>
            [NameInMap("RightsPeriod")]
            [Validation(Required=false)]
            public string RightsPeriod { get; set; }

            /// <summary>
            /// <para>The area to which the rights belong. This cannot replace the resource region in a new activation request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-east</para>
            /// </summary>
            [NameInMap("RightsResourceArea")]
            [Validation(Required=false)]
            public string RightsResourceArea { get; set; }

            /// <summary>
            /// <para>The actual expiration time of the resource. This is different from the deadline for rights activation. The time is in RFC 3339 UTC format and ends with Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-12-06T01:00:00Z</para>
            /// </summary>
            [NameInMap("RightsResourceExpireTime")]
            [Validation(Required=false)]
            public string RightsResourceExpireTime { get; set; }

            /// <summary>
            /// <para>The ID of the resource associated with the rights. This value is returned after the resource is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecd-example</para>
            /// </summary>
            [NameInMap("RightsResourceId")]
            [Validation(Required=false)]
            public string RightsResourceId { get; set; }

            /// <summary>
            /// <para>The region ID of the resource. This is configured separately from the POP request routing region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RightsResourceRegion")]
            [Validation(Required=false)]
            public string RightsResourceRegion { get; set; }

            /// <summary>
            /// <para>The status of the associated resource. Refer to the returned value for the actual status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("RightsResourceStatus")]
            [Validation(Required=false)]
            public string RightsResourceStatus { get; set; }

            /// <summary>
            /// <para>The rights resource type. Use Desktop for regular cloud computers. For other commodities, specify the actual rights type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Desktop</para>
            /// </summary>
            [NameInMap("RightsResourceType")]
            [Validation(Required=false)]
            public string RightsResourceType { get; set; }

            /// <summary>
            /// <para>The name of the rights source.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Channel Service Provider Co., Ltd</para>
            /// </summary>
            [NameInMap("RightsSourceName")]
            [Validation(Required=false)]
            public string RightsSourceName { get; set; }

            /// <summary>
            /// <para>The rights specification code. Refer to the rights query results for the actual value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eds.business_edition_office.4c8g</para>
            /// </summary>
            [NameInMap("RightsSpec")]
            [Validation(Required=false)]
            public string RightsSpec { get; set; }

            /// <summary>
            /// <para>The size of the system cloud disk. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("SystemDiskSize")]
            [Validation(Required=false)]
            public int? SystemDiskSize { get; set; }

            /// <summary>
            /// <para>The list of value-added feature information associated with the rights.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("ValuePackageInfos")]
            [Validation(Required=false)]
            public List<ListRightsResponseBodyDataValuePackageInfos> ValuePackageInfos { get; set; }
            public class ListRightsResponseBodyDataValuePackageInfos : TeaModel {
                /// <summary>
                /// <para>The content of the value-added feature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Basic monitoring, real-time monitoring, session monitoring, and application control</para>
                /// </summary>
                [NameInMap("Function")]
                [Validation(Required=false)]
                public string Function { get; set; }

                /// <summary>
                /// <para>The value-added feature code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Monitor</para>
                /// </summary>
                [NameInMap("ValuePackageCode")]
                [Validation(Required=false)]
                public string ValuePackageCode { get; set; }

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
        /// <para>The maximum number of results per page. Specify a positive integer from 1 to 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The description of the processing result. This is used for troubleshooting when a failure occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request is processed successfully</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. An empty value indicates that the current query has ended. If the value is not empty, pass it exactly as it is in the next query. The example is for illustration purposes only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b5f4e3d2c1a09876b5f4e3d2c1a09876</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request. This is used to troubleshoot call issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A00000-0000-4000-8000-000000000001</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was processed successfully. A successful activation request does not mean that the resource has been created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of rights that meet the query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
