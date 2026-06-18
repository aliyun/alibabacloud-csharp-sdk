// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetWafFilterResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned matching engine configuration.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public GetWafFilterResponseBodyFilter Filter { get; set; }
        public class GetWafFilterResponseBodyFilter : TeaModel {
            /// <summary>
            /// <para>A list of match objects and their properties.</para>
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
                /// <para>The internal key for the match object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>http.request.headers</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The label for the match object.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Header</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>A list of logical operators that define the matching conditions.</para>
                /// </summary>
                [NameInMap("Logics")]
                [Validation(Required=false)]
                public List<GetWafFilterResponseBodyFilterFieldsLogics> Logics { get; set; }
                public class GetWafFilterResponseBodyFilterFieldsLogics : TeaModel {
                    /// <summary>
                    /// <para>Configurable attributes, such as case sensitivity.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Attributes")]
                    [Validation(Required=false)]
                    public int? Attributes { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the current plan supports this operator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("Enable")]
                    [Validation(Required=false)]
                    public bool? Enable { get; set; }

                    /// <summary>
                    /// <para>The input type for the value. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>select:single</c>: A single-select input.</para>
                    /// </description></item>
                    /// <item><description><para><c>select:multi</c>: A multi-select input.</para>
                    /// </description></item>
                    /// <item><description><para><c>input:single</c>: A single-value text input.</para>
                    /// </description></item>
                    /// <item><description><para><c>input:multi</c>: A multi-value text input.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>input:single</para>
                    /// </summary>
                    [NameInMap("Kind")]
                    [Validation(Required=false)]
                    public string Kind { get; set; }

                    /// <summary>
                    /// <para>The minimum plan that supports this operator, provided the current plan does not.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>high</para>
                    /// </summary>
                    [NameInMap("MinPlan")]
                    [Validation(Required=false)]
                    public string MinPlan { get; set; }

                    /// <summary>
                    /// <para>Indicates whether to negate the match result.</para>
                    /// </summary>
                    [NameInMap("Negative")]
                    [Validation(Required=false)]
                    public bool? Negative { get; set; }

                    /// <summary>
                    /// <para>The label for the operator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Does not equal</para>
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <para>The internal identifier for the operator.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>eq</para>
                    /// </summary>
                    [NameInMap("Symbol")]
                    [Validation(Required=false)]
                    public string Symbol { get; set; }

                    /// <summary>
                    /// <para>A hint for entering a valid value.</para>
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
                    /// <item><description><para><c>integer</c>: An integer.</para>
                    /// </description></item>
                    /// <item><description><para><c>integer_slice</c>: An integer array.</para>
                    /// </description></item>
                    /// <item><description><para><c>string</c>: A string.</para>
                    /// </description></item>
                    /// <item><description><para><c>string_slice</c>: A string array.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>string</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The validator, which defines validation rules for the value.</para>
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
                        /// <para>The length limit for the value.</para>
                        /// </summary>
                        [NameInMap("Length")]
                        [Validation(Required=false)]
                        public WafQuotaInteger Length { get; set; }

                        /// <summary>
                        /// <para>The regular expression pattern for the value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>^example$</para>
                        /// </summary>
                        [NameInMap("Pattern")]
                        [Validation(Required=false)]
                        public string Pattern { get; set; }

                        /// <summary>
                        /// <para>The value range for numeric validation.</para>
                        /// </summary>
                        [NameInMap("Range")]
                        [Validation(Required=false)]
                        public WafQuotaInteger Range { get; set; }

                    }

                }

                /// <summary>
                /// <para>The minimum plan that supports this match object, provided the current plan does not.</para>
                /// 
                /// <b>Example:</b>
                /// <para>high</para>
                /// </summary>
                [NameInMap("MinPlan")]
                [Validation(Required=false)]
                public string MinPlan { get; set; }

                /// <summary>
                /// <para>The selector, which defines how to select the match object.</para>
                /// </summary>
                [NameInMap("Selector")]
                [Validation(Required=false)]
                public GetWafFilterResponseBodyFilterFieldsSelector Selector { get; set; }
                public class GetWafFilterResponseBodyFilterFieldsSelector : TeaModel {
                    /// <summary>
                    /// <para>A list of data options available when the selector <c>Kind</c> is <c>data</c>.</para>
                    /// </summary>
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public List<GetWafFilterResponseBodyFilterFieldsSelectorData> Data { get; set; }
                    public class GetWafFilterResponseBodyFilterFieldsSelectorData : TeaModel {
                        /// <summary>
                        /// <para>The label for the data option.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>China</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <para>The value of the data option.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CN</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The selector type, which indicates whether it targets data items or other entities.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>data</para>
                    /// </summary>
                    [NameInMap("Kind")]
                    [Validation(Required=false)]
                    public string Kind { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the match object includes subfields.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Sub")]
                [Validation(Required=false)]
                public bool? Sub { get; set; }

                /// <summary>
                /// <para>A hint for entering the subfield value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>e.g. Content-Type</para>
                /// </summary>
                [NameInMap("SubTip")]
                [Validation(Required=false)]
                public string SubTip { get; set; }

            }

            /// <summary>
            /// <para>The phase at which the WAF processes requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http_bot</para>
            /// </summary>
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            /// <summary>
            /// <para>The target of the matching engine.</para>
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
