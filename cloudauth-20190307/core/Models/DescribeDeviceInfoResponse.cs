// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudauth20190307.Models
{
    public class DescribeDeviceInfoResponse : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=true)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("DeviceInfoList")]
        [Validation(Required=true)]
        public DescribeDeviceInfoResponseDeviceInfoList DeviceInfoList { get; set; }
        public class DescribeDeviceInfoResponseDeviceInfoList : TeaModel {
            [NameInMap("DeviceInfo")]
            [Validation(Required=true)]
            public List<DescribeDeviceInfoResponseDeviceInfoListDeviceInfo> DeviceInfo { get; set; }
            public class DescribeDeviceInfoResponseDeviceInfoListDeviceInfo : TeaModel {
                public string BeginDay { get; set; }
                public string BizType { get; set; }
                public string DeviceId { get; set; }
                public string ExpiredDay { get; set; }
                public string UserDeviceId { get; set; }
            }
        };

    }

}
