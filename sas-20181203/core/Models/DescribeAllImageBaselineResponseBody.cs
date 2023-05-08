// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeAllImageBaselineResponseBody : TeaModel {
        [NameInMap("ImageBaselines")]
        [Validation(Required=false)]
        public DescribeAllImageBaselineResponseBodyImageBaselines ImageBaselines { get; set; }
        public class DescribeAllImageBaselineResponseBodyImageBaselines : TeaModel {
            [NameInMap("BaselineClassList")]
            [Validation(Required=false)]
            public List<DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassList> BaselineClassList { get; set; }
            public class DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassList : TeaModel {
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                [NameInMap("BaselineNameList")]
                [Validation(Required=false)]
                public List<DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassListBaselineNameList> BaselineNameList { get; set; }
                public class DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassListBaselineNameList : TeaModel {
                    [NameInMap("Alias")]
                    [Validation(Required=false)]
                    public string Alias { get; set; }

                    [NameInMap("BaselineItemList")]
                    [Validation(Required=false)]
                    public List<DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassListBaselineNameListBaselineItemList> BaselineItemList { get; set; }
                    public class DescribeAllImageBaselineResponseBodyImageBaselinesBaselineClassListBaselineNameListBaselineItemList : TeaModel {
                        [NameInMap("Alias")]
                        [Validation(Required=false)]
                        public string Alias { get; set; }

                        [NameInMap("ClassKey")]
                        [Validation(Required=false)]
                        public string ClassKey { get; set; }

                        [NameInMap("ItemKey")]
                        [Validation(Required=false)]
                        public string ItemKey { get; set; }

                        [NameInMap("NameKey")]
                        [Validation(Required=false)]
                        public string NameKey { get; set; }

                    }

                    [NameInMap("ClassKey")]
                    [Validation(Required=false)]
                    public string ClassKey { get; set; }

                    [NameInMap("NameKey")]
                    [Validation(Required=false)]
                    public string NameKey { get; set; }

                }

                [NameInMap("ClassKey")]
                [Validation(Required=false)]
                public string ClassKey { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
