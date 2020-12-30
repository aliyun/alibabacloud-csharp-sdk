// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeElasticBandwidthSpecResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ElasticBandwidthSpec")]
        [Validation(Required=false)]
        public List<string> ElasticBandwidthSpec { get; set; }

    }

}
