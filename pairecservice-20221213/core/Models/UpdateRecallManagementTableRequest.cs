// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateRecallManagementTableRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the data size fluctuation threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableDataSizeFluctuationThreshold")]
        [Validation(Required=false)]
        public bool? EnableDataSizeFluctuationThreshold { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the row count fluctuation threshold.</para>
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
        public UpdateRecallManagementTableRequestFields Fields { get; set; }
        public class UpdateRecallManagementTableRequestFields : TeaModel {
            /// <summary>
            /// <para>Specifies the role of the field. Valid values:</para>
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
            /// <para>The field name.</para>
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
        /// <para>The version ID of the table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20250701</para>
        /// </summary>
        [NameInMap("IndexVersionId")]
        [Validation(Required=false)]
        public string IndexVersionId { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-test123</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The maximum value for the data size fluctuation threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxDataSizeFluctuationThreshold")]
        [Validation(Required=false)]
        public int? MaxDataSizeFluctuationThreshold { get; set; }

        /// <summary>
        /// <para>The maximum value for the row count fluctuation threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxRowCountFluctuationThreshold")]
        [Validation(Required=false)]
        public int? MaxRowCountFluctuationThreshold { get; set; }

        /// <summary>
        /// <para>The minimum value for the data size fluctuation threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MinDataSizeFluctuationThreshold")]
        [Validation(Required=false)]
        public int? MinDataSizeFluctuationThreshold { get; set; }

        /// <summary>
        /// <para>The minimum value for the row count fluctuation threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MinRowCountFluctuationThreshold")]
        [Validation(Required=false)]
        public int? MinRowCountFluctuationThreshold { get; set; }

    }

}
