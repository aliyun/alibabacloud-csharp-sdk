// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RescaleDeviceServiceResponseBody : TeaModel {
        [NameInMap("DeviceIds")]
        [Validation(Required=false)]
        public List<string> DeviceIds { get; set; }

        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceDetailInfos")]
        [Validation(Required=false)]
        public List<RescaleDeviceServiceResponseBodyResourceDetailInfos> ResourceDetailInfos { get; set; }
        public class RescaleDeviceServiceResponseBodyResourceDetailInfos : TeaModel {
            [NameInMap("ID")]
            [Validation(Required=false)]
            public string ID { get; set; }

            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            [NameInMap("ISP")]
            [Validation(Required=false)]
            public string ISP { get; set; }

            [NameInMap("Mac")]
            [Validation(Required=false)]
            public string Mac { get; set; }

            [NameInMap("RegionID")]
            [Validation(Required=false)]
            public string RegionID { get; set; }

            [NameInMap("Server")]
            [Validation(Required=false)]
            public string Server { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
