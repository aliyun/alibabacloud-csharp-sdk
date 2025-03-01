// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetWafFilterResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned match conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public GetWafFilterResponseBodyFilter Filter { get; set; }
        public class GetWafFilterResponseBodyFilter : TeaModel {
            /// <summary>
            /// <para>The matched objects and related properties.</para>
            /// </summary>
            [NameInMap("Fields")]
            [Validation(Required=false)]
            public List<GetWafFilterResponseBodyFilterFields> Fields { get; set; }
            public class GetWafFilterResponseBodyFilterFields : TeaModel {
                [NameInMap("Enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

                /// <summary>
                /// <para>The field for matched objects in the system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http.request.headers</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The label of the matched object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Header</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The logical conditions.</para>
                /// </summary>
                [NameInMap("Logics")]
                [Validation(Required=false)]
                public List<GetWafFilterResponseBodyFilterFieldsLogics> Logics { get; set; }
                public class GetWafFilterResponseBodyFilterFieldsLogics : TeaModel {
                    /// <summary>
                    /// <para>A custom attribute. For example, this parameter can specify whether the value is case-sensitive.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Attributes")]
                    [Validation(Required=false)]
                    public int? Attributes { get; set; }

                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <para>The type of the value input box. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>select:single</description></item>
                    /// <item><description>select:multi</description></item>
                    /// <item><description>input:single</description></item>
                    /// <item><description>input:multi</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>input:single</para>
                    /// </summary>
                    [NameInMap("Kind")]
                    [Validation(Required=false)]
                    public string Kind { get; set; }

                    [NameInMap("MinPlan")]
                    [Validation(Required=false)]
                    public string MinPlan { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the match result is inverted.</para>
                    /// </summary>
                    [NameInMap("Negative")]
                    [Validation(Required=false)]
                    public bool? Negative { get; set; }

                    /// <summary>
                    /// <para>The displayed matching characters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Does not equal</para>
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>The matching characters in the system.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eq</para>
                    /// </summary>
                    [NameInMap("Symbol")]
                    [Validation(Required=false)]
                    public string Symbol { get; set; }

                    /// <summary>
                    /// <para>The tip on how to enter a valid value that is required by the rules.</para>
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
                    /// <item><description>integer</description></item>
                    /// <item><description>integer_slice</description></item>
                    /// <item><description>string</description></item>
                    /// <item><description>string_slice</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>string</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The validator, which defines the validation rules for a value.</para>
                    /// </summary>
                    [NameInMap("Validator")]
                    [Validation(Required=false)]
                    public GetWafFilterResponseBodyFilterFieldsLogicsValidator Validator { get; set; }
                    public class GetWafFilterResponseBodyFilterFieldsLogicsValidator : TeaModel {
                        /// <summary>
                        /// <para>The error message when the validation fails.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Enter a valid expression</para>
                        /// </summary>
                        [NameInMap("ErrMsg")]
                        [Validation(Required=false)]
                        public string ErrMsg { get; set; }

                        /// <summary>
                        /// <para>The length of the value.</para>
                        /// </summary>
                        [NameInMap("Length")]
                        [Validation(Required=false)]
                        public WafQuotaInteger Length { get; set; }

                        /// <summary>
                        /// <para>The regular expression pattern of the value, which is used to validate strings.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>^example$</para>
                        /// </summary>
                        [NameInMap("Pattern")]
                        [Validation(Required=false)]
                        public string Pattern { get; set; }

                        /// <summary>
                        /// <para>The range of the value, which is used to validate numbers.</para>
                        /// </summary>
                        [NameInMap("Range")]
                        [Validation(Required=false)]
                        public WafQuotaInteger Range { get; set; }

                    }

                }

                [NameInMap("MinPlan")]
                [Validation(Required=false)]
                public string MinPlan { get; set; }

                /// <summary>
                /// <para>The selector, which defines how to select a matched object.</para>
                /// </summary>
                [NameInMap("Selector")]
                [Validation(Required=false)]
                public GetWafFilterResponseBodyFilterFieldsSelector Selector { get; set; }
                public class GetWafFilterResponseBodyFilterFieldsSelector : TeaModel {
                    /// <summary>
                    /// <para>The data. This parameter is available only when the value of the Kind parameter is data.</para>
                    /// </summary>
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public List<GetWafFilterResponseBodyFilterFieldsSelectorData> Data { get; set; }
                    public class GetWafFilterResponseBodyFilterFieldsSelectorData : TeaModel {
                        /// <summary>
                        /// <para>The label of the data.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>China</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The value of the data.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CN</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The type of selector. Valid values: data and others.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>data</para>
                    /// </summary>
                    [NameInMap("Kind")]
                    [Validation(Required=false)]
                    public string Kind { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the matched object contains a subfield.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Sub")]
                [Validation(Required=false)]
                public bool? Sub { get; set; }

                /// <summary>
                /// <para>The tip on how to enter a subfield.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e.g. Content-Type</para>
                /// </summary>
                [NameInMap("SubTip")]
                [Validation(Required=false)]
                public string SubTip { get; set; }

            }

            /// <summary>
            /// <para>The WAF rule category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http_bot</para>
            /// </summary>
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            /// <summary>
            /// <para>The condition for matching incoming requests.</para>
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
