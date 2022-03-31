// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnWafFilterInfoResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public List<DescribeDcdnWafFilterInfoResponseBodyContent> Content { get; set; }
        public class DescribeDcdnWafFilterInfoResponseBodyContent : TeaModel {
            [NameInMap("DefenseScene")]
            [Validation(Required=false)]
            public string DefenseScene { get; set; }

            [NameInMap("Fields")]
            [Validation(Required=false)]
            public List<DescribeDcdnWafFilterInfoResponseBodyContentFields> Fields { get; set; }
            public class DescribeDcdnWafFilterInfoResponseBodyContentFields : TeaModel {
                [NameInMap("ExtendField")]
                [Validation(Required=false)]
                public string ExtendField { get; set; }

                [NameInMap("LogicalSymbol")]
                [Validation(Required=false)]
                public List<DescribeDcdnWafFilterInfoResponseBodyContentFieldsLogicalSymbol> LogicalSymbol { get; set; }
                public class DescribeDcdnWafFilterInfoResponseBodyContentFieldsLogicalSymbol : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("MaxLength")]
                    [Validation(Required=false)]
                    public int? MaxLength { get; set; }

                    [NameInMap("Regexp")]
                    [Validation(Required=false)]
                    public DescribeDcdnWafFilterInfoResponseBodyContentFieldsLogicalSymbolRegexp Regexp { get; set; }
                    public class DescribeDcdnWafFilterInfoResponseBodyContentFieldsLogicalSymbolRegexp : TeaModel {
                        [NameInMap("ErrMsg")]
                        [Validation(Required=false)]
                        public string ErrMsg { get; set; }
                        [NameInMap("Pattern")]
                        [Validation(Required=false)]
                        public string Pattern { get; set; }
                    };

                    [NameInMap("Symbol")]
                    [Validation(Required=false)]
                    public string Symbol { get; set; }

                    [NameInMap("Tip")]
                    [Validation(Required=false)]
                    public string Tip { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                [NameInMap("MatchField")]
                [Validation(Required=false)]
                public string MatchField { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
