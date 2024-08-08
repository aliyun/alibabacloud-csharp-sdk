// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeDasConfigResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the automatic storage expansion feature is enabled for the standard cluster.
        /// </summary>
        [NameInMap("StorageAutoScale")]
        [Validation(Required=false)]
        public string StorageAutoScale { get; set; }

        /// <summary>
        /// The maximum storage capacity of the standard cluster that is scaled up. Unit: GB.
        /// 
        /// >  This parameter is returned when the StorageAutoScale parameter is set to Enable.
        /// </summary>
        [NameInMap("StorageUpperBound")]
        [Validation(Required=false)]
        public long? StorageUpperBound { get; set; }

    }

}
