// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20190902.Models
{
    public class SearchSimilarityResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<SearchSimilarityResponseBodyDataList> DataList { get; set; }
        public class SearchSimilarityResponseBodyDataList : TeaModel {
            [NameInMap("ClassificationSimilarityList")]
            [Validation(Required=false)]
            public List<SearchSimilarityResponseBodyDataListClassificationSimilarityList> ClassificationSimilarityList { get; set; }
            public class SearchSimilarityResponseBodyDataListClassificationSimilarityList : TeaModel {
                [NameInMap("Classification")]
                [Validation(Required=false)]
                public int? Classification { get; set; }

                [NameInMap("ClassificationName")]
                [Validation(Required=false)]
                public string ClassificationName { get; set; }

                [NameInMap("Rate")]
                [Validation(Required=false)]
                public int? Rate { get; set; }

                [NameInMap("SimilarGroupList")]
                [Validation(Required=false)]
                public List<SearchSimilarityResponseBodyDataListClassificationSimilarityListSimilarGroupList> SimilarGroupList { get; set; }
                public class SearchSimilarityResponseBodyDataListClassificationSimilarityListSimilarGroupList : TeaModel {
                    [NameInMap("DetailList")]
                    [Validation(Required=false)]
                    public List<SearchSimilarityResponseBodyDataListClassificationSimilarityListSimilarGroupListDetailList> DetailList { get; set; }
                    public class SearchSimilarityResponseBodyDataListClassificationSimilarityListSimilarGroupListDetailList : TeaModel {
                        [NameInMap("Code")]
                        [Validation(Required=false)]
                        public string Code { get; set; }

                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("Rate")]
                        [Validation(Required=false)]
                        public int? Rate { get; set; }

                        [NameInMap("TmNumber")]
                        [Validation(Required=false)]
                        public string TmNumber { get; set; }

                        [NameInMap("Uid")]
                        [Validation(Required=false)]
                        public string Uid { get; set; }

                        [NameInMap("Uri")]
                        [Validation(Required=false)]
                        public string Uri { get; set; }

                    }

                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public int? Rate { get; set; }

                    [NameInMap("SimilarGroup")]
                    [Validation(Required=false)]
                    public string SimilarGroup { get; set; }

                    [NameInMap("SimilarGroupName")]
                    [Validation(Required=false)]
                    public string SimilarGroupName { get; set; }

                }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
