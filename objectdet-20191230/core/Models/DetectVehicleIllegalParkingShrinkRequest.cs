// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectVehicleIllegalParkingShrinkRequest : TeaModel {
        /// <summary>
        /// A short description of struct
        /// </summary>
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

        [NameInMap("RoadRegions")]
        [Validation(Required=false)]
        public string RoadRegionsShrink { get; set; }

    }

}
