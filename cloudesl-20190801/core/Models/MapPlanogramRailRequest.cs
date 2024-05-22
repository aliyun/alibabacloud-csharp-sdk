// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20190801.Models
{
    public class MapPlanogramRailRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Layer")]
        [Validation(Required=false)]
        public string Layer { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("RailCode")]
        [Validation(Required=false)]
        public string RailCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Shelf")]
        [Validation(Required=false)]
        public string Shelf { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StoreId")]
        [Validation(Required=false)]
        public string StoreId { get; set; }

    }

}
