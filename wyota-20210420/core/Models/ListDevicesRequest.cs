// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Wyota20210420.Models
{
    public class ListDevicesRequest : TeaModel {
        [NameInMap("Alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        [NameInMap("BuildId")]
        [Validation(Required=false)]
        public string BuildId { get; set; }

        [NameInMap("ClientType")]
        [Validation(Required=false)]
        public int? ClientType { get; set; }

        [NameInMap("DeviceGroupId")]
        [Validation(Required=false)]
        public string DeviceGroupId { get; set; }

        [NameInMap("DeviceIpV4")]
        [Validation(Required=false)]
        public string DeviceIpV4 { get; set; }

        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("DeviceOS")]
        [Validation(Required=false)]
        public string DeviceOS { get; set; }

        [NameInMap("DevicePlatform")]
        [Validation(Required=false)]
        public string DevicePlatform { get; set; }

        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        [NameInMap("LabelContent")]
        [Validation(Required=false)]
        public string LabelContent { get; set; }

        [NameInMap("LabelId")]
        [Validation(Required=false)]
        public string LabelId { get; set; }

        [NameInMap("LocationInfo")]
        [Validation(Required=false)]
        public string LocationInfo { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("SerialNo")]
        [Validation(Required=false)]
        public string SerialNo { get; set; }

        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
