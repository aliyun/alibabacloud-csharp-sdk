// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeLoginBaseConfigsResponseBody : TeaModel {
        [NameInMap("BaseConfigs")]
        [Validation(Required=false)]
        public List<DescribeLoginBaseConfigsResponseBodyBaseConfigs> BaseConfigs { get; set; }
        public class DescribeLoginBaseConfigsResponseBodyBaseConfigs : TeaModel {
            [NameInMap("Account")]
            [Validation(Required=false)]
            public string Account { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<DescribeLoginBaseConfigsResponseBodyBaseConfigsTargetList> TargetList { get; set; }
            public class DescribeLoginBaseConfigsResponseBodyBaseConfigsTargetList : TeaModel {
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            [NameInMap("UuidCount")]
            [Validation(Required=false)]
            public int? UuidCount { get; set; }

        }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
