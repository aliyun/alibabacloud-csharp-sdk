// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class ImportDTDataRequest : TeaModel {
        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=true)]
        public List<ImportDTDataRequestItems> Items { get; set; }
        public class ImportDTDataRequestItems : TeaModel {
            [NameInMap("DeviceName")]
            [Validation(Required=true)]
            public string DeviceName { get; set; }

            [NameInMap("Params")]
            [Validation(Required=true)]
            public string Params { get; set; }

        }

        [NameInMap("ProductKey")]
        [Validation(Required=true)]
        public string ProductKey { get; set; }

    }

}
