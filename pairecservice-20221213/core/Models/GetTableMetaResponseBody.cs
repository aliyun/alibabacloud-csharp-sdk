// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetTableMetaResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the table can be deleted. The value is <c>false</c> if other resources reference the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CanDelete")]
        [Validation(Required=false)]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// <para>Additional configurations for the table, provided as a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;table_type&quot;:&quot;item&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The table description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test table</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The fields in the table.</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<GetTableMetaResponseBodyFields> Fields { get; set; }
        public class GetTableMetaResponseBodyFields : TeaModel {
            /// <summary>
            /// <para>Whether the field is a dimension field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDimensionField")]
            [Validation(Required=false)]
            public bool? IsDimensionField { get; set; }

            /// <summary>
            /// <para>The field meaning.</para>
            /// 
            /// <b>Example:</b>
            /// <para>the gender of people</para>
            /// </summary>
            [NameInMap("Meaning")]
            [Validation(Required=false)]
            public string Meaning { get; set; }

            /// <summary>
            /// <para>The field name.</para>
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
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15:24:33</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The import time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtImportedTime")]
        [Validation(Required=false)]
        public string GmtImportedTime { get; set; }

        /// <summary>
        /// <para>The modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15:24:33</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The table module. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>ABTest</c>: An A/B testing data table.</para>
        /// </description></item>
        /// <item><description><para><c>ExperimentTool</c>: An experiment tool table.</para>
        /// </description></item>
        /// <item><description><para><c>DataDiagnosis</c>: A table for data diagnosis.</para>
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
        /// <para>The table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_table</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>reso-wkgo***</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Maxcompute</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ResourceUri")]
        [Validation(Required=false)]
        public string ResourceUri { get; set; }

        /// <summary>
        /// <para>The table ID.</para>
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
        /// <para>The table type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>MaxCompute</c></para>
        /// </description></item>
        /// <item><description><para><c>Hologres</c></para>
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
        /// <para>The URL of the table in Data Map. This parameter is returned only for MaxCompute tables.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://dmc-xxx.com/dm/table/xxx">https://dmc-xxx.com/dm/table/xxx</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
