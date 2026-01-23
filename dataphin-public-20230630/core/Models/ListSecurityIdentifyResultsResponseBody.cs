// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class ListSecurityIdentifyResultsResponseBody : TeaModel {
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
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageResult")]
        [Validation(Required=false)]
        public ListSecurityIdentifyResultsResponseBodyPageResult PageResult { get; set; }
        public class ListSecurityIdentifyResultsResponseBodyPageResult : TeaModel {
            [NameInMap("SecurityIdentifyResultList")]
            [Validation(Required=false)]
            public List<ListSecurityIdentifyResultsResponseBodyPageResultSecurityIdentifyResultList> SecurityIdentifyResultList { get; set; }
            public class ListSecurityIdentifyResultsResponseBodyPageResultSecurityIdentifyResultList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-06-30</para>
                /// </summary>
                [NameInMap("BizDate")]
                [Validation(Required=false)]
                public string BizDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>LD_test</para>
                /// </summary>
                [NameInMap("BizUnitDisplayName")]
                [Validation(Required=false)]
                public string BizUnitDisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BizUnitId")]
                [Validation(Required=false)]
                public long? BizUnitId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>LD_test</para>
                /// </summary>
                [NameInMap("BizUnitName")]
                [Validation(Required=false)]
                public string BizUnitName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ClassifyAbbreviation")]
                [Validation(Required=false)]
                public string ClassifyAbbreviation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>33</para>
                /// </summary>
                [NameInMap("ClassifyId")]
                [Validation(Required=false)]
                public long? ClassifyId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ClassifyName")]
                [Validation(Required=false)]
                public string ClassifyName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-06-30 10:30:30</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>101121</para>
                /// </summary>
                [NameInMap("DatasourceId")]
                [Validation(Required=false)]
                public long? DatasourceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ds1</para>
                /// </summary>
                [NameInMap("DatasourceName")]
                [Validation(Required=false)]
                public string DatasourceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("FieldDescription")]
                [Validation(Required=false)]
                public string FieldDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>t_test.col1</para>
                /// </summary>
                [NameInMap("FieldId")]
                [Validation(Required=false)]
                public string FieldId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>col1</para>
                /// </summary>
                [NameInMap("FieldName")]
                [Validation(Required=false)]
                public string FieldName { get; set; }

                [NameInMap("HasBetterRule")]
                [Validation(Required=false)]
                public bool? HasBetterRule { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>99</para>
                /// </summary>
                [NameInMap("IdentifyRecordId")]
                [Validation(Required=false)]
                public long? IdentifyRecordId { get; set; }

                [NameInMap("IsCustomIdentify")]
                [Validation(Required=false)]
                public bool? IsCustomIdentify { get; set; }

                [NameInMap("IsLocked")]
                [Validation(Required=false)]
                public bool? IsLocked { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("LevelAbbreviation")]
                [Validation(Required=false)]
                public string LevelAbbreviation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LevelColor")]
                [Validation(Required=false)]
                public long? LevelColor { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LevelIndex")]
                [Validation(Required=false)]
                public long? LevelIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("LevelName")]
                [Validation(Required=false)]
                public string LevelName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30012011</para>
                /// </summary>
                [NameInMap("Modifier")]
                [Validation(Required=false)]
                public string Modifier { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-06-30 10:30:30</para>
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ProjectDisplayName")]
                [Validation(Required=false)]
                public string ProjectDisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>101121</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ProjectName")]
                [Validation(Required=false)]
                public string ProjectName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("ScanTaskId")]
                [Validation(Required=false)]
                public long? ScanTaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ENABLE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>testdb</para>
                /// </summary>
                [NameInMap("TableCatalog")]
                [Validation(Required=false)]
                public string TableCatalog { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TableDescription")]
                [Validation(Required=false)]
                public string TableDescription { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>DEV</para>
                /// </summary>
                [NameInMap("TableEnv")]
                [Validation(Required=false)]
                public string TableEnv { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TableId")]
                [Validation(Required=false)]
                public string TableId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>t_test</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("TableTaskId")]
                [Validation(Required=false)]
                public long? TableTaskId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>LOGIC_TABLE</para>
                /// </summary>
                [NameInMap("TableType")]
                [Validation(Required=false)]
                public string TableType { get; set; }

            }

            /// <summary>
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

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
