// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeDeviceInfoResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("DeviceInfoList")]
        [Validation(Required=false)]
        public DescribeDeviceInfoResponseBodyDeviceInfoList DeviceInfoList { get; set; }
        public class DescribeDeviceInfoResponseBodyDeviceInfoList : TeaModel {
            [NameInMap("DeviceInfo")]
            [Validation(Required=false)]
            public List<DescribeDeviceInfoResponseBodyDeviceInfoListDeviceInfo> DeviceInfo { get; set; }
            public class DescribeDeviceInfoResponseBodyDeviceInfoListDeviceInfo : TeaModel {
                public string BeginDay { get; set; }
                public string BizType { get; set; }
                public string DeviceId { get; set; }
                public string ExpiredDay { get; set; }
                public string UserDeviceId { get; set; }
            }
        };

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
