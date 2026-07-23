// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetRecallManagementTableResponseBody : TeaModel {
        /// <summary>
        /// <para>Specifies whether the table can be deleted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CanDelete")]
        [Validation(Required=false)]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// <para>Additional configurations for the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;item_id&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Api</para>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public string DataSource { get; set; }

        /// <summary>
        /// <para>The data table description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the fluctuation threshold for the data size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableDataSizeFluctuationThreshold")]
        [Validation(Required=false)]
        public bool? EnableDataSizeFluctuationThreshold { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the fluctuation threshold for the row count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableRowCountFluctuationThreshold")]
        [Validation(Required=false)]
        public bool? EnableRowCountFluctuationThreshold { get; set; }

        /// <summary>
        /// <para>A list of fields.</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<GetRecallManagementTableResponseBodyFields> Fields { get; set; }
        public class GetRecallManagementTableResponseBodyFields : TeaModel {
            /// <summary>
            /// <para>A list of field attributes.</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<string> Attributes { get; set; }

            /// <summary>
            /// <para>The field name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>age</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The field type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STRING</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The vector dimension.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("VectorDimension")]
            [Validation(Required=false)]
            public int? VectorDimension { get; set; }

            /// <summary>
            /// <para>The vector metric type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>L2</para>
            /// </summary>
            [NameInMap("VectorMetricType")]
            [Validation(Required=false)]
            public string VectorMetricType { get; set; }

        }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The index effective time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-15T23:24:33.132+08:00</para>
        /// </summary>
        [NameInMap("IndexEffectiveTime")]
        [Validation(Required=false)]
        public string IndexEffectiveTime { get; set; }

        /// <summary>
        /// <para>The index version ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20250701</para>
        /// </summary>
        [NameInMap("IndexVersionId")]
        [Validation(Required=false)]
        public string IndexVersionId { get; set; }

        /// <summary>
        /// <para>The maximum data size fluctuation threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxDataSizeFluctuationThreshold")]
        [Validation(Required=false)]
        public int? MaxDataSizeFluctuationThreshold { get; set; }

        /// <summary>
        /// <para>The maximum row count fluctuation threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxRowCountFluctuationThreshold")]
        [Validation(Required=false)]
        public int? MaxRowCountFluctuationThreshold { get; set; }

        /// <summary>
        /// <para>The MaxCompute project name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("MaxcomputeProjectName")]
        [Validation(Required=false)]
        public string MaxcomputeProjectName { get; set; }

        /// <summary>
        /// <para>The MaxCompute schema.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("MaxcomputeSchema")]
        [Validation(Required=false)]
        public string MaxcomputeSchema { get; set; }

        /// <summary>
        /// <para>The MaxCompute table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table-1</para>
        /// </summary>
        [NameInMap("MaxcomputeTableName")]
        [Validation(Required=false)]
        public string MaxcomputeTableName { get; set; }

        /// <summary>
        /// <para>The minimum data size fluctuation threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MinDataSizeFluctuationThreshold")]
        [Validation(Required=false)]
        public int? MinDataSizeFluctuationThreshold { get; set; }

        /// <summary>
        /// <para>The minimum row count fluctuation threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MinRowCountFluctuationThreshold")]
        [Validation(Required=false)]
        public int? MinRowCountFluctuationThreshold { get; set; }

        /// <summary>
        /// <para>The data table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>table-123</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The partition fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dt</para>
        /// </summary>
        [NameInMap("PartitionFields")]
        [Validation(Required=false)]
        public string PartitionFields { get; set; }

        /// <summary>
        /// <para>The data table ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RecallManagementTableId")]
        [Validation(Required=false)]
        public string RecallManagementTableId { get; set; }

        /// <summary>
        /// <para>The recall type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>X2I</para>
        /// </summary>
        [NameInMap("RecallType")]
        [Validation(Required=false)]
        public string RecallType { get; set; }

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
        /// <para>The table type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Recall</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
