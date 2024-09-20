// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class SearchShrinkRequest : TeaModel {
        [NameInMap("adults")]
        [Validation(Required=false)]
        public int? Adults { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("air_legs")]
        [Validation(Required=false)]
        public string AirLegsShrink { get; set; }

        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public string CabinClass { get; set; }

        [NameInMap("children")]
        [Validation(Required=false)]
        public int? Children { get; set; }

        [NameInMap("infants")]
        [Validation(Required=false)]
        public int? Infants { get; set; }

        [NameInMap("search_control_options")]
        [Validation(Required=false)]
        public string SearchControlOptionsShrink { get; set; }

    }

}
