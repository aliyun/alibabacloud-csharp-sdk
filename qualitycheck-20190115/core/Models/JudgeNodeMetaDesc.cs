// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class JudgeNodeMetaDesc : TeaModel {
        /// <summary>
        /// <para>Actual value</para>
        /// 
        /// <b>Example:</b>
        /// <para>xx</para>
        /// </summary>
        [NameInMap("ActualValue")]
        [Validation(Required=false)]
        public string ActualValue { get; set; }

        /// <summary>
        /// <para>Data type</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public int? DataType { get; set; }

        [NameInMap("ExpressionMetaDesc")]
        [Validation(Required=false)]
        public JudgeNodeMetaDescExpressionMetaDesc ExpressionMetaDesc { get; set; }
        public class JudgeNodeMetaDescExpressionMetaDesc : TeaModel {
            [NameInMap("LeftFieldType")]
            [Validation(Required=false)]
            public int? LeftFieldType { get; set; }

            [NameInMap("LeftOperand")]
            [Validation(Required=false)]
            public string LeftOperand { get; set; }

            [NameInMap("Operator")]
            [Validation(Required=false)]
            public string Operator { get; set; }

            [NameInMap("RightFieldType")]
            [Validation(Required=false)]
            public int? RightFieldType { get; set; }

            [NameInMap("RightOperand")]
            [Validation(Required=false)]
            public string RightOperand { get; set; }

            [NameInMap("RoundingMode")]
            [Validation(Required=false)]
            public string RoundingMode { get; set; }

        }

        /// <summary>
        /// <para>System field</para>
        /// 
        /// <b>Example:</b>
        /// <para>remark1</para>
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// <para>Field data source type: 1: System predefined field. 2: Quality inspection field for passed parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("FieldType")]
        [Validation(Required=false)]
        public int? FieldType { get; set; }

        /// <summary>
        /// <para>Expression</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Symbol")]
        [Validation(Required=false)]
        public int? Symbol { get; set; }

        /// <summary>
        /// <para>Preset value</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxx</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
