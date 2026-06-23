// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListMyRelatedApprovalsResponseBody : TeaModel {
        /// <summary>
        /// <para>The paginated results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMyRelatedApprovalsResponseBodyData Data { get; set; }
        public class ListMyRelatedApprovalsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of the approval requests.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListMyRelatedApprovalsResponseBodyDataData> Data { get; set; }
            public class ListMyRelatedApprovalsResponseBodyDataData : TeaModel {
                /// <summary>
                /// <para>The time when the request was submitted, in milliseconds since the Unix epoch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1779695088000</para>
                /// </summary>
                [NameInMap("ApplicationTime")]
                [Validation(Required=false)]
                public long? ApplicationTime { get; set; }

                /// <summary>
                /// <para>The content of the request.</para>
                /// </summary>
                [NameInMap("Contents")]
                [Validation(Required=false)]
                public List<ListMyRelatedApprovalsResponseBodyDataDataContents> Contents { get; set; }
                public class ListMyRelatedApprovalsResponseBodyDataDataContents : TeaModel {
                    /// <summary>
                    /// <para>The permissions requested for the resource.</para>
                    /// </summary>
                    [NameInMap("AccessTypes")]
                    [Validation(Required=false)]
                    public List<string> AccessTypes { get; set; }

                    /// <summary>
                    /// <para>The authorization method.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("AuthMethod")]
                    [Validation(Required=false)]
                    public string AuthMethod { get; set; }

                    /// <summary>
                    /// <para>The time when the entry was created, in milliseconds since the Unix epoch.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-09-11 10:13:21</para>
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
                    /// <para>The permission\&quot;s expiration time, in milliseconds since the Unix epoch.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1779695088000</para>
                    /// </summary>
                    [NameInMap("ExpirationTime")]
                    [Validation(Required=false)]
                    public long? ExpirationTime { get; set; }

                    /// <summary>
                    /// <para>The permissions granted for the resource after the final approval.</para>
                    /// </summary>
                    [NameInMap("FinalAccessTypes")]
                    [Validation(Required=false)]
                    public List<string> FinalAccessTypes { get; set; }

                    /// <summary>
                    /// <para>The grantee.</para>
                    /// </summary>
                    [NameInMap("Grantee")]
                    [Validation(Required=false)]
                    public ListMyRelatedApprovalsResponseBodyDataDataContentsGrantee Grantee { get; set; }
                    public class ListMyRelatedApprovalsResponseBodyDataDataContentsGrantee : TeaModel {
                        /// <summary>
                        /// <para>The principal ID.</para>
                        /// <para>Note: The format of this ID depends on the PrincipalType:</para>
                        /// <list type="bullet">
                        /// <item><description><para>RamUser: The user ID.</para>
                        /// </description></item>
                        /// <item><description><para>RamRole: The user ID, prefixed with <c>ROLE_</c>.</para>
                        /// </description></item>
                        /// <item><description><para>DataworksTenantMember: The user ID.</para>
                        /// </description></item>
                        /// <item><description><para>DataworksTenantRole: The role code in the Dataworks tenant.</para>
                        /// </description></item>
                        /// <item><description><para>DataworksProjectRole: The role code in the Dataworks workspace.</para>
                        /// </description></item>
                        /// <item><description><para>DataworksProjectMember: The user ID.</para>
                        /// </description></item>
                        /// <item><description><para>DlfRole: The name of the DlfNext role.</para>
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
                        /// <item><description><para>RamRole</para>
                        /// </description></item>
                        /// <item><description><para>RamUser</para>
                        /// </description></item>
                        /// <item><description><para>DataworksTenantMember</para>
                        /// </description></item>
                        /// <item><description><para>DataworksTenantRole</para>
                        /// </description></item>
                        /// <item><description><para>DataworksProjectMember</para>
                        /// </description></item>
                        /// <item><description><para>DataworksProjectRole</para>
                        /// </description></item>
                        /// <item><description><para>DlfRole</para>
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
                    /// <para>The unique ID of the request content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1009516415</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The ID of the approval process instance for the request.</para>
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
                    public ListMyRelatedApprovalsResponseBodyDataDataContentsResource Resource { get; set; }
                    public class ListMyRelatedApprovalsResponseBodyDataDataContentsResource : TeaModel {
                        /// <summary>
                        /// <para>The name of the ResourceSchema required to parse the resource.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MaxCompute</para>
                        /// </summary>
                        [NameInMap("DefSchema")]
                        [Validation(Required=false)]
                        public string DefSchema { get; set; }

                        /// <summary>
                        /// <para>The version of the ResourceSchema required to parse the resource.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>v1.0.0</para>
                        /// </summary>
                        [NameInMap("DefVersion")]
                        [Validation(Required=false)]
                        public string DefVersion { get; set; }

                        /// <summary>
                        /// <para>The resource metadata. The content is constrained by the ResourceSchema.</para>
                        /// </summary>
                        [NameInMap("MetaData")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> MetaData { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the resource type at the leaf-node level.</para>
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
                    /// <item><description><para>WaitApproval: Waiting for approval.</para>
                    /// </description></item>
                    /// <item><description><para>Confirmed: Pending authorization.</para>
                    /// </description></item>
                    /// <item><description><para>RejectApproval: Approval rejected.</para>
                    /// </description></item>
                    /// <item><description><para>AuthorizeSucceed: Authorization succeeded.</para>
                    /// </description></item>
                    /// <item><description><para>AuthorizeFailed: Authorization failed.</para>
                    /// </description></item>
                    /// <item><description><para>Deleted: Deleted.</para>
                    /// </description></item>
                    /// <item><description><para>Canceled: Canceled.</para>
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
                    /// <para>The time when the entry was last updated, in milliseconds since the Unix epoch.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-03-05 18:24:13</para>
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
                /// <para>176906667488145</para>
                /// </summary>
                [NameInMap("ProcessInstanceId")]
                [Validation(Required=false)]
                public string ProcessInstanceId { get; set; }

                /// <summary>
                /// <para>The reason for the request.</para>
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
                /// <item><description><para>WaitApproval: Waiting for approval.</para>
                /// </description></item>
                /// <item><description><para>Confirmed: Pending authorization.</para>
                /// </description></item>
                /// <item><description><para>RejectApproval: Approval rejected.</para>
                /// </description></item>
                /// <item><description><para>AuthorizeSucceed: Authorization succeeded.</para>
                /// </description></item>
                /// <item><description><para>AuthorizeFailed: Authorization failed.</para>
                /// </description></item>
                /// <item><description><para>Deleted: Deleted.</para>
                /// </description></item>
                /// <item><description><para>Canceled: Canceled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Deleted</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether more results are available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// <para>The token to use to retrieve the next page of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJpZCI6NDU2fQ==</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default: 10. Maximum: 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

        }

        /// <summary>
        /// <para>The request ID, a universally unique identifier (UUID).</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc5df3a17****903790e8e8a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
