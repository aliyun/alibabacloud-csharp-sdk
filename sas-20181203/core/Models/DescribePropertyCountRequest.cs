// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyCountRequest : TeaModel {
        /// <summary>
        /// The UUIDs of the assets. Separate multiple UUIDs with commas (,).
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The number of scheduled tasks.
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public string UuidList { get; set; }

    }

}
