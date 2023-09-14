// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetUserDeviceResponseBody : TeaModel {
        [NameInMap("Device")]
        [Validation(Required=false)]
        public GetUserDeviceResponseBodyDevice Device { get; set; }
        public class GetUserDeviceResponseBodyDevice : TeaModel {
            [NameInMap("AppStatus")]
            [Validation(Required=false)]
            public string AppStatus { get; set; }

            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            [NameInMap("CPU")]
            [Validation(Required=false)]
            public string CPU { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Department")]
            [Validation(Required=false)]
            public string Department { get; set; }

            [NameInMap("DeviceBelong")]
            [Validation(Required=false)]
            public string DeviceBelong { get; set; }

            [NameInMap("DeviceModel")]
            [Validation(Required=false)]
            public string DeviceModel { get; set; }

            [NameInMap("DeviceStatus")]
            [Validation(Required=false)]
            public string DeviceStatus { get; set; }

            [NameInMap("DeviceTag")]
            [Validation(Required=false)]
            public string DeviceTag { get; set; }

            [NameInMap("DeviceType")]
            [Validation(Required=false)]
            public string DeviceType { get; set; }

            [NameInMap("DeviceVersion")]
            [Validation(Required=false)]
            public string DeviceVersion { get; set; }

            [NameInMap("Disk")]
            [Validation(Required=false)]
            public string Disk { get; set; }

            [NameInMap("DlpStatus")]
            [Validation(Required=false)]
            public string DlpStatus { get; set; }

            [NameInMap("HistoryUsers")]
            [Validation(Required=false)]
            public List<GetUserDeviceResponseBodyDeviceHistoryUsers> HistoryUsers { get; set; }
            public class GetUserDeviceResponseBodyDeviceHistoryUsers : TeaModel {
                [NameInMap("SaseUserId")]
                [Validation(Required=false)]
                public string SaseUserId { get; set; }

                [NameInMap("Username")]
                [Validation(Required=false)]
                public string Username { get; set; }

            }

            [NameInMap("Hostname")]
            [Validation(Required=false)]
            public string Hostname { get; set; }

            [NameInMap("IaStatus")]
            [Validation(Required=false)]
            public string IaStatus { get; set; }

            [NameInMap("InnerIP")]
            [Validation(Required=false)]
            public string InnerIP { get; set; }

            [NameInMap("Mac")]
            [Validation(Required=false)]
            public string Mac { get; set; }

            [NameInMap("Memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            [NameInMap("NacStatus")]
            [Validation(Required=false)]
            public string NacStatus { get; set; }

            [NameInMap("PaStatus")]
            [Validation(Required=false)]
            public string PaStatus { get; set; }

            [NameInMap("SaseUserId")]
            [Validation(Required=false)]
            public string SaseUserId { get; set; }

            [NameInMap("SharingStatus")]
            [Validation(Required=false)]
            public bool? SharingStatus { get; set; }

            [NameInMap("SrcIP")]
            [Validation(Required=false)]
            public string SrcIP { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("Username")]
            [Validation(Required=false)]
            public string Username { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
