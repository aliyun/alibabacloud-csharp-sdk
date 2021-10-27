// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeDeviceInfoRequest : TeaModel {
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("DeviceId")]
        [Validation(Required=false)]
        public string DeviceId { get; set; }

        [NameInMap("ExpiredEndDay")]
        [Validation(Required=false)]
        public string ExpiredEndDay { get; set; }

        [NameInMap("ExpiredStartDay")]
        [Validation(Required=false)]
        public string ExpiredStartDay { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("UserDeviceId")]
        [Validation(Required=false)]
        public string UserDeviceId { get; set; }

    }

}
