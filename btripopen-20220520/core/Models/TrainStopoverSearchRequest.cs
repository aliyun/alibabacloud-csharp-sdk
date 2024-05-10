// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainStopoverSearchRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("arr_station")]
        [Validation(Required=false)]
        public string ArrStation { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("dep_station")]
        [Validation(Required=false)]
        public string DepStation { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("train_date")]
        [Validation(Required=false)]
        public string TrainDate { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("train_no")]
        [Validation(Required=false)]
        public string TrainNo { get; set; }

    }

}
