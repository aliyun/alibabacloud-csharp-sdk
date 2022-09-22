// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPServerless20190615.Models
{
    public class DescribeResourceUsageResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeResourceUsageResponseBodyDataList> DataList { get; set; }
        public class DescribeResourceUsageResponseBodyDataList : TeaModel {
            [NameInMap("CloudDB")]
            [Validation(Required=false)]
            public DescribeResourceUsageResponseBodyDataListCloudDB CloudDB { get; set; }
            public class DescribeResourceUsageResponseBodyDataListCloudDB : TeaModel {
                [NameInMap("DataSize")]
                [Validation(Required=false)]
                public long? DataSize { get; set; }

                [NameInMap("Read")]
                [Validation(Required=false)]
                public long? Read { get; set; }

                [NameInMap("Write")]
                [Validation(Required=false)]
                public long? Write { get; set; }

            }

            [NameInMap("CloudFunction")]
            [Validation(Required=false)]
            public DescribeResourceUsageResponseBodyDataListCloudFunction CloudFunction { get; set; }
            public class DescribeResourceUsageResponseBodyDataListCloudFunction : TeaModel {
                [NameInMap("Compute")]
                [Validation(Required=false)]
                public long? Compute { get; set; }

                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                [NameInMap("Traffic")]
                [Validation(Required=false)]
                public long? Traffic { get; set; }

            }

            [NameInMap("CloudStorage")]
            [Validation(Required=false)]
            public DescribeResourceUsageResponseBodyDataListCloudStorage CloudStorage { get; set; }
            public class DescribeResourceUsageResponseBodyDataListCloudStorage : TeaModel {
                [NameInMap("DataSize")]
                [Validation(Required=false)]
                public long? DataSize { get; set; }

                [NameInMap("Download")]
                [Validation(Required=false)]
                public long? Download { get; set; }

                [NameInMap("Traffic")]
                [Validation(Required=false)]
                public long? Traffic { get; set; }

                [NameInMap("Upload")]
                [Validation(Required=false)]
                public long? Upload { get; set; }

            }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("StaticWeb")]
            [Validation(Required=false)]
            public DescribeResourceUsageResponseBodyDataListStaticWeb StaticWeb { get; set; }
            public class DescribeResourceUsageResponseBodyDataListStaticWeb : TeaModel {
                [NameInMap("DataSize")]
                [Validation(Required=false)]
                public long? DataSize { get; set; }

                [NameInMap("Traffic")]
                [Validation(Required=false)]
                public long? Traffic { get; set; }

            }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Paginator")]
        [Validation(Required=false)]
        public DescribeResourceUsageResponseBodyPaginator Paginator { get; set; }
        public class DescribeResourceUsageResponseBodyPaginator : TeaModel {
            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public long? PageCount { get; set; }

            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public long? PageNum { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
