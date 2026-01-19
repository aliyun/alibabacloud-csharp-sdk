// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListCloudAccountRolesResponseBody : TeaModel {
        [NameInMap("CloudAccountRoles")]
        [Validation(Required=false)]
        public List<ListCloudAccountRolesResponseBodyCloudAccountRoles> CloudAccountRoles { get; set; }
        public class ListCloudAccountRolesResponseBodyCloudAccountRoles : TeaModel {
            /// <summary>
            /// <para>云账号ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>ca_01kmegjc11qa1txxxxx</para>
            /// </summary>
            [NameInMap("CloudAccountId")]
            [Validation(Required=false)]
            public string CloudAccountId { get; set; }

            /// <summary>
            /// <para>云账号角色外部唯一ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::xxx:role/role-test</para>
            /// </summary>
            [NameInMap("CloudAccountRoleExternalId")]
            [Validation(Required=false)]
            public string CloudAccountRoleExternalId { get; set; }

            /// <summary>
            /// <para>云账号角色可用性</para>
            /// 
            /// <b>Example:</b>
            /// <para>healthy</para>
            /// </summary>
            [NameInMap("CloudAccountRoleHealth")]
            [Validation(Required=false)]
            public string CloudAccountRoleHealth { get; set; }

            [NameInMap("CloudAccountRoleHealthCheckResult")]
            [Validation(Required=false)]
            public ListCloudAccountRolesResponseBodyCloudAccountRolesCloudAccountRoleHealthCheckResult CloudAccountRoleHealthCheckResult { get; set; }
            public class ListCloudAccountRolesResponseBodyCloudAccountRolesCloudAccountRoleHealthCheckResult : TeaModel {
                [NameInMap("ErrorReason")]
                [Validation(Required=false)]
                public ListCloudAccountRolesResponseBodyCloudAccountRolesCloudAccountRoleHealthCheckResultErrorReason ErrorReason { get; set; }
                public class ListCloudAccountRolesResponseBodyCloudAccountRolesCloudAccountRoleHealthCheckResultErrorReason : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>AuthenticationFail.NoPermission</para>
                    /// </summary>
                    [NameInMap("ErrorCode")]
                    [Validation(Required=false)]
                    public string ErrorCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>There is no permission.</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1649830226000</para>
                /// </summary>
                [NameInMap("LastCheckTime")]
                [Validation(Required=false)]
                public long? LastCheckTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public string Result { get; set; }

            }

            /// <summary>
            /// <para>云账号角色ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>carole_01kmek49aqxxxx</para>
            /// </summary>
            [NameInMap("CloudAccountRoleId")]
            [Validation(Required=false)]
            public string CloudAccountRoleId { get; set; }

            /// <summary>
            /// <para>云账号名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>role-test</para>
            /// </summary>
            [NameInMap("CloudAccountRoleName")]
            [Validation(Required=false)]
            public string CloudAccountRoleName { get; set; }

            /// <summary>
            /// <para>云账号角色用途</para>
            /// 
            /// <b>Example:</b>
            /// <para>role</para>
            /// </summary>
            [NameInMap("CloudAccountRoleType")]
            [Validation(Required=false)]
            public string CloudAccountRoleType { get; set; }

            /// <summary>
            /// <para>云账号角色类别</para>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("CloudAccountRoleUsageType")]
            [Validation(Required=false)]
            public string CloudAccountRoleUsageType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1719320115000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>云账号描述</para>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_account_role_description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>IDaaS EIAM 实例Id</para>
            /// 
            /// <b>Example:</b>
            /// <para>idaas_ue2jvisn35ea5lmthk267xxxxx</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>云账号角色状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>enabled</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1719320117000</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>分页查询时每页行数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>本次调用返回的查询凭证（Token）值，用于下一次翻页查询。</para>
        /// 
        /// <b>Example:</b>
        /// <para>NTxxxexample</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0441BD79-92F3-53AA-8657-F8CE4A2B912A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
