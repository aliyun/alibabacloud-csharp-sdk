// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainNoListSearchShrinkRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("arr_location")]
        [Validation(Required=false)]
        public string ArrLocation { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dep_date")]
        [Validation(Required=false)]
        public string DepDate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dep_location")]
        [Validation(Required=false)]
        public string DepLocation { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("option")]
        [Validation(Required=false)]
        public string OptionShrink { get; set; }

        [NameInMap("order_id")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

    }

}
