// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListMyApplicationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The data part of the paginated result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListMyApplicationsResponseBodyData Data { get; set; }
        public class ListMyApplicationsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of application order details.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListMyApplicationsResponseBodyDataData> Data { get; set; }
            public class ListMyApplicationsResponseBodyDataData : TeaModel {
                /// <summary>
                /// <para>The time when the application was initiated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1779695088000</para>
                /// </summary>
                [NameInMap("ApplicationTime")]
                [Validation(Required=false)]
                public long? ApplicationTime { get; set; }

                /// <summary>
                /// <para>The application content.</para>
                /// </summary>
                [NameInMap("Contents")]
                [Validation(Required=false)]
                public List<ListMyApplicationsResponseBodyDataDataContents> Contents { get; set; }
                public class ListMyApplicationsResponseBodyDataDataContents : TeaModel {
                    /// <summary>
                    /// <para>The resource operation permissions requested in the application.</para>
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
                    /// <para>The permission expiration date (millisecond timestamp).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1782354014507</para>
                    /// </summary>
                    [NameInMap("ExpirationTime")]
                    [Validation(Required=false)]
                    public long? ExpirationTime { get; set; }

                    /// <summary>
                    /// <para>The resource operation permissions that were finally approved.</para>
                    /// </summary>
                    [NameInMap("FinalAccessTypes")]
                    [Validation(Required=false)]
                    public List<string> FinalAccessTypes { get; set; }

                    /// <summary>
                    /// <para><b>The authorization target.</b></para>
                    /// </summary>
                    [NameInMap("Grantee")]
                    [Validation(Required=false)]
                    public ListMyApplicationsResponseBodyDataDataContentsGrantee Grantee { get; set; }
                    public class ListMyApplicationsResponseBodyDataDataContentsGrantee : TeaModel {
                        /// <summary>
                        /// <para>The principal ID for authorization:</para>
                        /// <list type="bullet">
                        /// <item><description>RamUser: DataWorks UserId.</description></item>
                        /// <item><description>RamRole: DataWorks UserId prefixed with &quot;ROLE_&quot;.</description></item>
                        /// <item><description>DataworksTenantMember: DataWorks UserId.</description></item>
                        /// <item><description>DataworksTenantRole: DataWorks tenant roleCode.</description></item>
                        /// <item><description>DataworksProjectRole: DataWorks workspace roleCode.</description></item>
                        /// <item><description>DataworksProjectMember: DataWorks UserId.</description></item>
                        /// <item><description>DlfRole: DlfNext role name.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ROLE_3133343434</para>
                        /// </summary>
                        [NameInMap("PrincipalId")]
                        [Validation(Required=false)]
                        public string PrincipalId { get; set; }

                        /// <summary>
                        /// <para>The principal type for authorization:</para>
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
                    /// <para>The primary key of the application content.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>a8aa620037bb410ea13837f9b4d053d8</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The approval process instance ID of the initiated application.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>777799223</para>
                    /// </summary>
                    [NameInMap("ProcessInstanceId")]
                    [Validation(Required=false)]
                    public string ProcessInstanceId { get; set; }

                    /// <summary>
                    /// <para><b>The resource declaration.</b></para>
                    /// </summary>
                    [NameInMap("Resource")]
                    [Validation(Required=false)]
                    public ListMyApplicationsResponseBodyDataDataContentsResource Resource { get; set; }
                    public class ListMyApplicationsResponseBodyDataDataContentsResource : TeaModel {
                        /// <summary>
                        /// <para><b>The ResourceSchema.name on which the resource parsing depends.</b></para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>MaxCompute</para>
                        /// </summary>
                        [NameInMap("DefSchema")]
                        [Validation(Required=false)]
                        public string DefSchema { get; set; }

                        /// <summary>
                        /// <para><b>The ResourceSchema.version on which the resource parsing depends.</b></para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>v1.0.0</para>
                        /// </summary>
                        [NameInMap("DefVersion")]
                        [Validation(Required=false)]
                        public string DefVersion { get; set; }

                        /// <summary>
                        /// <para><b>The resource metadata, whose content is constrained by ResourceSchema.</b></para>
                        /// </summary>
                        [NameInMap("MetaData")]
                        [Validation(Required=false)]
                        public Dictionary<string, object> MetaData { get; set; }

                    }

                    /// <summary>
                    /// <para>The minimum permission resource type.</para>
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
                    /// <item><description>WaitApproval: pending approval.</description></item>
                    /// <item><description>Confirmed: pending authorization.</description></item>
                    /// <item><description>RejectApproval: approval rejected.</description></item>
                    /// <item><description>AuthorizeSucceed: authorization succeeded.</description></item>
                    /// <item><description>AuthorizeFailed: authorization failed.</description></item>
                    /// <item><description>Deleted: deleted.</description></item>
                    /// <item><description>Canceled: withdrawn.</description></item>
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
                /// <item><description>WaitApproval: pending approval.</description></item>
                /// <item><description>Confirmed: pending authorization.</description></item>
                /// <item><description>RejectApproval: approval rejected.</description></item>
                /// <item><description>AuthorizeSucceed: authorization succeeded.</description></item>
                /// <item><description>AuthorizeFailed: authorization failed.</description></item>
                /// <item><description>Deleted: deleted.</description></item>
                /// <item><description>Canceled: withdrawn.</description></item>
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
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0bc5df3a17****903790e8e8a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
