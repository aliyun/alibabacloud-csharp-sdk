// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetWafFilterResponseBody : TeaModel {
        /// <summary>
        /// <para>The matching engine configuration information returned.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public GetWafFilterResponseBodyFilter Filter { get; set; }
        public class GetWafFilterResponseBodyFilter : TeaModel {
            /// <summary>
            /// <para>The list that describes match objects and their properties.</para>
            /// </summary>
            [NameInMap("Fields")]
            [Validation(Required=false)]
            public List<GetWafFilterResponseBodyFilterFields> Fields { get; set; }
            public class GetWafFilterResponseBodyFilterFields : TeaModel {
                /// <summary>
                /// <para>Indicates whether the current plan supports this match object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The parameter of the match object used internally by the system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http.request.headers</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The display label of the match object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Header</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The list of logical operator properties that define the logical conditions used for matching.</para>
                /// </summary>
                [NameInMap("Logics")]
                [Validation(Required=false)]
                public List<GetWafFilterResponseBodyFilterFieldsLogics> Logics { get; set; }
                public class GetWafFilterResponseBodyFilterFieldsLogics : TeaModel {
                    /// <summary>
                    /// <para>The configurable attributes, such as whether the match is case-sensitive.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Attributes")]
                    [Validation(Required=false)]
                    public int? Attributes { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the current plan supports this match operator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <para>The type of the value input field. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>select:single: single-select input field</description></item>
                    /// <item><description>select:multi: multi-select input field</description></item>
                    /// <item><description>input:single: single input field</description></item>
                    /// <item><description>input:multi: multi input field</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>input:single</para>
                    /// </summary>
                    [NameInMap("Kind")]
                    [Validation(Required=false)]
                    public string Kind { get; set; }

                    /// <summary>
                    /// <para>The minimum plan that supports this match operator, displayed when the current plan does not support it.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>high</para>
                    /// </summary>
                    [NameInMap("MinPlan")]
                    [Validation(Required=false)]
                    public string MinPlan { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the match result is negated.</para>
                    /// </summary>
                    [NameInMap("Negative")]
                    [Validation(Required=false)]
                    public bool? Negative { get; set; }

                    /// <summary>
                    /// <para>The display label of the match operator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Does not equal</para>
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>The parameter of the match operator used internally by the system.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eq</para>
                    /// </summary>
                    [NameInMap("Symbol")]
                    [Validation(Required=false)]
                    public string Symbol { get; set; }

                    /// <summary>
                    /// <para>The input hint that helps users provide valid values required by the rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>e.g. image/jpeg</para>
                    /// </summary>
                    [NameInMap("Tip")]
                    [Validation(Required=false)]
                    public string Tip { get; set; }

                    /// <summary>
                    /// <para>The type of the value. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>integer: integer</description></item>
                    /// <item><description>integer_slice: integer array</description></item>
                    /// <item><description>string: string</description></item>
                    /// <item><description>string_slice: string array</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>string</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The validator object that defines the validation rules for values.</para>
                    /// </summary>
                    [NameInMap("Validator")]
                    [Validation(Required=false)]
                    public GetWafFilterResponseBodyFilterFieldsLogicsValidator Validator { get; set; }
                    public class GetWafFilterResponseBodyFilterFieldsLogicsValidator : TeaModel {
                        /// <summary>
                        /// <para>The error message returned when validation fails.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Enter a valid expression</para>
                        /// </summary>
                        [NameInMap("ErrMsg")]
                        [Validation(Required=false)]
                        public string ErrMsg { get; set; }

                        /// <summary>
                        /// <para>The length limit of the value.</para>
                        /// </summary>
                        [NameInMap("Length")]
                        [Validation(Required=false)]
                        public WafQuotaInteger Length { get; set; }

                        /// <summary>
                        /// <para>The regular expression pattern for the value, used for string validation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>^example$</para>
                        /// </summary>
                        [NameInMap("Pattern")]
                        [Validation(Required=false)]
                        public string Pattern { get; set; }

                        /// <summary>
                        /// <para>The numeric range of the value, used for number validation.</para>
                        /// </summary>
                        [NameInMap("Range")]
                        [Validation(Required=false)]
                        public WafQuotaInteger Range { get; set; }

                    }

                }

                /// <summary>
                /// <para>The minimum plan that supports this match object, displayed when the current plan does not support it.</para>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("MinPlan")]
                [Validation(Required=false)]
                public string MinPlan { get; set; }

                /// <summary>
                /// <para>The selector object that defines how to select the match object.</para>
                /// </summary>
                [NameInMap("Selector")]
                [Validation(Required=false)]
                public GetWafFilterResponseBodyFilterFieldsSelector Selector { get; set; }
                public class GetWafFilterResponseBodyFilterFieldsSelector : TeaModel {
                    /// <summary>
                    /// <para>The list of available data when the selector kind is data.</para>
                    /// </summary>
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public List<GetWafFilterResponseBodyFilterFieldsSelectorData> Data { get; set; }
                    public class GetWafFilterResponseBodyFilterFieldsSelectorData : TeaModel {
                        /// <summary>
                        /// <para>The display label of the available data.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>China</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The parameter value of the available data.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CN</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The kind of the selector, such as whether it is used for selecting data items or other purposes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>data</para>
                    /// </summary>
                    [NameInMap("Kind")]
                    [Validation(Required=false)]
                    public string Kind { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the match object contains subfields.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Sub")]
                [Validation(Required=false)]
                public bool? Sub { get; set; }

                /// <summary>
                /// <para>The hint provided to users about how to enter subfields.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e.g. Content-Type</para>
                /// </summary>
                [NameInMap("SubTip")]
                [Validation(Required=false)]
                public string SubTip { get; set; }

                /// <summary>
                /// <para>The enumerated sub-item list (dropdown subfields for grouped fields such as ali.websdk). Top-level match objects populate this list. Sub-items that are flat fields can be used directly as the left-hand side of an expression.</para>
                /// </summary>
                [NameInMap("Subs")]
                [Validation(Required=false)]
                public List<GetWafFilterResponseBodyFilterFieldsSubs> Subs { get; set; }
                public class GetWafFilterResponseBodyFilterFieldsSubs : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether the current plan supports this match object.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <para>The parameter of the sub-item match object.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ali.websdk.umid</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The display label of the sub-item match object.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Web UMID</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The list of logical operator properties applicable to the sub-item (same structure as the parent Logics).</para>
                    /// </summary>
                    [NameInMap("Logics")]
                    [Validation(Required=false)]
                    public List<GetWafFilterResponseBodyFilterFieldsSubsLogics> Logics { get; set; }
                    public class GetWafFilterResponseBodyFilterFieldsSubsLogics : TeaModel {
                        /// <summary>
                        /// <para>The field attributes.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("Attributes")]
                        [Validation(Required=false)]
                        public int? Attributes { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the current plan supports this match operator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Enable")]
                        [Validation(Required=false)]
                        public bool? Enable { get; set; }

                        /// <summary>
                        /// <para>The type of the value input field. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>select:single: single-select input field</description></item>
                        /// <item><description>select:multi: multi-select input field</description></item>
                        /// <item><description>input:single: single input field</description></item>
                        /// <item><description>input:multi: multi input field</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>select:single</para>
                        /// </summary>
                        [NameInMap("Kind")]
                        [Validation(Required=false)]
                        public string Kind { get; set; }

                        /// <summary>
                        /// <para>The minimum plan that supports this match operator, displayed when the current plan does not support it.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>high</para>
                        /// </summary>
                        [NameInMap("MinPlan")]
                        [Validation(Required=false)]
                        public string MinPlan { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the match result is negated.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Negative")]
                        [Validation(Required=false)]
                        public bool? Negative { get; set; }

                        /// <summary>
                        /// <para>The display label of the match operator.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Equal</para>
                        /// </summary>
                        [NameInMap("Operator")]
                        [Validation(Required=false)]
                        public string Operator { get; set; }

                        /// <summary>
                        /// <para>The parameter of the match operator used internally by the system.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>eq</para>
                        /// </summary>
                        [NameInMap("Symbol")]
                        [Validation(Required=false)]
                        public string Symbol { get; set; }

                        /// <summary>
                        /// <para>The input hint that helps users provide valid values required by the rule.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>e.g. image/jpeg</para>
                        /// </summary>
                        [NameInMap("Tip")]
                        [Validation(Required=false)]
                        public string Tip { get; set; }

                        /// <summary>
                        /// <para>The type of the value. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description>integer: integer</description></item>
                        /// <item><description>integer_slice: integer array</description></item>
                        /// <item><description>string: string</description></item>
                        /// <item><description>string_slice: string array</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>string</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The validator object that defines the validation rules for values.</para>
                        /// </summary>
                        [NameInMap("Validator")]
                        [Validation(Required=false)]
                        public GetWafFilterResponseBodyFilterFieldsSubsLogicsValidator Validator { get; set; }
                        public class GetWafFilterResponseBodyFilterFieldsSubsLogicsValidator : TeaModel {
                            /// <summary>
                            /// <para>The error message returned when validation fails.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>Enter a valid expression</para>
                            /// </summary>
                            [NameInMap("ErrMsg")]
                            [Validation(Required=false)]
                            public string ErrMsg { get; set; }

                            /// <summary>
                            /// <para>The length limit of the value.</para>
                            /// </summary>
                            [NameInMap("Length")]
                            [Validation(Required=false)]
                            public WafQuotaInteger Length { get; set; }

                            /// <summary>
                            /// <para>The regular expression pattern for the value, used for string validation.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>^example$</para>
                            /// </summary>
                            [NameInMap("Pattern")]
                            [Validation(Required=false)]
                            public string Pattern { get; set; }

                            /// <summary>
                            /// <para>The numeric range of the value, used for number validation.</para>
                            /// </summary>
                            [NameInMap("Range")]
                            [Validation(Required=false)]
                            public WafQuotaInteger Range { get; set; }

                        }

                    }

                    /// <summary>
                    /// <para>The minimum plan that supports this match object, displayed when the current plan does not support it.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>high</para>
                    /// </summary>
                    [NameInMap("MinPlan")]
                    [Validation(Required=false)]
                    public string MinPlan { get; set; }

                }

            }

            /// <summary>
            /// <para>The phase in which WAF processes the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http_bot</para>
            /// </summary>
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            /// <summary>
            /// <para>The target value of the matching engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>characteristics</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>The rule type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http_custom_cc</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
