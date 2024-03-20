// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alikafka20190916.Models
{
    public class EnableAutoGroupCreationRequest : TeaModel {
        /// <summary>
        /// Specify whether to enable the flexible group creation feature. Valid values:
        /// 
        /// *   **true**: enables the flexible group creation feature.
        /// *   **false**: disabled the flexible group creation feature.
        /// </summary>
        [NameInMap("Enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// You can call the [GetInstanceList](~~437663~~) operation to query instances.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
