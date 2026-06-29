// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListSecurityIdentifyResultsResponseBody : TeaModel {
        /// <summary>
        /// <para>Backend response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Backend response error details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Paginated query result.</para>
        /// </summary>
        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListSecurityIdentifyResultsResponseBodyPageResult PageResult { get; set; }
        public class ListSecurityIdentifyResultsResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>Paginated identification result list.</para>
            /// </summary>
            [NameInMap("SecurityIdentifyResultList")]
            [Validation(Required=false)]
            public List<ListSecurityIdentifyResultsResponseBodyPageResultSecurityIdentifyResultList> SecurityIdentifyResultList { get; set; }
            public class ListSecurityIdentifyResultsResponseBodyPageResultSecurityIdentifyResultList : TeaModel {
                /// <summary>
                /// <para>Business date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30</para>
                /// </summary>
                [NameInMap("BizDate")]
                [Validation(Required=false)]
                public string BizDate { get; set; }

                /// <summary>
                /// <para>Business unit display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LD_test</para>
                /// </summary>
                [NameInMap("BizUnitDisplayName")]
                [Validation(Required=false)]
                public string BizUnitDisplayName { get; set; }

                /// <summary>
                /// <para>Business unit ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BizUnitId")]
                [Validation(Required=false)]
                public long? BizUnitId { get; set; }

                /// <summary>
                /// <para>Business unit name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LD_test</para>
                /// </summary>
                [NameInMap("BizUnitName")]
                [Validation(Required=false)]
                public string BizUnitName { get; set; }

                /// <summary>
                /// <para>Classification abbreviation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ClassifyAbbreviation")]
                [Validation(Required=false)]
                public string ClassifyAbbreviation { get; set; }

                /// <summary>
                /// <para>Classification ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>33</para>
                /// </summary>
                [NameInMap("ClassifyId")]
                [Validation(Required=false)]
                public long? ClassifyId { get; set; }

                /// <summary>
                /// <para>Classification name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ClassifyName")]
                [Validation(Required=false)]
                public string ClassifyName { get; set; }

                /// <summary>
                /// <para>Creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 10:30:30</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>Creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>Data source ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>101121</para>
                /// </summary>
                [NameInMap("DatasourceId")]
                [Validation(Required=false)]
                public long? DatasourceId { get; set; }

                /// <summary>
                /// <para>Data source name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ds1</para>
                /// </summary>
                [NameInMap("DatasourceName")]
                [Validation(Required=false)]
                public string DatasourceName { get; set; }

                /// <summary>
                /// <para>Field description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("FieldDescription")]
                [Validation(Required=false)]
                public string FieldDescription { get; set; }

                /// <summary>
                /// <para>Field ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t_test.col1</para>
                /// </summary>
                [NameInMap("FieldId")]
                [Validation(Required=false)]
                public string FieldId { get; set; }

                /// <summary>
                /// <para>Field name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>col1</para>
                /// </summary>
                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                /// <summary>
                /// <para>Whether a better matching result exists.</para>
                /// </summary>
                [NameInMap("HasBetterRule")]
                [Validation(Required=false)]
                public bool? HasBetterRule { get; set; }

                /// <summary>
                /// <para>Identification result ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Identification record ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>99</para>
                /// </summary>
                [NameInMap("IdentifyRecordId")]
                [Validation(Required=false)]
                public long? IdentifyRecordId { get; set; }

                /// <summary>
                /// <para>Whether it is a custom tagging rule.</para>
                /// </summary>
                [NameInMap("IsCustomIdentify")]
                [Validation(Required=false)]
                public bool? IsCustomIdentify { get; set; }

                /// <summary>
                /// <para>Whether it is locked.</para>
                /// </summary>
                [NameInMap("IsLocked")]
                [Validation(Required=false)]
                public bool? IsLocked { get; set; }

                /// <summary>
                /// <para>Security level abbreviation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("LevelAbbreviation")]
                [Validation(Required=false)]
                public string LevelAbbreviation { get; set; }

                /// <summary>
                /// <para>Security level color.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LevelColor")]
                [Validation(Required=false)]
                public long? LevelColor { get; set; }

                /// <summary>
                /// <para>Security level index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LevelIndex")]
                [Validation(Required=false)]
                public long? LevelIndex { get; set; }

                /// <summary>
                /// <para>Security level name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("LevelName")]
                [Validation(Required=false)]
                public string LevelName { get; set; }

                /// <summary>
                /// <para>Modifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                /// <summary>
                /// <para>Modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-06-30 10:30:30</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <para>Project display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ProjectDisplayName")]
                [Validation(Required=false)]
                public string ProjectDisplayName { get; set; }

                /// <summary>
                /// <para>Project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>101121</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>Project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>Scan task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("ScanTaskId")]
                [Validation(Required=false)]
                public long? ScanTaskId { get; set; }

                /// <summary>
                /// <para>Status. Valid values: ENABLE and DISABLE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ENABLE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>Table catalog.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testdb</para>
                /// </summary>
                [NameInMap("TableCatalog")]
                [Validation(Required=false)]
                public string TableCatalog { get; set; }

                /// <summary>
                /// <para>Table description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TableDescription")]
                [Validation(Required=false)]
                public string TableDescription { get; set; }

                /// <summary>
                /// <para>Table environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEV</para>
                /// </summary>
                [NameInMap("TableEnv")]
                [Validation(Required=false)]
                public string TableEnv { get; set; }

                /// <summary>
                /// <para>Table ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TableId")]
                [Validation(Required=false)]
                public string TableId { get; set; }

                /// <summary>
                /// <para>Table name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t_test</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>Table identification task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("TableTaskId")]
                [Validation(Required=false)]
                public long? TableTaskId { get; set; }

                /// <summary>
                /// <para>Table type. Valid values: LOGIC_TABLE (logical table), LOGIC_DIM_TABLE (dimension logical table), LOGIC_FACT_TABLE (fact logical table), LOGIC_SUM_TABLE (summary logical table), LOGIC_ODM_SOURCE (source table), LOGIC_LABEL_TABLE (label logical table), PHYSICAL_TABLE (physical table), REAL_TIME_LOGIC_TABLE (real-time configured logical table).</para>
                /// 
                /// <b>Example:</b>
                /// <para>LOGIC_TABLE</para>
                /// </summary>
                [NameInMap("TableType")]
                [Validation(Required=false)]
                public string TableType { get; set; }

            }

            /// <summary>
            /// <para>Total number of records.</para>
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
        /// <para>Whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
