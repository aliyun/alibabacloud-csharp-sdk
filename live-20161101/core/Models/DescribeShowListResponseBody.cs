// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeShowListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ShowList")]
        [Validation(Required=false)]
        public string ShowList { get; set; }

        [NameInMap("ShowListInfo")]
        [Validation(Required=false)]
        public DescribeShowListResponseBodyShowListInfo ShowListInfo { get; set; }
        public class DescribeShowListResponseBodyShowListInfo : TeaModel {
            [NameInMap("CurrentShowId")]
            [Validation(Required=false)]
            public string CurrentShowId { get; set; }

            [NameInMap("HighPriorityShowId")]
            [Validation(Required=false)]
            public string HighPriorityShowId { get; set; }

            [NameInMap("HighPriorityShowStartTime")]
            [Validation(Required=false)]
            public string HighPriorityShowStartTime { get; set; }

            [NameInMap("ShowList")]
            [Validation(Required=false)]
            public DescribeShowListResponseBodyShowListInfoShowList ShowList { get; set; }
            public class DescribeShowListResponseBodyShowListInfoShowList : TeaModel {
                [NameInMap("Show")]
                [Validation(Required=false)]
                public List<DescribeShowListResponseBodyShowListInfoShowListShow> Show { get; set; }
                public class DescribeShowListResponseBodyShowListInfoShowListShow : TeaModel {
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public long? Duration { get; set; }

                    [NameInMap("RepeatTimes")]
                    [Validation(Required=false)]
                    public int? RepeatTimes { get; set; }

                    [NameInMap("ResourceInfo")]
                    [Validation(Required=false)]
                    public DescribeShowListResponseBodyShowListInfoShowListShowResourceInfo ResourceInfo { get; set; }
                    public class DescribeShowListResponseBodyShowListInfoShowListShowResourceInfo : TeaModel {
                        [NameInMap("LiveInputType")]
                        [Validation(Required=false)]
                        public int? LiveInputType { get; set; }

                        [NameInMap("ResourceId")]
                        [Validation(Required=false)]
                        public string ResourceId { get; set; }

                        [NameInMap("ResourceType")]
                        [Validation(Required=false)]
                        public string ResourceType { get; set; }

                        [NameInMap("ResourceUrl")]
                        [Validation(Required=false)]
                        public string ResourceUrl { get; set; }

                    }

                    [NameInMap("ShowId")]
                    [Validation(Required=false)]
                    public string ShowId { get; set; }

                    [NameInMap("ShowName")]
                    [Validation(Required=false)]
                    public string ShowName { get; set; }

                }

            }

            [NameInMap("ShowListRepeatTimes")]
            [Validation(Required=false)]
            public int? ShowListRepeatTimes { get; set; }

            [NameInMap("TotalShowListRepeatTimes")]
            [Validation(Required=false)]
            public int? TotalShowListRepeatTimes { get; set; }

        }

    }

}
