// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListResourcePermissionOperationLogResponseBody : TeaModel {
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
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The paging query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListResourcePermissionOperationLogResponseBodyPageResult PageResult { get; set; }
        public class ListResourcePermissionOperationLogResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The paginated records.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListResourcePermissionOperationLogResponseBodyPageResultData> Data { get; set; }
            public class ListResourcePermissionOperationLogResponseBodyPageResultData : TeaModel {
                /// <summary>
                /// <para>The operator.</para>
                /// </summary>
                [NameInMap("Account")]
                [Validation(Required=false)]
                public ListResourcePermissionOperationLogResponseBodyPageResultDataAccount Account { get; set; }
                public class ListResourcePermissionOperationLogResponseBodyPageResultDataAccount : TeaModel {
                    /// <summary>
                    /// <para>The account ID.</para>
                    /// <list type="bullet">
                    /// <item><description>Individual account: the userId on the Dataphin side.</description></item>
                    /// <item><description>Production account: the UserId obtained by calling the GetProjectProduceUser operation.</description></item>
                    /// <item><description>User group: the user group ID obtained by calling the ListUserGroup operation.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1212131</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The account name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The authorization account type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>PERSONAL: individual account</description></item>
                    /// <item><description>PRODUCE: production account</description></item>
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

                /// <summary>
                /// <para>The authorization scope of the table. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>selectTable: specified table</description></item>
                /// <item><description>projectAllTable: all tables in the project</description></item>
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
                /// <para>The operation ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123133</para>
                /// </summary>
                [NameInMap("OperateId")]
                [Validation(Required=false)]
                public long? OperateId { get; set; }

                /// <summary>
                /// <para>The operation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1710012121000</para>
                /// </summary>
                [NameInMap("OperateTime")]
                [Validation(Required=false)]
                public long? OperateTime { get; set; }

                /// <summary>
                /// <para>The operation type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>APPLY: Apply for permissions.</description></item>
                /// <item><description>GRANT: Grant permissions.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>APPLY</para>
                /// </summary>
                [NameInMap("OperateType")]
                [Validation(Required=false)]
                public string OperateType { get; set; }

                /// <summary>
                /// <para>The validity period settings.</para>
                /// </summary>
                [NameInMap("Period")]
                [Validation(Required=false)]
                public ListResourcePermissionOperationLogResponseBodyPageResultDataPeriod Period { get; set; }
                public class ListResourcePermissionOperationLogResponseBodyPageResultDataPeriod : TeaModel {
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
                    /// <para>The validity period type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>CUSTOM: custom</description></item>
                    /// <item><description>LONG_TERM: permanently valid</description></item>
                    /// <item><description>DAYS_30: valid for 30 days</description></item>
                    /// <item><description>DAYS_90: valid for 90 days</description></item>
                    /// <item><description>DAYS_180: valid for 180 days.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CUSTOM</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The reason.</para>
                /// 
                /// <b>Example:</b>
                /// <para>xx测试</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                /// <summary>
                /// <para>The permission resource.</para>
                /// </summary>
                [NameInMap("ResourceInfo")]
                [Validation(Required=false)]
                public ListResourcePermissionOperationLogResponseBodyPageResultDataResourceInfo ResourceInfo { get; set; }
                public class ListResourcePermissionOperationLogResponseBodyPageResultDataResourceInfo : TeaModel {
                    /// <summary>
                    /// <para>The business unit information.</para>
                    /// </summary>
                    [NameInMap("BizUnitInfo")]
                    [Validation(Required=false)]
                    public ListResourcePermissionOperationLogResponseBodyPageResultDataResourceInfoBizUnitInfo BizUnitInfo { get; set; }
                    public class ListResourcePermissionOperationLogResponseBodyPageResultDataResourceInfoBizUnitInfo : TeaModel {
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
                        /// <para>The environment identifier. Valid values: </para>
                        /// <list type="bullet">
                        /// <item><description>DEV</description></item>
                        /// <item><description>PROD.</description></item>
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
                    /// <para>The resource environment. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>DEV</description></item>
                    /// <item><description>PROD.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DEV</para>
                    /// </summary>
                    [NameInMap("Env")]
                    [Validation(Required=false)]
                    public string Env { get; set; }

                    /// <summary>
                    /// <para>The permission resource ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>a.tb1</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The permission resource name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tb1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The project information.</para>
                    /// </summary>
                    [NameInMap("ProjectInfo")]
                    [Validation(Required=false)]
                    public ListResourcePermissionOperationLogResponseBodyPageResultDataResourceInfoProjectInfo ProjectInfo { get; set; }
                    public class ListResourcePermissionOperationLogResponseBodyPageResultDataResourceInfoProjectInfo : TeaModel {
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
                        /// <para>The environment identifier. Valid values: </para>
                        /// <list type="bullet">
                        /// <item><description>DEV</description></item>
                        /// <item><description>PROD.</description></item>
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
                    /// <para>The resource type. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>PHYSICAL_TABLE: physical table</description></item>
                    /// <item><description>PHYSICAL_VIEW: physical view</description></item>
                    /// <item><description>LOGICAL_TABLE: fact logical table</description></item>
                    /// <item><description>LOGICAL_VIEW: fact logical view</description></item>
                    /// <item><description>REALTIME_LOGICAL_TABLE: real-time meta table</description></item>
                    /// <item><description>REALTIME_MIRROR_TABLE: real-time meta table</description></item>
                    /// <item><description>DATASOURCE: datasource.</description></item>
                    /// </list>
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
                public ListResourcePermissionOperationLogResponseBodyPageResultDataTargetAccount TargetAccount { get; set; }
                public class ListResourcePermissionOperationLogResponseBodyPageResultDataTargetAccount : TeaModel {
                    /// <summary>
                    /// <para>The account ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1212131</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <para>The account name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The authorized account type.</para>
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
