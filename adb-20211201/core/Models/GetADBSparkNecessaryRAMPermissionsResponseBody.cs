// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetADBSparkNecessaryRAMPermissionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetADBSparkNecessaryRAMPermissionsResponseBodyData Data { get; set; }
        public class GetADBSparkNecessaryRAMPermissionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The diagnostic information returned when the permission check fails.</para>
            /// </summary>
            [NameInMap("DeniedDetail")]
            [Validation(Required=false)]
            public GetADBSparkNecessaryRAMPermissionsResponseBodyDataDeniedDetail DeniedDetail { get; set; }
            public class GetADBSparkNecessaryRAMPermissionsResponseBodyDataDeniedDetail : TeaModel {
                /// <summary>
                /// <para>The name of the RAM action for which authentication failed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ListSparkApps</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The type of access policy denial. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ImplicitDeny: The resource owner has not configured a relevant access policy for the current user. Unauthorized operations are denied by default.</description></item>
                /// <item><description>ExplicitDeny: The RAM policy configured by the resource owner explicitly denies the current user authorization to access the corresponding resource.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ImplicitDeny</para>
                /// </summary>
                [NameInMap("NoPermissionType")]
                [Validation(Required=false)]
                public string NoPermissionType { get; set; }

                /// <summary>
                /// <para>The type of the policy that caused the permission denial. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ControlPolicy: control policy.</description></item>
                /// <item><description>SessionPolicy: an additional permission policy attached to a temporary token.</description></item>
                /// <item><description>AssumeRolePolicy: the trust policy of a RAM role.</description></item>
                /// <item><description>AccountLevelIdentityBasedPolicy: an identity-access policy at the account authorization scope, including custom policies and system policies.</description></item>
                /// <item><description>ResourceGroupLevelIdentityBasedPolicy: an identity-access policy at the resource group authorization scope, including custom policies and system policies.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ControlPolicy</para>
                /// </summary>
                [NameInMap("PolicyType")]
                [Validation(Required=false)]
                public string PolicyType { get; set; }

                /// <summary>
                /// <para>The identity type of the current user. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SubUser: Resource Access Management (RAM) user.</description></item>
                /// <item><description>AssumedRoleUser: RAM role.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SubUser</para>
                /// </summary>
                [NameInMap("PrincipalType")]
                [Validation(Required=false)]
                public string PrincipalType { get; set; }

                /// <summary>
                /// <para>The information about the authentication target, which can be the Resource Access Management (RAM) users ID of the current user or the role information of the current accessor.</para>
                /// 
                /// <b>Example:</b>
                /// <para>223345695632****</para>
                /// </summary>
                [NameInMap("ResourceAuthTargetInfo")]
                [Validation(Required=false)]
                public string ResourceAuthTargetInfo { get; set; }

                /// <summary>
                /// <para>The ID of the resource owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11685695632****</para>
                /// </summary>
                [NameInMap("ResourceOwnerId")]
                [Validation(Required=false)]
                public string ResourceOwnerId { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the current user has the basic permissions to use ADB Spark. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The check is passed. The user has the basic permissions.</description></item>
            /// <item><description>false: The check failed. The user is missing some permissions.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public bool? Passed { get; set; }

            /// <summary>
            /// <para>The recommended RAM configuration based on the diagnostic information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Grant the system RAM policy \&quot;AliyunADBDeveloperAccess\&quot; to current RAM user can quickly solve this issue.</para>
            /// </summary>
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>642F3512-C628-5D0C-8815-F6670C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
