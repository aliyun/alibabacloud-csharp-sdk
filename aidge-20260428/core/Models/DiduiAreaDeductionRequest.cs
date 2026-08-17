// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class DiduiAreaDeductionRequest : TeaModel {
        /// <summary>
        /// <para>The list of products and their detection boxes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Products")]
        [Validation(Required=false)]
        public List<DiduiAreaDeductionRequestProducts> Products { get; set; }
        public class DiduiAreaDeductionRequestProducts : TeaModel {
            /// <summary>
            /// <para>The detection boxes for the current SKU. Coordinate values range from 0 to 1000.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Boxes")]
            [Validation(Required=false)]
            public List<DiduiAreaDeductionRequestProductsBoxes> Boxes { get; set; }
            public class DiduiAreaDeductionRequestProductsBoxes : TeaModel {
                /// <summary>
                /// <para>The bottom boundary of the detection box.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>689</para>
                /// </summary>
                [NameInMap("Bottom")]
                [Validation(Required=false)]
                public double? Bottom { get; set; }

                /// <summary>
                /// <para>The left boundary of the detection box.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>763</para>
                /// </summary>
                [NameInMap("Left")]
                [Validation(Required=false)]
                public double? Left { get; set; }

                /// <summary>
                /// <para>The right boundary of the detection box.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>904</para>
                /// </summary>
                [NameInMap("Right")]
                [Validation(Required=false)]
                public double? Right { get; set; }

                /// <summary>
                /// <para>The top boundary of the detection box.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>606</para>
                /// </summary>
                [NameInMap("Top")]
                [Validation(Required=false)]
                public double? Top { get; set; }

            }

            /// <summary>
            /// <para>The unique ID of the SKU.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>6901234579</para>
            /// </summary>
            [NameInMap("SkuId")]
            [Validation(Required=false)]
            public string SkuId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the customer-specific SKU vector database that determines which database is used for retrieval. The database must be created in advance through the database creation process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rag_xxx</para>
        /// </summary>
        [NameInMap("RagId")]
        [Validation(Required=false)]
        public string RagId { get; set; }

        /// <summary>
        /// <para>The optional business request ID used for Tracing Analysis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>didui-request-001</para>
        /// </summary>
        [NameInMap("ReqId")]
        [Validation(Required=false)]
        public string ReqId { get; set; }

        /// <summary>
        /// <para>The HTTPS URL of the overall floor display image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/didui.jpg">https://example.com/didui.jpg</a></para>
        /// </summary>
        [NameInMap("TargetImageUrl")]
        [Validation(Required=false)]
        public string TargetImageUrl { get; set; }

    }

}
