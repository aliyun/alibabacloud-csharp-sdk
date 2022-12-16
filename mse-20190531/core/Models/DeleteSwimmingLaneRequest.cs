// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class DeleteSwimmingLaneRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// - zh: Chinese
        /// - en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The ID of the lane.
        /// </summary>
        [NameInMap("LaneId")]
        [Validation(Required=false)]
        public long? LaneId { get; set; }

    }

}
