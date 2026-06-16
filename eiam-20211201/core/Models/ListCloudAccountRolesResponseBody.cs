// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListCloudAccountRolesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of cloud roles.</para>
        /// </summary>
        [NameInMap("CloudAccountRoles")]
        [Validation(Required=false)]
        public List<ListCloudAccountRolesResponseBodyCloudAccountRoles> CloudAccountRoles { get; set; }
        public class ListCloudAccountRolesResponseBodyCloudAccountRoles : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca_01kmegjc11qa1txxxxx</para>
            /// </summary>
            [NameInMap("CloudAccountId")]
            [Validation(Required=false)]
            public string CloudAccountId { get; set; }

            /// <summary>
            /// <para>The external ID for the cloud role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::xxx:role/role-test</para>
            /// </summary>
            [NameInMap("CloudAccountRoleExternalId")]
            [Validation(Required=false)]
            public string CloudAccountRoleExternalId { get; set; }

            /// <summary>
            /// <para>The health status of the cloud role. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>healthy: The role is healthy.</para>
            /// </description></item>
            /// <item><description><para>unhealthy: The role is unhealthy.</para>
            /// </description></item>
            /// <item><description><para>unknown: The health status is unknown.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>healthy</para>
            /// </summary>
            [NameInMap("CloudAccountRoleHealth")]
            [Validation(Required=false)]
            public string CloudAccountRoleHealth { get; set; }

            /// <summary>
            /// <para>The result of the health check for the cloud role.</para>
            /// </summary>
            [NameInMap("CloudAccountRoleHealthCheckResult")]
            [Validation(Required=false)]
            public ListCloudAccountRolesResponseBodyCloudAccountRolesCloudAccountRoleHealthCheckResult CloudAccountRoleHealthCheckResult { get; set; }
            public class ListCloudAccountRolesResponseBodyCloudAccountRolesCloudAccountRoleHealthCheckResult : TeaModel {
                /// <summary>
                /// <para>The reason for the error. This parameter is returned when the health check status is unhealthy.</para>
                /// </summary>
                [NameInMap("ErrorReason")]
                [Validation(Required=false)]
                public ListCloudAccountRolesResponseBodyCloudAccountRolesCloudAccountRoleHealthCheckResultErrorReason ErrorReason { get; set; }
                public class ListCloudAccountRolesResponseBodyCloudAccountRolesCloudAccountRoleHealthCheckResultErrorReason : TeaModel {
                    /// <summary>
                    /// <para>The error code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>AuthenticationFail.NoPermission</para>
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// <para>The error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>There is no permission.</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                }

                /// <summary>
                /// <para>The time of the last health check. This is a UNIX timestamp. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1649830226000</para>
                /// </summary>
                [NameInMap("LastCheckTime")]
                [Validation(Required=false)]
                public long? LastCheckTime { get; set; }

                /// <summary>
                /// <para>The result of the health check. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>success: The health check was successful.</para>
                /// </description></item>
                /// <item><description><para>failed: The health check failed.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

            }

            /// <summary>
            /// <para>The ID of the cloud role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>carole_01kmek49aqxxxx</para>
            /// </summary>
            [NameInMap("CloudAccountRoleId")]
            [Validation(Required=false)]
            public string CloudAccountRoleId { get; set; }

            /// <summary>
            /// <para>The name of the cloud role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>role-test</para>
            /// </summary>
            [NameInMap("CloudAccountRoleName")]
            [Validation(Required=false)]
            public string CloudAccountRoleName { get; set; }

            /// <summary>
            /// <para>The type of the cloud role. The format of the role type varies based on the type of the cloud account. The following value is supported:</para>
            /// <list type="bullet">
            /// <item><description>role: This value applies to Alibaba Cloud accounts.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>role</para>
            /// </summary>
            [NameInMap("CloudAccountRoleType")]
            [Validation(Required=false)]
            public string CloudAccountRoleType { get; set; }

            /// <summary>
            /// <para>The usage type of the cloud role. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>system: The role is used by the system.</para>
            /// </description></item>
            /// <item><description><para>user: The role is used by a user.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("CloudAccountRoleUsageType")]
            [Validation(Required=false)]
            public string CloudAccountRoleUsageType { get; set; }

            /// <summary>
            /// <para>The time when the role was created. This is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719320115000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the cloud role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_account_role_description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The status of the cloud role. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>enabled: The role is enabled.</para>
            /// </description></item>
            /// <item><description><para>disabled: The role is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the role was last updated. This is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719320117000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The query token returned in this call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
