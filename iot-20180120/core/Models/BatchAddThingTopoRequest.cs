// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchAddThingTopoRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("TopoAddItem")]
        [Validation(Required=true)]
        public List<BatchAddThingTopoRequestTopoAddItem> TopoAddItem { get; set; }
        public class BatchAddThingTopoRequestTopoAddItem : TeaModel {
            [NameInMap("ProductKey")]
            [Validation(Required=true)]
            public string ProductKey { get; set; }

            [NameInMap("DeviceName")]
            [Validation(Required=true)]
            public string DeviceName { get; set; }

            [NameInMap("Sign")]
            [Validation(Required=true)]
            public string Sign { get; set; }

            [NameInMap("SignMethod")]
            [Validation(Required=true)]
            public string SignMethod { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }

        }

        [NameInMap("GwProductKey")]
        [Validation(Required=true)]
        public string GwProductKey { get; set; }

        [NameInMap("GwDeviceName")]
        [Validation(Required=true)]
        public string GwDeviceName { get; set; }

    }

}
