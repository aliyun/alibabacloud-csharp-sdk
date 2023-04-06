// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListIspTypesRequest : TeaModel {
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The type of the Global Accelerator (GA) instance to be queried. Valid values:
        /// 
        /// *   **basic**: basic GA instance
        /// *   **standard**: standard GA instance
        /// </summary>
        [NameInMap("AcceleratorType")]
        [Validation(Required=false)]
        public string AcceleratorType { get; set; }

        /// <summary>
        /// The ID of the acceleration region to be queried.
        /// </summary>
        [NameInMap("BusinessRegionId")]
        [Validation(Required=false)]
        public string BusinessRegionId { get; set; }

    }

}
