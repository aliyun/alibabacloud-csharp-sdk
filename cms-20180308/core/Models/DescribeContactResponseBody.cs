// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20180308.Models
{
    public class DescribeContactResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public DescribeContactResponseBodyDatapoints Datapoints { get; set; }
        public class DescribeContactResponseBodyDatapoints : TeaModel {
            [NameInMap("Channels")]
            [Validation(Required=false)]
            public DescribeContactResponseBodyDatapointsChannels Channels { get; set; }
            public class DescribeContactResponseBodyDatapointsChannels : TeaModel {
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public List<DescribeContactResponseBodyDatapointsChannelsChannel> Channel { get; set; }
                public class DescribeContactResponseBodyDatapointsChannelsChannel : TeaModel {
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
