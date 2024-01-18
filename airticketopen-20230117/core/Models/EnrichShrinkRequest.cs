// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class EnrichShrinkRequest : TeaModel {
        [NameInMap("adults")]
        [Validation(Required=false)]
        public int? Adults { get; set; }

        [NameInMap("cabin_class")]
        [Validation(Required=false)]
        public string CabinClass { get; set; }

        [NameInMap("children")]
        [Validation(Required=false)]
        public int? Children { get; set; }

        [NameInMap("infants")]
        [Validation(Required=false)]
        public int? Infants { get; set; }

        [NameInMap("journey_param_list")]
        [Validation(Required=false)]
        public string JourneyParamListShrink { get; set; }

        [NameInMap("solution_id")]
        [Validation(Required=false)]
        public string SolutionId { get; set; }

    }

}
