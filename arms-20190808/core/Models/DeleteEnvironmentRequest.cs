// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteEnvironmentRequest : TeaModel {
        /// <summary>
        /// cascade delete Prometheus instance.
        /// </summary>
        [NameInMap("DeletePromInstance")]
        [Validation(Required=false)]
        public bool? DeletePromInstance { get; set; }

        /// <summary>
        /// The ID of the environment instance.
        /// </summary>
        [NameInMap("EnvironmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
