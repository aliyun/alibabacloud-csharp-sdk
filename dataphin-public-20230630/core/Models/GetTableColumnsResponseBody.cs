// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetTableColumnsResponseBody : TeaModel {
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
        /// <para>List of asset table columns.</para>
        /// </summary>
        [NameInMap("ColumnList")]
        [Validation(Required=false)]
        public List<GetTableColumnsResponseBodyColumnList> ColumnList { get; set; }
        public class GetTableColumnsResponseBodyColumnList : TeaModel {
            /// <summary>
            /// <para>Data classification ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("ClassifyId")]
            [Validation(Required=false)]
            public long? ClassifyId { get; set; }

            /// <summary>
            /// <para>Data classification name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ClassifyName")]
            [Validation(Required=false)]
            public string ClassifyName { get; set; }

            /// <summary>
            /// <para>Column comment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30 00:00:00</para>
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
            /// <para>3301</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public long? DataSourceId { get; set; }

            /// <summary>
            /// <para>Data source type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MAX_COMPUTE</para>
            /// </summary>
            [NameInMap("DataSourceType")]
            [Validation(Required=false)]
            public string DataSourceType { get; set; }

            /// <summary>
            /// <para>Data type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>varchar</para>
            /// </summary>
            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            /// <summary>
            /// <para>Default value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// <para>Column display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>年龄</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>Environment: dev or prod.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dev</para>
            /// </summary>
            [NameInMap("Env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>Column GUID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1121.col1</para>
            /// </summary>
            [NameInMap("Guid")]
            [Validation(Required=false)]
            public string Guid { get; set; }

            /// <summary>
            /// <para>Whether this is a foreign key.</para>
            /// </summary>
            [NameInMap("IsForeignKey")]
            [Validation(Required=false)]
            public bool? IsForeignKey { get; set; }

            /// <summary>
            /// <para>Whether this is a partition column.</para>
            /// </summary>
            [NameInMap("IsPartitionColumn")]
            [Validation(Required=false)]
            public bool? IsPartitionColumn { get; set; }

            /// <summary>
            /// <para>Whether this is a primary key.</para>
            /// </summary>
            [NameInMap("IsPrimaryKey")]
            [Validation(Required=false)]
            public bool? IsPrimaryKey { get; set; }

            /// <summary>
            /// <para>Last modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30012011</para>
            /// </summary>
            [NameInMap("LastModifier")]
            [Validation(Required=false)]
            public string LastModifier { get; set; }

            /// <summary>
            /// <para>Data level abbreviation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>L1</para>
            /// </summary>
            [NameInMap("LevelAbbreviation")]
            [Validation(Required=false)]
            public string LevelAbbreviation { get; set; }

            /// <summary>
            /// <para>Modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-06-30 00:00:00</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>Column name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>age</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Whether null values are allowed.</para>
            /// </summary>
            [NameInMap("Nullable")]
            [Validation(Required=false)]
            public bool? Nullable { get; set; }

            /// <summary>
            /// <para>Sequence number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SeqNumber")]
            [Validation(Required=false)]
            public int? SeqNumber { get; set; }

            /// <summary>
            /// <para>Table GUID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1121</para>
            /// </summary>
            [NameInMap("TableGuid")]
            [Validation(Required=false)]
            public string TableGuid { get; set; }

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
            /// <para>Query count in the last 30 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>99</para>
            /// </summary>
            [NameInMap("VisitCount30d")]
            [Validation(Required=false)]
            public long? VisitCount30d { get; set; }

        }

        /// <summary>
        /// <para>HTTP response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Backend response exception details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>internal error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
