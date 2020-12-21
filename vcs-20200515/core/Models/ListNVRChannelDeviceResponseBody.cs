// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class ListNVRChannelDeviceResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListNVRChannelDeviceResponseBodyData> Data { get; set; }
        public class ListNVRChannelDeviceResponseBodyData : TeaModel {
            [NameInMap("DeviceCode")]
            [Validation(Required=false)]
            public string DeviceCode { get; set; }

            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            [NameInMap("DatasourceType")]
            [Validation(Required=false)]
            public string DatasourceType { get; set; }

            [NameInMap("DeviceStatus")]
            [Validation(Required=false)]
            public string DeviceStatus { get; set; }

            [NameInMap("StreamStatus")]
            [Validation(Required=false)]
            public string StreamStatus { get; set; }

            [NameInMap("ComptureStatus")]
            [Validation(Required=false)]
            public string ComptureStatus { get; set; }

            [NameInMap("DeviceSn")]
            [Validation(Required=false)]
            public string DeviceSn { get; set; }

            [NameInMap("SampleName")]
            [Validation(Required=false)]
            public string SampleName { get; set; }

        }

    }

}
