// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetBatchTaskUdfLineagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. The value OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBatchTaskUdfLineagesResponseBodyData Data { get; set; }
        public class GetBatchTaskUdfLineagesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of lineage groups.</para>
            /// </summary>
            [NameInMap("LineageGroupList")]
            [Validation(Required=false)]
            public List<GetBatchTaskUdfLineagesResponseBodyDataLineageGroupList> LineageGroupList { get; set; }
            public class GetBatchTaskUdfLineagesResponseBodyDataLineageGroupList : TeaModel {
                /// <summary>
                /// <para>The collection of input lineage tables.</para>
                /// </summary>
                [NameInMap("InputLineageList")]
                [Validation(Required=false)]
                public List<GetBatchTaskUdfLineagesResponseBodyDataLineageGroupListInputLineageList> InputLineageList { get; set; }
                public class GetBatchTaskUdfLineagesResponseBodyDataLineageGroupListInputLineageList : TeaModel {
                    /// <summary>
                    /// <para>The business unit ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>103111231</para>
                    /// </summary>
                    [NameInMap("BizUnitId")]
                    [Validation(Required=false)]
                    public string BizUnitId { get; set; }

                    /// <summary>
                    /// <para>The business unit name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx测试</para>
                    /// </summary>
                    [NameInMap("BizUnitName")]
                    [Validation(Required=false)]
                    public string BizUnitName { get; set; }

                    /// <summary>
                    /// <para>The list of lineage columns.</para>
                    /// </summary>
                    [NameInMap("ColumnList")]
                    [Validation(Required=false)]
                    public List<GetBatchTaskUdfLineagesResponseBodyDataLineageGroupListInputLineageListColumnList> ColumnList { get; set; }
                    public class GetBatchTaskUdfLineagesResponseBodyDataLineageGroupListInputLineageListColumnList : TeaModel {
                        /// <summary>
                        /// <para>The data type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>varchar</para>
                        /// </summary>
                        [NameInMap("DataType")]
                        [Validation(Required=false)]
                        public string DataType { get; set; }

                        /// <summary>
                        /// <para>The description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The column ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>c011</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The column name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>c011</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the column is a partition key.</para>
                        /// </summary>
                        [NameInMap("PartitionKey")]
                        [Validation(Required=false)]
                        public bool? PartitionKey { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the column is a primary key.</para>
                        /// </summary>
                        [NameInMap("PrimaryKey")]
                        [Validation(Required=false)]
                        public bool? PrimaryKey { get; set; }

                    }

                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test xx</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The display name of the table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>t_input</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para>The environment. Valid values: prod and dev.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dev</para>
                    /// </summary>
                    [NameInMap("Env")]
                    [Validation(Required=false)]
                    public string Env { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the full table is selected.</para>
                    /// </summary>
                    [NameInMap("FullTable")]
                    [Validation(Required=false)]
                    public bool? FullTable { get; set; }

                    /// <summary>
                    /// <para>The globally unique ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Guid_101121</para>
                    /// </summary>
                    [NameInMap("Guid")]
                    [Validation(Required=false)]
                    public string Guid { get; set; }

                    /// <summary>
                    /// <para>The table name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>t_input</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The owner of the table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("OwnerName")]
                    [Validation(Required=false)]
                    public string OwnerName { get; set; }

                    /// <summary>
                    /// <para>The owner of the table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20112101</para>
                    /// </summary>
                    [NameInMap("OwnerUserId")]
                    [Validation(Required=false)]
                    public string OwnerUserId { get; set; }

                    /// <summary>
                    /// <para>The project to which the table belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>131211211</para>
                    /// </summary>
                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public string ProjectId { get; set; }

                    /// <summary>
                    /// <para>The project to which the table belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>prj_test</para>
                    /// </summary>
                    [NameInMap("ProjectName")]
                    [Validation(Required=false)]
                    public string ProjectName { get; set; }

                    /// <summary>
                    /// <para>The table subtype. For example, dim indicates a dimension logical table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dim</para>
                    /// </summary>
                    [NameInMap("SubType")]
                    [Validation(Required=false)]
                    public string SubType { get; set; }

                }

                /// <summary>
                /// <para>The collection of output lineage tables.</para>
                /// </summary>
                [NameInMap("OutputLineageList")]
                [Validation(Required=false)]
                public List<GetBatchTaskUdfLineagesResponseBodyDataLineageGroupListOutputLineageList> OutputLineageList { get; set; }
                public class GetBatchTaskUdfLineagesResponseBodyDataLineageGroupListOutputLineageList : TeaModel {
                    /// <summary>
                    /// <para>The business unit ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>103111231</para>
                    /// </summary>
                    [NameInMap("BizUnitId")]
                    [Validation(Required=false)]
                    public string BizUnitId { get; set; }

                    /// <summary>
                    /// <para>The business unit name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx测试</para>
                    /// </summary>
                    [NameInMap("BizUnitName")]
                    [Validation(Required=false)]
                    public string BizUnitName { get; set; }

                    /// <summary>
                    /// <para>The list of lineage columns.</para>
                    /// </summary>
                    [NameInMap("ColumnList")]
                    [Validation(Required=false)]
                    public List<GetBatchTaskUdfLineagesResponseBodyDataLineageGroupListOutputLineageListColumnList> ColumnList { get; set; }
                    public class GetBatchTaskUdfLineagesResponseBodyDataLineageGroupListOutputLineageListColumnList : TeaModel {
                        /// <summary>
                        /// <para>The data type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>varchar</para>
                        /// </summary>
                        [NameInMap("DataType")]
                        [Validation(Required=false)]
                        public string DataType { get; set; }

                        /// <summary>
                        /// <para>The description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>xx</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The column ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>c011</para>
                        /// </summary>
                        [NameInMap("Id")]
                        [Validation(Required=false)]
                        public string Id { get; set; }

                        /// <summary>
                        /// <para>The column name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>c011</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the column is a partition key.</para>
                        /// </summary>
                        [NameInMap("PartitionKey")]
                        [Validation(Required=false)]
                        public bool? PartitionKey { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the column is a primary key.</para>
                        /// </summary>
                        [NameInMap("PrimaryKey")]
                        [Validation(Required=false)]
                        public bool? PrimaryKey { get; set; }

                    }

                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test xx</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The display name of the table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>t_input</para>
                    /// </summary>
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    /// <summary>
                    /// <para>The environment. Valid values: prod and dev.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dev</para>
                    /// </summary>
                    [NameInMap("Env")]
                    [Validation(Required=false)]
                    public string Env { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the full table is selected.</para>
                    /// </summary>
                    [NameInMap("FullTable")]
                    [Validation(Required=false)]
                    public bool? FullTable { get; set; }

                    /// <summary>
                    /// <para>The globally unique ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Guid_101121</para>
                    /// </summary>
                    [NameInMap("Guid")]
                    [Validation(Required=false)]
                    public string Guid { get; set; }

                    /// <summary>
                    /// <para>The table name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>t_input</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The owner of the table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>张三</para>
                    /// </summary>
                    [NameInMap("OwnerName")]
                    [Validation(Required=false)]
                    public string OwnerName { get; set; }

                    /// <summary>
                    /// <para>The owner of the table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20112101</para>
                    /// </summary>
                    [NameInMap("OwnerUserId")]
                    [Validation(Required=false)]
                    public string OwnerUserId { get; set; }

                    /// <summary>
                    /// <para>The project to which the table belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>131211211</para>
                    /// </summary>
                    [NameInMap("ProjectId")]
                    [Validation(Required=false)]
                    public string ProjectId { get; set; }

                    /// <summary>
                    /// <para>The project to which the table belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>prj_test</para>
                    /// </summary>
                    [NameInMap("ProjectName")]
                    [Validation(Required=false)]
                    public string ProjectName { get; set; }

                    /// <summary>
                    /// <para>The table subtype. For example, dim indicates a dimension logical table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dim</para>
                    /// </summary>
                    [NameInMap("SubType")]
                    [Validation(Required=false)]
                    public string SubType { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
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
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
