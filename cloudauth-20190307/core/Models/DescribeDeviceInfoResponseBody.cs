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
                [NameInMap("BeginDay")]
                [Validation(Required=false)]
                public string BeginDay { get; set; }

                [NameInMap("BizType")]
                [Validation(Required=false)]
                public string BizType { get; set; }

                [NameInMap("DeviceId")]
                [Validation(Required=false)]
                public string DeviceId { get; set; }

                [NameInMap("ExpiredDay")]
                [Validation(Required=false)]
                public string ExpiredDay { get; set; }

                [NameInMap("UserDeviceId")]
                [Validation(Required=false)]
                public string UserDeviceId { get; set; }

            }

        }

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
