// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class UpdateRecallManagementTableRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableDataSizeFluctuationThreshold")]
        [Validation(Required=false)]
        public bool? EnableDataSizeFluctuationThreshold { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableRowCountFluctuationThreshold")]
        [Validation(Required=false)]
        public bool? EnableRowCountFluctuationThreshold { get; set; }

        [NameInMap("Fields")]
        [Validation(Required=false)]
        public UpdateRecallManagementTableRequestFields Fields { get; set; }
        public class UpdateRecallManagementTableRequestFields : TeaModel {
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<string> Attributes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>age</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("VectorDimension")]
            [Validation(Required=false)]
            public int? VectorDimension { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>L2</para>
            /// </summary>
            [NameInMap("VectorMetricType")]
            [Validation(Required=false)]
            public string VectorMetricType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20250701</para>
        /// </summary>
        [NameInMap("IndexVersionId")]
        [Validation(Required=false)]
        public string IndexVersionId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pairec-cn-test123</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxDataSizeFluctuationThreshold")]
        [Validation(Required=false)]
        public int? MaxDataSizeFluctuationThreshold { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxRowCountFluctuationThreshold")]
        [Validation(Required=false)]
        public int? MaxRowCountFluctuationThreshold { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MinDataSizeFluctuationThreshold")]
        [Validation(Required=false)]
        public int? MinDataSizeFluctuationThreshold { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MinRowCountFluctuationThreshold")]
        [Validation(Required=false)]
        public int? MinRowCountFluctuationThreshold { get; set; }

    }

}
