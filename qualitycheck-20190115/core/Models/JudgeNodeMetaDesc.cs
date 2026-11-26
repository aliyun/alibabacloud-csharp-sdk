// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class JudgeNodeMetaDesc : TeaModel {
        /// <summary>
        /// <para>The actual value. <b>[Deprecated]</b></para>
        /// 
        /// <b>Example:</b>
        /// <para><b>[Deprecated]</b></para>
        /// </summary>
        [NameInMap("ActualValue")]
        [Validation(Required=false)]
        public string ActualValue { get; set; }

        /// <summary>
        /// <para>The data type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public int? DataType { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b></para>
        /// </summary>
        [NameInMap("ExpressionMetaDesc")]
        [Validation(Required=false)]
        public JudgeNodeMetaDescExpressionMetaDesc ExpressionMetaDesc { get; set; }
        public class JudgeNodeMetaDescExpressionMetaDesc : TeaModel {
            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para><b>[Deprecated]</b></para>
            /// </summary>
            [NameInMap("LeftFieldType")]
            [Validation(Required=false)]
            public int? LeftFieldType { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para><b>[Deprecated]</b></para>
            /// </summary>
            [NameInMap("LeftOperand")]
            [Validation(Required=false)]
            public string LeftOperand { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para><b>[Deprecated]</b></para>
            /// </summary>
            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para><b>[Deprecated]</b></para>
            /// </summary>
            [NameInMap("RightFieldType")]
            [Validation(Required=false)]
            public int? RightFieldType { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para><b>[Deprecated]</b></para>
            /// </summary>
            [NameInMap("RightOperand")]
            [Validation(Required=false)]
            public string RightOperand { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b></para>
            /// 
            /// <b>Example:</b>
            /// <para><b>[Deprecated]</b></para>
            /// </summary>
            [NameInMap("RoundingMode")]
            [Validation(Required=false)]
            public string RoundingMode { get; set; }

        }

        /// <summary>
        /// <para>The system field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>remark1</para>
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// <para>The field data source type. 1: System predefined field. 2: Parameter-passed quality inspection field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FieldType")]
        [Validation(Required=false)]
        public int? FieldType { get; set; }

        /// <summary>
        /// <para>The logical expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Symbol")]
        [Validation(Required=false)]
        public int? Symbol { get; set; }

        /// <summary>
        /// <para>The preset value. <b>[Deprecated]</b></para>
        /// 
        /// <b>Example:</b>
        /// <para><b>[Deprecated]</b></para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
