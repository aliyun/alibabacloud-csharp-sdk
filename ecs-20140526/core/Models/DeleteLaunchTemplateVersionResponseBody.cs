// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DeleteLaunchTemplateVersionResponseBody : TeaModel {
        /// <summary>
        /// 实例启动模板版本。
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
                /// 实例启动模板ID。
                /// </summary>
                [NameInMap("LaunchTemplateId")]
                [Validation(Required=false)]
                public string LaunchTemplateId { get; set; }

                /// <summary>
                /// 实例启动模板版本号。
                /// </summary>
                [NameInMap("LaunchTemplateVersionNumber")]
                [Validation(Required=false)]
                public long? LaunchTemplateVersionNumber { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
