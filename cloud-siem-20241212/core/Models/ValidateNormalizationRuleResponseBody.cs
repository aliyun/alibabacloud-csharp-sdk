// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20241212.Models
{
    public class ValidateNormalizationRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
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
            /// <para>The field name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>host</para>
            /// </summary>
            [NameInMap("FieldName")]
            [Validation(Required=false)]
            public string FieldName { get; set; }

            /// <summary>
            /// <para>The field value.</para>
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
            /// <item><description><para>OperationDenied.TheValueIsRequired: A required parameter is empty.</para>
            /// </description></item>
            /// <item><description><para>OperationDenied.TheValueIsNull: The parameter value is empty.</para>
            /// </description></item>
            /// <item><description><para>OperationDenied.TheEnumValueNotSupport: The field value is not within the valid enumeration.</para>
            /// </description></item>
            /// <item><description><para>OperationDenied.TheValueLessThanMin: The field value is less than the minimum value.</para>
            /// </description></item>
            /// <item><description><para>OperationDenied.TheValueMoreThanMax: The field value is greater than the maximum value.</para>
            /// </description></item>
            /// <item><description><para>OperationDenied.TheValueNotMatchRegularExpression: The field value does not match the regular expression.</para>
            /// </description></item>
            /// <item><description><para>success: The validation passed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The source of the normalized field. Valid values: \<c>preset\\</c> (built-in) and \<c>custom\\</c>.</para>
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
            /// <para>Indicates whether the normalized field is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NormalizationFieldRequired")]
            [Validation(Required=false)]
            public bool? NormalizationFieldRequired { get; set; }

            /// <summary>
            /// <para>Indicates whether the name of the normalized field is a built-in field name.</para>
            /// </summary>
            [NameInMap("NormalizationFieldReserved")]
            [Validation(Required=false)]
            public bool? NormalizationFieldReserved { get; set; }

            /// <summary>
            /// <para>The type of the normalized field. Supported types: \<c>text\\</c>, \<c>long\\</c>, \<c>double\\</c>, and \<c>json\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("NormalizationFieldType")]
            [Validation(Required=false)]
            public string NormalizationFieldType { get; set; }

            /// <summary>
            /// <para>The reason why the validation of the normalized field failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OperationDenied.TheValueIsRequired</para>
            /// </summary>
            [NameInMap("NormalizationFieldValidationReason")]
            [Validation(Required=false)]
            public string NormalizationFieldValidationReason { get; set; }

            /// <summary>
            /// <para>The validation status of the normalized field. Valid values: \<c>pass\\</c> and \<c>fail\\</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pass</para>
            /// </summary>
            [NameInMap("NormalizationFieldValidationStatus")]
            [Validation(Required=false)]
            public string NormalizationFieldValidationStatus { get; set; }

            /// <summary>
            /// <para>The result of the validation. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>1: The validation passed.</para>
            /// </description></item>
            /// <item><description><para>0: A warning is returned.</para>
            /// </description></item>
            /// <item><description><para>-1: The validation failed.</para>
            /// </description></item>
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
