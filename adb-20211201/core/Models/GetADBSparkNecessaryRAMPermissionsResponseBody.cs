// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class GetADBSparkNecessaryRAMPermissionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetADBSparkNecessaryRAMPermissionsResponseBodyData Data { get; set; }
        public class GetADBSparkNecessaryRAMPermissionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>When permission check fails, returns diagnostic information related to permission check failure.</para>
            /// </summary>
            [NameInMap("DeniedDetail")]
            [Validation(Required=false)]
            public GetADBSparkNecessaryRAMPermissionsResponseBodyDataDeniedDetail DeniedDetail { get; set; }
            public class GetADBSparkNecessaryRAMPermissionsResponseBodyDataDeniedDetail : TeaModel {
                /// <summary>
                /// <para>The name of the RAM action that failed the authentication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ListSparkApps</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The type of the policy denial. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ImplicitDeny: Resource owner has not configured relevant permission policies for the current user, default denial of unauthorized operations.</description></item>
                /// <item><description>ExplicitDeny: RAM policies configured by the resource owner explicitly deny the current user access to corresponding resources</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ImplicitDeny</para>
                /// </summary>
                [NameInMap("NoPermissionType")]
                [Validation(Required=false)]
                public string NoPermissionType { get; set; }

                /// <summary>
                /// <para>The type of the policy that causes the access denied error.</para>
                /// <list type="bullet">
                /// <item><description>ControlPolicy: control policy</description></item>
                /// <item><description>SessionPolicy: Temporary Token additional permission policy</description></item>
                /// <item><description>AssumeRolePolicy: RAM role trust policy</description></item>
                /// <item><description>AccountLevelIdentityBasedPolicy: Principal policy within account authorization scope, including custom policies and system policies</description></item>
                /// <item><description>ResourceGroupLevelIdentityBasedPolicy: Principal policy within resource group authorization scope, including custom policies and system policies.</description></item>
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
                /// <item><description>SubUser: a RAM user</description></item>
                /// <item><description>AssumedRoleUser: a RAM role</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SubUser</para>
                /// </summary>
                [NameInMap("PrincipalType")]
                [Validation(Required=false)]
                public string PrincipalType { get; set; }

                /// <summary>
                /// <para>Authentication object information, can be the current user\&quot;s RAM account ID, or the role information corresponding to the current visitor.</para>
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
            /// <para>Check whether the use has the basic permissions to use Analytic DB for Spark.</para>
            /// <list type="bullet">
            /// <item><description>true: The check is passed and the basic permissions are granted.</description></item>
            /// <item><description>false: The check fails and some permissions are missing.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Passed")]
            [Validation(Required=false)]
            public bool? Passed { get; set; }

            /// <summary>
            /// <para>Based on diagnostic information, recommends configurations for customers to perform in the RAM system.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Grant the system RAM policy \&quot;AliyunADBDeveloperAccess\&quot; to current RAM user can quickly solve this issue.</para>
            /// </summary>
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>642F3512-C628-5D0C-8815-F6670C****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
