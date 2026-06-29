// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListResourcePermissionsResponseBody : TeaModel {
        /// <summary>
        /// <para>Error code. OK indicates a normal request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Paginated query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListResourcePermissionsResponseBodyPageResult PageResult { get; set; }
        public class ListResourcePermissionsResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>Paginated list.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListResourcePermissionsResponseBodyPageResultData> Data { get; set; }
            public class ListResourcePermissionsResponseBodyPageResultData : TeaModel {
                /// <summary>
                /// <para>Authorization scope of the table. Specified table: selectTable. All tables in the project: projectAllTable. All logical tables in the business unit: bizUnitAllLogicTable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>selectTable</para>
                /// </summary>
                [NameInMap("AuthScope")]
                [Validation(Required=false)]
                public string AuthScope { get; set; }

                /// <summary>
                /// <para>Validity period settings.</para>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public ListResourcePermissionsResponseBodyPageResultDataPeriod Period { get; set; }
                public class ListResourcePermissionsResponseBodyPageResultDataPeriod : TeaModel {
                    /// <summary>
                    /// <para>Expiration time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1712000000000</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>Validity period type. Custom: CUSTOM. Long-term: LONG_TERM.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CUSTOM</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>List of validity periods for different permission types.</para>
                /// </summary>
                [NameInMap("PermissionPeriodList")]
                [Validation(Required=false)]
                public List<ListResourcePermissionsResponseBodyPageResultDataPermissionPeriodList> PermissionPeriodList { get; set; }
                public class ListResourcePermissionsResponseBodyPageResultDataPermissionPeriodList : TeaModel {
                    /// <summary>
                    /// <para>Validity period settings.</para>
                    /// </summary>
                    [NameInMap("Period")]
                    [Validation(Required=false)]
                    public ListResourcePermissionsResponseBodyPageResultDataPermissionPeriodListPeriod Period { get; set; }
                    public class ListResourcePermissionsResponseBodyPageResultDataPermissionPeriodListPeriod : TeaModel {
                        /// <summary>
                        /// <para>Expiration time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1712000000000</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>Validity period type. Custom: CUSTOM. Long-term: LONG_TERM.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CUSTOM</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>Permission type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SELECT</para>
                    /// </summary>
                    [NameInMap("PermissionType")]
                    [Validation(Required=false)]
                    public string PermissionType { get; set; }

                }

                /// <summary>
                /// <para>Record ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12123111</para>
                /// </summary>
                [NameInMap("RecordId")]
                [Validation(Required=false)]
                public string RecordId { get; set; }

                /// <summary>
                /// <para>Permission resource.</para>
                /// </summary>
                [NameInMap("ResourceInfo")]
                [Validation(Required=false)]
                public ListResourcePermissionsResponseBodyPageResultDataResourceInfo ResourceInfo { get; set; }
                public class ListResourcePermissionsResponseBodyPageResultDataResourceInfo : TeaModel {
                    /// <summary>
                    /// <para>Business unit.</para>
                    /// </summary>
                    [NameInMap("BizUnitInfo")]
                    [Validation(Required=false)]
                    public ListResourcePermissionsResponseBodyPageResultDataResourceInfoBizUnitInfo BizUnitInfo { get; set; }
                    public class ListResourcePermissionsResponseBodyPageResultDataResourceInfoBizUnitInfo : TeaModel {
                        /// <summary>
                        /// <para>Display name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("DisplayName")]
                        [Validation(Required=false)]
                        public string DisplayName { get; set; }

                        /// <summary>
                        /// <para>Environment identifier. Development: DEV. Production: PROD.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DEV</para>
                        /// </summary>
                        [NameInMap("Env")]
                        [Validation(Required=false)]
                        public string Env { get; set; }

                        /// <summary>
                        /// <para>ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>121323</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>Name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>Resource display name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tb1</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para>Resource environment type. Development: DEV. Production: PROD.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DEV</para>
                    /// </summary>
                    [NameInMap("Env")]
                    [Validation(Required=false)]
                    public string Env { get; set; }

                    /// <summary>
                    /// <para>Permission resource ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>a.tb1</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>Permission resource name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tb1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Project.</para>
                    /// </summary>
                    [NameInMap("ProjectInfo")]
                    [Validation(Required=false)]
                    public ListResourcePermissionsResponseBodyPageResultDataResourceInfoProjectInfo ProjectInfo { get; set; }
                    public class ListResourcePermissionsResponseBodyPageResultDataResourceInfoProjectInfo : TeaModel {
                        /// <summary>
                        /// <para>Display name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("DisplayName")]
                        [Validation(Required=false)]
                        public string DisplayName { get; set; }

                        /// <summary>
                        /// <para>Environment identifier. Development: DEV. Production: PROD.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DEV</para>
                        /// </summary>
                        [NameInMap("Env")]
                        [Validation(Required=false)]
                        public string Env { get; set; }

                        /// <summary>
                        /// <para>Project ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1123131</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        /// <summary>
                        /// <para>Name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>Resource type. Valid values: PHYSICAL_TABLE, PHYSICAL_VIEW, LOGICAL_TABLE, LOGICAL_VIEW, REALTIME_LOGICAL_TABLE, REALTIME_MIRROR_TABLE, and DATASOURCE.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PHYSICAL_TABLE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>Authorized object.</para>
                /// </summary>
                [NameInMap("TargetAccount")]
                [Validation(Required=false)]
                public ListResourcePermissionsResponseBodyPageResultDataTargetAccount TargetAccount { get; set; }
                public class ListResourcePermissionsResponseBodyPageResultDataTargetAccount : TeaModel {
                    /// <summary>
                    /// <para>Personal account: the userId on the Dataphin side. Production account: the UserId obtained by calling the GetProjectProduceUser operation. User group: the user group ID obtained by calling the ListUserGroup operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1212131</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>Personal account: the userId on the Dataphin side. Production account: the UserId obtained by calling the GetProjectProduceUser operation. User group: the user group ID obtained by calling the ListUserGroup operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Authorization account type. Valid values: PERSONAL (personal account), PRODUCE (production account), and USER_GROUP (user group).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PERSONAL</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>Total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
