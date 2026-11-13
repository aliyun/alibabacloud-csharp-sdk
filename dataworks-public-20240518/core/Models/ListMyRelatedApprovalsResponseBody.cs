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
            /// <para>The permission request details.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListMyRelatedApprovalsResponseBodyDataData> Data { get; set; }
            public class ListMyRelatedApprovalsResponseBodyDataData : TeaModel {
                /// <summary>
                /// <para>The time when the request was submitted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1779695088000</para>
                /// </summary>
                [NameInMap("ApplicationTime")]
                [Validation(Required=false)]
                public long? ApplicationTime { get; set; }

                /// <summary>
                /// <para>The request details.</para>
                /// </summary>
                [NameInMap("Contents")]
                [Validation(Required=false)]
                public List<ListMyRelatedApprovalsResponseBodyDataDataContents> Contents { get; set; }
                public class ListMyRelatedApprovalsResponseBodyDataDataContents : TeaModel {
                    /// <summary>
                    /// <para>The permissions requested for the resource operations.</para>
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
                    /// <para>The creation time.</para>
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
                    /// <para>The expiration time of the permissions. The value is a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1779695088000</para>
                    /// </summary>
                    [NameInMap("ExpirationTime")]
                    [Validation(Required=false)]
                    public long? ExpirationTime { get; set; }

                    /// <summary>
                    /// <para>The resource operation permissions that are finally approved.</para>
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
                        /// <para>The ID of the principal.</para>
                        /// <para>Note: The meaning of the ID varies based on the principal type:</para>
                        /// <list type="bullet">
                        /// <item><description>RamUser: DataWorks user ID.</description></item>
                        /// <item><description>RamRole: DataWorks user ID that starts with &quot;ROLE_&quot;.</description></item>
                        /// <item><description>DataworksTenantMember: DataWorks user ID.</description></item>
                        /// <item><description>DataworksTenantRole: DataWorks tenant role code.</description></item>
                        /// <item><description>DataworksProjectRole: DataWorks workspace role code.</description></item>
                        /// <item><description>DataworksProjectMember: DataWorks user ID.</description></item>
                        /// <item><description>DlfRole: DLF Next role name.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ROLE_3133343434</para>
                        /// </summary>
                        [NameInMap("PrincipalId")]
                        [Validation(Required=false)]
                        public string PrincipalId { get; set; }

                        /// <summary>
                        /// <para>The type of the principal. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>RamRole</description></item>
                        /// <item><description>RamUser</description></item>
                        /// <item><description>DataworksTenantMember</description></item>
                        /// <item><description>DataworksTenantRole</description></item>
                        /// <item><description>DataworksProjectMember</description></item>
                        /// <item><description>DataworksProjectRole</description></item>
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
                        /// <para>The ResourceSchema.name that the resource parsing depends on.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MaxCompute</para>
                        /// </summary>
                        [NameInMap("DefSchema")]
                        [Validation(Required=false)]
                        public string DefSchema { get; set; }

                        /// <summary>
                        /// <para>The ResourceSchema.version that the resource parsing depends on.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>v1.0.0</para>
                        /// </summary>
                        [NameInMap("DefVersion")]
                        [Validation(Required=false)]
                        public string DefVersion { get; set; }

                        /// <summary>
                        /// <para>The resource metadata. The data content is constrained by ResourceSchema.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>{&quot;schema&quot;: &quot;default&quot;, &quot;threeTierModel&quot;: false, &quot;project&quot;: &quot;sync_dtestn&quot;, &quot;workspace&quot;: &quot;4477656&quot;, &quot;table&quot;: &quot;order&quot;, &quot;tenant&quot;: &quot;524257424864736&quot;}</para>
                        /// </summary>
                        [NameInMap("MetaData")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> MetaData { get; set; }

                    }

                    /// <summary>
                    /// <para>The least privilege resource type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>table</para>
                    /// </summary>
                    [NameInMap("ResourceName")]
                    [Validation(Required=false)]
                    public string ResourceName { get; set; }

                    /// <summary>
                    /// <para>Filters by approval status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>WaitApproval: Pending approval.</description></item>
                    /// <item><description>Confirmed: Pending authorization.</description></item>
                    /// <item><description>RejectApproval: Rejected.</description></item>
                    /// <item><description>AuthorizeSucceed: Authorized.</description></item>
                    /// <item><description>AuthorizeFailed: Authorization failed.</description></item>
                    /// <item><description>Deleted: Deleted.</description></item>
                    /// <item><description>Canceled: Withdrawn.</description></item>
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
                /// <para>Business requirement</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>Filters by approval status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>WaitApproval: Pending approval.</description></item>
                /// <item><description>Confirmed: Pending authorization.</description></item>
                /// <item><description>RejectApproval: Rejected.</description></item>
                /// <item><description>AuthorizeSucceed: Authorized.</description></item>
                /// <item><description>AuthorizeFailed: Authorization failed.</description></item>
                /// <item><description>Deleted: Deleted.</description></item>
                /// <item><description>Canceled: Withdrawn.</description></item>
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
            /// <para>Indicates whether more data exists.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// <para>The pagination cursor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJpZCI6NDU2fQ==</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The number of entries per page. Default value: 10. Maximum value: 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

        }

        /// <summary>
        /// <para>The ID of the API request. The ID is a UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc5df3a17****903790e8e8a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
