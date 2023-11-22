// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafFilterInfoResponseBody : TeaModel {
        /// <summary>
        /// The returned information.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafFilterInfoResponseBodyContent> Content { get; set; }
        public class DescribeDcdnWafFilterInfoResponseBodyContent : TeaModel {
            /// <summary>
            /// The type of the protection policy. The value of this parameter is the same as that of the DefenseScenes parameter in the request.
            /// </summary>
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

            /// <summary>
            /// The information about the match condition.
            /// </summary>
            [NameInMap("Fields")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafFilterInfoResponseBodyContentFields> Fields { get; set; }
            public class DescribeDcdnWafFilterInfoResponseBodyContentFields : TeaModel {
                /// <summary>
                /// The description of the match field. This parameter is not returned or is empty if no match fields are found.
                /// </summary>
                [NameInMap("ExtendField")]
                [Validation(Required=false)]
                public string ExtendField { get; set; }

                /// <summary>
                /// The logical operator.
                /// </summary>
                [NameInMap("LogicalSymbol")]
                [Validation(Required=false)]
                public List<DescribeDcdnWafFilterInfoResponseBodyContentFieldsLogicalSymbol> LogicalSymbol { get; set; }
                public class DescribeDcdnWafFilterInfoResponseBodyContentFieldsLogicalSymbol : TeaModel {
                    [NameInMap("Attributes")]
                    [Validation(Required=false)]
                    public int? Attributes { get; set; }

                    /// <summary>
                    /// The logical symbol that is displayed in the Dynamic Content Delivery Network (DCDN) console.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The maximum number of match contents that can be returned. The value of this parameter varies based on the value of the Type parameter. Valid values:
                    /// 
                    /// *   If **multi** is returned for the Type parameter, the value of this parameter indicates the maximum number of match contents.
                    /// *   If **single** is returned for the Type parameter, the value of this parameter is 1.
                    /// *   If **none** is returned for the Type parameter, the value of this parameter is 0.
                    /// </summary>
                    [NameInMap("MaxLength")]
                    [Validation(Required=false)]
                    public int? MaxLength { get; set; }

                    /// <summary>
                    /// The regular expression.
                    /// </summary>
                    [NameInMap("Regexp")]
                    [Validation(Required=false)]
                    public DescribeDcdnWafFilterInfoResponseBodyContentFieldsLogicalSymbolRegexp Regexp { get; set; }
                    public class DescribeDcdnWafFilterInfoResponseBodyContentFieldsLogicalSymbolRegexp : TeaModel {
                        /// <summary>
                        /// The error message returned because no items match the regular expression.
                        /// </summary>
                        [NameInMap("ErrMsg")]
                        [Validation(Required=false)]
                        public string ErrMsg { get; set; }

                        /// <summary>
                        /// The regular expression.
                        /// </summary>
                        [NameInMap("Pattern")]
                        [Validation(Required=false)]
                        public string Pattern { get; set; }

                    }

                    /// <summary>
                    /// The logical symbol that is passed to the backend.
                    /// </summary>
                    [NameInMap("Symbol")]
                    [Validation(Required=false)]
                    public string Symbol { get; set; }

                    /// <summary>
                    /// The tips that are displayed in the match content.
                    /// </summary>
                    [NameInMap("Tip")]
                    [Validation(Required=false)]
                    public string Tip { get; set; }

                    /// <summary>
                    /// The number of match contents. Valid values:
                    /// 
                    /// *   multi: multiple match contents
                    /// *   single: one match content
                    /// *   none: no match contents
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// The match field.
                /// </summary>
                [NameInMap("MatchField")]
                [Validation(Required=false)]
                public string MatchField { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
