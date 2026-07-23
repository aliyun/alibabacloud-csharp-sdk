// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetInstanceResourceTableResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of fields in the data table.</para>
        /// </summary>
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<GetInstanceResourceTableResponseBodyFields> Fields { get; set; }
        public class GetInstanceResourceTableResponseBodyFields : TeaModel {
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
            /// <para>Indicates whether the field is a partition field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsPartitionField")]
            [Validation(Required=false)]
            public bool? IsPartitionField { get; set; }

            /// <summary>
            /// <para>The meaning of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;&quot;</para>
            /// </summary>
            [NameInMap("Meaning")]
            [Validation(Required=false)]
            public string Meaning { get; set; }

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
            /// <para>BIGINT</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>74D958EF-3598-56FA-8296-FF1575CE43DF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The table name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_table</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
