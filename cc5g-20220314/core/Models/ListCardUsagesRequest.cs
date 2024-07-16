// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CC5G20220314.Models
{
    public class ListCardUsagesRequest : TeaModel {
        [NameInMap("Iccids")]
        [Validation(Required=false)]
        public List<string> Iccids { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("WirelessCloudConnectorId")]
        [Validation(Required=false)]
        public string WirelessCloudConnectorId { get; set; }

    }

}
