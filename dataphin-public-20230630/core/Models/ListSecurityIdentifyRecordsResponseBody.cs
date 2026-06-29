// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListSecurityIdentifyRecordsResponseBody : TeaModel {
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
        public ListSecurityIdentifyRecordsResponseBodyPageResult PageResult { get; set; }
        public class ListSecurityIdentifyRecordsResponseBodyPageResult : TeaModel {
            /// <summary>
            /// <para>The list of identification records.</para>
            /// </summary>
            [NameInMap("IdentifyRecordList")]
            [Validation(Required=false)]
            public List<ListSecurityIdentifyRecordsResponseBodyPageResultIdentifyRecordList> IdentifyRecordList { get; set; }
            public class ListSecurityIdentifyRecordsResponseBodyPageResultIdentifyRecordList : TeaModel {
                /// <summary>
                /// <para>The actual match rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1</para>
                /// </summary>
                [NameInMap("ActualIdentifyRate")]
                [Validation(Required=false)]
                public double? ActualIdentifyRate { get; set; }

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
                /// <para>The display name of the business unit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_abc</para>
                /// </summary>
                [NameInMap("BizUnitDisplayName")]
                [Validation(Required=false)]
                public string BizUnitDisplayName { get; set; }

                /// <summary>
                /// <para>The business unit ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("BizUnitId")]
                [Validation(Required=false)]
                public long? BizUnitId { get; set; }

                /// <summary>
                /// <para>The business unit name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("BizUnitName")]
                [Validation(Required=false)]
                public string BizUnitName { get; set; }

                /// <summary>
                /// <para>The classification abbreviation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ClassifyAbbreviation")]
                [Validation(Required=false)]
                public string ClassifyAbbreviation { get; set; }

                /// <summary>
                /// <para>The classification ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ClassifyId")]
                [Validation(Required=false)]
                public long? ClassifyId { get; set; }

                /// <summary>
                /// <para>The classification name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ClassifyName")]
                [Validation(Required=false)]
                public string ClassifyName { get; set; }

                /// <summary>
                /// <para>The classification effective status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ENABLE: enabled.</description></item>
                /// <item><description>DISABLE: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ENABLE</para>
                /// </summary>
                [NameInMap("ClassifyStatus")]
                [Validation(Required=false)]
                public string ClassifyStatus { get; set; }

                /// <summary>
                /// <para>The datasource ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("DatasourceId")]
                [Validation(Required=false)]
                public long? DatasourceId { get; set; }

                /// <summary>
                /// <para>The datasource name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DatasourceName")]
                [Validation(Required=false)]
                public string DatasourceName { get; set; }

                /// <summary>
                /// <para>The field description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("FieldDescription")]
                [Validation(Required=false)]
                public string FieldDescription { get; set; }

                /// <summary>
                /// <para>The field ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t_test.col1</para>
                /// </summary>
                [NameInMap("FieldId")]
                [Validation(Required=false)]
                public string FieldId { get; set; }

                /// <summary>
                /// <para>The field name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>col1</para>
                /// </summary>
                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                /// <summary>
                /// <para>The identification record ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Indicates whether this is a better match.</para>
                /// </summary>
                [NameInMap("IsBetterMatch")]
                [Validation(Required=false)]
                public bool? IsBetterMatch { get; set; }

                /// <summary>
                /// <para>Indicates whether a custom tagging rule is used.</para>
                /// </summary>
                [NameInMap("IsCustomIdentify")]
                [Validation(Required=false)]
                public bool? IsCustomIdentify { get; set; }

                /// <summary>
                /// <para>Indicates whether the record is locked.</para>
                /// </summary>
                [NameInMap("IsLocked")]
                [Validation(Required=false)]
                public bool? IsLocked { get; set; }

                /// <summary>
                /// <para>The classification level abbreviation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("LevelAbbreviation")]
                [Validation(Required=false)]
                public string LevelAbbreviation { get; set; }

                /// <summary>
                /// <para>The classification level index.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LevelIndex")]
                [Validation(Required=false)]
                public long? LevelIndex { get; set; }

                /// <summary>
                /// <para>The classification level name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("LevelName")]
                [Validation(Required=false)]
                public string LevelName { get; set; }

                /// <summary>
                /// <para>The display name of the project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test_abc</para>
                /// </summary>
                [NameInMap("ProjectDisplayName")]
                [Validation(Required=false)]
                public string ProjectDisplayName { get; set; }

                /// <summary>
                /// <para>The project ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The project name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <para>The table description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TableDescription")]
                [Validation(Required=false)]
                public string TableDescription { get; set; }

                /// <summary>
                /// <para>The table environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DEV</para>
                /// </summary>
                [NameInMap("TableEnv")]
                [Validation(Required=false)]
                public string TableEnv { get; set; }

                /// <summary>
                /// <para>The table ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TableId")]
                [Validation(Required=false)]
                public string TableId { get; set; }

                /// <summary>
                /// <para>The table name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t_test</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The table type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>LOGIC_TABLE: logical table.</description></item>
                /// <item><description>LOGIC_DIM_TABLE: logical dimension table.</description></item>
                /// <item><description>LOGIC_FACT_TABLE: logical fact table.</description></item>
                /// <item><description>LOGIC_SUM_TABLE: logical aggregate table.</description></item>
                /// <item><description>LOGIC_ODM_SOURCE: source table.</description></item>
                /// <item><description>LOGIC_LABEL_TABLE: logical label table.</description></item>
                /// <item><description>PHYSICAL_TABLE: physical table.</description></item>
                /// <item><description>REAL_TIME_LOGIC_TABLE: real-time configured logical table.</description></item>
                /// </list>
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
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
