// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ApplyResourceAccessPermissionRequest : TeaModel {
        /// <summary>
        /// <para>A list of permission requests.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApplyContents")]
        [Validation(Required=false)]
        public List<ApplyResourceAccessPermissionRequestApplyContents> ApplyContents { get; set; }
        public class ApplyResourceAccessPermissionRequestApplyContents : TeaModel {
            /// <summary>
            /// <para>The requested permissions.</para>
            /// <para>Note: The supported permission types vary by resource level and are constrained by the <c>ResourceSchema</c> of the corresponding resource type.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("AccessTypes")]
            [Validation(Required=false)]
            public List<string> AccessTypes { get; set; }

            /// <summary>
            /// <para>The authorization method.</para>
            /// <para>Note: This parameter is supported only for <c>SEVERLESS_STARROCKS</c> resources. Valid values are <c>ranger</c> and <c>starrocksManager</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ranger</para>
            /// </summary>
            [NameInMap("AuthMethod")]
            [Validation(Required=false)]
            public string AuthMethod { get; set; }

            /// <summary>
            /// <para>The permission expiration time, as a Unix timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1785835708000</para>
            /// </summary>
            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public long? ExpirationTime { get; set; }

            /// <summary>
            /// <para>The principal to which permissions are granted.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Grantee")]
            [Validation(Required=false)]
            public ApplyResourceAccessPermissionRequestApplyContentsGrantee Grantee { get; set; }
            public class ApplyResourceAccessPermissionRequestApplyContentsGrantee : TeaModel {
                /// <summary>
                /// <para>The ID of the principal. The value of this parameter depends on the <c>PrincipalType</c>:</para>
                /// <list type="bullet">
                /// <item><description><para><c>RamUser</c>: The Dataworks user ID.</para>
                /// </description></item>
                /// <item><description><para><c>RamRole</c>: The Dataworks user ID, prefixed with <c>ROLE_</c>.</para>
                /// </description></item>
                /// <item><description><para><c>DlfRole</c>: The DlfNext role name.</para>
                /// </description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ROLE_32237475848545</para>
                /// </summary>
                [NameInMap("PrincipalId")]
                [Validation(Required=false)]
                public string PrincipalId { get; set; }

                /// <summary>
                /// <para>The principal type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>RamRole</para>
                /// </description></item>
                /// <item><description><para>RamUser</para>
                /// </description></item>
                /// <item><description><para>DlfRole</para>
                /// </description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RamRole</para>
                /// </summary>
                [NameInMap("PrincipalType")]
                [Validation(Required=false)]
                public string PrincipalType { get; set; }

            }

            /// <summary>
            /// <para>The resource for which permissions are requested.</para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public ApplyResourceAccessPermissionRequestApplyContentsResource Resource { get; set; }
            public class ApplyResourceAccessPermissionRequestApplyContentsResource : TeaModel {
                /// <summary>
                /// <para>The resource type.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MaxCompute</para>
                /// </summary>
                [NameInMap("DefSchema")]
                [Validation(Required=false)]
                public string DefSchema { get; set; }

                /// <summary>
                /// <para>The version of <c>ResourceSchema</c> that is required to parse the resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1.0.0</para>
                /// </summary>
                [NameInMap("DefVersion")]
                [Validation(Required=false)]
                public string DefVersion { get; set; }

                /// <summary>
                /// <para>The resource metadata. The content is constrained by <c>ResourceSchema</c>.</para>
                /// </summary>
                [NameInMap("MetaData")]
                [Validation(Required=false)]
                public Dictionary<string, object> MetaData { get; set; }

            }

        }

        /// <summary>
        /// <para>The idempotency parameter, which prevents duplicate operations from repeated calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABFUOEUOTRTRJKE</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The reason for the request.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>业务发展需要</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
