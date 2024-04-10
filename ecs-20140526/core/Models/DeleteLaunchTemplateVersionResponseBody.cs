// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DeleteLaunchTemplateVersionResponseBody : TeaModel {
        /// <summary>
        /// The versions of the launch template.
        /// </summary>
        [NameInMap("LaunchTemplateVersions")]
        [Validation(Required=false)]
        public DeleteLaunchTemplateVersionResponseBodyLaunchTemplateVersions LaunchTemplateVersions { get; set; }
        public class DeleteLaunchTemplateVersionResponseBodyLaunchTemplateVersions : TeaModel {
            [NameInMap("LaunchTemplateVersion")]
            [Validation(Required=false)]
            public List<DeleteLaunchTemplateVersionResponseBodyLaunchTemplateVersionsLaunchTemplateVersion> LaunchTemplateVersion { get; set; }
            public class DeleteLaunchTemplateVersionResponseBodyLaunchTemplateVersionsLaunchTemplateVersion : TeaModel {
                /// <summary>
                /// The ID of the launch template.
                /// </summary>
                [NameInMap("LaunchTemplateId")]
                [Validation(Required=false)]
                public string LaunchTemplateId { get; set; }

                /// <summary>
                /// The version number of the launch template.
                /// </summary>
                [NameInMap("LaunchTemplateVersionNumber")]
                [Validation(Required=false)]
                public long? LaunchTemplateVersionNumber { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
