// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListAccessConfigurationProvisioningsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of access configuration provisionings.</para>
        /// </summary>
        [NameInMap("AccessConfigurationProvisionings")]
        [Validation(Required=false)]
        public List<ListAccessConfigurationProvisioningsResponseBodyAccessConfigurationProvisionings> AccessConfigurationProvisionings { get; set; }
        public class ListAccessConfigurationProvisioningsResponseBodyAccessConfigurationProvisionings : TeaModel {
            /// <summary>
            /// <para>The access configuration ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ac-00ccule7tadaijxc****</para>
            /// </summary>
            [NameInMap("AccessConfigurationId")]
            [Validation(Required=false)]
            public string AccessConfigurationId { get; set; }

            /// <summary>
            /// <para>The name of the access configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC-Admin</para>
            /// </summary>
            [NameInMap("AccessConfigurationName")]
            [Validation(Required=false)]
            public string AccessConfigurationName { get; set; }

            /// <summary>
            /// <para>The time when the first provisioning succeeded. The time is displayed in UTC and follows the RFC 3339 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-26T08:54:14Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID of the provisioning target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>114240524784****</para>
            /// </summary>
            [NameInMap("OriginTargetId")]
            [Validation(Required=false)]
            public string OriginTargetId { get; set; }

            /// <summary>
            /// <para>The Policy Name of the custom policy created in the account in a resource directory.</para>
            /// </summary>
            [NameInMap("RAMPolicyNames")]
            [Validation(Required=false)]
            public List<string> RAMPolicyNames { get; set; }

            /// <summary>
            /// <para>The name of the RAM role created in the account in a resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunReservedSSO-VPC-Admin</para>
            /// </summary>
            [NameInMap("RAMRoleName")]
            [Validation(Required=false)]
            public string RAMRoleName { get; set; }

            /// <summary>
            /// <para>The name of the SAML IdP created in the account in a resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunReservedSSO-d-00fc2p61****</para>
            /// </summary>
            [NameInMap("SAMLProviderName")]
            [Validation(Required=false)]
            public string SAMLProviderName { get; set; }

            /// <summary>
            /// <para>The provisioning status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Provisioned: The provisioning succeeded.</description></item>
            /// <item><description>ReprovisionRequired: Reprovisioning is required.</description></item>
            /// <item><description>DeprovisionFailed: The provisioning failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Provisioned</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The target ID.</para>
            /// <para>If the target type is RD-Account, this parameter indicates the UID of the account in a resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101522521960****</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The name of the target.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SharedServices_5009****</para>
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// <para>The path ID of the target in the resource directory.</para>
            /// </summary>
            [NameInMap("TargetPath")]
            [Validation(Required=false)]
            public string TargetPath { get; set; }

            /// <summary>
            /// <para>The path name of the target in the resource directory.</para>
            /// </summary>
            [NameInMap("TargetPathName")]
            [Validation(Required=false)]
            public string TargetPathName { get; set; }

            /// <summary>
            /// <para>The target type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RD-Account: The target is an account in a resource directory.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RD-Account</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The time when the latest provisioning succeeded. The time is displayed in UTC and follows the RFC 3339 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-26T08:54:18Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the returned results are truncated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The results are truncated.</description></item>
        /// <item><description>false: The results are not truncated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to return the next page of query results.</para>
        /// <remarks>
        /// <para>This parameter is returned only when IsTruncated is set to true.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>K1c3o9K7pFxoTtxH1Nm7MMLb7zrDGvftYBQBPDVv7AD3a8yhRb3Mk8L9ivmN6bFSjfkZNTAg3h4****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6BA1BDF1-D845-5D2C-B742-74BE2970E4C1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that meet the filter conditions specified in the request parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public int? TotalCounts { get; set; }

    }

}
