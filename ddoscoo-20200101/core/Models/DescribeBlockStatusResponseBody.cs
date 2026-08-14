// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeBlockStatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<DescribeBlockStatusResponseBodyStatusList> StatusList { get; set; }
        public class DescribeBlockStatusResponseBodyStatusList : TeaModel {
            [NameInMap("BlockStatusList")]
            [Validation(Required=false)]
            public List<DescribeBlockStatusResponseBodyStatusListBlockStatusList> BlockStatusList { get; set; }
            public class DescribeBlockStatusResponseBodyStatusListBlockStatusList : TeaModel {
                [NameInMap("BlockStatus")]
                [Validation(Required=false)]
                public string BlockStatus { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public long? EndTime { get; set; }

                [NameInMap("Line")]
                [Validation(Required=false)]
                public string Line { get; set; }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public long? StartTime { get; set; }

            }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

        }

    }

}
