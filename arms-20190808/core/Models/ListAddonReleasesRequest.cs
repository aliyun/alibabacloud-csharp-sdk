// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListAddonReleasesRequest : TeaModel {
        /// <summary>
        /// The name of the add-on.
        /// </summary>
        [NameInMap("AddonName")]
        [Validation(Required=false)]
        public string AddonName { get; set; }

        /// <summary>
        /// The environment ID.
        /// 
        /// This parameter is required.
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
