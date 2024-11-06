// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafFilterInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned information.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafFilterInfoResponseBodyContent> Content { get; set; }
        public class DescribeDcdnWafFilterInfoResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The type of the protection policy. The value of this parameter is the same as that of the DefenseScenes parameter in the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom_acl</para>
            /// </summary>
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

            /// <summary>
            /// <para>The information about the match condition.</para>
            /// </summary>
            [NameInMap("Fields")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafFilterInfoResponseBodyContentFields> Fields { get; set; }
            public class DescribeDcdnWafFilterInfoResponseBodyContentFields : TeaModel {
                /// <summary>
                /// <para>The description of the match field. This parameter is not returned or is empty if no match fields are found.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Custom Header</para>
                /// </summary>
                [NameInMap("ExtendField")]
                [Validation(Required=false)]
                public string ExtendField { get; set; }

                /// <summary>
                /// <para>The information about the logical symbol.</para>
                /// </summary>
                [NameInMap("LogicalSymbol")]
                [Validation(Required=false)]
                public List<DescribeDcdnWafFilterInfoResponseBodyContentFieldsLogicalSymbol> LogicalSymbol { get; set; }
                public class DescribeDcdnWafFilterInfoResponseBodyContentFieldsLogicalSymbol : TeaModel {
                    /// <summary>
                    /// <para>The configurable attributes, which are bit-field variables that are shown in the following list.\
                    /// For example, 1(00000001) indicates that case sensitivity can be enabled and stream match cannot be enabled, and 3(00000011) indicates that case sensitivity and stream match can be enabled.</para>
                    /// <list type="bullet">
                    /// <item><description>Bit (low to high) - Description</description></item>
                    /// <item><description>1 - Case sensitivity</description></item>
                    /// <item><description>2 - Stream match</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Attributes")]
                    [Validation(Required=false)]
                    public int? Attributes { get; set; }

                    /// <summary>
                    /// <para>The logical symbol that is displayed in the Dynamic Content Delivery Network (DCDN) console.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Equal to one of multiple values.</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The maximum number of match items that can be returned. The value of this parameter varies based on the value of the Type parameter. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>If <b>multi</b> is returned for the Type parameter, the value of this parameter indicates the maximum number of match items.</description></item>
                    /// <item><description>If <b>single</b> is returned for the Type parameter, the value of this parameter is 1.</description></item>
                    /// <item><description>If <b>none</b> is returned for the Type parameter, the value of this parameter is 0.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("MaxLength")]
                    [Validation(Required=false)]
                    public int? MaxLength { get; set; }

                    /// <summary>
                    /// <para>The information about the regular expression.</para>
                    /// </summary>
                    [NameInMap("Regexp")]
                    [Validation(Required=false)]
                    public DescribeDcdnWafFilterInfoResponseBodyContentFieldsLogicalSymbolRegexp Regexp { get; set; }
                    public class DescribeDcdnWafFilterInfoResponseBodyContentFieldsLogicalSymbolRegexp : TeaModel {
                        /// <summary>
                        /// <para>The error message returned when no items match the regular expression.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Specify this field.</para>
                        /// </summary>
                        [NameInMap("ErrMsg")]
                        [Validation(Required=false)]
                        public string ErrMsg { get; set; }

                        /// <summary>
                        /// <para>The regular expression.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>^\S+$</para>
                        /// </summary>
                        [NameInMap("Pattern")]
                        [Validation(Required=false)]
                        public string Pattern { get; set; }

                    }

                    /// <summary>
                    /// <para>The logical symbol that is passed to the backend.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>match-one</para>
                    /// </summary>
                    [NameInMap("Symbol")]
                    [Validation(Required=false)]
                    public string Symbol { get; set; }

                    /// <summary>
                    /// <para>The tips that are displayed in the match item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>You can enter up to 50 tips. Press the Enter key.</para>
                    /// </summary>
                    [NameInMap("Tip")]
                    [Validation(Required=false)]
                    public string Tip { get; set; }

                    /// <summary>
                    /// <para>The number of match items. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>multi: You can specify multiple match items.</description></item>
                    /// <item><description>single: You can specify only a match item.</description></item>
                    /// <item><description>none: no match items.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>multi</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The match field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Header</para>
                /// </summary>
                [NameInMap("MatchField")]
                [Validation(Required=false)]
                public string MatchField { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>153ca2cd-3c01-44be-204c-64dbc6c88630</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
