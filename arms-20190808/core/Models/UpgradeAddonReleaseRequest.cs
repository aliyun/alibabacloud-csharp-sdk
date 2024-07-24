// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpgradeAddonReleaseRequest : TeaModel {
        /// <summary>
        /// The version of the add-on.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AddonVersion")]
        [Validation(Required=false)]
        public string AddonVersion { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

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

        /// <summary>
        /// The name of the release.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReleaseName")]
        [Validation(Required=false)]
        public string ReleaseName { get; set; }

        /// <summary>
        /// The metadata information.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Values")]
        [Validation(Required=false)]
        public string Values { get; set; }

    }

}
