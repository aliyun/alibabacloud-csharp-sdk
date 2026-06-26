// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetApplicationContentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The process instance and associated application content.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetApplicationContentsResponseBodyData Data { get; set; }
        public class GetApplicationContentsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the application was submitted, as a millisecond timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1779675618000</para>
            /// </summary>
            [NameInMap("ApplicationTime")]
            [Validation(Required=false)]
            public long? ApplicationTime { get; set; }

            /// <summary>
            /// <para>The list of application contents.</para>
            /// </summary>
            [NameInMap("Contents")]
            [Validation(Required=false)]
            public List<GetApplicationContentsResponseBodyDataContents> Contents { get; set; }
            public class GetApplicationContentsResponseBodyDataContents : TeaModel {
                /// <summary>
                /// <para>The list of requested permissions.</para>
                /// <para>Note: Different levels of resources support different permission application types, all constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.isValidLeaf, accessTypeRestrictions, and authMethodAccessTypes.</para>
                /// <para>See also: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation on the international site</a></para>
                /// </summary>
                [NameInMap("AccessTypes")]
                [Validation(Required=false)]
                public List<string> AccessTypes { get; set; }

                /// <summary>
                /// <para>The authorization method. Currently, only SEVERLESS_STARROCKS supports specifying the authorization method: ranger or starrocksManager.</para>
                /// <para>Note: Different resources support different authorization methods, all constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.authMethods.</para>
                /// <para>See also: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation on the international site</a></para>
                /// 
                /// <b>Example:</b>
                /// <para>ranger</para>
                /// </summary>
                [NameInMap("AuthMethod")]
                [Validation(Required=false)]
                public string AuthMethod { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1773972024000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// <para>Note: The resource types supported for applications are constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.name.</para>
                /// <para>See also: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation on the international site</a></para>
                /// 
                /// <b>Example:</b>
                /// <para>MaxCompute</para>
                /// </summary>
                [NameInMap("DefSchema")]
                [Validation(Required=false)]
                public string DefSchema { get; set; }

                /// <summary>
                /// <para>The permission expiration date, as a millisecond timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1785835708000</para>
                /// </summary>
                [NameInMap("ExpirationTime")]
                [Validation(Required=false)]
                public long? ExpirationTime { get; set; }

                /// <summary>
                /// <para>The list of resource operation permissions that are finally approved.</para>
                /// </summary>
                [NameInMap("FinalAccessTypes")]
                [Validation(Required=false)]
                public List<string> FinalAccessTypes { get; set; }

                /// <summary>
                /// <para>The grantee description.</para>
                /// <para>Note: The grantee principal types supported by the system are constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.authPrincipal.</para>
                /// <para>See also: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation on the international site</a></para>
                /// </summary>
                [NameInMap("Grantee")]
                [Validation(Required=false)]
                public GetApplicationContentsResponseBodyDataContentsGrantee Grantee { get; set; }
                public class GetApplicationContentsResponseBodyDataContentsGrantee : TeaModel {
                    /// <summary>
                    /// <para>The grantee principal ID. The ID has different meanings depending on the principal type:</para>
                    /// <list type="bullet">
                    /// <item><description><para>RamUser: DataWorks UserId.</para>
                    /// </description></item>
                    /// <item><description><para>RamRole: DataWorks UserId prefixed with &quot;ROLE_&quot;.</para>
                    /// </description></item>
                    /// <item><description><para>DlfRole: DlfNext role name.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ROLE_3133343434</para>
                    /// </summary>
                    [NameInMap("PrincipalId")]
                    [Validation(Required=false)]
                    public string PrincipalId { get; set; }

                    /// <summary>
                    /// <para>The grantee principal type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>RamUser</description></item>
                    /// <item><description>RamRole</description></item>
                    /// <item><description>DlfRole</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RamRole</para>
                    /// </summary>
                    [NameInMap("PrincipalType")]
                    [Validation(Required=false)]
                    public string PrincipalType { get; set; }

                }

                /// <summary>
                /// <para>The unique identifier of the application content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y9H7AKFmjhWzLYdZNDZA5</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The approval process instance ID of the submitted application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>777799223</para>
                /// </summary>
                [NameInMap("ProcessInstanceId")]
                [Validation(Required=false)]
                public string ProcessInstanceId { get; set; }

                /// <summary>
                /// <para>The resource declaration. The resource description is constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.</para>
                /// <para>See also: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation on the international site</a></para>
                /// </summary>
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public GetApplicationContentsResponseBodyDataContentsResource Resource { get; set; }
                public class GetApplicationContentsResponseBodyDataContentsResource : TeaModel {
                    /// <summary>
                    /// <para>The resource type.</para>
                    /// <para>Note: The resource types supported for applications are constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.name.</para>
                    /// <para>See also: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation on the international site</a></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MaxCompute</para>
                    /// </summary>
                    [NameInMap("DefSchema")]
                    [Validation(Required=false)]
                    public string DefSchema { get; set; }

                    /// <summary>
                    /// <para>The resource parsing version, which is constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.version.</para>
                    /// <para>See also: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation on the international site</a></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v1.0.0</para>
                    /// </summary>
                    [NameInMap("DefVersion")]
                    [Validation(Required=false)]
                    public string DefVersion { get; set; }

                    /// <summary>
                    /// <para>The resource metadata declaration.</para>
                    /// <para>Note: The metadata is constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.resources. A valid resource declaration must include the full-path metadata declaration from level 0 to the validLeaf level.</para>
                    /// <para>See also: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation on the international site</a></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;{\&quot;schema\&quot;:\&quot;default\&quot;,\&quot;threeTierModel\&quot;:false,\&quot;workspace\&quot;:\&quot;449656\&quot;,\&quot;project\&quot;:\&quot;sync_destination\&quot;,\&quot;table\&quot;:\&quot;order_table\&quot;,\&quot;tenant\&quot;:\&quot;524997424564736\&quot;}&quot;</para>
                    /// </summary>
                    [NameInMap("MetaData")]
                    [Validation(Required=false)]
                    public string MetaData { get; set; }

                }

                /// <summary>
                /// <para>The minimum-permission resource type.</para>
                /// <para>Note: The minimum-permission resource type is constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.resources[*].isValidLeaf being true.</para>
                /// <para>See also: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation on the international site</a></para>
                /// 
                /// <b>Example:</b>
                /// <para>table</para>
                /// </summary>
                [NameInMap("ResourceName")]
                [Validation(Required=false)]
                public string ResourceName { get; set; }

                /// <summary>
                /// <para>The approval status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>WaitApproval: Pending approval.</description></item>
                /// <item><description>Confirmed: Pending authorization.</description></item>
                /// <item><description>RejectApproval: Approval rejected.</description></item>
                /// <item><description>AuthorizeSucceed: Authorization succeeded.</description></item>
                /// <item><description>AuthorizeFailed: Authorization failed.</description></item>
                /// <item><description>Deleted: Deleted.</description></item>
                /// <item><description>Canceled: Canceled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Deleted</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The tenant ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>69973837489</para>
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public string TenantId { get; set; }

                /// <summary>
                /// <para>The update time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1773972024000</para>
                /// </summary>
                [NameInMap("UpdateTime")]
                [Validation(Required=false)]
                public long? UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The resource type.</para>
            /// <para>Note: The resource types supported for applications are constrained by <a href="https://help.aliyun.com/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema</a>.name.</para>
            /// <para>See also: <a href="https://www.alibabacloud.com/help/zh/dataworks/developer-reference/resourceschema-template-instructions">ResourceSchema documentation on the international site</a></para>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("DefSchema")]
            [Validation(Required=false)]
            public string DefSchema { get; set; }

            /// <summary>
            /// <para>The process instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>332066440109224007</para>
            /// </summary>
            [NameInMap("ProcessInstanceId")]
            [Validation(Required=false)]
            public string ProcessInstanceId { get; set; }

            /// <summary>
            /// <para>The application reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>业务需要</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The approval status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>WaitApproval: Pending approval.</description></item>
            /// <item><description>Confirmed: Pending authorization.</description></item>
            /// <item><description>RejectApproval: Approval rejected.</description></item>
            /// <item><description>AuthorizeSucceed: Authorization succeeded.</description></item>
            /// <item><description>AuthorizeFailed: Authorization failed.</description></item>
            /// <item><description>Deleted: Deleted.</description></item>
            /// <item><description>Canceled: Canceled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WaitApproval</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is used for locating logs and troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34267E2E-0335-1A60-A1F0-ADA530890CBA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
