// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListTableMetasResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of data tables.</para>
        /// </summary>
        [NameInMap("TableMetas")]
        [Validation(Required=false)]
        public List<ListTableMetasResponseBodyTableMetas> TableMetas { get; set; }
        public class ListTableMetasResponseBodyTableMetas : TeaModel {
            /// <summary>
            /// <para>Indicates whether the data table can be deleted. The value is false if the table is referenced elsewhere.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanDelete")]
            [Validation(Required=false)]
            public bool? CanDelete { get; set; }

            /// <summary>
            /// <para>The additional configurations of the data table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;table_type&quot;:&quot;item&quot;}</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The description of the data table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>this is a test table</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of fields in the table.</para>
            /// </summary>
            [NameInMap("Fields")]
            [Validation(Required=false)]
            public List<ListTableMetasResponseBodyTableMetasFields> Fields { get; set; }
            public class ListTableMetasResponseBodyTableMetasFields : TeaModel {
                /// <summary>
                /// <para>Indicates whether the field is a dimension field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsDimensionField")]
                [Validation(Required=false)]
                public bool? IsDimensionField { get; set; }

                /// <summary>
                /// <para>The meaning of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>the gender of people</para>
                /// </summary>
                [NameInMap("Meaning")]
                [Validation(Required=false)]
                public string Meaning { get; set; }

                /// <summary>
                /// <para>The name of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gender</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The field type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BIGINT</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The creation time. The format is YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-12 12:24:33</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The time when the fields were imported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imprecation</para>
            /// </summary>
            [NameInMap("GmtImportedTime")]
            [Validation(Required=false)]
            public string GmtImportedTime { get; set; }

            /// <summary>
            /// <para>The update time. The format is YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-12 12:24:33</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>The module of the data table.</para>
            /// <list type="bullet">
            /// <item><description><para>ABTest: Experiment data tables</para>
            /// </description></item>
            /// <item><description><para>ExperimentTool: Experiment tool tables</para>
            /// </description></item>
            /// <item><description><para>DataDiagnosis: Data diagnosis</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ABTest</para>
            /// </summary>
            [NameInMap("Module")]
            [Validation(Required=false)]
            public string Module { get; set; }

            /// <summary>
            /// <para>The name of the data table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test_table</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>reso-2s416t***</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Maxcompute</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The resource URI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ResourceUri")]
            [Validation(Required=false)]
            public string ResourceUri { get; set; }

            /// <summary>
            /// <para>The ID of the data table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("TableMetaId")]
            [Validation(Required=false)]
            public string TableMetaId { get; set; }

            /// <summary>
            /// <para>The name of the table in the database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table_mysql</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

            /// <summary>
            /// <para>The type of the data table.</para>
            /// <list type="bullet">
            /// <item><description><para>MaxCompute</para>
            /// </description></item>
            /// <item><description><para>Hologres</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The URL of the table in DataWorks Data Map. This parameter is returned only if the table is a MaxCompute table.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://dmc-xxx.com/dm/table/xxx">https://dmc-xxx.com/dm/table/xxx</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
