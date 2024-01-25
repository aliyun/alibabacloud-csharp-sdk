// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vdmeter20210425.Models
{
    public class DescribeNewPlayVideoPlaySessioninfoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeNewPlayVideoPlaySessioninfoResponseBodyData> Data { get; set; }
        public class DescribeNewPlayVideoPlaySessioninfoResponseBodyData : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            [NameInMap("DeviceBrand")]
            [Validation(Required=false)]
            public string DeviceBrand { get; set; }

            [NameInMap("DeviceModel")]
            [Validation(Required=false)]
            public string DeviceModel { get; set; }

            [NameInMap("OS")]
            [Validation(Required=false)]
            public string OS { get; set; }

            [NameInMap("OV")]
            [Validation(Required=false)]
            public string OV { get; set; }

            [NameInMap("TerminalType")]
            [Validation(Required=false)]
            public string TerminalType { get; set; }

            [NameInMap("VPS")]
            [Validation(Required=false)]
            public string VPS { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
