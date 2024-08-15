// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteAddonReleaseRequest : TeaModel {
        /// <summary>
        /// The name of the add-on. If you assign a value to AddonName, the ReleaseName parameter is ignored and all AddonReleases that belong to the same add-on are deleted.
        /// </summary>
        [NameInMap("AddonName")]
        [Validation(Required=false)]
        public string AddonName { get; set; }

        /// <summary>
        /// Environment ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("EnvironmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Whether to be forcibly deleted. The default value is false.
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// The region ID.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Name of Release.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ReleaseName")]
        [Validation(Required=false)]
        public string ReleaseName { get; set; }

    }

}
