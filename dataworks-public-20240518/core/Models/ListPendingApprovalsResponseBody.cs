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
            /// <para>The list of data in the paginated results.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListPendingApprovalsResponseBodyDataData> Data { get; set; }
            public class ListPendingApprovalsResponseBodyDataData : TeaModel {
                /// <summary>
                /// <para>The time when the application was initiated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1778641560000</para>
                /// </summary>
                [NameInMap("ApplicationTime")]
                [Validation(Required=false)]
                public long? ApplicationTime { get; set; }

                /// <summary>
                /// <para>The application content.</para>
                /// </summary>
                [NameInMap("Contents")]
                [Validation(Required=false)]
                public List<ListPendingApprovalsResponseBodyDataDataContents> Contents { get; set; }
                public class ListPendingApprovalsResponseBodyDataDataContents : TeaModel {
                    /// <summary>
                    /// <para>The requested resource operation permissions.</para>
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
                    /// <para>The format is <c>yyyy-MM-dd HH:mm:ss</c>, such as <c>2025-09-11 10:13:21</c>. This example does not include a time zone identifier.</para>
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
                    /// <para>The expiration date of the permissions. The value is a UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1782354014507</para>
                    /// </summary>
                    [NameInMap("ExpirationTime")]
                    [Validation(Required=false)]
                    public long? ExpirationTime { get; set; }

                    /// <summary>
                    /// <para>The resource operation permissions that received final approval.</para>
                    /// </summary>
                    [NameInMap("FinalAccessTypes")]
                    [Validation(Required=false)]
                    public List<string> FinalAccessTypes { get; set; }

                    /// <summary>
                    /// <para>The description of the authorization principal.</para>
                    /// </summary>
                    [NameInMap("Grantee")]
                    [Validation(Required=false)]
                    public ListPendingApprovalsResponseBodyDataDataContentsGrantee Grantee { get; set; }
                    public class ListPendingApprovalsResponseBodyDataDataContentsGrantee : TeaModel {
                        /// <summary>
                        /// <para>The ID of the principal.</para>
                        /// <para>Note: When principalType is of different types, it corresponds to different semantics:</para>
                        /// <list type="bullet">
                        /// <item><description>RamUser: DataWorks user ID</description></item>
                        /// <item><description>RamRole: DataWorks user ID starting with &quot;ROLE_&quot;</description></item>
                        /// <item><description>DataworksTenantMember: DataWorks user ID</description></item>
                        /// <item><description>DataworksTenantRole: DataWorks tenant roleCode</description></item>
                        /// <item><description>DataworksProjectRole: DataWorks workspace roleCode</description></item>
                        /// <item><description>DataworksProjectMember: DataWorks user ID</description></item>
                        /// <item><description>DlfRole: DlfNext role name</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>213463068144525171</para>
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
                        /// <para>RamUser</para>
                        /// </summary>
                        [NameInMap("PrincipalType")]
                        [Validation(Required=false)]
                        public string PrincipalType { get; set; }

                    }

                    /// <summary>
                    /// <para>The unique identifier of the application content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>210001918826</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para><b>The approval process instance ID.</b></para>
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
                        /// <para>The ResourceSchema.name on which the resource parsing depends.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MaxCompute</para>
                        /// </summary>
                        [NameInMap("DefSchema")]
                        [Validation(Required=false)]
                        public string DefSchema { get; set; }

                        /// <summary>
                        /// <para>The ResourceSchema.version on which the resource parsing depends.</para>
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
                    /// <para>The approval status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>WaitApproval: pending approval</description></item>
                    /// <item><description>Confirmed: pending authorization</description></item>
                    /// <item><description>RejectApproval: approval rejected</description></item>
                    /// <item><description>AuthorizeSucceed: authorization succeeded</description></item>
                    /// <item><description>AuthorizeFailed: authorization failed</description></item>
                    /// <item><description>Deleted: deleted</description></item>
                    /// <item><description>Canceled: withdrawn</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Deleted</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The ID of the tenant.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>69973837489</para>
                    /// </summary>
                    [NameInMap("TenantId")]
                    [Validation(Required=false)]
                    public string TenantId { get; set; }

                    /// <summary>
                    /// <para>The update time.</para>
                    /// <para>The format is <c>yyyy-MM-dd HH:mm:ss</c>, such as <c>2022-07-06 19:13:05</c>. This example does not include a time zone identifier.</para>
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
                /// <para>The approval process instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>176906667488145</para>
                /// </summary>
                [NameInMap("ProcessInstanceId")]
                [Validation(Required=false)]
                public string ProcessInstanceId { get; set; }

                /// <summary>
                /// <para>The reason for the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Business requirement</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The approval status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>WaitApproval: pending approval</description></item>
                /// <item><description>Confirmed: pending authorization</description></item>
                /// <item><description>RejectApproval: approval rejected</description></item>
                /// <item><description>AuthorizeSucceed: authorization succeeded</description></item>
                /// <item><description>AuthorizeFailed: authorization failed</description></item>
                /// <item><description>Deleted: deleted</description></item>
                /// <item><description>Canceled: withdrawn</description></item>
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
            /// <para>The cursor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJpZCI6MTIzfQ==</para>
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
        /// <para>The ID of the API request, generated by using a UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc5df3a17****903790e8e8a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
