// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListSecurityIdentifyResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>The backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// <para>The backend exception details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The paging query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListSecurityIdentifyResultsResponseBodyPageResult PageResult { get; set; }
        public class ListSecurityIdentifyResultsResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The paginated list of identification results.</para>
            /// </summary>
            [NameInMap("SecurityIdentifyResultList")]
            [Validation(Required=false)]
            public List<ListSecurityIdentifyResultsResponseBodyPageResultSecurityIdentifyResultList> SecurityIdentifyResultList { get; set; }
            public class ListSecurityIdentifyResultsResponseBodyPageResultSecurityIdentifyResultList : TeaModel {
                /// <summary>
                /// <para>The business date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30</para>
                /// </summary>
                [NameInMap("BizDate")]
                [Validation(Required=false)]
                public string BizDate { get; set; }

                /// <summary>
                /// <para>The Chinese name of the business unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LD_test</para>
                /// </summary>
                [NameInMap("BizUnitDisplayName")]
                [Validation(Required=false)]
                public string BizUnitDisplayName { get; set; }

                /// <summary>
                /// <para>The ID of the business unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BizUnitId")]
                [Validation(Required=false)]
                public long? BizUnitId { get; set; }

                /// <summary>
                /// <para>The names of the business units.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LD_test</para>
                /// </summary>
                [NameInMap("BizUnitName")]
                [Validation(Required=false)]
                public string BizUnitName { get; set; }

                /// <summary>
                /// <para>The abbreviation of the classification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ClassifyAbbreviation")]
                [Validation(Required=false)]
                public string ClassifyAbbreviation { get; set; }

                /// <summary>
                /// <para>The ID of the classification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>33</para>
                /// </summary>
                [NameInMap("ClassifyId")]
                [Validation(Required=false)]
                public long? ClassifyId { get; set; }

                /// <summary>
                /// <para>The name of the classification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ClassifyName")]
                [Validation(Required=false)]
                public string ClassifyName { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 10:30:30</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The ID of the data source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>101121</para>
                /// </summary>
                [NameInMap("DatasourceId")]
                [Validation(Required=false)]
                public long? DatasourceId { get; set; }

                /// <summary>
                /// <para>The names of the data sources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds1</para>
                /// </summary>
                [NameInMap("DatasourceName")]
                [Validation(Required=false)]
                public string DatasourceName { get; set; }

                /// <summary>
                /// <para>The description of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("FieldDescription")]
                [Validation(Required=false)]
                public string FieldDescription { get; set; }

                /// <summary>
                /// <para>The ID of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t_test.col1</para>
                /// </summary>
                [NameInMap("FieldId")]
                [Validation(Required=false)]
                public string FieldId { get; set; }

                /// <summary>
                /// <para>The name of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>col1</para>
                /// </summary>
                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                /// <summary>
                /// <para>Indicates whether a better match exists.</para>
                /// </summary>
                [NameInMap("HasBetterRule")]
                [Validation(Required=false)]
                public bool? HasBetterRule { get; set; }

                /// <summary>
                /// <para>The ID of the identification result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The ID of the identification record.</para>
                /// 
                /// <b>Example:</b>
                /// <para>99</para>
                /// </summary>
                [NameInMap("IdentifyRecordId")]
                [Validation(Required=false)]
                public long? IdentifyRecordId { get; set; }

                /// <summary>
                /// <para>Indicates whether a custom identification rule is used.</para>
                /// </summary>
                [NameInMap("IsCustomIdentify")]
                [Validation(Required=false)]
                public bool? IsCustomIdentify { get; set; }

                /// <summary>
                /// <para>Specifies whether the item is locked.</para>
                /// </summary>
                [NameInMap("IsLocked")]
                [Validation(Required=false)]
                public bool? IsLocked { get; set; }

                /// <summary>
                /// <para>The abbreviation of the classification level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("LevelAbbreviation")]
                [Validation(Required=false)]
                public string LevelAbbreviation { get; set; }

                /// <summary>
                /// <para>The color of the classification level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LevelColor")]
                [Validation(Required=false)]
                public long? LevelColor { get; set; }

                /// <summary>
                /// <para>The classification level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LevelIndex")]
                [Validation(Required=false)]
                public long? LevelIndex { get; set; }

                /// <summary>
                /// <para>The name of the classification level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("LevelName")]
                [Validation(Required=false)]
                public string LevelName { get; set; }

                /// <summary>
                /// <para>The modifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 10:30:30</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>The Chinese name of the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ProjectDisplayName")]
                [Validation(Required=false)]
                public string ProjectDisplayName { get; set; }

                /// <summary>
                /// <para>The ID of the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>101121</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The names of the projects.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The ID of the scan task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("ScanTaskId")]
                [Validation(Required=false)]
                public long? ScanTaskId { get; set; }

                /// <summary>
                /// <para>The status. Valid values: ENABLE (enabled) and DISABLE (disabled).</para>
                /// 
                /// <b>Example:</b>
                /// <para>ENABLE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The catalog of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testdb</para>
                /// </summary>
                [NameInMap("TableCatalog")]
                [Validation(Required=false)]
                public string TableCatalog { get; set; }

                /// <summary>
                /// <para>The description of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TableDescription")]
                [Validation(Required=false)]
                public string TableDescription { get; set; }

                /// <summary>
                /// <para>The environment of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEV</para>
                /// </summary>
                [NameInMap("TableEnv")]
                [Validation(Required=false)]
                public string TableEnv { get; set; }

                /// <summary>
                /// <para>The ID of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TableId")]
                [Validation(Required=false)]
                public string TableId { get; set; }

                /// <summary>
                /// <para>The name of the table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t_test</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The ID of the table identification task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("TableTaskId")]
                [Validation(Required=false)]
                public long? TableTaskId { get; set; }

                /// <summary>
                /// <para>The table type. Valid values: LOGIC_TABLE (logical table), LOGIC_DIM_TABLE (logical dimension table), LOGIC_FACT_TABLE (logical fact table), LOGIC_SUM_TABLE (logical aggregate table), LOGIC_ODM_SOURCE (source table), LOGIC_LABEL_TABLE (logical tag table), PHYSICAL_TABLE (physical table), and REAL_TIME_LOGIC_TABLE (real-time configured logical table).</para>
                /// 
                /// <b>Example:</b>
                /// <para>LOGIC_TABLE</para>
                /// </summary>
                [NameInMap("TableType")]
                [Validation(Required=false)]
                public string TableType { get; set; }

            }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>68</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>82E78D6B-AA8F-1FEF-8AA3-5C9DA2A79140</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
