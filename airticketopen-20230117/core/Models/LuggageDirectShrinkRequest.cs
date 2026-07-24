// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AirticketOpen20230117.Models
{
    public class LuggageDirectShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of flight segments that constitute an itinerary. Maximum size: 2.</para>
        /// </summary>
        [NameInMap("flight_segment_param_list")]
        [Validation(Required=false)]
        public string FlightSegmentParamListShrink { get; set; }

    }

}
