// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class CreateRecallManagementTableRequest : TeaModel {
        /// <summary>
        /// <para>Additional settings for the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;&quot;:&quot;&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The data source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MaxcomputeAndApiApi</para>
        /// </summary>
        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public string DataSource { get; set; }

        /// <summary>
        /// <para><b>The description of the table.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test table</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Whether to enable the data size fluctuation threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableDataSizeFluctuationThreshold")]
        [Validation(Required=false)]
        public bool? EnableDataSizeFluctuationThreshold { get; set; }

        /// <summary>
        /// <para>Whether to enable the row count fluctuation threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableRowCountFluctuationThreshold")]
        [Validation(Required=false)]
        public bool? EnableRowCountFluctuationThreshold { get; set; }

        /// <summary>
        /// <para>The list of fields.</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<CreateRecallManagementTableRequestFields> Fields { get; set; }
        public class CreateRecallManagementTableRequestFields : TeaModel {
            /// <summary>
            /// <para>The attributes of the field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>Primary</c>: The primary key field.</para>
            /// </description></item>
            /// <item><description><para><c>Item</c>: The item field.</para>
            /// </description></item>
            /// <item><description><para><c>Score</c>: The recall score field.</para>
            /// </description></item>
            /// <item><description><para><c>Vector</c>: The vector field.</para>
            /// </description></item>
            /// <item><description><para><c>Index</c>: The index field.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<string> Attributes { get; set; }

            /// <summary>
            /// <para>The name of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>age</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The data type of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>STRING(全大写)</para>
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
        /// <para><b>The instance ID.</b></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-test123</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The maximum data size fluctuation threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxDataSizeFluctuationThreshold")]
        [Validation(Required=false)]
        public long? MaxDataSizeFluctuationThreshold { get; set; }

        /// <summary>
        /// <para>The maximum row count fluctuation threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxRowCountFluctuationThreshold")]
        [Validation(Required=false)]
        public long? MaxRowCountFluctuationThreshold { get; set; }

        /// <summary>
        /// <para>The MaxCompute project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("MaxcomputeProjectName")]
        [Validation(Required=false)]
        public string MaxcomputeProjectName { get; set; }

        /// <summary>
        /// <para><b>The schema in MaxCompute.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("MaxcomputeSchema")]
        [Validation(Required=false)]
        public string MaxcomputeSchema { get; set; }

        /// <summary>
        /// <para>The name of the table in MaxCompute.</para>
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
        public long? MinDataSizeFluctuationThreshold { get; set; }

        /// <summary>
        /// <para>The minimum row count fluctuation threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MinRowCountFluctuationThreshold")]
        [Validation(Required=false)]
        public long? MinRowCountFluctuationThreshold { get; set; }

        /// <summary>
        /// <para><b>The name of the table.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>table-123</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The recall type of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>X2I</para>
        /// </summary>
        [NameInMap("RecallType")]
        [Validation(Required=false)]
        public string RecallType { get; set; }

        /// <summary>
        /// <para><b>The table type.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>Recall</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
