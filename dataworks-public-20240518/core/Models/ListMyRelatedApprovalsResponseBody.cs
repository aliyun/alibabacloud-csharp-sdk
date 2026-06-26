// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListMyRelatedApprovalsResponseBody : TeaModel {
        /// <summary>
        /// <para>Paginated results</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMyRelatedApprovalsResponseBodyData Data { get; set; }
        public class ListMyRelatedApprovalsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Application order details</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListMyRelatedApprovalsResponseBodyDataData> Data { get; set; }
            public class ListMyRelatedApprovalsResponseBodyDataData : TeaModel {
                /// <summary>
                /// <para>Application submission time</para>
                /// 
                /// <b>Example:</b>
                /// <para>1779695088000</para>
                /// </summary>
                [NameInMap("ApplicationTime")]
                [Validation(Required=false)]
                public long? ApplicationTime { get; set; }

                /// <summary>
                /// <para>Application content</para>
                /// </summary>
                [NameInMap("Contents")]
                [Validation(Required=false)]
                public List<ListMyRelatedApprovalsResponseBodyDataDataContents> Contents { get; set; }
                public class ListMyRelatedApprovalsResponseBodyDataDataContents : TeaModel {
                    /// <summary>
                    /// <para>Resource operation permissions requested in the application</para>
                    /// </summary>
                    [NameInMap("AccessTypes")]
                    [Validation(Required=false)]
                    public List<string> AccessTypes { get; set; }

                    /// <summary>
                    /// <para>Authorization method</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>default</para>
                    /// </summary>
                    [NameInMap("AuthMethod")]
                    [Validation(Required=false)]
                    public string AuthMethod { get; set; }

                    /// <summary>
                    /// <para>Creation time</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-09-11 10:13:21</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>Resource type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MaxCompute</para>
                    /// </summary>
                    [NameInMap("DefSchema")]
                    [Validation(Required=false)]
                    public string DefSchema { get; set; }

                    /// <summary>
                    /// <para>Permission expiration date, millisecond timestamp</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1779695088000</para>
                    /// </summary>
                    [NameInMap("ExpirationTime")]
                    [Validation(Required=false)]
                    public long? ExpirationTime { get; set; }

                    /// <summary>
                    /// <para>Resource operation permissions finally approved</para>
                    /// </summary>
                    [NameInMap("FinalAccessTypes")]
                    [Validation(Required=false)]
                    public List<string> FinalAccessTypes { get; set; }

                    /// <summary>
                    /// <para>Authorization target</para>
                    /// </summary>
                    [NameInMap("Grantee")]
                    [Validation(Required=false)]
                    public ListMyRelatedApprovalsResponseBodyDataDataContentsGrantee Grantee { get; set; }
                    public class ListMyRelatedApprovalsResponseBodyDataDataContentsGrantee : TeaModel {
                        /// <summary>
                        /// <para>Principal ID.</para>
                        /// <para>Note: When principalType is a different type, it corresponds to different semantics:</para>
                        /// <list type="bullet">
                        /// <item><description>RamUser: Dataworks UserId</description></item>
                        /// <item><description>RamRole: Dataworks UserId prefixed with &quot;ROLE_&quot;</description></item>
                        /// <item><description>DataworksTenantMember: Dataworks UserId</description></item>
                        /// <item><description>DataworksTenantRole: Dataworks tenant roleCode</description></item>
                        /// <item><description>DataworksProjectRole: Dataworks workspace roleCode</description></item>
                        /// <item><description>DataworksProjectMember: Dataworks UserId</description></item>
                        /// <item><description>DlfRole: DlfNext role name</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ROLE_3133343434</para>
                        /// </summary>
                        [NameInMap("PrincipalId")]
                        [Validation(Required=false)]
                        public string PrincipalId { get; set; }

                        /// <summary>
                        /// <para>Principal type. Enum values:</para>
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
                    /// <para>Unique identifier of the application content</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1009516415</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>Approval process instance ID of the submitted application</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>777799223</para>
                    /// </summary>
                    [NameInMap("ProcessInstanceId")]
                    [Validation(Required=false)]
                    public string ProcessInstanceId { get; set; }

                    /// <summary>
                    /// <para>Resource declaration</para>
                    /// </summary>
                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public ListMyRelatedApprovalsResponseBodyDataDataContentsResource Resource { get; set; }
                    public class ListMyRelatedApprovalsResponseBodyDataDataContentsResource : TeaModel {
                        /// <summary>
                        /// <para>ResourceSchema.name that the resource parsing depends on</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MaxCompute</para>
                        /// </summary>
                        [NameInMap("DefSchema")]
                        [Validation(Required=false)]
                        public string DefSchema { get; set; }

                        /// <summary>
                        /// <para>ResourceSchema.version that the resource parsing depends on</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>v1.0.0</para>
                        /// </summary>
                        [NameInMap("DefVersion")]
                        [Validation(Required=false)]
                        public string DefVersion { get; set; }

                        /// <summary>
                        /// <para>Resource metadata, data content is constrained by ResourceSchema</para>
                        /// </summary>
                        [NameInMap("MetaData")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> MetaData { get; set; }

                    }

                    /// <summary>
                    /// <para>Minimum permission resource type</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>table</para>
                    /// </summary>
                    [NameInMap("ResourceName")]
                    [Validation(Required=false)]
                    public string ResourceName { get; set; }

                    /// <summary>
                    /// <para>Approval status. Enum values:</para>
                    /// <list type="bullet">
                    /// <item><description>WaitApproval: Pending approval</description></item>
                    /// <item><description>Confirmed: Pending authorization</description></item>
                    /// <item><description>RejectApproval: Approval rejected</description></item>
                    /// <item><description>AuthorizeSucceed: Authorization succeeded</description></item>
                    /// <item><description>AuthorizeFailed: Authorization failed</description></item>
                    /// <item><description>Deleted: Deleted</description></item>
                    /// <item><description>Canceled: Withdrawn</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Deleted</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>Tenant ID</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>69973837489</para>
                    /// </summary>
                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    /// <summary>
                    /// <para>Update time</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-03-05 18:24:13</para>
                    /// </summary>
                    [NameInMap("UpdateTime")]
                    [Validation(Required=false)]
                    public long? UpdateTime { get; set; }

                }

                /// <summary>
                /// <para>Resource type</para>
                /// 
                /// <b>Example:</b>
                /// <para>MaxCompute</para>
                /// </summary>
                [NameInMap("DefSchema")]
                [Validation(Required=false)]
                public string DefSchema { get; set; }

                /// <summary>
                /// <para>Process instance ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>176906667488145</para>
                /// </summary>
                [NameInMap("ProcessInstanceId")]
                [Validation(Required=false)]
                public string ProcessInstanceId { get; set; }

                /// <summary>
                /// <para>Application reason</para>
                /// 
                /// <b>Example:</b>
                /// <para>业务需要</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>Approval status. Enum values:</para>
                /// <list type="bullet">
                /// <item><description>WaitApproval: Pending approval</description></item>
                /// <item><description>Confirmed: Pending authorization</description></item>
                /// <item><description>RejectApproval: Approval rejected</description></item>
                /// <item><description>AuthorizeSucceed: Authorization succeeded</description></item>
                /// <item><description>AuthorizeFailed: Authorization failed</description></item>
                /// <item><description>Deleted: Deleted</description></item>
                /// <item><description>Canceled: Withdrawn</description></item>
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
            /// <para>Whether there is more data</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// <para>Pagination cursor</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJpZCI6NDU2fQ==</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>Page size (default 10, maximum 200)</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

        }

        /// <summary>
        /// <para>API request ID, generated by UUID</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc5df3a17****903790e8e8a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
