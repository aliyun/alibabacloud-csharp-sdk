// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class LocationTransferType : TeaModel {
        /// <summary>
        /// The region in which the destination bucket can be located
        /// </summary>
        [NameInMap("Location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// The container that stores the transmission type
        /// </summary>
        [NameInMap("TransferTypes")]
        [Validation(Required=false)]
        public LocationTransferTypeTransferTypes TransferTypes { get; set; }
        public class LocationTransferTypeTransferTypes : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

    }

}
