// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class DiduiAreaDeductionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Products")]
        [Validation(Required=false)]
        public List<DiduiAreaDeductionRequestProducts> Products { get; set; }
        public class DiduiAreaDeductionRequestProducts : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Boxes")]
            [Validation(Required=false)]
            public List<DiduiAreaDeductionRequestProductsBoxes> Boxes { get; set; }
            public class DiduiAreaDeductionRequestProductsBoxes : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>689</para>
                /// </summary>
                [NameInMap("Bottom")]
                [Validation(Required=false)]
                public double? Bottom { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>763</para>
                /// </summary>
                [NameInMap("Left")]
                [Validation(Required=false)]
                public double? Left { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>904</para>
                /// </summary>
                [NameInMap("Right")]
                [Validation(Required=false)]
                public double? Right { get; set; }

                /// <summary>
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
        /// <b>Example:</b>
        /// <para>rag_xxx</para>
        /// </summary>
        [NameInMap("RagId")]
        [Validation(Required=false)]
        public string RagId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>didui-request-001</para>
        /// </summary>
        [NameInMap("ReqId")]
        [Validation(Required=false)]
        public string ReqId { get; set; }

        /// <summary>
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
