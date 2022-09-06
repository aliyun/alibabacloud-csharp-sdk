// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySpeechLicenseDeviceListRequest : TeaModel {
        [NameInMap("CheckGroupId")]
        [Validation(Required=false)]
        public string CheckGroupId { get; set; }

        [NameInMap("DeviceName")]
        [Validation(Required=false)]
        public string DeviceName { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("LicenseStatusList")]
        [Validation(Required=false)]
        public List<string> LicenseStatusList { get; set; }

        [NameInMap("PageId")]
        [Validation(Required=false)]
        public int? PageId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProductKey")]
        [Validation(Required=false)]
        public string ProductKey { get; set; }

    }

}
