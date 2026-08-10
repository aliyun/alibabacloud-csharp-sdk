// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListResourcePermissionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message returned for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The paged query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListResourcePermissionsResponseBodyPageResult PageResult { get; set; }
        public class ListResourcePermissionsResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The paged list.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListResourcePermissionsResponseBodyPageResultData> Data { get; set; }
            public class ListResourcePermissionsResponseBodyPageResultData : TeaModel {
                /// <summary>
                /// <para>The authorization scope of the table. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>selectTable: a specified table.</description></item>
                /// <item><description>projectAllTable: all tables in the project.</description></item>
                /// <item><description>bizUnitAllLogicTable: all logical tables in the business unit.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>selectTable</para>
                /// </summary>
                [NameInMap("AuthScope")]
                [Validation(Required=false)]
                public string AuthScope { get; set; }

                /// <summary>
                /// <para>The validity period settings.</para>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public ListResourcePermissionsResponseBodyPageResultDataPeriod Period { get; set; }
                public class ListResourcePermissionsResponseBodyPageResultDataPeriod : TeaModel {
                    /// <summary>
                    /// <para>The expiration time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1712000000000</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <para>The validity period type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CUSTOM</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The list of validity periods for different permission types.</para>
                /// </summary>
                [NameInMap("PermissionPeriodList")]
                [Validation(Required=false)]
                public List<ListResourcePermissionsResponseBodyPageResultDataPermissionPeriodList> PermissionPeriodList { get; set; }
                public class ListResourcePermissionsResponseBodyPageResultDataPermissionPeriodList : TeaModel {
                    /// <summary>
                    /// <para>The validity period settings.</para>
                    /// </summary>
                    [NameInMap("Period")]
                    [Validation(Required=false)]
                    public ListResourcePermissionsResponseBodyPageResultDataPermissionPeriodListPeriod Period { get; set; }
                    public class ListResourcePermissionsResponseBodyPageResultDataPermissionPeriodListPeriod : TeaModel {
                        /// <summary>
                        /// <para>The expiration time.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1712000000000</para>
                        /// </summary>
                        [NameInMap("EndTime")]
                        [Validation(Required=false)]
                        public string EndTime { get; set; }

                        /// <summary>
                        /// <para>The validity period type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CUSTOM</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                    /// <summary>
                    /// <para>The permission type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SELECT</para>
                    /// </summary>
                    [NameInMap("PermissionType")]
                    [Validation(Required=false)]
                    public string PermissionType { get; set; }

                }

                /// <summary>
                /// <para>The record ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12123111</para>
                /// </summary>
                [NameInMap("RecordId")]
                [Validation(Required=false)]
                public string RecordId { get; set; }

                /// <summary>
                /// <para>The permission resource.</para>
                /// </summary>
                [NameInMap("ResourceInfo")]
                [Validation(Required=false)]
                public ListResourcePermissionsResponseBodyPageResultDataResourceInfo ResourceInfo { get; set; }
                public class ListResourcePermissionsResponseBodyPageResultDataResourceInfo : TeaModel {
                    /// <summary>
                    /// <para>The business unit.</para>
                    /// </summary>
                    [NameInMap("BizUnitInfo")]
                    [Validation(Required=false)]
                    public ListResourcePermissionsResponseBodyPageResultDataResourceInfoBizUnitInfo BizUnitInfo { get; set; }
                    public class ListResourcePermissionsResponseBodyPageResultDataResourceInfoBizUnitInfo : TeaModel {
                        /// <summary>
                        /// <para>The display name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("DisplayName")]
                        [Validation(Required=false)]
                        public string DisplayName { get; set; }

                        /// <summary>
                        /// <para>The environment identifier. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>DEV: development.</description></item>
                        /// <item><description>PROD: production.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DEV</para>
                        /// </summary>
                        [NameInMap("Env")]
                        [Validation(Required=false)]
                        public string Env { get; set; }

                        /// <summary>
                        /// <para>Id</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>121323</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The display name of the resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tb1</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para>The resource environment type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>DEV: development.</description></item>
                    /// <item><description>PROD: production.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DEV</para>
                    /// </summary>
                    [NameInMap("Env")]
                    [Validation(Required=false)]
                    public string Env { get; set; }

                    /// <summary>
                    /// <para>The ID of the permission resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>a.tb1</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The name of the permission resource.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tb1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The project.</para>
                    /// </summary>
                    [NameInMap("ProjectInfo")]
                    [Validation(Required=false)]
                    public ListResourcePermissionsResponseBodyPageResultDataResourceInfoProjectInfo ProjectInfo { get; set; }
                    public class ListResourcePermissionsResponseBodyPageResultDataResourceInfoProjectInfo : TeaModel {
                        /// <summary>
                        /// <para>The display name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("DisplayName")]
                        [Validation(Required=false)]
                        public string DisplayName { get; set; }

                        /// <summary>
                        /// <para>The environment identifier. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>DEV: development.</description></item>
                        /// <item><description>PROD: production.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DEV</para>
                        /// </summary>
                        [NameInMap("Env")]
                        [Validation(Required=false)]
                        public string Env { get; set; }

                        /// <summary>
                        /// <para>The project ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1123131</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        /// <summary>
                        /// <para>The name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The resource type. Valid values: PHYSICAL_TABLE, PHYSICAL_VIEW, LOGICAL_TABLE, LOGICAL_VIEW, REALTIME_LOGICAL_TABLE, REALTIME_MIRROR_TABLE, DATASOURCE.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>PHYSICAL_TABLE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The authorized object.</para>
                /// </summary>
                [NameInMap("TargetAccount")]
                [Validation(Required=false)]
                public ListResourcePermissionsResponseBodyPageResultDataTargetAccount TargetAccount { get; set; }
                public class ListResourcePermissionsResponseBodyPageResultDataTargetAccount : TeaModel {
                    /// <summary>
                    /// <para>The account ID. For an individual account, this is the Dataphin-side userId. For a production account, this is the UserId obtained by calling the GetProjectProduceUser operation. For a user group, this is the user group ID obtained by calling the ListUserGroup operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1212131</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The account ID. For an individual account, this is the Dataphin-side userId. For a production account, this is the UserId obtained by calling the GetProjectProduceUser operation. For a user group, this is the user group ID obtained by calling the ListUserGroup operation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The type of the authorized account. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>PERSONAL: individual account.</description></item>
                    /// <item><description>PRODUCE: production account.</description></item>
                    /// <item><description>USER_GROUP: user group.</description></item>
                    /// </list>
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
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
