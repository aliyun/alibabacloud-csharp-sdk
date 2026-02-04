// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ValidateNormalizationRuleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****。</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ValidateResult")]
        [Validation(Required=false)]
        public List<ValidateNormalizationRuleResponseBodyValidateResult> ValidateResult { get; set; }
        public class ValidateNormalizationRuleResponseBodyValidateResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>host。</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ze。</para>
            /// </summary>
            [NameInMap("FieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aaa</para>
            /// </summary>
            [NameInMap("LogFieldName")]
            [Validation(Required=false)]
            public string LogFieldName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bbb</para>
            /// </summary>
            [NameInMap("LogFieldValue")]
            [Validation(Required=false)]
            public string LogFieldValue { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>success。</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>preset</para>
            /// </summary>
            [NameInMap("NormalizationFieldFrom")]
            [Validation(Required=false)]
            public string NormalizationFieldFrom { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>host。</para>
            /// </summary>
            [NameInMap("NormalizationFieldName")]
            [Validation(Required=false)]
            public string NormalizationFieldName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true。</para>
            /// </summary>
            [NameInMap("NormalizationFieldRequired")]
            [Validation(Required=false)]
            public bool? NormalizationFieldRequired { get; set; }

            [NameInMap("NormalizationFieldReserved")]
            [Validation(Required=false)]
            public bool? NormalizationFieldReserved { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("NormalizationFieldType")]
            [Validation(Required=false)]
            public string NormalizationFieldType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OperationDenied.TheValueIsRequired</para>
            /// </summary>
            [NameInMap("NormalizationFieldValidationReason")]
            [Validation(Required=false)]
            public string NormalizationFieldValidationReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pass</para>
            /// </summary>
            [NameInMap("NormalizationFieldValidationStatus")]
            [Validation(Required=false)]
            public string NormalizationFieldValidationStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1。</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public int? Result { get; set; }

        }

    }

}
