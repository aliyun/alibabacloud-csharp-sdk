// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ValidateNormalizationRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of validation results.</para>
        /// </summary>
        [NameInMap("ValidateResult")]
        [Validation(Required=false)]
        public List<ValidateNormalizationRuleResponseBodyValidateResult> ValidateResult { get; set; }
        public class ValidateNormalizationRuleResponseBodyValidateResult : TeaModel {
            /// <summary>
            /// <para>The name of the field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>host</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>The field information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ze</para>
            /// </summary>
            [NameInMap("FieldValue")]
            [Validation(Required=false)]
            public string FieldValue { get; set; }

            /// <summary>
            /// <para>The name of the log field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aaa</para>
            /// </summary>
            [NameInMap("LogFieldName")]
            [Validation(Required=false)]
            public string LogFieldName { get; set; }

            /// <summary>
            /// <para>The value of the log field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bbb</para>
            /// </summary>
            [NameInMap("LogFieldValue")]
            [Validation(Required=false)]
            public string LogFieldValue { get; set; }

            /// <summary>
            /// <para>The reason for the validation result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>OperationDenied.TheValueIsRequired: A required parameter is empty.</description></item>
            /// <item><description>OperationDenied.TheValueIsNull: The parameter value is null.</description></item>
            /// <item><description>OperationDenied.TheEnumValueNotSupport: The field value is not within the valid enum values.</description></item>
            /// <item><description>OperationDenied.TheValueLessThanMin: The field value is less than the specified minimum value.</description></item>
            /// <item><description>OperationDenied.TheValueMoreThanMax: The field value is greater than the specified maximum value.</description></item>
            /// <item><description>OperationDenied.TheValueNotMatchRegularExpression: The field value fails the regular expression match.</description></item>
            /// <item><description>success: The validation is passed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The source of the normalized field. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>preset: Built-in.</description></item>
            /// <item><description>custom: Custom.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>preset</para>
            /// </summary>
            [NameInMap("NormalizationFieldFrom")]
            [Validation(Required=false)]
            public string NormalizationFieldFrom { get; set; }

            /// <summary>
            /// <para>The name of the normalized field.</para>
            /// 
            /// <b>Example:</b>
            /// <para>host</para>
            /// </summary>
            [NameInMap("NormalizationFieldName")]
            [Validation(Required=false)]
            public string NormalizationFieldName { get; set; }

            /// <summary>
            /// <para>Specifies whether the normalized field is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NormalizationFieldRequired")]
            [Validation(Required=false)]
            public bool? NormalizationFieldRequired { get; set; }

            /// <summary>
            /// <para>Specifies whether the normalized field name is built into the system.</para>
            /// </summary>
            [NameInMap("NormalizationFieldReserved")]
            [Validation(Required=false)]
            public bool? NormalizationFieldReserved { get; set; }

            /// <summary>
            /// <para>The type of the normalized field. Valid values: text, long, double, and json.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("NormalizationFieldType")]
            [Validation(Required=false)]
            public string NormalizationFieldType { get; set; }

            /// <summary>
            /// <para>The reason why the normalized field fails the validation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OperationDenied.TheValueIsRequired</para>
            /// </summary>
            [NameInMap("NormalizationFieldValidationReason")]
            [Validation(Required=false)]
            public string NormalizationFieldValidationReason { get; set; }

            /// <summary>
            /// <para>The validation status of the normalized field. Valid values: pass and fail.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pass</para>
            /// </summary>
            [NameInMap("NormalizationFieldValidationStatus")]
            [Validation(Required=false)]
            public string NormalizationFieldValidationStatus { get; set; }

            /// <summary>
            /// <para>The validation result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>1: The validation is passed.</description></item>
            /// <item><description>0: A warning is returned.</description></item>
            /// <item><description>1: The validation fails.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public int? Result { get; set; }

        }

    }

}
