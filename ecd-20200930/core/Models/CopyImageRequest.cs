// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CopyImageRequest : TeaModel {
        /// <summary>
        /// The description of the new image in the destination region. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("DestinationDescription")]
        [Validation(Required=false)]
        public string DestinationDescription { get; set; }

        /// <summary>
        /// The name of the new image. The name must be 2 to 128 characters in length. The name must start with a letter but cannot start with `http://` or `https://`. The name can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
        /// </summary>
        [NameInMap("DestinationImageName")]
        [Validation(Required=false)]
        public string DestinationImageName { get; set; }

        /// <summary>
        /// The ID of the destination region. The ID must be different from the current region ID of the image. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("DestinationRegionId")]
        [Validation(Required=false)]
        public string DestinationRegionId { get; set; }

        /// <summary>
        /// The ID of the image that is copied to the destination region.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
