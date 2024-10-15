// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ModuleFlightItemListBestPriceItemSubItemPositionMapValue : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("journey_index")]
        [Validation(Required=false)]
        public int? JourneyIndex { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("segment_index")]
        [Validation(Required=false)]
        public int? SegmentIndex { get; set; }

    }

}
