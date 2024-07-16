// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CC5G20220314.Models
{
    public class ListCardDayUsagesRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Iccids")]
        [Validation(Required=false)]
        public List<string> Iccids { get; set; }

        [NameInMap("LatestMonthNum")]
        [Validation(Required=false)]
        public int? LatestMonthNum { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("WirelessCloudConnectorId")]
        [Validation(Required=false)]
        public string WirelessCloudConnectorId { get; set; }

    }

}
