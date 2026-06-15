// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiFeatureStore20230621.Models
{
    public class UpdateLabelTableRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data source for the label table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DatasourceId")]
        [Validation(Required=false)]
        public string DatasourceId { get; set; }

        /// <summary>
        /// <para>The fields to modify.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<UpdateLabelTableRequestFields> Fields { get; set; }
        public class UpdateLabelTableRequestFields : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>item</para>
            /// </summary>
            [NameInMap("AlignedEntityName")]
            [Validation(Required=false)]
            public string AlignedEntityName { get; set; }

            /// <summary>
            /// <para>The field\&quot;s attributes.</para>
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
            /// <para>DOUBLE</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The name of the label table.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rec_test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
