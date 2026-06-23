// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListMyApplicationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The paginated results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMyApplicationsResponseBodyData Data { get; set; }
        public class ListMyApplicationsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of application details.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListMyApplicationsResponseBodyDataData> Data { get; set; }
            public class ListMyApplicationsResponseBodyDataData : TeaModel {
                /// <summary>
                /// <para>The time the application was submitted, in Unix timestamp format (milliseconds).</para>
                /// 
                /// <b>Example:</b>
                /// <para>1779695088000</para>
                /// </summary>
                [NameInMap("ApplicationTime")]
                [Validation(Required=false)]
                public long? ApplicationTime { get; set; }

                /// <summary>
                /// <para>The content of the application.</para>
                /// </summary>
                [NameInMap("Contents")]
                [Validation(Required=false)]
                public List<ListMyApplicationsResponseBodyDataDataContents> Contents { get; set; }
                public class ListMyApplicationsResponseBodyDataDataContents : TeaModel {
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
                    /// <para>The time when the item was created, in Unix timestamp format (milliseconds).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-11-29 15:04:52</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>The resource type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MAXCOMPUTE</para>
                    /// </summary>
                    [NameInMap("DefSchema")]
                    [Validation(Required=false)]
                    public string DefSchema { get; set; }

                    /// <summary>
                    /// <para>When the permission expires, in Unix timestamp format (milliseconds).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1782354014507</para>
                    /// </summary>
                    [NameInMap("ExpirationTime")]
                    [Validation(Required=false)]
                    public long? ExpirationTime { get; set; }

                    /// <summary>
                    /// <para>The granted permissions.</para>
                    /// </summary>
                    [NameInMap("FinalAccessTypes")]
                    [Validation(Required=false)]
                    public List<string> FinalAccessTypes { get; set; }

                    /// <summary>
                    /// <para><b>The principal to be granted the permission.</b></para>
                    /// </summary>
                    [NameInMap("Grantee")]
                    [Validation(Required=false)]
                    public ListMyApplicationsResponseBodyDataDataContentsGrantee Grantee { get; set; }
                    public class ListMyApplicationsResponseBodyDataDataContentsGrantee : TeaModel {
                        /// <summary>
                        /// <para>The ID of the principal. The value of this parameter varies based on the value of <c>PrincipalType</c>:</para>
                        /// <list type="bullet">
                        /// <item><description><para><c>RamUser</c>: The DataWorks user ID.</para>
                        /// </description></item>
                        /// <item><description><para><c>RamRole</c>: The DataWorks user ID, prefixed with <c>ROLE_</c>.</para>
                        /// </description></item>
                        /// <item><description><para><c>DataworksTenantMember</c>: The DataWorks user ID.</para>
                        /// </description></item>
                        /// <item><description><para><c>DataworksTenantRole</c>: The DataWorks tenant role code.</para>
                        /// </description></item>
                        /// <item><description><para><c>DataworksProjectRole</c>: The DataWorks workspace role code.</para>
                        /// </description></item>
                        /// <item><description><para><c>DataworksProjectMember</c>: The DataWorks user ID.</para>
                        /// </description></item>
                        /// <item><description><para><c>DlfRole</c>: The DlfNext role name.</para>
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
                        /// <para>The type of the principal. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><para><c>RamRole</c></para>
                        /// </description></item>
                        /// <item><description><para><c>RamUser</c></para>
                        /// </description></item>
                        /// <item><description><para><c>DataworksTenantMember</c></para>
                        /// </description></item>
                        /// <item><description><para><c>DataworksTenantRole</c></para>
                        /// </description></item>
                        /// <item><description><para><c>DataworksProjectMember</c></para>
                        /// </description></item>
                        /// <item><description><para><c>DataworksProjectRole</c></para>
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
                    /// <para>The unique ID of the application item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>a8aa620037bb410ea13837f9b4d053d8</para>
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
                    /// <para><b>The requested resource.</b></para>
                    /// </summary>
                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public ListMyApplicationsResponseBodyDataDataContentsResource Resource { get; set; }
                    public class ListMyApplicationsResponseBodyDataDataContentsResource : TeaModel {
                        /// <summary>
                        /// <para><b>The name of the <c>ResourceSchema</c> used to parse the resource.</b></para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MaxCompute</para>
                        /// </summary>
                        [NameInMap("DefSchema")]
                        [Validation(Required=false)]
                        public string DefSchema { get; set; }

                        /// <summary>
                        /// <para><b>The version of the <c>ResourceSchema</c> used to parse the resource.</b></para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>v1.0.0</para>
                        /// </summary>
                        [NameInMap("DefVersion")]
                        [Validation(Required=false)]
                        public string DefVersion { get; set; }

                        /// <summary>
                        /// <para><b>The resource metadata. Its format is defined by the <c>ResourceSchema</c>.</b></para>
                        /// </summary>
                        [NameInMap("MetaData")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> MetaData { get; set; }

                    }

                    /// <summary>
                    /// <para>The category of the resource. For example, <c>table</c>.</para>
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
                    /// <item><description><para><c>AuthorizeSucceed</c>: Authorization succeeded</para>
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
                    /// <para>The time when the item was last updated, in Unix timestamp format (milliseconds).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-07-08 23:58:59</para>
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
                /// <item><description><para><c>WaitApproval</c>: Pending approval</para>
                /// </description></item>
                /// <item><description><para><c>Confirmed</c>: Pending authorization</para>
                /// </description></item>
                /// <item><description><para><c>RejectApproval</c>: Rejected</para>
                /// </description></item>
                /// <item><description><para><c>AuthorizeSucceed</c>: Authorization succeeded</para>
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
            /// <para>Indicates whether more results are available.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HasMore")]
            [Validation(Required=false)]
            public bool? HasMore { get; set; }

            /// <summary>
            /// <para>The cursor to retrieve the next page of results. If this parameter is empty, all results have been returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eyJpZCI6NDU2fQ==</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

            /// <summary>
            /// <para>The page size. Default value: 10. Maximum value: 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

        }

        /// <summary>
        /// <para>A unique identifier (UUID) generated for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc5df3a17****903790e8e8a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
