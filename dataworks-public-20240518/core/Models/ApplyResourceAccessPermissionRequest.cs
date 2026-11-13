// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ApplyResourceAccessPermissionRequest : TeaModel {
        /// <summary>
        /// <para>The list of resource permission applications.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApplyContents")]
        [Validation(Required=false)]
        public List<ApplyResourceAccessPermissionRequestApplyContents> ApplyContents { get; set; }
        public class ApplyResourceAccessPermissionRequestApplyContents : TeaModel {
            /// <summary>
            /// <para>The list of requested permissions.</para>
            /// <para><b>Note</b>: The types of permissions that can be applied for vary across resources at different levels. All are constrained by <a href="https://www.alibabacloud.com/help/en/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.isValidLeaf, accessTypeRestrictions, and authMethodAccessTypes.</para>
            /// <para>Appendix: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation</a></para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("AccessTypes")]
            [Validation(Required=false)]
            public List<string> AccessTypes { get; set; }

            /// <summary>
            /// <para>The authorization method. Currently, only SEVERLESS_STARROCKS supports specifying the authorization method: ranger and starrocksManager.</para>
            /// <para><b>Note</b>: The authorization methods supported vary across resources. All are constrained by <a href="https://www.alibabacloud.com/help/en/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.authMethods.</para>
            /// <para>Appendix: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>ranger</para>
            /// </summary>
            [NameInMap("AuthMethod")]
            [Validation(Required=false)]
            public string AuthMethod { get; set; }

            /// <summary>
            /// <para>The expiration time of the permissions, specified as a millisecond timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1785835708000</para>
            /// </summary>
            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public long? ExpirationTime { get; set; }

            /// <summary>
            /// <para>The grantee description.</para>
            /// <para><b>Note</b>: The principal types supported by the system are constrained by <a href="https://www.alibabacloud.com/help/en/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.authPrincipal.</para>
            /// <para>Appendix: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation</a></para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Grantee")]
            [Validation(Required=false)]
            public ApplyResourceAccessPermissionRequestApplyContentsGrantee Grantee { get; set; }
            public class ApplyResourceAccessPermissionRequestApplyContentsGrantee : TeaModel {
                /// <summary>
                /// <para>The principal ID. The mapped IDs have different semantics for different principal types:</para>
                /// <list type="bullet">
                /// <item><description>RamUser: the DataWorks user ID.</description></item>
                /// <item><description>RamRole: the DataWorks user ID that starts with &quot;ROLE_&quot;.</description></item>
                /// <item><description>DlfRole: the DlfNext role name.</description></item>
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
                /// <item><description>RamRole</description></item>
                /// <item><description>RamUser</description></item>
                /// <item><description>DlfRole</description></item>
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
            /// <para>The resource description.</para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public ApplyResourceAccessPermissionRequestApplyContentsResource Resource { get; set; }
            public class ApplyResourceAccessPermissionRequestApplyContentsResource : TeaModel {
                /// <summary>
                /// <para>The resource type.</para>
                /// <para><b>Note</b>: The resource types supported by the system are constrained by <a href="https://www.alibabacloud.com/help/en/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.name.</para>
                /// <para>Appendix: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation</a></para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MaxCompute</para>
                /// </summary>
                [NameInMap("DefSchema")]
                [Validation(Required=false)]
                public string DefSchema { get; set; }

                /// <summary>
                /// <para>The resource parsing version is constrained by <a href="https://www.alibabacloud.com/help/en/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.version.</para>
                /// <para><a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation</a></para>
                /// 
                /// <b>Example:</b>
                /// <para>v1.0.0</para>
                /// </summary>
                [NameInMap("DefVersion")]
                [Validation(Required=false)]
                public string DefVersion { get; set; }

                /// <summary>
                /// <para>The resource metadata declaration.</para>
                /// <para><b>Note</b>: The metadata is constrained by <a href="https://www.alibabacloud.com/help/en/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.resources. A valid resource declaration must include metadata for the full resource path from level 0 through the validLeaf level.</para>
                /// <para>Appendix: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation</a></para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;workspace&quot;: &quot;449656&quot;, &quot;project&quot;: &quot;sync_destination&quot;, &quot;table&quot;: &quot;order_table&quot;, &quot;threeTierModel&quot;: false}</para>
                /// </summary>
                [NameInMap("MetaData")]
                [Validation(Required=false)]
                public Dictionary<string, object> MetaData { get; set; }

            }

        }

        /// <summary>
        /// <para>The idempotency token used to prevent duplicate operations caused by multiple calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABFUOEUOTRTRJKE</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The reason for the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business development requirements</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
