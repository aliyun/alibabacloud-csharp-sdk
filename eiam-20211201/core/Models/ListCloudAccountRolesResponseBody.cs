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
            /// <para>The cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca_01kmegjc11qa1txxxxx</para>
            /// </summary>
            [NameInMap("CloudAccountId")]
            [Validation(Required=false)]
            public string CloudAccountId { get; set; }

            /// <summary>
            /// <para>The cloud role identifier.</para>
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
            /// <item><description>healthy: healthy.</description></item>
            /// <item><description>unhealthy: unhealthy.</description></item>
            /// <item><description>unknown: unknown.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>healthy</para>
            /// </summary>
            [NameInMap("CloudAccountRoleHealth")]
            [Validation(Required=false)]
            public string CloudAccountRoleHealth { get; set; }

            /// <summary>
            /// <para>The health check result of the cloud role.</para>
            /// </summary>
            [NameInMap("CloudAccountRoleHealthCheckResult")]
            [Validation(Required=false)]
            public ListCloudAccountRolesResponseBodyCloudAccountRolesCloudAccountRoleHealthCheckResult CloudAccountRoleHealthCheckResult { get; set; }
            public class ListCloudAccountRolesResponseBodyCloudAccountRolesCloudAccountRoleHealthCheckResult : TeaModel {
                /// <summary>
                /// <para>The error reason. This field is returned when the health check status is unhealthy.</para>
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
                    /// <para>The error description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>There is no permission.</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                }

                /// <summary>
                /// <para>The last check time, in UNIX timestamp format. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1649830226000</para>
                /// </summary>
                [NameInMap("LastCheckTime")]
                [Validation(Required=false)]
                public long? LastCheckTime { get; set; }

                /// <summary>
                /// <para>The health check result of the cloud role. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>success: succeeded.</description></item>
                /// <item><description>failed: failed.</description></item>
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
            /// <para>The cloud role ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>carole_01kmek49aqxxxx</para>
            /// </summary>
            [NameInMap("CloudAccountRoleId")]
            [Validation(Required=false)]
            public string CloudAccountRoleId { get; set; }

            /// <summary>
            /// <para>The cloud role name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>role-test</para>
            /// </summary>
            [NameInMap("CloudAccountRoleName")]
            [Validation(Required=false)]
            public string CloudAccountRoleName { get; set; }

            /// <summary>
            /// <para>The cloud role type. The specific format depends on the cloud account type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>role: applicable to Alibaba Cloud accounts.</description></item>
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
            /// <item><description>system: system.</description></item>
            /// <item><description>user: user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("CloudAccountRoleUsageType")]
            [Validation(Required=false)]
            public string CloudAccountRoleUsageType { get; set; }

            /// <summary>
            /// <para>The creation time, in UNIX timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719320115000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The cloud role description.</para>
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
            /// <para>The cloud role status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>enabled: enabled.</description></item>
            /// <item><description>disable: disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The last update time, in UNIX timestamp format. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1719320117000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The number of rows per page in the paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token returned in this call.</para>
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
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
