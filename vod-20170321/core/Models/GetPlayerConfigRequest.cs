// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetPlayerConfigRequest : TeaModel {
        [NameInMap("ApiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        [NameInMap("AuthInfo")]
        [Validation(Required=false)]
        public string AuthInfo { get; set; }

        [NameInMap("AuthTimestamp")]
        [Validation(Required=false)]
        public long? AuthTimestamp { get; set; }

        [NameInMap("DeviceBrand")]
        [Validation(Required=false)]
        public string DeviceBrand { get; set; }

        [NameInMap("DeviceModel")]
        [Validation(Required=false)]
        public string DeviceModel { get; set; }

        [NameInMap("OsName")]
        [Validation(Required=false)]
        public string OsName { get; set; }

        [NameInMap("Reserved")]
        [Validation(Required=false)]
        public string Reserved { get; set; }

        [NameInMap("Rule")]
        [Validation(Required=false)]
        public string Rule { get; set; }

    }

}
