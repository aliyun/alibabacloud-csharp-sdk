// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetApplicationContentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The process instance and its associated application contents.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetApplicationContentsResponseBodyData Data { get; set; }
        public class GetApplicationContentsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the application was submitted. This value is a millisecond-precision timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1779675618000</para>
            /// </summary>
            [NameInMap("ApplicationTime")]
            [Validation(Required=false)]
            public long? ApplicationTime { get; set; }

            /// <summary>
            /// <para>A list of the application contents.</para>
            /// </summary>
            [NameInMap("Contents")]
            [Validation(Required=false)]
            public List<GetApplicationContentsResponseBodyDataContents> Contents { get; set; }
            public class GetApplicationContentsResponseBodyDataContents : TeaModel {
                /// <summary>
                /// <para>A list of the permissions requested for the resource.</para>
                /// </summary>
                [NameInMap("AccessTypes")]
                [Validation(Required=false)]
                public List<string> AccessTypes { get; set; }

                /// <summary>
                /// <para>The authorization method.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ranger</para>
                /// </summary>
                [NameInMap("AuthMethod")]
                [Validation(Required=false)]
                public string AuthMethod { get; set; }

                /// <summary>
                /// <para>The time when the content item was created. This value is a millisecond-precision timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1773972024000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>The resource type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MaxCompute</para>
                /// </summary>
                [NameInMap("DefSchema")]
                [Validation(Required=false)]
                public string DefSchema { get; set; }

                /// <summary>
                /// <para>The time when the permissions expire. This value is a millisecond-precision timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1785835708000</para>
                /// </summary>
                [NameInMap("ExpirationTime")]
                [Validation(Required=false)]
                public long? ExpirationTime { get; set; }

                /// <summary>
                /// <para>A list of the permissions granted in the final approval.</para>
                /// </summary>
                [NameInMap("FinalAccessTypes")]
                [Validation(Required=false)]
                public List<string> FinalAccessTypes { get; set; }

                /// <summary>
                /// <para>The grantee.</para>
                /// </summary>
                [NameInMap("Grantee")]
                [Validation(Required=false)]
                public GetApplicationContentsResponseBodyDataContentsGrantee Grantee { get; set; }
                public class GetApplicationContentsResponseBodyDataContentsGrantee : TeaModel {
                    /// <summary>
                    /// <para>The ID of the principal. The format of the ID varies based on the <c>PrincipalType</c> value:</para>
                    /// <list type="bullet">
                    /// <item><description><para>If <c>PrincipalType</c> is <c>RamUser</c>, this parameter specifies the ID of a DataWorks user.</para>
                    /// </description></item>
                    /// <item><description><para>If <c>PrincipalType</c> is <c>RamRole</c>, this parameter specifies the ID of a role in DataWorks. The ID must be prefixed with <c>ROLE_</c>.</para>
                    /// </description></item>
                    /// <item><description><para>If <c>PrincipalType</c> is <c>DlfRole</c>, this parameter specifies the name of a DlfNext role.</para>
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
                    /// <para>The principal type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>RamUser</c></para>
                    /// </description></item>
                    /// <item><description><para><c>RamRole</c></para>
                    /// </description></item>
                    /// <item><description><para><c>DlfRole</c></para>
                    /// </description></item>
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
                /// <para>The unique ID of the application content item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Y9H7AKFmjhWzLYdZNDZA5</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The ID of the approval process instance for the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>777799223</para>
                /// </summary>
                [NameInMap("ProcessInstanceId")]
                [Validation(Required=false)]
                public string ProcessInstanceId { get; set; }

                /// <summary>
                /// <para>The resource declaration.</para>
                /// </summary>
                [NameInMap("Resource")]
                [Validation(Required=false)]
                public GetApplicationContentsResponseBodyDataContentsResource Resource { get; set; }
                public class GetApplicationContentsResponseBodyDataContentsResource : TeaModel {
                    /// <summary>
                    /// <para>The name of the <c>ResourceSchema</c> that defines how to parse this resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MaxCompute</para>
                    /// </summary>
                    [NameInMap("DefSchema")]
                    [Validation(Required=false)]
                    public string DefSchema { get; set; }

                    /// <summary>
                    /// <para>The version of the <c>ResourceSchema</c> that defines how to parse this resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>v1.0.0</para>
                    /// </summary>
                    [NameInMap("DefVersion")]
                    [Validation(Required=false)]
                    public string DefVersion { get; set; }

                    /// <summary>
                    /// <para>The resource metadata. The structure of the metadata is defined by the <c>ResourceSchema</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;{\&quot;schema\&quot;:\&quot;default\&quot;,\&quot;threeTierModel\&quot;:false,\&quot;workspace\&quot;:\&quot;449656\&quot;,\&quot;project\&quot;:\&quot;sync_destination\&quot;,\&quot;table\&quot;:\&quot;order_table\&quot;,\&quot;tenant\&quot;:\&quot;524997424564736\&quot;}&quot;</para>
                    /// </summary>
                    [NameInMap("MetaData")]
                    [Validation(Required=false)]
                    public string MetaData { get; set; }

                }

                /// <summary>
                /// <para>The specific type of the resource, such as a table.</para>
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
                /// <item><description><para><c>WaitApproval</c>: The item is pending approval.</para>
                /// </description></item>
                /// <item><description><para><c>Confirmed</c>: The item is pending authorization.</para>
                /// </description></item>
                /// <item><description><para><c>RejectApproval</c>: The item was rejected.</para>
                /// </description></item>
                /// <item><description><para><c>AuthorizeSucceed</c>: Authorization was successful.</para>
                /// </description></item>
                /// <item><description><para><c>AuthorizeFailed</c>: Authorization failed.</para>
                /// </description></item>
                /// <item><description><para><c>Deleted</c>: The item was deleted during the approval process.</para>
                /// </description></item>
                /// <item><description><para><c>Canceled</c>: The item was canceled.</para>
                /// </description></item>
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
                /// <para>The time when the content item was last updated. This value is a millisecond-precision timestamp.</para>
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
            /// <para>The reason for the application.</para>
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
            /// <item><description><para><c>WaitApproval</c>: The application is pending approval.</para>
            /// </description></item>
            /// <item><description><para><c>Confirmed</c>: The application is pending authorization.</para>
            /// </description></item>
            /// <item><description><para><c>RejectApproval</c>: The application was rejected.</para>
            /// </description></item>
            /// <item><description><para><c>AuthorizeSucceed</c>: Authorization was successful.</para>
            /// </description></item>
            /// <item><description><para><c>AuthorizeFailed</c>: Authorization failed.</para>
            /// </description></item>
            /// <item><description><para><c>Deleted</c>: The application was deleted.</para>
            /// </description></item>
            /// <item><description><para><c>Canceled</c>: The application was canceled.</para>
            /// </description></item>
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
        /// <para>The request ID. Use this ID to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34267E2E-0335-1A60-A1F0-ADA530890CBA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
