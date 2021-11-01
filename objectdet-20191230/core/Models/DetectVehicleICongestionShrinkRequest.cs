// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Objectdet20191230.Models
{
    public class DetectVehicleICongestionShrinkRequest : TeaModel {
        /// <summary>
        /// A short description of struct
        /// </summary>
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

        [NameInMap("OriginRequestId")]
        [Validation(Required=false)]
        public string OriginRequestId { get; set; }

        [NameInMap("PreRegionIntersectFeatures")]
        [Validation(Required=false)]
        public string PreRegionIntersectFeaturesShrink { get; set; }

        [NameInMap("RoadRegions")]
        [Validation(Required=false)]
        public string RoadRegionsShrink { get; set; }

        [NameInMap("StreamArn")]
        [Validation(Required=false)]
        public string StreamArn { get; set; }

    }

}
