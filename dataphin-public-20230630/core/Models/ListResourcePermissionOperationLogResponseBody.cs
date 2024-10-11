// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListResourcePermissionOperationLogResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListResourcePermissionOperationLogResponseBodyPageResult PageResult { get; set; }
        public class ListResourcePermissionOperationLogResponseBodyPageResult : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListResourcePermissionOperationLogResponseBodyPageResultData> Data { get; set; }
            public class ListResourcePermissionOperationLogResponseBodyPageResultData : TeaModel {
                [NameInMap("Account")]
                [Validation(Required=false)]
                public ListResourcePermissionOperationLogResponseBodyPageResultDataAccount Account { get; set; }
                public class ListResourcePermissionOperationLogResponseBodyPageResultDataAccount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1212131</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PERSONAL</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>selectTable</para>
                /// </summary>
                [NameInMap("AuthScope")]
                [Validation(Required=false)]
                public string AuthScope { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123133</para>
                /// </summary>
                [NameInMap("OperateId")]
                [Validation(Required=false)]
                public long? OperateId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1710012121000</para>
                /// </summary>
                [NameInMap("OperateTime")]
                [Validation(Required=false)]
                public long? OperateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>APPLY</para>
                /// </summary>
                [NameInMap("OperateType")]
                [Validation(Required=false)]
                public string OperateType { get; set; }

                [NameInMap("Period")]
                [Validation(Required=false)]
                public ListResourcePermissionOperationLogResponseBodyPageResultDataPeriod Period { get; set; }
                public class ListResourcePermissionOperationLogResponseBodyPageResultDataPeriod : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1712000000000</para>
                    /// </summary>
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>CUSTOM</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>xx测试</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                [NameInMap("ResourceInfo")]
                [Validation(Required=false)]
                public ListResourcePermissionOperationLogResponseBodyPageResultDataResourceInfo ResourceInfo { get; set; }
                public class ListResourcePermissionOperationLogResponseBodyPageResultDataResourceInfo : TeaModel {
                    [NameInMap("BizUnitInfo")]
                    [Validation(Required=false)]
                    public ListResourcePermissionOperationLogResponseBodyPageResultDataResourceInfoBizUnitInfo BizUnitInfo { get; set; }
                    public class ListResourcePermissionOperationLogResponseBodyPageResultDataResourceInfoBizUnitInfo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("DisplayName")]
                        [Validation(Required=false)]
                        public string DisplayName { get; set; }

                        /// <summary>
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
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>tb1</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>DEV</para>
                    /// </summary>
                    [NameInMap("Env")]
                    [Validation(Required=false)]
                    public string Env { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>a.tb1</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>tb1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("ProjectInfo")]
                    [Validation(Required=false)]
                    public ListResourcePermissionOperationLogResponseBodyPageResultDataResourceInfoProjectInfo ProjectInfo { get; set; }
                    public class ListResourcePermissionOperationLogResponseBodyPageResultDataResourceInfoProjectInfo : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("DisplayName")]
                        [Validation(Required=false)]
                        public string DisplayName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>DEV</para>
                        /// </summary>
                        [NameInMap("Env")]
                        [Validation(Required=false)]
                        public string Env { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1123131</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PHYSICAL_TABLE</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("TargetAccount")]
                [Validation(Required=false)]
                public ListResourcePermissionOperationLogResponseBodyPageResultDataTargetAccount TargetAccount { get; set; }
                public class ListResourcePermissionOperationLogResponseBodyPageResultDataTargetAccount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1212131</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public string Id { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xx</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>PERSONAL</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>121</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
