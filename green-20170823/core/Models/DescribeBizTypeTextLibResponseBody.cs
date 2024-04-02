// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class DescribeBizTypeTextLibResponseBody : TeaModel {
        [NameInMap("Black")]
        [Validation(Required=false)]
        public DescribeBizTypeTextLibResponseBodyBlack Black { get; set; }
        public class DescribeBizTypeTextLibResponseBodyBlack : TeaModel {
            [NameInMap("All")]
            [Validation(Required=false)]
            public List<DescribeBizTypeTextLibResponseBodyBlackAll> All { get; set; }
            public class DescribeBizTypeTextLibResponseBodyBlackAll : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Selected")]
            [Validation(Required=false)]
            public List<DescribeBizTypeTextLibResponseBodyBlackSelected> Selected { get; set; }
            public class DescribeBizTypeTextLibResponseBodyBlackSelected : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        [NameInMap("Ignore")]
        [Validation(Required=false)]
        public DescribeBizTypeTextLibResponseBodyIgnore Ignore { get; set; }
        public class DescribeBizTypeTextLibResponseBodyIgnore : TeaModel {
            [NameInMap("All")]
            [Validation(Required=false)]
            public List<DescribeBizTypeTextLibResponseBodyIgnoreAll> All { get; set; }
            public class DescribeBizTypeTextLibResponseBodyIgnoreAll : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Selected")]
            [Validation(Required=false)]
            public List<DescribeBizTypeTextLibResponseBodyIgnoreSelected> Selected { get; set; }
            public class DescribeBizTypeTextLibResponseBodyIgnoreSelected : TeaModel {
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
        public DescribeBizTypeTextLibResponseBodyReview Review { get; set; }
        public class DescribeBizTypeTextLibResponseBodyReview : TeaModel {
            [NameInMap("All")]
            [Validation(Required=false)]
            public List<DescribeBizTypeTextLibResponseBodyReviewAll> All { get; set; }
            public class DescribeBizTypeTextLibResponseBodyReviewAll : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Selected")]
            [Validation(Required=false)]
            public List<DescribeBizTypeTextLibResponseBodyReviewSelected> Selected { get; set; }
            public class DescribeBizTypeTextLibResponseBodyReviewSelected : TeaModel {
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
        public DescribeBizTypeTextLibResponseBodyWhite White { get; set; }
        public class DescribeBizTypeTextLibResponseBodyWhite : TeaModel {
            [NameInMap("All")]
            [Validation(Required=false)]
            public List<DescribeBizTypeTextLibResponseBodyWhiteAll> All { get; set; }
            public class DescribeBizTypeTextLibResponseBodyWhiteAll : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Selected")]
            [Validation(Required=false)]
            public List<DescribeBizTypeTextLibResponseBodyWhiteSelected> Selected { get; set; }
            public class DescribeBizTypeTextLibResponseBodyWhiteSelected : TeaModel {
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
