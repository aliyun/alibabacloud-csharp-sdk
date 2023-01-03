// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class ListVpdsRequest : TeaModel {
        [NameInMap("EnablePage")]
        [Validation(Required=false)]
        public bool? EnablePage { get; set; }

        [NameInMap("FilterErId")]
        [Validation(Required=false)]
        public string FilterErId { get; set; }

        [NameInMap("ForSelect")]
        [Validation(Required=false)]
        public bool? ForSelect { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("VpdId")]
        [Validation(Required=false)]
        public string VpdId { get; set; }

        [NameInMap("WithDependence")]
        [Validation(Required=false)]
        public bool? WithDependence { get; set; }

        [NameInMap("WithoutVcc")]
        [Validation(Required=false)]
        public bool? WithoutVcc { get; set; }

    }

}
