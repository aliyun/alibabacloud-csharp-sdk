// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class TypeLatLng : TeaModel {
        /// <summary>
        /// The latitude in degrees. It must be in the range [-90.0, +90.0].
        /// </summary>
        [NameInMap("Latitude")]
        [Validation(Required=false)]
        public double? Latitude { get; set; }

        /// <summary>
        /// The longitude in degrees. It must be in the range [-180.0, +180.0].
        /// </summary>
        [NameInMap("Longitude")]
        [Validation(Required=false)]
        public double? Longitude { get; set; }

    }

}
