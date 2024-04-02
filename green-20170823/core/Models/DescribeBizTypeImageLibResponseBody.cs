// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeBizTypeImageLibResponseBody : TeaModel {
        [NameInMap("Black")]
        [Validation(Required=false)]
        public DescribeBizTypeImageLibResponseBodyBlack Black { get; set; }
        public class DescribeBizTypeImageLibResponseBodyBlack : TeaModel {
            [NameInMap("All")]
            [Validation(Required=false)]
            public List<DescribeBizTypeImageLibResponseBodyBlackAll> All { get; set; }
            public class DescribeBizTypeImageLibResponseBodyBlackAll : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Selected")]
            [Validation(Required=false)]
            public List<DescribeBizTypeImageLibResponseBodyBlackSelected> Selected { get; set; }
            public class DescribeBizTypeImageLibResponseBodyBlackSelected : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Review")]
        [Validation(Required=false)]
        public DescribeBizTypeImageLibResponseBodyReview Review { get; set; }
        public class DescribeBizTypeImageLibResponseBodyReview : TeaModel {
            [NameInMap("All")]
            [Validation(Required=false)]
            public List<DescribeBizTypeImageLibResponseBodyReviewAll> All { get; set; }
            public class DescribeBizTypeImageLibResponseBodyReviewAll : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Selected")]
            [Validation(Required=false)]
            public List<DescribeBizTypeImageLibResponseBodyReviewSelected> Selected { get; set; }
            public class DescribeBizTypeImageLibResponseBodyReviewSelected : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        [NameInMap("White")]
        [Validation(Required=false)]
        public DescribeBizTypeImageLibResponseBodyWhite White { get; set; }
        public class DescribeBizTypeImageLibResponseBodyWhite : TeaModel {
            [NameInMap("All")]
            [Validation(Required=false)]
            public List<DescribeBizTypeImageLibResponseBodyWhiteAll> All { get; set; }
            public class DescribeBizTypeImageLibResponseBodyWhiteAll : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Selected")]
            [Validation(Required=false)]
            public List<DescribeBizTypeImageLibResponseBodyWhiteSelected> Selected { get; set; }
            public class DescribeBizTypeImageLibResponseBodyWhiteSelected : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

    }

}
