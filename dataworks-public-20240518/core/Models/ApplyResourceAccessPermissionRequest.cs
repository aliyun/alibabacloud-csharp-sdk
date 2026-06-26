// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ApplyResourceAccessPermissionRequest : TeaModel {
        /// <summary>
        /// <para>The list of resource permission application contents.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApplyContents")]
        [Validation(Required=false)]
        public List<ApplyResourceAccessPermissionRequestApplyContents> ApplyContents { get; set; }
        public class ApplyResourceAccessPermissionRequestApplyContents : TeaModel {
            /// <summary>
            /// <para>The list of permissions to apply for.</para>
            /// <para><b>Note</b>: Different resource levels support different permission types. They are uniformly constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.isValidLeaf, accessTypeRestrictions, and authMethodAccessTypes.</para>
            /// <para>Appendix: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for international site</a></para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("AccessTypes")]
            [Validation(Required=false)]
            public List<string> AccessTypes { get; set; }

            /// <summary>
            /// <para>The authorization method. Currently, only SEVERLESS_STARROCKS supports specifying the authorization method: ranger or starrocksManager.</para>
            /// <para><b>Note</b>: Different resources support different authorization methods, which are uniformly constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.authMethods.</para>
            /// <para>Appendix: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for international site</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>ranger</para>
            /// </summary>
            [NameInMap("AuthMethod")]
            [Validation(Required=false)]
            public string AuthMethod { get; set; }

            /// <summary>
            /// <para>The permission expiration time, in milliseconds timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1785835708000</para>
            /// </summary>
            [NameInMap("ExpirationTime")]
            [Validation(Required=false)]
            public long? ExpirationTime { get; set; }

            /// <summary>
            /// <para>The grantee description.</para>
            /// <para><b>Note</b>: The supported grantee types are constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.authPrincipal.</para>
            /// <para>Appendix: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for international site</a></para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Grantee")]
            [Validation(Required=false)]
            public ApplyResourceAccessPermissionRequestApplyContentsGrantee Grantee { get; set; }
            public class ApplyResourceAccessPermissionRequestApplyContentsGrantee : TeaModel {
                /// <summary>
                /// <para>The grantee ID. The ID has different semantics depending on the grantee type:</para>
                /// <list type="bullet">
                /// <item><description><para>RamUser: Dataworks UserId</para>
                /// </description></item>
                /// <item><description><para>RamRole: Dataworks UserId prefixed with &quot;ROLE_&quot;</para>
                /// </description></item>
                /// <item><description><para>DlfRole: DlfNext role name</para>
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
                /// <para>The grantee type. Valid values:</para>
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
                /// <para><b>Note</b>: The resource types supported for application are constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.name.</para>
                /// <para>Appendix: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for international site</a></para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MaxCompute</para>
                /// </summary>
                [NameInMap("DefSchema")]
                [Validation(Required=false)]
                public string DefSchema { get; set; }

                /// <summary>
                /// <para>The resource parsing version, which is constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.version.</para>
                /// <para><a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for international site</a></para>
                /// 
                /// <b>Example:</b>
                /// <para>v1.0.0</para>
                /// </summary>
                [NameInMap("DefVersion")]
                [Validation(Required=false)]
                public string DefVersion { get; set; }

                /// <summary>
                /// <para>The resource metadata declaration.</para>
                /// <para><b>Note</b>: The metadata is constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.resources. A valid resource declaration must include full-path metadata declarations from level 0 to validLeaf.</para>
                /// <para>Appendix: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation for international site</a></para>
                /// </summary>
                [NameInMap("MetaData")]
                [Validation(Required=false)]
                public Dictionary<string, object> MetaData { get; set; }

            }

        }

        /// <summary>
        /// <para>The idempotency parameter. Used to prevent duplicate operations caused by multiple calls.</para>
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
        /// <para>业务发展需要</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
