/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DdosDiversion20230701.Models
{
    public class ConfigNetStatusRequest : TeaModel {
        [NameInMap("Net")]
        [Validation(Required=false)]
        public string Net { get; set; }

        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<string> Regions { get; set; }

        [NameInMap("SaleId")]
        [Validation(Required=false)]
        public string SaleId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SubNets")]
        [Validation(Required=false)]
        public List<string> SubNets { get; set; }

    }

}
