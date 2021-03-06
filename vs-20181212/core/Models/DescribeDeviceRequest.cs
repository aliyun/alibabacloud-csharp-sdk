// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeDeviceRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ShowLog")]
        [Validation(Required=false)]
        public string ShowLog { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("IncludeStats")]
        [Validation(Required=false)]
        public bool? IncludeStats { get; set; }

        [NameInMap("IncludeDirectory")]
        [Validation(Required=false)]
        public bool? IncludeDirectory { get; set; }

    }

}
