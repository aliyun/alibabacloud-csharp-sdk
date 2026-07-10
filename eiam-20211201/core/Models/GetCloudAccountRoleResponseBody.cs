// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class GetCloudAccountRoleResponseBody : TeaModel {
        /// <summary>
        /// <para>The cloud role details.</para>
        /// </summary>
        [NameInMap("CloudAccountRole")]
        [Validation(Required=false)]
        public GetCloudAccountRoleResponseBodyCloudAccountRole CloudAccountRole { get; set; }
        public class GetCloudAccountRoleResponseBodyCloudAccountRole : TeaModel {
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
            /// <para>The cloud role health status. Valid values:</para>
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
            /// <para>The cloud role health check result.</para>
            /// </summary>
            [NameInMap("CloudAccountRoleHealthCheckResult")]
            [Validation(Required=false)]
            public GetCloudAccountRoleResponseBodyCloudAccountRoleCloudAccountRoleHealthCheckResult CloudAccountRoleHealthCheckResult { get; set; }
            public class GetCloudAccountRoleResponseBodyCloudAccountRoleCloudAccountRoleHealthCheckResult : TeaModel {
                /// <summary>
                /// <para>The error reason. This field is returned when the health check status is unhealthy.</para>
                /// </summary>
                [NameInMap("ErrorReason")]
                [Validation(Required=false)]
                public GetCloudAccountRoleResponseBodyCloudAccountRoleCloudAccountRoleHealthCheckResultErrorReason ErrorReason { get; set; }
                public class GetCloudAccountRoleResponseBodyCloudAccountRoleCloudAccountRoleHealthCheckResultErrorReason : TeaModel {
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
                /// <para>The time of the last health check. The value is a UNIX timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1649830226000</para>
                /// </summary>
                [NameInMap("LastCheckTime")]
                [Validation(Required=false)]
                public long? LastCheckTime { get; set; }

                /// <summary>
                /// <para>The cloud role health check result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>success: succeeded.</para>
                /// </description></item>
                /// <item><description><para>failed: failed.</para>
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
            /// <para>The cloud role usage type. Valid values:</para>
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
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
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
            /// <para>The last update time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1649830227000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
