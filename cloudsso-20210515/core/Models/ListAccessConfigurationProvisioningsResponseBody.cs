// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class ListAccessConfigurationProvisioningsResponseBody : TeaModel {
        /// <summary>
        /// <para>The accounts for which the access configuration is provisioned.</para>
        /// </summary>
        [NameInMap("AccessConfigurationProvisionings")]
        [Validation(Required=false)]
        public List<ListAccessConfigurationProvisioningsResponseBodyAccessConfigurationProvisionings> AccessConfigurationProvisionings { get; set; }
        public class ListAccessConfigurationProvisioningsResponseBodyAccessConfigurationProvisionings : TeaModel {
            /// <summary>
            /// <para>The ID of the access configuration.</para>
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
            /// <para>The first time when the access configuration was provisioned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-26T08:54:14Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The name of the custom policy that is created for an account in the resource directory.</para>
            /// </summary>
            [NameInMap("RAMPolicyNames")]
            [Validation(Required=false)]
            public List<string> RAMPolicyNames { get; set; }

            /// <summary>
            /// <para>The name of the RAM role that is created for an account in the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunReservedSSO-VPC-Admin</para>
            /// </summary>
            [NameInMap("RAMRoleName")]
            [Validation(Required=false)]
            public string RAMRoleName { get; set; }

            /// <summary>
            /// <para>The name of the Security Assertion Markup Language (SAML) identity provider (IdP) that is created within an account in the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AliyunReservedSSO-d-00fc2p61****</para>
            /// </summary>
            [NameInMap("SAMLProviderName")]
            [Validation(Required=false)]
            public string SAMLProviderName { get; set; }

            /// <summary>
            /// <para>The status of the access configuration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Provisioned: The access configuration is provisioned.</description></item>
            /// <item><description>ReprovisionRequired: The access configuration needs to be re-provisioned.</description></item>
            /// <item><description>DeprovisionFailed: The access configuration failed to be provisioned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Provisioned</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the task object.</para>
            /// <para>If the value of TargetType is <c>RD-Account</c>, the value of this parameter is the UID of an account in the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>101522521960****</para>
            /// </summary>
            [NameInMap("TargetId")]
            [Validation(Required=false)]
            public string TargetId { get; set; }

            /// <summary>
            /// <para>The name of the task object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SharedServices_5009****</para>
            /// </summary>
            [NameInMap("TargetName")]
            [Validation(Required=false)]
            public string TargetName { get; set; }

            /// <summary>
            /// <para>The path ID of the task object in the resource directory.</para>
            /// </summary>
            [NameInMap("TargetPath")]
            [Validation(Required=false)]
            public string TargetPath { get; set; }

            /// <summary>
            /// <para>The path name of the task object in the resource directory.</para>
            /// </summary>
            [NameInMap("TargetPathName")]
            [Validation(Required=false)]
            public string TargetPathName { get; set; }

            /// <summary>
            /// <para>The type of the task object.</para>
            /// <para>Set the value to RD-Account, which specifies the accounts in the resource directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RD-Account</para>
            /// </summary>
            [NameInMap("TargetType")]
            [Validation(Required=false)]
            public string TargetType { get; set; }

            /// <summary>
            /// <para>The last time when the access configuration was provisioned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-26T08:54:18Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the queried entries are truncated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>The maximum number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results.</para>
        /// <remarks>
        /// <para> This parameter is returned only when the value of <c>IsTruncated</c> is <c>true</c>.</para>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCounts")]
        [Validation(Required=false)]
        public int? TotalCounts { get; set; }

    }

}
