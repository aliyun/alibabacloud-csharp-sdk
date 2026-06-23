// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListPendingApprovalsResponseBody : TeaModel {
        /// <summary>
        /// <para>The paginated results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListPendingApprovalsResponseBodyData Data { get; set; }
        public class ListPendingApprovalsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of pending approvals.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListPendingApprovalsResponseBodyDataData> Data { get; set; }
            public class ListPendingApprovalsResponseBodyDataData : TeaModel {
                /// <summary>
                /// <para>The submission time of the request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>申请时间</para>
                /// </summary>
                [NameInMap("ApplicationTime")]
                [Validation(Required=false)]
                public long? ApplicationTime { get; set; }

                /// <summary>
                /// <para>The content of the request.</para>
                /// </summary>
                [NameInMap("Contents")]
                [Validation(Required=false)]
                public List<ListPendingApprovalsResponseBodyDataDataContents> Contents { get; set; }
                public class ListPendingApprovalsResponseBodyDataDataContents : TeaModel {
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
                    /// <para>The creation time of the entry.</para>
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
                    /// <para>The permission expiration time, in milliseconds since the Unix epoch.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1782354014507</para>
                    /// </summary>
                    [NameInMap("ExpirationTime")]
                    [Validation(Required=false)]
                    public long? ExpirationTime { get; set; }

                    /// <summary>
                    /// <para>The final permissions granted after approval.</para>
                    /// </summary>
                    [NameInMap("FinalAccessTypes")]
                    [Validation(Required=false)]
                    public List<string> FinalAccessTypes { get; set; }

                    /// <summary>
                    /// <para>Information about the grantee.</para>
                    /// </summary>
                    [NameInMap("Grantee")]
                    [Validation(Required=false)]
                    public ListPendingApprovalsResponseBodyDataDataContentsGrantee Grantee { get; set; }
                    public class ListPendingApprovalsResponseBodyDataDataContentsGrantee : TeaModel {
                        /// <summary>
                        /// <para>The principal ID.</para>
                        /// <para>Note: The meaning of this ID varies based on the <c>principalType</c>.</para>
                        /// <list type="bullet">
                        /// <item><description><para>If the <c>principalType</c> is <c>RamUser</c>, this is the DataWorks user ID.</para>
                        /// </description></item>
                        /// <item><description><para>If the <c>principalType</c> is <c>RamRole</c>, this is the DataWorks user ID, prefixed with &quot;ROLE_&quot;.</para>
                        /// </description></item>
                        /// <item><description><para>If the <c>principalType</c> is <c>DataWorksTenantMember</c>, this is the DataWorks user ID.</para>
                        /// </description></item>
                        /// <item><description><para>If the <c>principalType</c> is <c>DataWorksTenantRole</c>, this is the DataWorks tenant role code.</para>
                        /// </description></item>
                        /// <item><description><para>If the <c>principalType</c> is <c>DataWorksProjectRole</c>, this is the DataWorks workspace role code.</para>
                        /// </description></item>
                        /// <item><description><para>If the <c>principalType</c> is <c>DataWorksProjectMember</c>, this is the DataWorks user ID.</para>
                        /// </description></item>
                        /// <item><description><para>If the <c>principalType</c> is <c>DlfRole</c>, this is the DLF role name.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>213463068144525171</para>
                        /// </summary>
                        [NameInMap("PrincipalId")]
                        [Validation(Required=false)]
                        public string PrincipalId { get; set; }

                        /// <summary>
                        /// <para>The principal type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><c>RamRole</c>: A RAM role.</para>
                        /// </description></item>
                        /// <item><description><para><c>RamUser</c>: A RAM user.</para>
                        /// </description></item>
                        /// <item><description><para><c>DataWorksTenantMember</c>: A DataWorks tenant member.</para>
                        /// </description></item>
                        /// <item><description><para><c>DataWorksTenantRole</c>: A DataWorks tenant role.</para>
                        /// </description></item>
                        /// <item><description><para><c>DataWorksProjectMember</c>: A DataWorks workspace member.</para>
                        /// </description></item>
                        /// <item><description><para><c>DataWorksProjectRole</c>: A DataWorks workspace role.</para>
                        /// </description></item>
                        /// <item><description><para><c>DlfRole</c>: A DLF role.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>RamUser</para>
                        /// </summary>
                        [NameInMap("PrincipalType")]
                        [Validation(Required=false)]
                        public string PrincipalType { get; set; }

                    }

                    /// <summary>
                    /// <para>The unique identifier of the requested item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>210001918826</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para><b>The process instance ID.</b></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>176906667488145</para>
                    /// </summary>
                    [NameInMap("ProcessInstanceId")]
                    [Validation(Required=false)]
                    public string ProcessInstanceId { get; set; }

                    /// <summary>
                    /// <para>The resource declaration.</para>
                    /// </summary>
                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public ListPendingApprovalsResponseBodyDataDataContentsResource Resource { get; set; }
                    public class ListPendingApprovalsResponseBodyDataDataContentsResource : TeaModel {
                        /// <summary>
                        /// <para>The name of the <c>ResourceSchema</c> used to parse the resource.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MaxCompute</para>
                        /// </summary>
                        [NameInMap("DefSchema")]
                        [Validation(Required=false)]
                        public string DefSchema { get; set; }

                        /// <summary>
                        /// <para>The version of the <c>ResourceSchema</c> used to parse the resource.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>v1.0.0</para>
                        /// </summary>
                        [NameInMap("DefVersion")]
                        [Validation(Required=false)]
                        public string DefVersion { get; set; }

                        /// <summary>
                        /// <para>The resource metadata. The content is constrained by the DefSchema.</para>
                        /// </summary>
                        [NameInMap("MetaData")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> MetaData { get; set; }

                    }

                    /// <summary>
                    /// <para>The type of the resource, such as a table or function.</para>
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
                    /// <item><description><para><c>WaitApproval</c>: Pending approval</para>
                    /// </description></item>
                    /// <item><description><para><c>Confirmed</c>: Pending authorization</para>
                    /// </description></item>
                    /// <item><description><para><c>RejectApproval</c>: Rejected</para>
                    /// </description></item>
                    /// <item><description><para><c>AuthorizeSucceed</c>: Authorization successful</para>
                    /// </description></item>
                    /// <item><description><para><c>AuthorizeFailed</c>: Authorization failed</para>
                    /// </description></item>
                    /// <item><description><para><c>Deleted</c>: Deleted</para>
                    /// </description></item>
                    /// <item><description><para><c>Canceled</c>: Canceled</para>
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
                    /// <para>The time the entry was last updated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-07-06 19:13:05</para>
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
                /// <item><description><para><c>WaitApproval</c>: Pending approval</para>
                /// </description></item>
                /// <item><description><para><c>Confirmed</c>: Pending authorization</para>
                /// </description></item>
                /// <item><description><para><c>RejectApproval</c>: Rejected</para>
                /// </description></item>
                /// <item><description><para><c>AuthorizeSucceed</c>: Authorization successful</para>
                /// </description></item>
                /// <item><description><para><c>AuthorizeFailed</c>: Authorization failed</para>
                /// </description></item>
                /// <item><description><para><c>Deleted</c>: Deleted</para>
                /// </description></item>
                /// <item><description><para><c>Canceled</c>: Canceled</para>
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
            /// <para>Indicates whether more data is available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// <para>A token to retrieve the next page of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJpZCI6MTIzfQ==</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The page size. Default: 10. Maximum: 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc5df3a17****903790e8e8a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
