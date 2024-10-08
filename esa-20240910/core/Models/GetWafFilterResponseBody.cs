// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetWafFilterResponseBody : TeaModel {
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public GetWafFilterResponseBodyFilter Filter { get; set; }
        public class GetWafFilterResponseBodyFilter : TeaModel {
            [NameInMap("Fields")]
            [Validation(Required=false)]
            public List<GetWafFilterResponseBodyFilterFields> Fields { get; set; }
            public class GetWafFilterResponseBodyFilterFields : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>http.request.headers</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Header</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("Logics")]
                [Validation(Required=false)]
                public List<GetWafFilterResponseBodyFilterFieldsLogics> Logics { get; set; }
                public class GetWafFilterResponseBodyFilterFieldsLogics : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Attributes")]
                    [Validation(Required=false)]
                    public int? Attributes { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>input:single</para>
                    /// </summary>
                    [NameInMap("Kind")]
                    [Validation(Required=false)]
                    public string Kind { get; set; }

                    [NameInMap("Negative")]
                    [Validation(Required=false)]
                    public bool? Negative { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Does not equal</para>
                    /// </summary>
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>eq</para>
                    /// </summary>
                    [NameInMap("Symbol")]
                    [Validation(Required=false)]
                    public string Symbol { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>e.g. image/jpeg</para>
                    /// </summary>
                    [NameInMap("Tip")]
                    [Validation(Required=false)]
                    public string Tip { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>string</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Validator")]
                    [Validation(Required=false)]
                    public GetWafFilterResponseBodyFilterFieldsLogicsValidator Validator { get; set; }
                    public class GetWafFilterResponseBodyFilterFieldsLogicsValidator : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Enter a valid expression</para>
                        /// </summary>
                        [NameInMap("ErrMsg")]
                        [Validation(Required=false)]
                        public string ErrMsg { get; set; }

                        [NameInMap("Length")]
                        [Validation(Required=false)]
                        public WafQuotaInteger Length { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>^example$</para>
                        /// </summary>
                        [NameInMap("Pattern")]
                        [Validation(Required=false)]
                        public string Pattern { get; set; }

                        [NameInMap("Range")]
                        [Validation(Required=false)]
                        public WafQuotaInteger Range { get; set; }

                    }

                }

                [NameInMap("Selector")]
                [Validation(Required=false)]
                public GetWafFilterResponseBodyFilterFieldsSelector Selector { get; set; }
                public class GetWafFilterResponseBodyFilterFieldsSelector : TeaModel {
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public List<GetWafFilterResponseBodyFilterFieldsSelectorData> Data { get; set; }
                    public class GetWafFilterResponseBodyFilterFieldsSelectorData : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>China</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>CN</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>data</para>
                    /// </summary>
                    [NameInMap("Kind")]
                    [Validation(Required=false)]
                    public string Kind { get; set; }

                }

                [NameInMap("Sub")]
                [Validation(Required=false)]
                public bool? Sub { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>e.g. Content-Type</para>
                /// </summary>
                [NameInMap("SubTip")]
                [Validation(Required=false)]
                public string SubTip { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>http_bot</para>
            /// </summary>
            [NameInMap("Phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>characteristics</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>http_custom_cc</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>36af3fcc-43d0-441c-86b1-428951dc8225</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
