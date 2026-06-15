// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class CreateLabelTableRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data source that contains the label table. Call the ListDatasources operation to obtain this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DatasourceId")]
        [Validation(Required=false)]
        public string DatasourceId { get; set; }

        /// <summary>
        /// <para>The field list.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<CreateLabelTableRequestFields> Fields { get; set; }
        public class CreateLabelTableRequestFields : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>item</para>
            /// </summary>
            [NameInMap("AlignedEntityName")]
            [Validation(Required=false)]
            public string AlignedEntityName { get; set; }

            /// <summary>
            /// <para>The field attributes. Valid values include:</para>
            /// <para>● <c>Partition</c>: A partition field.</para>
            /// <para>● <c>FeatureField</c>: A feature field.</para>
            /// <para>● <c>FeatureGenerationReserveField</c>: A reserved field for Feature Generation (FG).</para>
            /// <para>● <c>EventTime</c>: The event time.</para>
            /// <para>● <c>LabelField</c>: A label field.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public List<string> Attributes { get; set; }

            /// <summary>
            /// <para>The name of the field.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lat</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The data type of the field.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>INT32</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The name of the label table.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rec_test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The project ID. Call the ListProjects operation to obtain this ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

    }

}
