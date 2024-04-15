// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class MigrateImageProtocolRequest : TeaModel {
        /// <summary>
        /// The image IDs.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public List<string> ImageId { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~196646~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The protocol to which you want to update the image protocols. Set the value to ASP.
        /// </summary>
        [NameInMap("TargetProtocolType")]
        [Validation(Required=false)]
        public string TargetProtocolType { get; set; }

    }

}
